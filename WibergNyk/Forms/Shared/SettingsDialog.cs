using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WibergNyk
{
    public partial class SettingsDialog : Form
    {
        public bool DbChange { get; private set; } = false;
        public SettingsDialog()
        {
            InitializeComponent();
            txtBackup.Text = Properties.Settings.Default.BackupLocation;
            txtDb.Text = Properties.Settings.Default.DatabasePath;
            txtPdf.Text = Properties.Settings.Default.PdfSaveLocation;
            txtVerksamhet.Text = Properties.Settings.Default.Verksamhet;
            txtSkapMapp.Text = Properties.Settings.Default.SkapMapp;
            cbBackupOnStart.Checked = Properties.Settings.Default.BackupOnStart;
        }

        private void cmdVerksamhetSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Verksamhet = txtVerksamhet.Text.Trim();
            Properties.Settings.Default.Save();
        }

        private void cmdDbBrowse_Click(object sender, EventArgs e)
        {
            var fileDalog = new OpenFileDialog();
            if (fileDalog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.DatabasePath = fileDalog.FileName;
                Properties.Settings.Default.Save();
                txtDb.Text = fileDalog.FileName;
                this.DbChange = true;
            }
        }

        private void cmdBackupBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.BackupLocation = folderDialog.SelectedPath;
                txtBackup.Text = Properties.Settings.Default.BackupLocation;
                Properties.Settings.Default.Save();
            }
        }

        private void cmdPdfBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.PdfSaveLocation = folderDialog.SelectedPath;
                txtPdf.Text = Properties.Settings.Default.PdfSaveLocation;
                Properties.Settings.Default.Save();
            }
        }

        private void cmdSkapMappBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.SkapMapp = folderDialog.SelectedPath;
                txtSkapMapp.Text = Properties.Settings.Default.SkapMapp;
                Properties.Settings.Default.Save();
            }
        }

        private void cmdPdfClear_Click(object sender, EventArgs e)
        {
            txtPdf.Text = string.Empty;
            Properties.Settings.Default.PdfSaveLocation = string.Empty;
            Properties.Settings.Default.Save();
        }

        private void cmdBackupClear_Click(object sender, EventArgs e)
        {
            txtBackup.Text = string.Empty;
            Properties.Settings.Default.BackupLocation = string.Empty;
            Properties.Settings.Default.Save();
        }

        private void cmdDbClear_Click(object sender, EventArgs e)
        {
            txtDb.Text = string.Empty;
            Properties.Settings.Default.DatabasePath = string.Empty;
            Properties.Settings.Default.Save();
            this.DbChange = true;
        }

        private void cbBackupOnStart_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.BackupOnStart = cbBackupOnStart.Checked;
            Properties.Settings.Default.Save();
        }

        private void cmdSkapMappClear_Click(object sender, EventArgs e)
        {
            txtSkapMapp.Text = string.Empty;
            Properties.Settings.Default.SkapMapp = string.Empty;
            Properties.Settings.Default.Save();
        }
    }
}
