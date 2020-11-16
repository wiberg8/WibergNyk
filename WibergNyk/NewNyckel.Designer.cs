namespace WibergNyk
{
    partial class NewNyckel
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
            this.laTyp = new System.Windows.Forms.Label();
            this.txtTyp = new System.Windows.Forms.TextBox();
            this.laTitle = new System.Windows.Forms.Label();
            this.laSerie = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.laNummer = new System.Windows.Forms.Label();
            this.txtNummer = new System.Windows.Forms.TextBox();
            this.laOvrigt = new System.Windows.Forms.Label();
            this.txtOvrigt = new System.Windows.Forms.TextBox();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // laTyp
            // 
            this.laTyp.AutoSize = true;
            this.laTyp.Location = new System.Drawing.Point(54, 63);
            this.laTyp.Name = "laTyp";
            this.laTyp.Size = new System.Drawing.Size(25, 13);
            this.laTyp.TabIndex = 28;
            this.laTyp.Text = "Typ";
            // 
            // txtTyp
            // 
            this.txtTyp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTyp.Location = new System.Drawing.Point(57, 79);
            this.txtTyp.Name = "txtTyp";
            this.txtTyp.Size = new System.Drawing.Size(368, 20);
            this.txtTyp.TabIndex = 27;
            // 
            // laTitle
            // 
            this.laTitle.AutoSize = true;
            this.laTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laTitle.Location = new System.Drawing.Point(23, 21);
            this.laTitle.Name = "laTitle";
            this.laTitle.Size = new System.Drawing.Size(122, 20);
            this.laTitle.TabIndex = 29;
            this.laTitle.Text = "Nyckel - Lägg till";
            // 
            // laSerie
            // 
            this.laSerie.AutoSize = true;
            this.laSerie.Location = new System.Drawing.Point(54, 102);
            this.laSerie.Name = "laSerie";
            this.laSerie.Size = new System.Drawing.Size(31, 13);
            this.laSerie.TabIndex = 31;
            this.laSerie.Text = "Serie";
            // 
            // txtSerie
            // 
            this.txtSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSerie.Location = new System.Drawing.Point(57, 118);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(368, 20);
            this.txtSerie.TabIndex = 30;
            // 
            // laNummer
            // 
            this.laNummer.AutoSize = true;
            this.laNummer.Location = new System.Drawing.Point(54, 141);
            this.laNummer.Name = "laNummer";
            this.laNummer.Size = new System.Drawing.Size(46, 13);
            this.laNummer.TabIndex = 33;
            this.laNummer.Text = "Nummer";
            // 
            // txtNummer
            // 
            this.txtNummer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNummer.Location = new System.Drawing.Point(57, 157);
            this.txtNummer.Name = "txtNummer";
            this.txtNummer.Size = new System.Drawing.Size(368, 20);
            this.txtNummer.TabIndex = 32;
            // 
            // laOvrigt
            // 
            this.laOvrigt.AutoSize = true;
            this.laOvrigt.Location = new System.Drawing.Point(54, 183);
            this.laOvrigt.Name = "laOvrigt";
            this.laOvrigt.Size = new System.Drawing.Size(35, 13);
            this.laOvrigt.TabIndex = 35;
            this.laOvrigt.Text = "Övrigt";
            // 
            // txtOvrigt
            // 
            this.txtOvrigt.Location = new System.Drawing.Point(57, 199);
            this.txtOvrigt.Multiline = true;
            this.txtOvrigt.Name = "txtOvrigt";
            this.txtOvrigt.Size = new System.Drawing.Size(368, 50);
            this.txtOvrigt.TabIndex = 34;
            // 
            // cmdCancel
            // 
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdCancel.Location = new System.Drawing.Point(318, 255);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(107, 25);
            this.cmdCancel.TabIndex = 37;
            this.cmdCancel.Text = "Avbryt";
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // cmdOk
            // 
            this.cmdOk.Location = new System.Drawing.Point(189, 255);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(107, 25);
            this.cmdOk.TabIndex = 36;
            this.cmdOk.Text = "Ok";
            this.cmdOk.UseVisualStyleBackColor = true;
            this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
            // 
            // NewNyckel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 292);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdOk);
            this.Controls.Add(this.laOvrigt);
            this.Controls.Add(this.txtOvrigt);
            this.Controls.Add(this.laNummer);
            this.Controls.Add(this.txtNummer);
            this.Controls.Add(this.laSerie);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.laTitle);
            this.Controls.Add(this.laTyp);
            this.Controls.Add(this.txtTyp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "NewNyckel";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NewNyckel";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NewNyckel_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label laTyp;
        private System.Windows.Forms.TextBox txtTyp;
        private System.Windows.Forms.Label laTitle;
        private System.Windows.Forms.Label laSerie;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label laNummer;
        private System.Windows.Forms.TextBox txtNummer;
        private System.Windows.Forms.Label laOvrigt;
        private System.Windows.Forms.TextBox txtOvrigt;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdOk;
    }
}