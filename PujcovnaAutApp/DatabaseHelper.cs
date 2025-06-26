using System.Collections.Generic;
using System;
using System.Data.SQLite;
using System.IO;

namespace PujcovnaAutApp
{
    public static class DatabaseHelper
    {
        private static string dbPath = "pujcovna.db";
        private static string connStr = $"Data Source={dbPath};Version=3;";

        public static SQLiteConnection GetConnection() => new SQLiteConnection(connStr);

        public static void InicializujDatabazi()
        {
            if (!File.Exists(dbPath))
            {
                SQLiteConnection.CreateFile(dbPath);

                using (var conn = new SQLiteConnection(connStr))
                {
                    conn.Open();
                    var cmd = conn.CreateCommand();
                    cmd.CommandText = @"
CREATE TABLE IF NOT EXISTS Auta (
    ID INTEGER PRIMARY KEY AUTOINCREMENT,
    SPZ TEXT,
    Znacka TEXT,
    Model TEXT,
    RokVyroby INTEGER,
    CenaZaDen REAL,
    KDispozici INTEGER
);

CREATE TABLE IF NOT EXISTS Zakaznici (
    ID INTEGER PRIMARY KEY AUTOINCREMENT,
    Jmeno TEXT,
    Prijmeni TEXT,
    Telefon TEXT,
    Email TEXT
);

CREATE TABLE IF NOT EXISTS Pujcky (
    ID INTEGER PRIMARY KEY AUTOINCREMENT,
    ZakaznikID INTEGER,
    AutoID INTEGER,
    DatumOd TEXT,
    DatumDo TEXT,
    FOREIGN KEY (ZakaznikID) REFERENCES Zakaznici(ID),
    FOREIGN KEY (AutoID) REFERENCES Auta(ID)
);";
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void AktualizovatDostupnostPodleDnesnihoData()
        {
            using (var conn = GetConnection())
            {
                conn.Open();

                var cmd = new SQLiteCommand("SELECT ID FROM Auta", conn);
                var reader = cmd.ExecuteReader();

                List<int> vsechnaAuta = new List<int>();
                while (reader.Read())
                {
                    vsechnaAuta.Add(reader.GetInt32(0));
                }
                reader.Close();

                foreach (int autoId in vsechnaAuta)
                {
                    var checkCmd = new SQLiteCommand(@"
                        SELECT COUNT(*) FROM Pujcky
                        WHERE AutoID = @id
                        AND DatumOd <= @dnes AND DatumDo >= @dnes
                    ", conn);

                    checkCmd.Parameters.AddWithValue("@id", autoId);
                    checkCmd.Parameters.AddWithValue("@dnes", DateTime.Now.Date.ToString("yyyy-MM-dd"));

                    int kolize = Convert.ToInt32(checkCmd.ExecuteScalar());

                    var updateCmd = new SQLiteCommand("UPDATE Auta SET KDispozici = @dispo WHERE ID = @id", conn);
                    updateCmd.Parameters.AddWithValue("@id", autoId);
                    updateCmd.Parameters.AddWithValue("@dispo", kolize == 0 ? 1 : 0);
                    updateCmd.ExecuteNonQuery();
                }
            }
        }
    }
}
