namespace WibergNyk
{
    partial class UpdateNyckel
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
            this.cmdSave = new System.Windows.Forms.Button();
            this.laOvrigt = new System.Windows.Forms.Label();
            this.txtOvrigt = new System.Windows.Forms.TextBox();
            this.laNummer = new System.Windows.Forms.Label();
            this.txtNummer = new System.Windows.Forms.TextBox();
            this.laSerie = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.laTitle = new System.Windows.Forms.Label();
            this.laTyp = new System.Windows.Forms.Label();
            this.txtTyp = new System.Windows.Forms.TextBox();
            this.cmdRadera = new System.Windows.Forms.Button();
            this.laId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmdCancel
            // 
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(308, 275);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(107, 25);
            this.cmdCancel.TabIndex = 48;
            this.cmdCancel.Text = "Avbryt";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(195, 275);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(107, 25);
            this.cmdSave.TabIndex = 47;
            this.cmdSave.Text = "Spara";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // laOvrigt
            // 
            this.laOvrigt.AutoSize = true;
            this.laOvrigt.Location = new System.Drawing.Point(44, 203);
            this.laOvrigt.Name = "laOvrigt";
            this.laOvrigt.Size = new System.Drawing.Size(35, 13);
            this.laOvrigt.TabIndex = 46;
            this.laOvrigt.Text = "Övrigt";
            // 
            // txtOvrigt
            // 
            this.txtOvrigt.Location = new System.Drawing.Point(47, 219);
            this.txtOvrigt.Multiline = true;
            this.txtOvrigt.Name = "txtOvrigt";
            this.txtOvrigt.Size = new System.Drawing.Size(368, 50);
            this.txtOvrigt.TabIndex = 45;
            // 
            // laNummer
            // 
            this.laNummer.AutoSize = true;
            this.laNummer.Location = new System.Drawing.Point(44, 161);
            this.laNummer.Name = "laNummer";
            this.laNummer.Size = new System.Drawing.Size(46, 13);
            this.laNummer.TabIndex = 44;
            this.laNummer.Text = "Nummer";
            // 
            // txtNummer
            // 
            this.txtNummer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNummer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNummer.Location = new System.Drawing.Point(47, 177);
            this.txtNummer.Name = "txtNummer";
            this.txtNummer.ReadOnly = true;
            this.txtNummer.Size = new System.Drawing.Size(368, 20);
            this.txtNummer.TabIndex = 43;
            this.txtNummer.TabStop = false;
            // 
            // laSerie
            // 
            this.laSerie.AutoSize = true;
            this.laSerie.Location = new System.Drawing.Point(44, 122);
            this.laSerie.Name = "laSerie";
            this.laSerie.Size = new System.Drawing.Size(31, 13);
            this.laSerie.TabIndex = 42;
            this.laSerie.Text = "Serie";
            // 
            // txtSerie
            // 
            this.txtSerie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSerie.Location = new System.Drawing.Point(47, 138);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.ReadOnly = true;
            this.txtSerie.Size = new System.Drawing.Size(368, 20);
            this.txtSerie.TabIndex = 41;
            this.txtSerie.TabStop = false;
            // 
            // laTitle
            // 
            this.laTitle.AutoSize = true;
            this.laTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laTitle.Location = new System.Drawing.Point(13, 16);
            this.laTitle.Name = "laTitle";
            this.laTitle.Size = new System.Drawing.Size(138, 20);
            this.laTitle.TabIndex = 40;
            this.laTitle.Text = "Nyckel - Redigerar";
            // 
            // laTyp
            // 
            this.laTyp.AutoSize = true;
            this.laTyp.Location = new System.Drawing.Point(44, 83);
            this.laTyp.Name = "laTyp";
            this.laTyp.Size = new System.Drawing.Size(25, 13);
            this.laTyp.TabIndex = 39;
            this.laTyp.Text = "Typ";
            // 
            // txtTyp
            // 
            this.txtTyp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTyp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTyp.Location = new System.Drawing.Point(47, 99);
            this.txtTyp.Name = "txtTyp";
            this.txtTyp.ReadOnly = true;
            this.txtTyp.Size = new System.Drawing.Size(368, 20);
            this.txtTyp.TabIndex = 38;
            this.txtTyp.TabStop = false;
            // 
            // cmdRadera
            // 
            this.cmdRadera.Location = new System.Drawing.Point(47, 275);
            this.cmdRadera.Name = "cmdRadera";
            this.cmdRadera.Size = new System.Drawing.Size(107, 25);
            this.cmdRadera.TabIndex = 49;
            this.cmdRadera.TabStop = false;
            this.cmdRadera.Text = "Radera";
            this.cmdRadera.UseVisualStyleBackColor = true;
            this.cmdRadera.Click += new System.EventHandler(this.cmdRadera_Click);
            // 
            // laId
            // 
            this.laId.AutoSize = true;
            this.laId.Location = new System.Drawing.Point(44, 44);
            this.laId.Name = "laId";
            this.laId.Size = new System.Drawing.Size(16, 13);
            this.laId.TabIndex = 51;
            this.laId.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtId.Location = new System.Drawing.Point(47, 60);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(87, 20);
            this.txtId.TabIndex = 50;
            this.txtId.TabStop = false;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // UpdateNyckel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(457, 318);
            this.Controls.Add(this.laId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.cmdRadera);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdSave);
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
            this.Name = "UpdateNyckel";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UpdateNyckel";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UpdateNyckel_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Label laOvrigt;
        private System.Windows.Forms.TextBox txtOvrigt;
        private System.Windows.Forms.Label laNummer;
        private System.Windows.Forms.TextBox txtNummer;
        private System.Windows.Forms.Label laSerie;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label laTitle;
        private System.Windows.Forms.Label laTyp;
        private System.Windows.Forms.TextBox txtTyp;
        private System.Windows.Forms.Button cmdRadera;
        private System.Windows.Forms.Label laId;
        private System.Windows.Forms.TextBox txtId;
    }
}