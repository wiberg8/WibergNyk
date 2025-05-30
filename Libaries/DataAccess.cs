using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WibergNykLibary;

namespace WibergNykLibary
{
    public static class DataAccess
    {
        public static void CreateDatabaseIfNotExists(string dbFilePath)
        {
            // Step 1: Create the database file if it does not exist
            if (!File.Exists(dbFilePath))
            {
                SQLiteConnection.CreateFile(dbFilePath);
            }

            // Step 2: Build the SQLite connection string
            string connectionString = $"Data Source={dbFilePath};Version=3;";

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                // Step 3: Create personer table if it doesn't exist
                string createPersonerTable = @"
            CREATE TABLE IF NOT EXISTS personer (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Fornamn TEXT,
                Efternamn TEXT,
                PersNr TEXT UNIQUE,
                Telefon TEXT,
                AnstalldSom TEXT,
                Ovrigt TEXT
            );";

                // Step 4: Create nycklar table if it doesn't exist
                string createNycklarTable = @"
            CREATE TABLE IF NOT EXISTS nycklar (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Typ TEXT,
                Serie TEXT,
                Nummer TEXT,
                Ovrigt TEXT,
                Status INTEGER NOT NULL DEFAULT 0,
                PersoId INTEGER,
                FOREIGN KEY (PersoId) REFERENCES personer(Id) ON DELETE SET NULL
            );";

                using (SQLiteCommand cmd = new SQLiteCommand(createPersonerTable, conn))
                {
                    cmd.ExecuteNonQuery();
                }

                using (SQLiteCommand cmd = new SQLiteCommand(createNycklarTable, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Person> GetAllPersoner()
        {
            List<Person> tempPersonList = new List<Person>();
            DBHandler.ExecQuery("SELECT * FROM personer ORDER BY Id ASC");
            if (!DBHandler.IsError())
                return PersonDataTableToList(DBHandler.DBDT);
            return new List<Person>();
        }
        public static List<Person> GetSearchPersoner(string searchQuery)
        {
            List<Person> tempPersonList = new List<Person>();
            DBHandler.AddParam("@Search", "%" + searchQuery + "%");
            DBHandler.ExecQuery
                (
                    "SELECT * FROM personer " +
                    "WHERE Id LIKE @Search OR Fornamn LIKE @Search OR Efternamn LIKE @Search OR PersNr LIKE @Search OR Telefon LIKE @Search OR AnstalldSom LIKE @Search " +
                    "ORDER BY Id ASC"
                );
            if (!DBHandler.IsError())
                return PersonDataTableToList(DBHandler.DBDT);
            return new List<Person>();
        }

        public static List<Nyckel> GetAllNycklar()
        {
            DBHandler.ExecQuery("SELECT * FROM nycklar ORDER BY Id ASC");
            //  Console.WriteLine("Antal rader dbhandler "+DBHandler.DBDT.Rows.Count);
            if (!DBHandler.IsError())
                return NyckelDataTableToList(DBHandler.DBDT);
            return new List<Nyckel>();
        }
        public static List<Nyckel> GetSearchNycklar(string searchQuery)
        {
            List<Nyckel> tempNyckelList = new List<Nyckel>();
            DBHandler.AddParam("@Search", "%" + searchQuery + "%");
            DBHandler.ExecQuery
                (
                    "SELECT * FROM nycklar " +
                    "WHERE Id LIKE @Search OR Typ LIKE @Search OR Serie LIKE @Search OR Nummer LIKE @Search " +
                    "ORDER BY Id ASC"
                );
            if (!DBHandler.IsError())
                return NyckelDataTableToList(DBHandler.DBDT);
            return new List<Nyckel>();

        }

        public static List<Nyckel> GetPersonNycklar(Person person)
        {
            List<Nyckel> tempNyckelList = new List<Nyckel>();
            DBHandler.AddParam("@PersoId", person.ID);
            DBHandler.ExecQuery("SELECT * FROM nycklar WHERE PersoId=@PersoId ORDER BY Id ASC");
            if (!DBHandler.IsError())
                return NyckelDataTableToList(DBHandler.DBDT);
            return new List<Nyckel>();
        }

        public static void RegisterNyckelToPerson(Nyckel nyckel, Person person)
        {
            DBHandler.AddParam("@Id", nyckel.ID);
            DBHandler.AddParam("@PersoId", person.ID);
            DBHandler.AddParam("@Status", NyckelStatus.UTE);
            DBHandler.ExecQuery("UPDATE nycklar SET PersoId=@PersoId,Status=@Status WHERE Id=@Id");
        }
        public static void UnregisterNyckelFromPerson(Nyckel nyckel)
        {
            DBHandler.AddParam("@Id", nyckel.ID);
            DBHandler.AddParam("@Status", NyckelStatus.INNE);
            DBHandler.ExecQuery("UPDATE nycklar SET PersoId=null,Status=@Status WHERE Id=@Id");
        }
        public static void DeletePersonResetNyckelStatus(Person person)
        {
            DBHandler.AddParam("@PersoId", person.ID);
            DBHandler.AddParam("@Status", NyckelStatus.INNE);
            DBHandler.ExecQuery("UPDATE nycklar SET PersoId=null,Status=@Status WHERE PersoId=@PersoId");
        }

        public static void InsertNyckel(Nyckel nyckel)
        {
            DBHandler.AddParam("@Typ", nyckel.Typ);
            DBHandler.AddParam("@Serie", nyckel.Serie);
            DBHandler.AddParam("@Nummer", nyckel.Nummer);
            DBHandler.AddParam("@Ovrigt", nyckel.Ovrigt);
            DBHandler.ExecQuery("INSERT INTO nycklar (Typ,Serie,Nummer,Ovrigt) VALUES (@Typ,@Serie,@Nummer,@Ovrigt)");
        }
        public static void UpdateNyckel(Nyckel nyckel)
        {
            DBHandler.AddParam("@Id", nyckel.ID);
            DBHandler.AddParam("@Ovrigt", nyckel.Ovrigt);
            DBHandler.ExecQuery("UPDATE nycklar SET Ovrigt=@Ovrigt WHERE Id=@Id");
        }
        public static bool ExistNyckel(Nyckel nyckel)
        {
            DBHandler.AddParam("@Typ", nyckel.Typ);
            DBHandler.AddParam("@Serie", nyckel.Serie);
            DBHandler.AddParam("@Nummer", nyckel.Nummer);
            DBHandler.ExecQuery("SELECT Id FROM nycklar WHERE Typ=@Typ AND Serie=@Serie AND Nummer=@Nummer");
            if (DBHandler.DBDT != null)
                return DBHandler.DBDT.Rows.Count > 0;
            return false;
        }
        public static void DeleteNyckel(Nyckel nyckel)
        {
            DBHandler.AddParam("@Id", nyckel.ID);
            DBHandler.ExecQuery("DELETE FROM nycklar WHERE Id=@Id");
        }

        public static void InsertPerson(Person person)
        {
            DBHandler.AddParam("@Fornamn", person.Fornamn);
            DBHandler.AddParam("@Efternamn", person.Efternamn);
            DBHandler.AddParam("@PersNr", person.PersNr);
            DBHandler.AddParam("@Telefon", person.Telefon);
            DBHandler.AddParam("@AnstalldSom", person.AnstalldSom);
            DBHandler.AddParam("@Ovrigt", person.Ovrigt);
            DBHandler.ExecQuery("INSERT INTO personer (Fornamn,Efternamn,PersNr,Telefon,AnstalldSom,Ovrigt) VALUES (@Fornamn,@Efternamn,@PersNr,@Telefon,@AnstalldSom,@Ovrigt)");
        }
        public static void UpdatePerson(Person person)
        {
            DBHandler.AddParam("@Efternamn", person.Efternamn);
            DBHandler.AddParam("@Telefon", person.Telefon);
            DBHandler.AddParam("@AnstalldSom", person.AnstalldSom);
            DBHandler.AddParam("@Ovrigt", person.Ovrigt);
            DBHandler.AddParam("@Id", person.ID);
            DBHandler.ExecQuery("UPDATE personer SET Efternamn=@Efternamn,Telefon=@Telefon,AnstalldSom=@AnstalldSom,Ovrigt=@Ovrigt WHERE Id=@Id");
        }
        public static bool ExistPerson(string persrNr)
        {
            DBHandler.AddParam("@PersNr", persrNr);
            DBHandler.ExecQuery("SELECT Id FROM personer WHERE PersNr IS NOT NULL AND NOT PersNr='' AND PersNr=@PersNr");
            if (DBHandler.DBDT != null)
                return DBHandler.DBDT.Rows.Count > 0;
            return false;
        }
        public static void DeletePerson(Person person)
        {
            DBHandler.AddParam("@Id", person.ID);
            DBHandler.ExecQuery("DELETE FROM personer WHERE Id=@Id");
        }

        private static List<Nyckel> NyckelDataTableToList(DataTable nyckelTable)
        {
            List<Nyckel> tempNycklar = new List<Nyckel>();
            foreach (DataRow row in nyckelTable.Rows)
            {
                if (int.TryParse(row["Id"].ToString(), out int parsedId))
                {
                    Nyckel nyckel = new Nyckel(parsedId)
                    {
                        Typ = row["Typ"].ToString(),
                        Serie = row["Serie"].ToString(),
                        Nummer = row["Nummer"].ToString(),
                        Ovrigt = row["Ovrigt"].ToString(),
                        Status = (NyckelStatus)int.Parse(row["Status"].ToString())
                    };
                    if (int.TryParse(row["PersoId"].ToString(), out int parsedPersoId))
                    {
                        nyckel.PersoId = parsedPersoId;
                    }
                    tempNycklar.Add(nyckel);
                }
            }
            return tempNycklar;
        }
        private static List<Person> PersonDataTableToList(DataTable personTable)
        {
            List<Person> tempPersoner = new List<Person>();
            foreach (DataRow row in personTable.Rows)
            {
                if (int.TryParse(row["Id"].ToString(), out int parsedId))
                {
                    Person person = new Person(parsedId)
                    {
                        Fornamn = row["Fornamn"].ToString(),
                        Efternamn = row["Efternamn"].ToString(),
                        PersNr = row["PersNr"].ToString(),
                        Telefon = row["Telefon"].ToString(),
                        AnstalldSom = row["AnstalldSom"].ToString(),
                        Ovrigt = row["Ovrigt"].ToString()
                    };
                    tempPersoner.Add(person);
                }
            }
            return tempPersoner;
        }

    }
}
