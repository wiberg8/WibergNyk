using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WibergNykLibary;

namespace WibergNyk
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            //Shows "splashscreen" and then closes it and makes this form visable again
            using (SplashScreen splashScreen=new SplashScreen())
            {
                splashScreen.ShowDialog();
                this.Visible = true;
            }
            UpdatePersonGrid(DataAccess.GetAllPersoner());
            UpdateNyckelGrid(DataAccess.GetAllNycklar());
        }
        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                //Clear selected nyckel. and person
                dgNycklar.ClearSelection();
                dgPersoner.ClearSelection();
                RefreshAllSelections();
            }
        }

        private void dgPersoner_SelectionChanged(object sender, EventArgs e)
        {
            cbRegistreradeNycklar.Items.Clear();
            //Checks if any rows are selected in dgPersoner
            if(dgPersoner.SelectedRows.Count > 0)
            {
                Person ValdPerson = (Person)dgPersoner.SelectedRows[0].Tag;
                if (ValdPerson != null)
                {
                    txtValdPerson.Text = ValdPerson.ToString();
                    txtValdPerson.Tag = ValdPerson;
                    RefreshPersonNycklar();
                }
            }
            else
            {
                txtValdNyckel.Text = string.Empty;
                txtValdNyckel.Tag = null;
                cbRegistreradeNycklar.Visible = false;
                cmdKvittens.Visible = false;
                cmdAvregistreraNyckel.Visible = false;
            }
        }
        private void dgNycklar_SelectionChanged(object sender, EventArgs e)
        {
            //Checks if any rows are selected in dgNycklar
            if (dgNycklar.SelectedRows.Count > 0)
            {
                Nyckel ValdNyckel = (Nyckel)dgNycklar.SelectedRows[0].Tag;
                if (ValdNyckel != null)
                {
                    txtValdNyckel.Text = ValdNyckel.ToString();
                    txtValdNyckel.Tag = ValdNyckel;
                    //Kollar om nyckeln är registrerad på någon eller inte
                    RefreshSelectedNyckel(ValdNyckel);
                }
            }
            else
            {
                laRegistreradNyckel.Text = string.Empty;
                laRegistreradNyckel.Visible = false;
                txtValdNyckel.Text = string.Empty;
                txtValdNyckel.Tag = null;
            }
        }

        private void tspNyPerson_Click(object sender, EventArgs e)
        {
            using (NewPerson newPersonDialog = new NewPerson())
            {
                var dialogResult = newPersonDialog.ShowDialog();
                if (dialogResult == DialogResult.OK && newPersonDialog.AddPerson != null)
                {
                    DataAccess.InsertPerson(newPersonDialog.AddPerson);
                    UpdatePersonGrid(DataAccess.GetAllPersoner());
                }
            }
        }

        private void tspNyNyckel_Click(object sender, EventArgs e)
        {
            using (NewNyckel newNyckelDialog = new NewNyckel())
            {
                var dialogResult = newNyckelDialog.ShowDialog();
                if (dialogResult == DialogResult.OK && newNyckelDialog.AddNyckel != null)
                {
                    DataAccess.InsertNyckel(newNyckelDialog.AddNyckel);
                    UpdateNyckelGrid(DataAccess.GetAllNycklar());
                }
            }
        }
        
        private void tspInstallningar_Click(object sender, EventArgs e)
        {
            using (SettingsDialog settingsDialog = new SettingsDialog())
            {
                settingsDialog.ShowDialog();
                if (settingsDialog.DbChange)
                {
                    DBHandler.SetFile(Properties.Settings.Default.DatabasePath);
                    UpdateNyckelGrid(DataAccess.GetAllNycklar());
                    UpdatePersonGrid(DataAccess.GetAllPersoner());
                    RefreshAllSelections();
                }
            }
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            if (rbSearchPersoner.Checked)
            {
                UpdatePersonGrid(DataAccess.GetSearchPersoner(txtSearch.Text));
            }
            else
            {
                UpdateNyckelGrid(DataAccess.GetSearchNycklar(txtSearch.Text));
            }
        }

        private void cmdRegistreraNyckel_Click(object sender, EventArgs e)
        {
            if(txtValdPerson.Tag == null || txtValdNyckel.Tag == null)
            {
                MessageBox.Show("Ingen person/nyckel vald");
                return;
            }
            DataAccess.RegisterNyckelToPerson((Nyckel)txtValdNyckel.Tag, (Person)txtValdPerson.Tag);
            
            RefreshPersonNycklar();
            UpdateNyckelGrid(DataAccess.GetAllNycklar());
        }

        private void cmdAvregistreraNyckel_Click(object sender, EventArgs e)
        {
            if (cbRegistreradeNycklar.SelectedItem.GetType() == typeof(Nyckel))
            {
                DataAccess.UnregisterNyckelFromPerson((Nyckel)cbRegistreradeNycklar.SelectedItem);
                RefreshPersonNycklar();
                UpdateNyckelGrid(DataAccess.GetAllNycklar());
            }
        }

        private void cmdKvittens_Click(object sender, EventArgs e)
        {
            if(cbRegistreradeNycklar.SelectedItem != null && txtValdPerson.Tag != null)
            {
                if(!Reciept.Create(Properties.Settings.Default.PdfSaveLocation, Properties.Settings.Default.Verksamhet, (Nyckel)cbRegistreradeNycklar.SelectedItem, (Person)txtValdPerson.Tag))
                {
                    MessageBox.Show("Något är fel med mappen");
                }
            }
        }

        private void cmdValdPersonMer_Click(object sender, EventArgs e)
        {
            //Checks if txtValdPerson tag is not null and is of type Person
            if (txtValdPerson.Tag != null && txtValdPerson.Tag.GetType() == typeof(Person))
            {
                Person valdPerson = (Person)txtValdPerson.Tag;
                using (UpdatePerson frm = new UpdatePerson(valdPerson))
                {
                    switch (frm.ShowDialog())
                    {
                        case DialogResult.OK:
                            DataAccess.UpdatePerson(frm.Updateperson);
                            txtValdPerson.Text = string.Empty;
                            txtValdPerson.Tag = null;
                            UpdatePersonGrid(DataAccess.GetAllPersoner());
                            UpdateNyckelGrid(DataAccess.GetAllNycklar());
                            break;
                        case DialogResult.Abort:
                            DataAccess.DeletePerson(frm.Updateperson);
                            DataAccess.DeletePersonResetNyckelStatus(frm.Updateperson);
                            txtValdPerson.Text = string.Empty;
                            txtValdPerson.Tag = null;
                            UpdatePersonGrid(DataAccess.GetAllPersoner());
                            UpdateNyckelGrid(DataAccess.GetAllNycklar());
                            break;
                        case DialogResult.Cancel:
                            break;
                    }

                }
            }
        }
        private void cmdValdNyckelMer_Click(object sender, EventArgs e)
        {
            if (txtValdNyckel.Tag != null && txtValdNyckel.Tag.GetType() == typeof(Nyckel))
            {
                Nyckel ValdNyckel = (Nyckel)txtValdNyckel.Tag;
                using (UpdateNyckel updateNyckelDialog = new UpdateNyckel(ValdNyckel))
                {
                    switch (updateNyckelDialog.ShowDialog())
                    {
                        case DialogResult.OK:
                            DataAccess.UpdateNyckel(updateNyckelDialog.Updatenyckel);
                            UpdateNyckelGrid(DataAccess.GetAllNycklar());
                            break;
                        case DialogResult.Abort:
                            DataAccess.DeleteNyckel(ValdNyckel);
                            UpdateNyckelGrid(DataAccess.GetAllNycklar());
                            break;
                    }

                }
            }
        }

        #region Metoder
        private void UpdatePersonGrid(List<Person> personLista)
        {
            dgPersoner.Rows.Clear();
            foreach (Person person in personLista)
            {
                var rowDisplay = new string[]
                {
                    person.ID.ToString(), person.Fornamn, person.Efternamn,
                    person.PersNr, person.Telefon, person.AnstalldSom
                };
                dgPersoner.Rows.Add(rowDisplay);
                //Set the tag on the added row
                dgPersoner.Rows[dgPersoner.Rows.Count - 1].Tag = person;
            }
            dgPersoner.ClearSelection();
            //DataGridLibary.SetColorVariationToRows(dgPersoner,Color.White, Color.LightGray); 
            DataGridLibary.SetColorVariationToRows(dgPersoner, GlobalConfig.FirstGridColor, GlobalConfig.SecondGridColor);
        }
        private void UpdateNyckelGrid(List<Nyckel> nyckelLista)
        {
            dgNycklar.Rows.Clear();
            foreach (Nyckel nyckel in nyckelLista)
            {
                string[] rowDisplay = new string[]
                {
                   nyckel.ID.ToString(), nyckel.Typ, nyckel.Serie, nyckel.Nummer
                };
                dgNycklar.Rows.Add(rowDisplay);
                //Set the tag on the added row
                dgNycklar.Rows[dgNycklar.Rows.Count - 1].Tag = nyckel;
            }
            dgNycklar.ClearSelection();
            DataGridLibary.SetColorVariationToRows(dgNycklar, GlobalConfig.FirstGridColor, GlobalConfig.SecondGridColor);
            cmdRegistreraNyckel.Visible = false;
            laRegistreradNyckel.Visible = false;
        }

        private void RefreshPersonNycklar()
        {
            cbRegistreradeNycklar.Items.Clear();
            foreach (Nyckel nyckel in DataAccess.GetPersonNycklar((Person)txtValdPerson.Tag))
            {
                cbRegistreradeNycklar.Items.Add(nyckel);
            }
            if (cbRegistreradeNycklar.Items.Count > 0)
            {
                cbRegistreradeNycklar.SelectedIndex = 0;
                cbRegistreradeNycklar.Visible = true;
                cmdAvregistreraNyckel.Visible = true;
                cmdKvittens.Visible = true;
            }
            else
            {
                cbRegistreradeNycklar.Visible = false;
                cmdAvregistreraNyckel.Visible = false;
                cmdKvittens.Visible = false;
            }
        }
        private void RefreshSelectedNyckel(Nyckel nyckel)
        {
            if (nyckel.Status == NyckelStatus.UTE)
            {
                cmdRegistreraNyckel.Visible = false;
                laRegistreradNyckel.Text = "Registrerad person id " + nyckel.PersoId;
                laRegistreradNyckel.Visible = true;
            }
            else if (nyckel.Status == NyckelStatus.INNE)
            {
                cmdRegistreraNyckel.Visible = true;
                laRegistreradNyckel.Text = string.Empty;
                laRegistreradNyckel.Visible = false;
            }
        }
        private void RefreshAllSelections()
        {
            cbRegistreradeNycklar.Visible = false;
            cmdKvittens.Visible = false;
            cmdAvregistreraNyckel.Visible = false;
            cmdRegistreraNyckel.Visible = false;
            txtValdPerson.Tag = null;
            txtValdPerson.Text = string.Empty;
            txtValdNyckel.Tag = null;
            txtValdNyckel.Text = string.Empty;
            laRegistreradNyckel.Visible = false;
        }
        #endregion

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
