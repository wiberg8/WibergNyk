namespace WibergNyk
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.txtValdPerson = new System.Windows.Forms.TextBox();
            this.laRegistreradNyckel = new System.Windows.Forms.Label();
            this.txtValdNyckel = new System.Windows.Forms.TextBox();
            this.cmdValdNyckelMer = new System.Windows.Forms.Button();
            this.cmdValdPersonMer = new System.Windows.Forms.Button();
            this.dgNycklar = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmKeyTyp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmKeySerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmKeyNummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgPersoner = new System.Windows.Forms.DataGridView();
            this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFirstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPersNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTelephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAnstalldSom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmdSearch = new System.Windows.Forms.Button();
            this.rbSearchPersoner = new System.Windows.Forms.RadioButton();
            this.rbSearchNycklar = new System.Windows.Forms.RadioButton();
            this.cbRegistreradeNycklar = new System.Windows.Forms.ComboBox();
            this.cmdAvregistreraNyckel = new System.Windows.Forms.Button();
            this.cmdRegistreraNyckel = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tspInstallningar = new System.Windows.Forms.ToolStripMenuItem();
            this.tspNy = new System.Windows.Forms.ToolStripMenuItem();
            this.tspNyNyckel = new System.Windows.Forms.ToolStripMenuItem();
            this.tspNyPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdKvittens = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgNycklar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPersoner)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtValdPerson
            // 
            this.txtValdPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValdPerson.Location = new System.Drawing.Point(12, 567);
            this.txtValdPerson.Name = "txtValdPerson";
            this.txtValdPerson.ReadOnly = true;
            this.txtValdPerson.Size = new System.Drawing.Size(285, 20);
            this.txtValdPerson.TabIndex = 0;
            this.txtValdPerson.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // laRegistreradNyckel
            // 
            this.laRegistreradNyckel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.laRegistreradNyckel.Location = new System.Drawing.Point(583, 591);
            this.laRegistreradNyckel.Name = "laRegistreradNyckel";
            this.laRegistreradNyckel.Size = new System.Drawing.Size(190, 25);
            this.laRegistreradNyckel.TabIndex = 3;
            this.laRegistreradNyckel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.laRegistreradNyckel.Visible = false;
            // 
            // txtValdNyckel
            // 
            this.txtValdNyckel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValdNyckel.Location = new System.Drawing.Point(586, 568);
            this.txtValdNyckel.Name = "txtValdNyckel";
            this.txtValdNyckel.ReadOnly = true;
            this.txtValdNyckel.Size = new System.Drawing.Size(413, 20);
            this.txtValdNyckel.TabIndex = 2;
            this.txtValdNyckel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmdValdNyckelMer
            // 
            this.cmdValdNyckelMer.Location = new System.Drawing.Point(892, 591);
            this.cmdValdNyckelMer.Name = "cmdValdNyckelMer";
            this.cmdValdNyckelMer.Size = new System.Drawing.Size(107, 25);
            this.cmdValdNyckelMer.TabIndex = 20;
            this.cmdValdNyckelMer.Text = "Mer...";
            this.cmdValdNyckelMer.UseVisualStyleBackColor = true;
            this.cmdValdNyckelMer.Click += new System.EventHandler(this.cmdValdNyckelMer_Click);
            // 
            // cmdValdPersonMer
            // 
            this.cmdValdPersonMer.Location = new System.Drawing.Point(190, 591);
            this.cmdValdPersonMer.Name = "cmdValdPersonMer";
            this.cmdValdPersonMer.Size = new System.Drawing.Size(107, 25);
            this.cmdValdPersonMer.TabIndex = 19;
            this.cmdValdPersonMer.Text = "Mer...";
            this.cmdValdPersonMer.UseVisualStyleBackColor = true;
            this.cmdValdPersonMer.Click += new System.EventHandler(this.cmdValdPersonMer_Click);
            // 
            // dgNycklar
            // 
            this.dgNycklar.AllowUserToAddRows = false;
            this.dgNycklar.AllowUserToDeleteRows = false;
            this.dgNycklar.AllowUserToResizeColumns = false;
            this.dgNycklar.AllowUserToResizeRows = false;
            this.dgNycklar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgNycklar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgNycklar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgNycklar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgNycklar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgNycklar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgNycklar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNycklar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.clmKeyTyp,
            this.clmKeySerie,
            this.clmKeyNummer});
            this.dgNycklar.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgNycklar.Location = new System.Drawing.Point(586, 99);
            this.dgNycklar.MultiSelect = false;
            this.dgNycklar.Name = "dgNycklar";
            this.dgNycklar.RowHeadersVisible = false;
            this.dgNycklar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgNycklar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgNycklar.ShowCellErrors = false;
            this.dgNycklar.ShowCellToolTips = false;
            this.dgNycklar.ShowEditingIcon = false;
            this.dgNycklar.ShowRowErrors = false;
            this.dgNycklar.Size = new System.Drawing.Size(413, 458);
            this.dgNycklar.TabIndex = 10;
            this.dgNycklar.SelectionChanged += new System.EventHandler(this.dgNycklar_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // clmKeyTyp
            // 
            this.clmKeyTyp.HeaderText = "Typ";
            this.clmKeyTyp.Name = "clmKeyTyp";
            // 
            // clmKeySerie
            // 
            this.clmKeySerie.HeaderText = "Serie";
            this.clmKeySerie.Name = "clmKeySerie";
            this.clmKeySerie.ReadOnly = true;
            // 
            // clmKeyNummer
            // 
            this.clmKeyNummer.HeaderText = "Nummer";
            this.clmKeyNummer.Name = "clmKeyNummer";
            this.clmKeyNummer.ReadOnly = true;
            // 
            // dgPersoner
            // 
            this.dgPersoner.AllowUserToAddRows = false;
            this.dgPersoner.AllowUserToDeleteRows = false;
            this.dgPersoner.AllowUserToResizeColumns = false;
            this.dgPersoner.AllowUserToResizeRows = false;
            this.dgPersoner.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPersoner.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgPersoner.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgPersoner.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgPersoner.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPersoner.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgPersoner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPersoner.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmId,
            this.clmFirstname,
            this.clmLastname,
            this.clmPersNr,
            this.clmTelephone,
            this.clmAnstalldSom});
            this.dgPersoner.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgPersoner.GridColor = System.Drawing.SystemColors.Control;
            this.dgPersoner.Location = new System.Drawing.Point(12, 99);
            this.dgPersoner.MultiSelect = false;
            this.dgPersoner.Name = "dgPersoner";
            this.dgPersoner.RowHeadersVisible = false;
            this.dgPersoner.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgPersoner.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPersoner.ShowCellErrors = false;
            this.dgPersoner.ShowCellToolTips = false;
            this.dgPersoner.ShowEditingIcon = false;
            this.dgPersoner.ShowRowErrors = false;
            this.dgPersoner.Size = new System.Drawing.Size(568, 458);
            this.dgPersoner.TabIndex = 11;
            this.dgPersoner.SelectionChanged += new System.EventHandler(this.dgPersoner_SelectionChanged);
            // 
            // clmId
            // 
            this.clmId.HeaderText = "Id";
            this.clmId.Name = "clmId";
            this.clmId.ReadOnly = true;
            // 
            // clmFirstname
            // 
            this.clmFirstname.HeaderText = "Förnamn";
            this.clmFirstname.Name = "clmFirstname";
            this.clmFirstname.ReadOnly = true;
            // 
            // clmLastname
            // 
            this.clmLastname.HeaderText = "Efternamn";
            this.clmLastname.Name = "clmLastname";
            this.clmLastname.ReadOnly = true;
            // 
            // clmPersNr
            // 
            this.clmPersNr.HeaderText = "PersNr";
            this.clmPersNr.Name = "clmPersNr";
            this.clmPersNr.ReadOnly = true;
            // 
            // clmTelephone
            // 
            this.clmTelephone.HeaderText = "Telefon";
            this.clmTelephone.Name = "clmTelephone";
            this.clmTelephone.ReadOnly = true;
            // 
            // clmAnstalldSom
            // 
            this.clmAnstalldSom.HeaderText = "Anställd.S";
            this.clmAnstalldSom.Name = "clmAnstalldSom";
            this.clmAnstalldSom.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Personer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(582, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Nycklar";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 48);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(238, 20);
            this.txtSearch.TabIndex = 27;
            // 
            // cmdSearch
            // 
            this.cmdSearch.Location = new System.Drawing.Point(256, 45);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(107, 25);
            this.cmdSearch.TabIndex = 21;
            this.cmdSearch.Text = "Sök";
            this.cmdSearch.UseVisualStyleBackColor = true;
            this.cmdSearch.Click += new System.EventHandler(this.cmdSearch_Click);
            // 
            // rbSearchPersoner
            // 
            this.rbSearchPersoner.AutoSize = true;
            this.rbSearchPersoner.Checked = true;
            this.rbSearchPersoner.Location = new System.Drawing.Point(12, 26);
            this.rbSearchPersoner.Name = "rbSearchPersoner";
            this.rbSearchPersoner.Size = new System.Drawing.Size(67, 17);
            this.rbSearchPersoner.TabIndex = 28;
            this.rbSearchPersoner.TabStop = true;
            this.rbSearchPersoner.Text = "Personer";
            this.rbSearchPersoner.UseVisualStyleBackColor = true;
            // 
            // rbSearchNycklar
            // 
            this.rbSearchNycklar.AutoSize = true;
            this.rbSearchNycklar.Location = new System.Drawing.Point(85, 26);
            this.rbSearchNycklar.Name = "rbSearchNycklar";
            this.rbSearchNycklar.Size = new System.Drawing.Size(61, 17);
            this.rbSearchNycklar.TabIndex = 29;
            this.rbSearchNycklar.Text = "Nycklar";
            this.rbSearchNycklar.UseVisualStyleBackColor = true;
            // 
            // cbRegistreradeNycklar
            // 
            this.cbRegistreradeNycklar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRegistreradeNycklar.FormattingEnabled = true;
            this.cbRegistreradeNycklar.Location = new System.Drawing.Point(303, 567);
            this.cbRegistreradeNycklar.Name = "cbRegistreradeNycklar";
            this.cbRegistreradeNycklar.Size = new System.Drawing.Size(277, 21);
            this.cbRegistreradeNycklar.TabIndex = 30;
            this.cbRegistreradeNycklar.Visible = false;
            // 
            // cmdAvregistreraNyckel
            // 
            this.cmdAvregistreraNyckel.Location = new System.Drawing.Point(473, 591);
            this.cmdAvregistreraNyckel.Name = "cmdAvregistreraNyckel";
            this.cmdAvregistreraNyckel.Size = new System.Drawing.Size(107, 25);
            this.cmdAvregistreraNyckel.TabIndex = 31;
            this.cmdAvregistreraNyckel.Text = "Avregistrera";
            this.cmdAvregistreraNyckel.UseVisualStyleBackColor = true;
            this.cmdAvregistreraNyckel.Visible = false;
            this.cmdAvregistreraNyckel.Click += new System.EventHandler(this.cmdAvregistreraNyckel_Click);
            // 
            // cmdRegistreraNyckel
            // 
            this.cmdRegistreraNyckel.Location = new System.Drawing.Point(779, 591);
            this.cmdRegistreraNyckel.Name = "cmdRegistreraNyckel";
            this.cmdRegistreraNyckel.Size = new System.Drawing.Size(107, 25);
            this.cmdRegistreraNyckel.TabIndex = 32;
            this.cmdRegistreraNyckel.Text = "Registrera";
            this.cmdRegistreraNyckel.UseVisualStyleBackColor = true;
            this.cmdRegistreraNyckel.Visible = false;
            this.cmdRegistreraNyckel.Click += new System.EventHandler(this.cmdRegistreraNyckel_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspInstallningar,
            this.tspNy});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1019, 24);
            this.menuStrip1.TabIndex = 35;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tspInstallningar
            // 
            this.tspInstallningar.Name = "tspInstallningar";
            this.tspInstallningar.Size = new System.Drawing.Size(84, 20);
            this.tspInstallningar.Text = "Inställningar";
            this.tspInstallningar.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tspInstallningar.Click += new System.EventHandler(this.tspInstallningar_Click);
            // 
            // tspNy
            // 
            this.tspNy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspNyNyckel,
            this.tspNyPerson});
            this.tspNy.Name = "tspNy";
            this.tspNy.Size = new System.Drawing.Size(43, 20);
            this.tspNy.Text = "Ny...";
            // 
            // tspNyNyckel
            // 
            this.tspNyNyckel.Name = "tspNyNyckel";
            this.tspNyNyckel.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.tspNyNyckel.Size = new System.Drawing.Size(156, 22);
            this.tspNyNyckel.Text = "Nyckel";
            this.tspNyNyckel.Click += new System.EventHandler(this.tspNyNyckel_Click);
            // 
            // tspNyPerson
            // 
            this.tspNyPerson.Name = "tspNyPerson";
            this.tspNyPerson.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F2)));
            this.tspNyPerson.Size = new System.Drawing.Size(156, 22);
            this.tspNyPerson.Text = "Person";
            this.tspNyPerson.Click += new System.EventHandler(this.tspNyPerson_Click);
            // 
            // cmdKvittens
            // 
            this.cmdKvittens.Location = new System.Drawing.Point(303, 591);
            this.cmdKvittens.Name = "cmdKvittens";
            this.cmdKvittens.Size = new System.Drawing.Size(107, 25);
            this.cmdKvittens.TabIndex = 36;
            this.cmdKvittens.Text = "Kvittens";
            this.cmdKvittens.UseVisualStyleBackColor = true;
            this.cmdKvittens.Visible = false;
            this.cmdKvittens.Click += new System.EventHandler(this.cmdKvittens_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 627);
            this.Controls.Add(this.cmdKvittens);
            this.Controls.Add(this.cmdRegistreraNyckel);
            this.Controls.Add(this.cmdAvregistreraNyckel);
            this.Controls.Add(this.cbRegistreradeNycklar);
            this.Controls.Add(this.laRegistreradNyckel);
            this.Controls.Add(this.cmdValdPersonMer);
            this.Controls.Add(this.cmdValdNyckelMer);
            this.Controls.Add(this.txtValdPerson);
            this.Controls.Add(this.rbSearchNycklar);
            this.Controls.Add(this.rbSearchPersoner);
            this.Controls.Add(this.cmdSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtValdNyckel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgPersoner);
            this.Controls.Add(this.dgNycklar);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "WibergNyk";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgNycklar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPersoner)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValdPerson;
        private System.Windows.Forms.Label laRegistreradNyckel;
        private System.Windows.Forms.TextBox txtValdNyckel;
        private System.Windows.Forms.Button cmdValdNyckelMer;
        private System.Windows.Forms.Button cmdValdPersonMer;
        private System.Windows.Forms.DataGridView dgNycklar;
        private System.Windows.Forms.DataGridView dgPersoner;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmKeyTyp;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmKeySerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmKeyNummer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button cmdSearch;
        private System.Windows.Forms.RadioButton rbSearchPersoner;
        private System.Windows.Forms.RadioButton rbSearchNycklar;
        private System.Windows.Forms.ComboBox cbRegistreradeNycklar;
        private System.Windows.Forms.Button cmdAvregistreraNyckel;
        private System.Windows.Forms.Button cmdRegistreraNyckel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tspNy;
        private System.Windows.Forms.ToolStripMenuItem tspNyNyckel;
        private System.Windows.Forms.ToolStripMenuItem tspNyPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFirstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPersNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTelephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAnstalldSom;
        private System.Windows.Forms.ToolStripMenuItem tspInstallningar;
        private System.Windows.Forms.Button cmdKvittens;
    }
}