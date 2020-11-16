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
    public partial class UpdatePerson : Form
    {
        public Person Updateperson { get; private set; }
        public UpdatePerson(Person person)
        {
            InitializeComponent();
            txtFornamn.Text = person.Fornamn;
            txtEfternamn.Text = person.Efternamn;
            txtPersNr.Text = person.PersNr;
            txtTelefon.Text = person.Telefon;
            txtAnstalldSom.Text = person.AnstalldSom;
            txtOvrigt.Text = person.Ovrigt;
            this.Updateperson = person;
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtFornamn.Text))
            {
                Updateperson.Efternamn = txtEfternamn.Text.Trim();
                Updateperson.Telefon = txtTelefon.Text.Trim();
                Updateperson.AnstalldSom = txtAnstalldSom.Text.Trim();
                Updateperson.Ovrigt = txtOvrigt.Text;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {

        }

        private void cmdRadera_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show(this, "Är du säker?", "WibergNyk", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Abort;
            }
        }

        private void UpdatePerson_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
