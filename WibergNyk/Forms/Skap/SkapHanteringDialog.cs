using Newtonsoft.Json;
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

namespace WibergNyk.Forms.Skap
{
    public partial class SkapHanteringDialog : Form
    {
        public SkapHanteringDialog()
        {
            InitializeComponent();
        }

        private void SkapHanteringDialog_Load(object sender, EventArgs e)
        {
            FillKlasser();
        }

        private void FillKlasser()
        {
            cbKlassSelect.Items.AddRange(Directory.GetFiles(Properties.Settings.Default.SkapMapp));
           
        }

        private void cmdImportSkapFil_Click(object sender, EventArgs e)
        {
            var fDialog = new OpenFileDialog();
            fDialog.ShowDialog();
            if (fDialog.CheckFileExists)
            {
                var skapList = new List<WibergNykLibary.Skap>();
                foreach(string line in File.ReadAllLines(fDialog.FileName))
                {
                    string[] lineSplit = line.Split(';');
                    if (lineSplit.Count() >= 2)
                    {
                        var skap = new WibergNykLibary.Skap
                        {
                            Nummer = lineSplit[0],
                            Namn = lineSplit[1]
                        };
                        skapList.Add(skap);
                    }
                }
                string serializedList = JsonConvert.SerializeObject(skapList, Formatting.Indented);

                File.WriteAllText(Properties.Settings.Default.SkapMapp  + "\\"+ Path.GetFileName(fDialog.FileName), serializedList);
            }
        }
    }
}
