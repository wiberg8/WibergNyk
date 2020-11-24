namespace WibergNyk
{
    partial class UpdatePerson
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
            this.components = new System.ComponentModel.Container();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmdCancel = new System.Windows.Forms.Button();
            this.laOvrigt = new System.Windows.Forms.Label();
            this.txtOvrigt = new System.Windows.Forms.TextBox();
            this.laAnstalldSom = new System.Windows.Forms.Label();
            this.txtAnstalldSom = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.laTelefon = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtPersNr = new System.Windows.Forms.MaskedTextBox();
            this.laPersNr = new System.Windows.Forms.Label();
            this.laEfternamn = new System.Windows.Forms.Label();
            this.txtEfternamn = new System.Windows.Forms.TextBox();
            this.laTitle = new System.Windows.Forms.Label();
            this.cmdSave = new System.Windows.Forms.Button();
            this.laFornamn = new System.Windows.Forms.Label();
            this.txtFornamn = new System.Windows.Forms.TextBox();
            this.cmdRadera = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider2
            // 
            this.errorProvider2.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider2.ContainerControl = this;
            this.errorProvider2.RightToLeft = true;
            // 
            // cmdCancel
            // 
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(588, 179);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(107, 25);
            this.cmdCancel.TabIndex = 43;
            this.cmdCancel.Text = "Avbryt";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // laOvrigt
            // 
            this.laOvrigt.AutoSize = true;
            this.laOvrigt.Location = new System.Drawing.Point(423, 95);
            this.laOvrigt.Name = "laOvrigt";
            this.laOvrigt.Size = new System.Drawing.Size(35, 13);
            this.laOvrigt.TabIndex = 50;
            this.laOvrigt.Text = "Övrigt";
            // 
            // txtOvrigt
            // 
            this.txtOvrigt.Location = new System.Drawing.Point(426, 111);
            this.txtOvrigt.Multiline = true;
            this.txtOvrigt.Name = "txtOvrigt";
            this.txtOvrigt.Size = new System.Drawing.Size(269, 62);
            this.txtOvrigt.TabIndex = 41;
            // 
            // laAnstalldSom
            // 
            this.laAnstalldSom.AutoSize = true;
            this.laAnstalldSom.Location = new System.Drawing.Point(423, 53);
            this.laAnstalldSom.Name = "laAnstalldSom";
            this.laAnstalldSom.Size = new System.Drawing.Size(66, 13);
            this.laAnstalldSom.TabIndex = 49;
            this.laAnstalldSom.Text = "Anställd som";
            // 
            // txtAnstalldSom
            // 
            this.txtAnstalldSom.Location = new System.Drawing.Point(426, 69);
            this.txtAnstalldSom.Name = "txtAnstalldSom";
            this.txtAnstalldSom.Size = new System.Drawing.Size(269, 20);
            this.txtAnstalldSom.TabIndex = 40;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            this.errorProvider.RightToLeft = true;
            // 
            // laTelefon
            // 
            this.laTelefon.AutoSize = true;
            this.laTelefon.Location = new System.Drawing.Point(148, 137);
            this.laTelefon.Name = "laTelefon";
            this.laTelefon.Size = new System.Drawing.Size(43, 13);
            this.laTelefon.TabIndex = 48;
            this.laTelefon.Text = "Telefon";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(151, 153);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(269, 20);
            this.txtTelefon.TabIndex = 39;
            // 
            // txtPersNr
            // 
            this.txtPersNr.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.txtPersNr.Location = new System.Drawing.Point(52, 153);
            this.txtPersNr.Mask = "00000000-0000";
            this.txtPersNr.Name = "txtPersNr";
            this.txtPersNr.ReadOnly = true;
            this.txtPersNr.Size = new System.Drawing.Size(93, 20);
            this.txtPersNr.TabIndex = 38;
            // 
            // laPersNr
            // 
            this.laPersNr.AutoSize = true;
            this.laPersNr.Location = new System.Drawing.Point(49, 137);
            this.laPersNr.Name = "laPersNr";
            this.laPersNr.Size = new System.Drawing.Size(39, 13);
            this.laPersNr.TabIndex = 47;
            this.laPersNr.Text = "PersNr";
            // 
            // laEfternamn
            // 
            this.laEfternamn.AutoSize = true;
            this.laEfternamn.Location = new System.Drawing.Point(49, 95);
            this.laEfternamn.Name = "laEfternamn";
            this.laEfternamn.Size = new System.Drawing.Size(55, 13);
            this.laEfternamn.TabIndex = 46;
            this.laEfternamn.Text = "Efternamn";
            // 
            // txtEfternamn
            // 
            this.txtEfternamn.Location = new System.Drawing.Point(52, 111);
            this.txtEfternamn.Name = "txtEfternamn";
            this.txtEfternamn.Size = new System.Drawing.Size(368, 20);
            this.txtEfternamn.TabIndex = 37;
            // 
            // laTitle
            // 
            this.laTitle.AutoSize = true;
            this.laTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laTitle.Location = new System.Drawing.Point(11, 15);
            this.laTitle.Name = "laTitle";
            this.laTitle.Size = new System.Drawing.Size(142, 20);
            this.laTitle.TabIndex = 45;
            this.laTitle.Text = "Person - Redigerar";
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(426, 179);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(107, 25);
            this.cmdSave.TabIndex = 42;
            this.cmdSave.Text = "Spara";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdOk_Click);
            // 
            // laFornamn
            // 
            this.laFornamn.AutoSize = true;
            this.laFornamn.Location = new System.Drawing.Point(49, 53);
            this.laFornamn.Name = "laFornamn";
            this.laFornamn.Size = new System.Drawing.Size(48, 13);
            this.laFornamn.TabIndex = 44;
            this.laFornamn.Text = "Förnamn";
            // 
            // txtFornamn
            // 
            this.txtFornamn.Location = new System.Drawing.Point(52, 69);
            this.txtFornamn.Name = "txtFornamn";
            this.txtFornamn.ReadOnly = true;
            this.txtFornamn.Size = new System.Drawing.Size(368, 20);
            this.txtFornamn.TabIndex = 36;
            // 
            // cmdRadera
            // 
            this.cmdRadera.Location = new System.Drawing.Point(52, 179);
            this.cmdRadera.Name = "cmdRadera";
            this.cmdRadera.Size = new System.Drawing.Size(107, 25);
            this.cmdRadera.TabIndex = 52;
            this.cmdRadera.TabStop = false;
            this.cmdRadera.Text = "Radera";
            this.cmdRadera.UseVisualStyleBackColor = true;
            this.cmdRadera.Click += new System.EventHandler(this.cmdRadera_Click);
            // 
            // UpdatePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 219);
            this.Controls.Add(this.cmdRadera);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.laOvrigt);
            this.Controls.Add(this.txtOvrigt);
            this.Controls.Add(this.laAnstalldSom);
            this.Controls.Add(this.txtAnstalldSom);
            this.Controls.Add(this.laTelefon);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtPersNr);
            this.Controls.Add(this.laPersNr);
            this.Controls.Add(this.laEfternamn);
            this.Controls.Add(this.txtEfternamn);
            this.Controls.Add(this.laTitle);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.laFornamn);
            this.Controls.Add(this.txtFornamn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "UpdatePerson";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UpdatePerson_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Label laOvrigt;
        private System.Windows.Forms.TextBox txtOvrigt;
        private System.Windows.Forms.Label laAnstalldSom;
        private System.Windows.Forms.TextBox txtAnstalldSom;
        private System.Windows.Forms.Label laTelefon;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.MaskedTextBox txtPersNr;
        private System.Windows.Forms.Label laPersNr;
        private System.Windows.Forms.Label laEfternamn;
        private System.Windows.Forms.TextBox txtEfternamn;
        private System.Windows.Forms.Label laTitle;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Label laFornamn;
        private System.Windows.Forms.TextBox txtFornamn;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button cmdRadera;
    }
}