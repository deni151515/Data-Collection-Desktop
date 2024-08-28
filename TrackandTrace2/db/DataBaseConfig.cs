using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace DataCollection.db
{
    public class DataBaseConfig
    {
        public const string connectionString = "Data Source=config.db;Version=3;";
        public static void InitializeDatabase()
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string createTableQuery = @"
        CREATE TABLE IF NOT EXISTS Printers (
            Idprinter INTEGER PRIMARY KEY,
            Printername TEXT,
            Ipprinter TEXT,
            Portprinter INTEGER
        );";
                using (var command = new SQLiteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
        public void AddPrinter(string printerName, string ipPrinter, int portPrinter)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string insertQuery = @"
                INSERT INTO Printers (Printername, Ipprinter, Portprinter)
                VALUES (@Printername, @Ipprinter, @Portprinter);";

                using (var command = new SQLiteCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@Printername", printerName);
                    command.Parameters.AddWithValue("@Ipprinter", ipPrinter);
                    command.Parameters.AddWithValue("@Portprinter", portPrinter);

                    command.ExecuteNonQuery();
                }
            }
        }

        public List<PrinterItem> LoadPrinters()
        {
            var printers = new List<PrinterItem>();

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT  Printername, Ipprinter, Portprinter FROM Printers";
                using (var command = new SQLiteCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string name = reader.GetString(0);
                        string ip = reader.GetString(1);
                        int port = reader.GetInt32(2);

                        printers.Add(new PrinterItem( name, ip, port));
                    }
                }
            }

            return printers;
        }

        public void UpdatePrinter(string originalName, string newIp, int newPort)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string updateQuery = @"
        UPDATE Printers
        SET Ipprinter = @Ipprinter, Portprinter = @Portprinter
        WHERE Printername = @Printername";

                using (var command = new SQLiteCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@Printername", originalName);
                    command.Parameters.AddWithValue("@Ipprinter", newIp);
                    command.Parameters.AddWithValue("@Portprinter", newPort);

                    command.ExecuteNonQuery();
                }
            }
        }



        public class PrinterItem
        {
            public string Name { get; set; }
            public string IP { get; set; }
            public int Port { get; set; }

            public PrinterItem(string name, string ip, int port)
            {
                Name = name;
                IP = ip;
                Port = port;
            }

            public override string ToString()
            {
                return Name;
            }
        }
    }
}
