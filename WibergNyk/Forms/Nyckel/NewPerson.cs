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
    public partial class NewPerson : Form
    {
        public Person AddPerson { get; private set; }
        public NewPerson()
        {
            InitializeComponent();
            SetErrorProvider(txtPersNr, "Varning (ej krav)", errorProvider);
            SetErrorProvider(txtFornamn, "Måste vara i fyllt", errorProvider2);
        }

        private void SetErrorProvider(MaskedTextBox maskedTextBox, string message, ErrorProvider eProvider)
        {
            if (maskedTextBox.MaskCompleted)
                eProvider.Clear();
            else
                eProvider.SetError(maskedTextBox, message);
        }
        private void SetErrorProvider(TextBox textBox, string message, ErrorProvider eProvider)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
                eProvider.SetError(textBox, message);
            else
                eProvider.Clear();
        }

        #region TextChanged events
        private void txtPersNr_TextChanged(object sender, EventArgs e)
        {
            SetErrorProvider(txtPersNr, "Varning (ej krav)", errorProvider);
        }
        private void txtFornamn_TextChanged(object sender, EventArgs e)
        {
            SetErrorProvider(txtFornamn, "Måste vara i fyllt", errorProvider2);
        }
        #endregion

        private void cmdOk_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtFornamn.Text))
            {
                string persNr = string.Empty;
                if (txtPersNr.MaskCompleted)
                    persNr = txtPersNr.Text;
                //Kollar om persnr redan finns på en person i så fall returnerar han från metoden för att undvika  DialogResult.OK och Initiera AddPerson
                if (DataAccess.ExistPerson(persNr))
                {
                    MessageBox.Show("Personen finns redan");
                }
                else
                {
                    this.AddPerson = new Person()
                    {
                        Fornamn = txtFornamn.Text.Trim(),
                        Efternamn = txtEfternamn.Text.Trim(),
                        PersNr = persNr,
                        Telefon = txtTelefon.Text,
                        AnstalldSom = txtAnstalldSom.Text.Trim(),
                        Ovrigt = txtOvrigt.Text
                    };
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private void NewPerson_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
