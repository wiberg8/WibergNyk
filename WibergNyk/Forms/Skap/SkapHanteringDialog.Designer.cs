namespace WibergNyk.Forms.Skap
{
    partial class SkapHanteringDialog
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
            this.cmdCancel = new System.Windows.Forms.Button();
            this.laKlassSelect = new System.Windows.Forms.Label();
            this.cbKlassSelect = new System.Windows.Forms.ComboBox();
            this.cmdImportSkapFil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdCancel
            // 
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(602, 349);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(107, 25);
            this.cmdCancel.TabIndex = 56;
            this.cmdCancel.Text = "Avsluta";
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // laKlassSelect
            // 
            this.laKlassSelect.AutoSize = true;
            this.laKlassSelect.Location = new System.Drawing.Point(19, 23);
            this.laKlassSelect.Name = "laKlassSelect";
            this.laKlassSelect.Size = new System.Drawing.Size(54, 13);
            this.laKlassSelect.TabIndex = 57;
            this.laKlassSelect.Text = "Välj klass:";
            // 
            // cbKlassSelect
            // 
            this.cbKlassSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKlassSelect.FormattingEnabled = true;
            this.cbKlassSelect.Location = new System.Drawing.Point(22, 39);
            this.cbKlassSelect.Name = "cbKlassSelect";
            this.cbKlassSelect.Size = new System.Drawing.Size(143, 21);
            this.cbKlassSelect.TabIndex = 58;
            // 
            // cmdImportSkapFil
            // 
            this.cmdImportSkapFil.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdImportSkapFil.Location = new System.Drawing.Point(189, 36);
            this.cmdImportSkapFil.Name = "cmdImportSkapFil";
            this.cmdImportSkapFil.Size = new System.Drawing.Size(122, 25);
            this.cmdImportSkapFil.TabIndex = 59;
            this.cmdImportSkapFil.Text = "Importera skåp fil";
            this.cmdImportSkapFil.UseVisualStyleBackColor = true;
            this.cmdImportSkapFil.Click += new System.EventHandler(this.cmdImportSkapFil_Click);
            // 
            // SkapHanteringDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 387);
            this.Controls.Add(this.cmdImportSkapFil);
            this.Controls.Add(this.cbKlassSelect);
            this.Controls.Add(this.laKlassSelect);
            this.Controls.Add(this.cmdCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SkapHanteringDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SkapHanteringDialog";
            this.Load += new System.EventHandler(this.SkapHanteringDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Label laKlassSelect;
        private System.Windows.Forms.ComboBox cbKlassSelect;
        private System.Windows.Forms.Button cmdImportSkapFil;
    }
}