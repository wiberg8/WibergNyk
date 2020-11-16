namespace WibergNyk
{
    partial class NewPerson
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
            this.cmdOk = new System.Windows.Forms.Button();
            this.laFornamn = new System.Windows.Forms.Label();
            this.txtFornamn = new System.Windows.Forms.TextBox();
            this.laTitle = new System.Windows.Forms.Label();
            this.laEfternamn = new System.Windows.Forms.Label();
            this.txtEfternamn = new System.Windows.Forms.TextBox();
            this.laPersNr = new System.Windows.Forms.Label();
            this.txtPersNr = new System.Windows.Forms.MaskedTextBox();
            this.laTelefon = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.laAnstalldSom = new System.Windows.Forms.Label();
            this.txtAnstalldSom = new System.Windows.Forms.TextBox();
            this.laOvrigt = new System.Windows.Forms.Label();
            this.txtOvrigt = new System.Windows.Forms.TextBox();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdOk
            // 
            this.cmdOk.Location = new System.Drawing.Point(427, 178);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(107, 25);
            this.cmdOk.TabIndex = 6;
            this.cmdOk.Text = "Ok";
            this.cmdOk.UseVisualStyleBackColor = true;
            this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
            // 
            // laFornamn
            // 
            this.laFornamn.AutoSize = true;
            this.laFornamn.Location = new System.Drawing.Point(50, 52);
            this.laFornamn.Name = "laFornamn";
            this.laFornamn.Size = new System.Drawing.Size(48, 13);
            this.laFornamn.TabIndex = 22;
            this.laFornamn.Text = "Förnamn";
            // 
            // txtFornamn
            // 
            this.txtFornamn.Location = new System.Drawing.Point(53, 68);
            this.txtFornamn.Name = "txtFornamn";
            this.txtFornamn.Size = new System.Drawing.Size(368, 20);
            this.txtFornamn.TabIndex = 0;
            this.txtFornamn.TextChanged += new System.EventHandler(this.txtFornamn_TextChanged);
            // 
            // laTitle
            // 
            this.laTitle.AutoSize = true;
            this.laTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laTitle.Location = new System.Drawing.Point(12, 14);
            this.laTitle.Name = "laTitle";
            this.laTitle.Size = new System.Drawing.Size(126, 20);
            this.laTitle.TabIndex = 24;
            this.laTitle.Text = "Person - Lägg till";
            // 
            // laEfternamn
            // 
            this.laEfternamn.AutoSize = true;
            this.laEfternamn.Location = new System.Drawing.Point(50, 94);
            this.laEfternamn.Name = "laEfternamn";
            this.laEfternamn.Size = new System.Drawing.Size(55, 13);
            this.laEfternamn.TabIndex = 26;
            this.laEfternamn.Text = "Efternamn";
            // 
            // txtEfternamn
            // 
            this.txtEfternamn.Location = new System.Drawing.Point(53, 110);
            this.txtEfternamn.Name = "txtEfternamn";
            this.txtEfternamn.Size = new System.Drawing.Size(368, 20);
            this.txtEfternamn.TabIndex = 1;
            // 
            // laPersNr
            // 
            this.laPersNr.AutoSize = true;
            this.laPersNr.Location = new System.Drawing.Point(50, 136);
            this.laPersNr.Name = "laPersNr";
            this.laPersNr.Size = new System.Drawing.Size(39, 13);
            this.laPersNr.TabIndex = 28;
            this.laPersNr.Text = "PersNr";
            // 
            // txtPersNr
            // 
            this.txtPersNr.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.txtPersNr.Location = new System.Drawing.Point(53, 152);
            this.txtPersNr.Mask = "00000000-0000";
            this.txtPersNr.Name = "txtPersNr";
            this.txtPersNr.Size = new System.Drawing.Size(93, 20);
            this.txtPersNr.TabIndex = 2;
            this.txtPersNr.TextChanged += new System.EventHandler(this.txtPersNr_TextChanged);
            // 
            // laTelefon
            // 
            this.laTelefon.AutoSize = true;
            this.laTelefon.Location = new System.Drawing.Point(149, 136);
            this.laTelefon.Name = "laTelefon";
            this.laTelefon.Size = new System.Drawing.Size(43, 13);
            this.laTelefon.TabIndex = 31;
            this.laTelefon.Text = "Telefon";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(152, 152);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(269, 20);
            this.txtTelefon.TabIndex = 3;
            // 
            // laAnstalldSom
            // 
            this.laAnstalldSom.AutoSize = true;
            this.laAnstalldSom.Location = new System.Drawing.Point(424, 52);
            this.laAnstalldSom.Name = "laAnstalldSom";
            this.laAnstalldSom.Size = new System.Drawing.Size(66, 13);
            this.laAnstalldSom.TabIndex = 33;
            this.laAnstalldSom.Text = "Anställd som";
            // 
            // txtAnstalldSom
            // 
            this.txtAnstalldSom.Location = new System.Drawing.Point(427, 68);
            this.txtAnstalldSom.Name = "txtAnstalldSom";
            this.txtAnstalldSom.Size = new System.Drawing.Size(269, 20);
            this.txtAnstalldSom.TabIndex = 4;
            // 
            // laOvrigt
            // 
            this.laOvrigt.AutoSize = true;
            this.laOvrigt.Location = new System.Drawing.Point(424, 94);
            this.laOvrigt.Name = "laOvrigt";
            this.laOvrigt.Size = new System.Drawing.Size(35, 13);
            this.laOvrigt.TabIndex = 35;
            this.laOvrigt.Text = "Övrigt";
            // 
            // txtOvrigt
            // 
            this.txtOvrigt.Location = new System.Drawing.Point(427, 110);
            this.txtOvrigt.Multiline = true;
            this.txtOvrigt.Name = "txtOvrigt";
            this.txtOvrigt.Size = new System.Drawing.Size(269, 62);
            this.txtOvrigt.TabIndex = 5;
            // 
            // cmdCancel
            // 
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdCancel.Location = new System.Drawing.Point(589, 178);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(107, 25);
            this.cmdCancel.TabIndex = 7;
            this.cmdCancel.Text = "Avbryt";
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            this.errorProvider.RightToLeft = true;
            // 
            // errorProvider2
            // 
            this.errorProvider2.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider2.ContainerControl = this;
            this.errorProvider2.RightToLeft = true;
            // 
            // NewPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 219);
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
            this.Controls.Add(this.cmdOk);
            this.Controls.Add(this.laFornamn);
            this.Controls.Add(this.txtFornamn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "NewPerson";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NewPerson_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdOk;
        private System.Windows.Forms.Label laFornamn;
        private System.Windows.Forms.TextBox txtFornamn;
        private System.Windows.Forms.Label laTitle;
        private System.Windows.Forms.Label laEfternamn;
        private System.Windows.Forms.TextBox txtEfternamn;
        private System.Windows.Forms.Label laPersNr;
        private System.Windows.Forms.MaskedTextBox txtPersNr;
        private System.Windows.Forms.Label laTelefon;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label laAnstalldSom;
        private System.Windows.Forms.TextBox txtAnstalldSom;
        private System.Windows.Forms.Label laOvrigt;
        private System.Windows.Forms.TextBox txtOvrigt;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}