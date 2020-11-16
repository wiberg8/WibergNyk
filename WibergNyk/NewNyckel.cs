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
    public partial class NewNyckel : Form
    {
        public Nyckel AddNyckel { get; private set; }
        public NewNyckel()
        {
            InitializeComponent();
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            AddNyckelOk();
        }

        private void NewNyckel_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void AddNyckelOk()
        {
            if (FieldsValid())
            {
                Nyckel nyckel = new Nyckel()
                {
                    Typ = txtTyp.Text.Trim(),
                    Serie = txtSerie.Text.Trim(),
                    Nummer = txtNummer.Text.Trim(),
                    Ovrigt = txtOvrigt.Text
                };
                if (DataAccess.ExistNyckel(nyckel))
                {
                    MessageBox.Show("Nyckeln finns redan");
                    return;
                }
                this.AddNyckel = nyckel;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Fälten Typ,Serie,Nummer måste vara i fyllda");
            }
        }

        private bool FieldsValid()
        {
            TextBox[] textBoxes = new TextBox[] {txtTyp,txtSerie,txtNummer};
            foreach(TextBox textBox in textBoxes)
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    return false;
                }
            return true;
        }

       
    }
}
