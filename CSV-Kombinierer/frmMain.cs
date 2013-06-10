using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSV_Kombinierer
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            lstFiles.DragEnter += (o, e) =>
                {
                    if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
                    {
                        string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                        foreach (string file in files)
                        {
                            if (!System.IO.Directory.Exists(file) && !file.ToLower().EndsWith(".csv"))
                            {
                                return;
                            }
                        }
                        e.Effect = DragDropEffects.All;
                    }
                };
            lstFiles.DragDrop += (o, e) =>
                {
                    string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                    foreach (string file in files)
                    {
                        if (System.IO.Directory.Exists(file))
                        {
                            Queue<string> ToDo = new Queue<string>(new string[] { file });
                            while (ToDo.Count > 0)
                            {
                                string current = ToDo.Dequeue();
                                foreach (string item in System.IO.Directory.GetFiles(current))
                                {
                                    if (item.ToLower().EndsWith(".csv"))
                                    {
                                        lstFiles.Items.Add(item);
                                    }
                                }
                                foreach (string directory in System.IO.Directory.GetDirectories(current))
                                {
                                    ToDo.Enqueue(directory);
                                }
                            }
                        }
                        else if (file.ToLower().EndsWith(".csv"))
                        {
                            lstFiles.Items.Add(file);
                        }
                    }
                    btnClear.Enabled = btnExport.Enabled = lstFiles.Items.Count > 0;
                };
            btnClear.Click += (o,e) => 
                {
                    lstFiles.Items.Clear();
                    btnClear.Enabled = btnExport.Enabled = false;
                };
            btnExport.Click += (o, e) =>
                {
                    using (SaveFileDialog sfd = new SaveFileDialog())
                    {
                        if (!String.IsNullOrWhiteSpace(Properties.Settings.Default.LastSave))
                        {
                            sfd.FileName = Properties.Settings.Default.LastSave;
                        }
                        sfd.OverwritePrompt = true;
                        if (sfd.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                        {
                            int lineCount = 0;
                            using (System.IO.StreamWriter output = new System.IO.StreamWriter(sfd.FileName, false))
                            {
                                bool isFirstFile = true;
                                foreach (string file in lstFiles.Items)
                                {
                                    bool isFirstLine = true;
                                    foreach (string line in System.IO.File.ReadAllLines(file))
                                    {
                                        if (!isFirstLine || isFirstFile || !chkRemoveFirstLine.Checked)
                                        {
                                            output.WriteLine(line);
                                            lineCount++;
                                        }
                                        isFirstLine = false;
                                    }
                                    isFirstFile = false;
                                }
                                output.Flush();
                                output.Close();
                            }
                            MessageBox.Show(this, lineCount.ToString() + " Zeilen aus " + lstFiles.Items.Count + " Dateien wurden in die Datei\n'" + sfd.FileName + "' geschrieben.", "Fertig!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Properties.Settings.Default.LastSave = sfd.FileName;
                            Properties.Settings.Default.Save();
                        }
                    }
                };
        }
    }
}
