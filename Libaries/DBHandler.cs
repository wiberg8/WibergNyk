using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WibergNykLibary
{
    public static class DBHandler
    {
        #region Instans variablar
        //private
        private static SQLiteConnection DBConn;

        private static SQLiteCommand DBCmd;

        private static SQLiteDataAdapter DBDA;

        private static List<SQLiteParameter> Params = new List<SQLiteParameter>();

        //Public
        public static DataTable DBDT;
        public static int RecordCount;
        public static string Exception;
        #endregion

        public static void SetFile(string FilePath)
        {
            DBConn = new SQLiteConnection
            {
                ConnectionString = "Data Source =" + FilePath + "; Version = 3; FailIfMissing=True"
            };
        }
        public static bool IsError()
        {
            return !string.IsNullOrEmpty(Exception) || DBDT == null;
        }

        public static void ExecQuery(string Query)
        {
            RecordCount = 0;
            Exception = string.Empty;

            try
            {
                DBConn.Open();
                DBCmd = new SQLiteCommand(Query, DBConn);

                Params.ForEach((SQLiteParameter p) => DBCmd.Parameters.Add(p));
                Params.Clear();

                DBDT = new DataTable();
                DBDA = new SQLiteDataAdapter(DBCmd);
                RecordCount = DBDA.Fill(DBDT);
            }
            catch (Exception ex)
            {
                Exception = ex.Message;
            }
            if (DBConn.State == ConnectionState.Open)
                DBConn.Close();
        }
        public static void AddParam(string Name, object Value)
        {
            SQLiteParameter NewParam = new SQLiteParameter(Name, Value);
            Params.Add(NewParam);
        }
    }
}
