namespace CSV_Kombinierer
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblHowTo = new System.Windows.Forms.Label();
            this.lstFiles = new System.Windows.Forms.ListBox();
            this.chkRemoveFirstLine = new System.Windows.Forms.CheckBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.nudHeaderCount = new System.Windows.Forms.NumericUpDown();
            this.lblHeaderLine = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeaderCount)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHowTo
            // 
            this.lblHowTo.AutoSize = true;
            this.lblHowTo.Location = new System.Drawing.Point(12, 9);
            this.lblHowTo.Name = "lblHowTo";
            this.lblHowTo.Size = new System.Drawing.Size(231, 13);
            this.lblHowTo.TabIndex = 0;
            this.lblHowTo.Text = "Ziehen Sie Dateien und Ordner in die Dateiliste:";
            // 
            // lstFiles
            // 
            this.lstFiles.AllowDrop = true;
            this.lstFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstFiles.FormattingEnabled = true;
            this.lstFiles.Location = new System.Drawing.Point(15, 38);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(499, 199);
            this.lstFiles.TabIndex = 1;
            // 
            // chkRemoveFirstLine
            // 
            this.chkRemoveFirstLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkRemoveFirstLine.AutoSize = true;
            this.chkRemoveFirstLine.Location = new System.Drawing.Point(17, 275);
            this.chkRemoveFirstLine.Name = "chkRemoveFirstLine";
            this.chkRemoveFirstLine.Size = new System.Drawing.Size(129, 17);
            this.chkRemoveFirstLine.TabIndex = 2;
            this.chkRemoveFirstLine.Text = "Kopfzeile(n) entfernen";
            this.chkRemoveFirstLine.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Enabled = false;
            this.btnExport.Location = new System.Drawing.Point(152, 243);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(362, 82);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Kombinieren und Speichern";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClear.Enabled = false;
            this.btnClear.Location = new System.Drawing.Point(15, 243);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(131, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Liste leeren";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // nudHeaderCount
            // 
            this.nudHeaderCount.Enabled = false;
            this.nudHeaderCount.Location = new System.Drawing.Point(36, 298);
            this.nudHeaderCount.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudHeaderCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHeaderCount.Name = "nudHeaderCount";
            this.nudHeaderCount.Size = new System.Drawing.Size(29, 20);
            this.nudHeaderCount.TabIndex = 5;
            this.nudHeaderCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblHeaderLine
            // 
            this.lblHeaderLine.AutoSize = true;
            this.lblHeaderLine.Location = new System.Drawing.Point(71, 300);
            this.lblHeaderLine.Name = "lblHeaderLine";
            this.lblHeaderLine.Size = new System.Drawing.Size(56, 13);
            this.lblHeaderLine.TabIndex = 6;
            this.lblHeaderLine.Text = "Kopfzeilen";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 337);
            this.Controls.Add(this.lblHeaderLine);
            this.Controls.Add(this.nudHeaderCount);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.chkRemoveFirstLine);
            this.Controls.Add(this.lstFiles);
            this.Controls.Add(this.lblHowTo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "CSV-Kombinierer";
            ((System.ComponentModel.ISupportInitialize)(this.nudHeaderCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHowTo;
        private System.Windows.Forms.ListBox lstFiles;
        private System.Windows.Forms.CheckBox chkRemoveFirstLine;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.NumericUpDown nudHeaderCount;
        private System.Windows.Forms.Label lblHeaderLine;
    }
}

