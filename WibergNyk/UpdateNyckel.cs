using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WibergNykLibary;

namespace WibergNyk
{
    public partial class UpdateNyckel : Form
    {
        public Nyckel Updatenyckel { get; private set; }
        private Nyckel EditingNyckel;
        public UpdateNyckel(Nyckel nyckel)
        {
            InitializeComponent();
            this.EditingNyckel = nyckel;
            txtId.Text = nyckel.ID.ToString();
            txtTyp.Text = nyckel.Typ;
            txtSerie.Text = nyckel.Serie;
            txtNummer.Text = nyckel.Nummer;
            txtOvrigt.Text = nyckel.Ovrigt;
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            this.Updatenyckel = EditingNyckel;
            Updatenyckel.Ovrigt = txtOvrigt.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void cmdRadera_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Är du säker?", "WibergNyk", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Abort;
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateNyckel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
