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
    }
}
