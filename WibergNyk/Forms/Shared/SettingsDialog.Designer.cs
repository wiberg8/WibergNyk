namespace WibergNyk
{
    partial class SettingsDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.laTitle = new System.Windows.Forms.Label();
            this.gbLocations = new System.Windows.Forms.GroupBox();
            this.cmdDbClear = new System.Windows.Forms.Button();
            this.cmdBackupClear = new System.Windows.Forms.Button();
            this.cmdPdfClear = new System.Windows.Forms.Button();
            this.laDb = new System.Windows.Forms.Label();
            this.cmdDbBrowse = new System.Windows.Forms.Button();
            this.txtDb = new System.Windows.Forms.TextBox();
            this.laBackup = new System.Windows.Forms.Label();
            this.cmdBackupBrowse = new System.Windows.Forms.Button();
            this.txtBackup = new System.Windows.Forms.TextBox();
            this.laPdf = new System.Windows.Forms.Label();
            this.cmdPdfBrowse = new System.Windows.Forms.Button();
            this.txtPdf = new System.Windows.Forms.TextBox();
            this.laVerksamhet = new System.Windows.Forms.Label();
            this.cmdVerksamhetSave = new System.Windows.Forms.Button();
            this.txtVerksamhet = new System.Windows.Forms.TextBox();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cbBackupOnStart = new System.Windows.Forms.CheckBox();
            this.cmdSkapMappClear = new System.Windows.Forms.Button();
            this.laSkapMapp = new System.Windows.Forms.Label();
            this.cmdSkapMappBrowse = new System.Windows.Forms.Button();
            this.txtSkapMapp = new System.Windows.Forms.TextBox();
            this.gbLocations.SuspendLayout();
            this.SuspendLayout();
            // 
            // laTitle
            // 
            this.laTitle.AutoSize = true;
            this.laTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laTitle.Location = new System.Drawing.Point(22, 21);
            this.laTitle.Name = "laTitle";
            this.laTitle.Size = new System.Drawing.Size(95, 20);
            this.laTitle.TabIndex = 41;
            this.laTitle.Text = "Inställningar";
            // 
            // gbLocations
            // 
            this.gbLocations.Controls.Add(this.cmdSkapMappClear);
            this.gbLocations.Controls.Add(this.laSkapMapp);
            this.gbLocations.Controls.Add(this.cmdSkapMappBrowse);
            this.gbLocations.Controls.Add(this.txtSkapMapp);
            this.gbLocations.Controls.Add(this.cmdDbClear);
            this.gbLocations.Controls.Add(this.cmdBackupClear);
            this.gbLocations.Controls.Add(this.cmdPdfClear);
            this.gbLocations.Controls.Add(this.laDb);
            this.gbLocations.Controls.Add(this.cmdDbBrowse);
            this.gbLocations.Controls.Add(this.txtDb);
            this.gbLocations.Controls.Add(this.laBackup);
            this.gbLocations.Controls.Add(this.cmdBackupBrowse);
            this.gbLocations.Controls.Add(this.txtBackup);
            this.gbLocations.Controls.Add(this.laPdf);
            this.gbLocations.Controls.Add(this.cmdPdfBrowse);
            this.gbLocations.Controls.Add(this.txtPdf);
            this.gbLocations.Location = new System.Drawing.Point(46, 64);
            this.gbLocations.Name = "gbLocations";
            this.gbLocations.Size = new System.Drawing.Size(628, 194);
            this.gbLocations.TabIndex = 42;
            this.gbLocations.TabStop = false;
            this.gbLocations.Text = "Sökvägar";
            // 
            // cmdDbClear
            // 
            this.cmdDbClear.Location = new System.Drawing.Point(515, 119);
            this.cmdDbClear.Name = "cmdDbClear";
            this.cmdDbClear.Size = new System.Drawing.Size(107, 25);
            this.cmdDbClear.TabIndex = 54;
            this.cmdDbClear.Text = "Återställ";
            this.cmdDbClear.UseVisualStyleBackColor = true;
            this.cmdDbClear.Click += new System.EventHandler(this.cmdDbClear_Click);
            // 
            // cmdBackupClear
            // 
            this.cmdBackupClear.Location = new System.Drawing.Point(515, 78);
            this.cmdBackupClear.Name = "cmdBackupClear";
            this.cmdBackupClear.Size = new System.Drawing.Size(107, 25);
            this.cmdBackupClear.TabIndex = 53;
            this.cmdBackupClear.Text = "Återställ";
            this.cmdBackupClear.UseVisualStyleBackColor = true;
            this.cmdBackupClear.Click += new System.EventHandler(this.cmdBackupClear_Click);
            // 
            // cmdPdfClear
            // 
            this.cmdPdfClear.Location = new System.Drawing.Point(515, 37);
            this.cmdPdfClear.Name = "cmdPdfClear";
            this.cmdPdfClear.Size = new System.Drawing.Size(107, 25);
            this.cmdPdfClear.TabIndex = 52;
            this.cmdPdfClear.Text = "Återställ";
            this.cmdPdfClear.UseVisualStyleBackColor = true;
            this.cmdPdfClear.Click += new System.EventHandler(this.cmdPdfClear_Click);
            // 
            // laDb
            // 
            this.laDb.AutoSize = true;
            this.laDb.Location = new System.Drawing.Point(16, 106);
            this.laDb.Name = "laDb";
            this.laDb.Size = new System.Drawing.Size(60, 13);
            this.laDb.TabIndex = 51;
            this.laDb.Text = "Databas fil:";
            // 
            // cmdDbBrowse
            // 
            this.cmdDbBrowse.Location = new System.Drawing.Point(402, 119);
            this.cmdDbBrowse.Name = "cmdDbBrowse";
            this.cmdDbBrowse.Size = new System.Drawing.Size(107, 25);
            this.cmdDbBrowse.TabIndex = 49;
            this.cmdDbBrowse.Text = "Utforska";
            this.cmdDbBrowse.UseVisualStyleBackColor = true;
            this.cmdDbBrowse.Click += new System.EventHandler(this.cmdDbBrowse_Click);
            // 
            // txtDb
            // 
            this.txtDb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDb.Location = new System.Drawing.Point(19, 122);
            this.txtDb.Name = "txtDb";
            this.txtDb.ReadOnly = true;
            this.txtDb.Size = new System.Drawing.Size(377, 20);
            this.txtDb.TabIndex = 50;
            this.txtDb.TabStop = false;
            this.txtDb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // laBackup
            // 
            this.laBackup.AutoSize = true;
            this.laBackup.Location = new System.Drawing.Point(16, 65);
            this.laBackup.Name = "laBackup";
            this.laBackup.Size = new System.Drawing.Size(47, 13);
            this.laBackup.TabIndex = 48;
            this.laBackup.Text = "Backup:";
            // 
            // cmdBackupBrowse
            // 
            this.cmdBackupBrowse.Location = new System.Drawing.Point(402, 78);
            this.cmdBackupBrowse.Name = "cmdBackupBrowse";
            this.cmdBackupBrowse.Size = new System.Drawing.Size(107, 25);
            this.cmdBackupBrowse.TabIndex = 46;
            this.cmdBackupBrowse.Text = "Utforska";
            this.cmdBackupBrowse.UseVisualStyleBackColor = true;
            this.cmdBackupBrowse.Click += new System.EventHandler(this.cmdBackupBrowse_Click);
            // 
            // txtBackup
            // 
            this.txtBackup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBackup.Location = new System.Drawing.Point(19, 81);
            this.txtBackup.Name = "txtBackup";
            this.txtBackup.ReadOnly = true;
            this.txtBackup.Size = new System.Drawing.Size(377, 20);
            this.txtBackup.TabIndex = 47;
            this.txtBackup.TabStop = false;
            this.txtBackup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // laPdf
            // 
            this.laPdf.AutoSize = true;
            this.laPdf.Location = new System.Drawing.Point(16, 24);
            this.laPdf.Name = "laPdf";
            this.laPdf.Size = new System.Drawing.Size(26, 13);
            this.laPdf.TabIndex = 45;
            this.laPdf.Text = "Pdf:";
            // 
            // cmdPdfBrowse
            // 
            this.cmdPdfBrowse.Location = new System.Drawing.Point(402, 37);
            this.cmdPdfBrowse.Name = "cmdPdfBrowse";
            this.cmdPdfBrowse.Size = new System.Drawing.Size(107, 25);
            this.cmdPdfBrowse.TabIndex = 43;
            this.cmdPdfBrowse.Text = "Utforska";
            this.cmdPdfBrowse.UseVisualStyleBackColor = true;
            this.cmdPdfBrowse.Click += new System.EventHandler(this.cmdPdfBrowse_Click);
            // 
            // txtPdf
            // 
            this.txtPdf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPdf.Location = new System.Drawing.Point(19, 40);
            this.txtPdf.Name = "txtPdf";
            this.txtPdf.ReadOnly = true;
            this.txtPdf.Size = new System.Drawing.Size(377, 20);
            this.txtPdf.TabIndex = 44;
            this.txtPdf.TabStop = false;
            this.txtPdf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // laVerksamhet
            // 
            this.laVerksamhet.AutoSize = true;
            this.laVerksamhet.Location = new System.Drawing.Point(62, 271);
            this.laVerksamhet.Name = "laVerksamhet";
            this.laVerksamhet.Size = new System.Drawing.Size(66, 13);
            this.laVerksamhet.TabIndex = 54;
            this.laVerksamhet.Text = "Verksamhet:";
            // 
            // cmdVerksamhetSave
            // 
            this.cmdVerksamhetSave.Location = new System.Drawing.Point(259, 285);
            this.cmdVerksamhetSave.Name = "cmdVerksamhetSave";
            this.cmdVerksamhetSave.Size = new System.Drawing.Size(107, 25);
            this.cmdVerksamhetSave.TabIndex = 52;
            this.cmdVerksamhetSave.Text = "Spara";
            this.cmdVerksamhetSave.UseVisualStyleBackColor = true;
            this.cmdVerksamhetSave.Click += new System.EventHandler(this.cmdVerksamhetSave_Click);
            // 
            // txtVerksamhet
            // 
            this.txtVerksamhet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVerksamhet.Location = new System.Drawing.Point(65, 287);
            this.txtVerksamhet.Name = "txtVerksamhet";
            this.txtVerksamhet.Size = new System.Drawing.Size(188, 20);
            this.txtVerksamhet.TabIndex = 53;
            this.txtVerksamhet.TabStop = false;
            this.txtVerksamhet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmdCancel
            // 
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(567, 287);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(107, 25);
            this.cmdCancel.TabIndex = 55;
            this.cmdCancel.Text = "Avsluta";
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // cbBackupOnStart
            // 
            this.cbBackupOnStart.AutoSize = true;
            this.cbBackupOnStart.Location = new System.Drawing.Point(553, 41);
            this.cbBackupOnStart.Name = "cbBackupOnStart";
            this.cbBackupOnStart.Size = new System.Drawing.Size(115, 17);
            this.cbBackupOnStart.TabIndex = 56;
            this.cbBackupOnStart.Text = "Backup vid upstart";
            this.cbBackupOnStart.UseVisualStyleBackColor = true;
            this.cbBackupOnStart.CheckedChanged += new System.EventHandler(this.cbBackupOnStart_CheckedChanged);
            // 
            // cmdSkapMappClear
            // 
            this.cmdSkapMappClear.Location = new System.Drawing.Point(515, 160);
            this.cmdSkapMappClear.Name = "cmdSkapMappClear";
            this.cmdSkapMappClear.Size = new System.Drawing.Size(107, 25);
            this.cmdSkapMappClear.TabIndex = 58;
            this.cmdSkapMappClear.Text = "Återställ";
            this.cmdSkapMappClear.UseVisualStyleBackColor = true;
            this.cmdSkapMappClear.Click += new System.EventHandler(this.cmdSkapMappClear_Click);
            // 
            // laSkapMapp
            // 
            this.laSkapMapp.AutoSize = true;
            this.laSkapMapp.Location = new System.Drawing.Point(16, 147);
            this.laSkapMapp.Name = "laSkapMapp";
            this.laSkapMapp.Size = new System.Drawing.Size(108, 13);
            this.laSkapMapp.TabIndex = 57;
            this.laSkapMapp.Text = "Skåphantering mapp:";
            // 
            // cmdSkapMappBrowse
            // 
            this.cmdSkapMappBrowse.Location = new System.Drawing.Point(402, 160);
            this.cmdSkapMappBrowse.Name = "cmdSkapMappBrowse";
            this.cmdSkapMappBrowse.Size = new System.Drawing.Size(107, 25);
            this.cmdSkapMappBrowse.TabIndex = 55;
            this.cmdSkapMappBrowse.Text = "Utforska";
            this.cmdSkapMappBrowse.UseVisualStyleBackColor = true;
            this.cmdSkapMappBrowse.Click += new System.EventHandler(this.cmdSkapMappBrowse_Click);
            // 
            // txtSkapMapp
            // 
            this.txtSkapMapp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSkapMapp.Location = new System.Drawing.Point(19, 163);
            this.txtSkapMapp.Name = "txtSkapMapp";
            this.txtSkapMapp.ReadOnly = true;
            this.txtSkapMapp.Size = new System.Drawing.Size(377, 20);
            this.txtSkapMapp.TabIndex = 56;
            this.txtSkapMapp.TabStop = false;
            this.txtSkapMapp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SettingsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 329);
            this.Controls.Add(this.cbBackupOnStart);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.laVerksamhet);
            this.Controls.Add(this.gbLocations);
            this.Controls.Add(this.cmdVerksamhetSave);
            this.Controls.Add(this.laTitle);
            this.Controls.Add(this.txtVerksamhet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "SettingsDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.gbLocations.ResumeLayout(false);
            this.gbLocations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label laTitle;
        private System.Windows.Forms.GroupBox gbLocations;
        private System.Windows.Forms.Label laDb;
        private System.Windows.Forms.Button cmdDbBrowse;
        private System.Windows.Forms.TextBox txtDb;
        private System.Windows.Forms.Label laBackup;
        private System.Windows.Forms.Button cmdBackupBrowse;
        private System.Windows.Forms.TextBox txtBackup;
        private System.Windows.Forms.Label laPdf;
        private System.Windows.Forms.Button cmdPdfBrowse;
        private System.Windows.Forms.TextBox txtPdf;
        private System.Windows.Forms.Label laVerksamhet;
        private System.Windows.Forms.Button cmdVerksamhetSave;
        private System.Windows.Forms.TextBox txtVerksamhet;
        private System.Windows.Forms.Button cmdDbClear;
        private System.Windows.Forms.Button cmdBackupClear;
        private System.Windows.Forms.Button cmdPdfClear;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.CheckBox cbBackupOnStart;
        private System.Windows.Forms.Button cmdSkapMappClear;
        private System.Windows.Forms.Label laSkapMapp;
        private System.Windows.Forms.Button cmdSkapMappBrowse;
        private System.Windows.Forms.TextBox txtSkapMapp;
    }
}