using WibergNykLibary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace WibergNyk
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (PriorProcess() is null)
            {
                BackupDatabase();
                DBHandler.SetFile(Properties.Settings.Default.DatabasePath);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmMain());
            }
            else
            {
                MessageBox.Show("Applikationen kör redan", "WibergNyk");
            }
        }

        private static void BackupDatabase()
        {
            bool backupExist = Directory.Exists(Properties.Settings.Default.BackupLocation);
            bool databaseExist = File.Exists(Properties.Settings.Default.DatabasePath);
            if (Properties.Settings.Default.BackupOnStart && backupExist && databaseExist)
            {
                IO.Backup(Properties.Settings.Default.BackupLocation, Properties.Settings.Default.DatabasePath);
            }
        }
        private static Process PriorProcess()
        {
            Process curr = Process.GetCurrentProcess();
            Process[] procs = Process.GetProcessesByName(curr.ProcessName);
            foreach (Process p in procs)
            {
                if ((p.Id != curr.Id) &&
                    (p.MainModule.FileName == curr.MainModule.FileName))
                    return p;
            }
            return null;
        }
    }
}
