using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WibergNykLibary
{
    public class DataGridLibary
    {
        public static void SetColorVariationToRows(DataGridView dataGridView, Color first, Color second)
        {
            for(int i=0; i< dataGridView.Rows.Count; i++)
            {
                if (i % 2 == 0)
                    dataGridView.Rows[i].DefaultCellStyle.BackColor = first;
                else
                    dataGridView.Rows[i].DefaultCellStyle.BackColor = second;
            }
        }

        //private void SetRowColor(DataGridViewRow dataGridRow)
        //{
        //    foreach (DataGridViewRow row in dataGridRow.Rows)
        //    {
        //        row.DefaultCellStyle.BackColor = Color.Red;
        //    }
        //}
    }
}
