using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Newtonsoft.Json.Linq;

namespace TrackandTrace2.db
{
    public static class DataBaseUser
    {
        public const string connectionString = "Data Source=User.db;Version=3;";

        public static void InitializeDatabase()
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string createUserTableQuery = @"
            CREATE TABLE IF NOT EXISTS UserData (
                Id INTEGER PRIMARY KEY,
                Username TEXT,
                Token TEXT ,
                TokenExpiredAt INTEGER,
                IdSubRole INTEGER ,
                IsLoggedIn INTEGER  DEFAULT 0
            );";
                using (var command = new SQLiteCommand(createUserTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }

                string createMenuPermissionsTableQuery = @"
            CREATE TABLE IF NOT EXISTS MenuPermissions (
                IdPermision INTEGER PRIMARY KEY, 
                IdMenuPermission INTEGER,
                IdMenu INTEGER,
                MenuName TEXT,
                LabelMenu TEXT,
                IdSubRole INTEGER,
                CreatePermission INTEGER,
                ViewPermission INTEGER,
                UpdatePermission INTEGER,
                DeletePermission INTEGER
            );";
                using (var command = new SQLiteCommand(createMenuPermissionsTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }


        public static void SaveUserData(string username, string token, long tokenExpiredAt, int idSubRole, bool isLoggedIn = true)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = @"
            INSERT INTO UserData (Username, Token, TokenExpiredAt, IdSubRole, IsLoggedIn) 
            VALUES (@username, @token, @tokenExpiredAt, @idSubRole, @isLoggedIn)";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@token", token);
                    command.Parameters.AddWithValue("@tokenExpiredAt", tokenExpiredAt);
                    command.Parameters.AddWithValue("@idSubRole", idSubRole);
                    command.Parameters.AddWithValue("@isLoggedIn", isLoggedIn ? 1 : 0);
                    command.ExecuteNonQuery();
                }
            }
        }
       


        public static void SaveMenuPermissions(JArray menuPermissions)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                foreach (var item in menuPermissions)
                {
                    int idMenuPermission = (int)item["idMenuPermission"];
                    int idMenu = (int)item["idMenu"];
                    string menuName = (string)item["menuName"];
                    string labelMenu = (string)item["labelMenu"];
                    int idSubRole = (int)item["idSubRole"];
                    int createPermission = (int)item["createPermission"];
                    int viewPermission = (int)item["viewPermission"];
                    int updatePermission = (int)item["updatePermission"];
                    int deletePermission = (int)item["deletePermission"];

                    string query = @"
                        INSERT INTO MenuPermissions (IdMenuPermission, IdMenu, MenuName, LabelMenu, IdSubRole, CreatePermission, ViewPermission, UpdatePermission, DeletePermission)
                        VALUES (@idMenuPermission, @idMenu, @menuName, @labelMenu, @idSubRole, @createPermission, @viewPermission, @updatePermission, @deletePermission)";

                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idMenuPermission", idMenuPermission);
                        command.Parameters.AddWithValue("@idMenu", idMenu);
                        command.Parameters.AddWithValue("@menuName", menuName);
                        command.Parameters.AddWithValue("@labelMenu", labelMenu);
                        command.Parameters.AddWithValue("@idSubRole", idSubRole);
                        command.Parameters.AddWithValue("@createPermission", createPermission);
                        command.Parameters.AddWithValue("@viewPermission", viewPermission);
                        command.Parameters.AddWithValue("@updatePermission", updatePermission);
                        command.Parameters.AddWithValue("@deletePermission", deletePermission);
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
       
        public static void ClearUserData()
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string deleteUserDataQuery = "DELETE FROM UserData";
                using (var command = new SQLiteCommand(deleteUserDataQuery, connection))
                {
                    command.ExecuteNonQuery();
                }

                string deleteMenuPermissionsQuery = "DELETE FROM MenuPermissions";
                using (var command = new SQLiteCommand(deleteMenuPermissionsQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }


        public static (string Token, DateTime TokenExpiration, int IdSubRole) LoadUserData()
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string selectQuery = "SELECT Token, TokenExpiredAt, IdSubRole FROM UserData ORDER BY Id DESC LIMIT 1";
                using (var command = new SQLiteCommand(selectQuery, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string token = reader.GetString(0);
                            long tokenExpiredAt = reader.GetInt64(1);
                            int idSubRole = reader.GetInt32(2);

                            DateTime tokenExpiration;
                            try
                            {
                                if (tokenExpiredAt < -62135596800 || tokenExpiredAt > 253402300799)
                                {
                                    throw new ArgumentOutOfRangeException(nameof(tokenExpiredAt), "Timestamp is out of range.");
                                }

                                tokenExpiration = DateTimeOffset.FromUnixTimeSeconds(tokenExpiredAt).DateTime;
                            }
                            catch (ArgumentOutOfRangeException ex)
                            {
                                Console.WriteLine($"Error converting Unix timestamp: {ex.Message}");
                                tokenExpiration = DateTime.MinValue;
                            }

                            return (token, tokenExpiration, idSubRole);
                        }
                        else
                        {
                            throw new Exception("No user data found.");
                        }
                    }
                }
            }
        }


        public static List<MenuPermission> GetMenuPermissions()
        {
            var permissions = new List<MenuPermission>();

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand("SELECT MenuName, ViewPermission FROM MenuPermissions", connection);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var permission = new MenuPermission
                        {
                            MenuName = reader["MenuName"].ToString(),
                            ViewPermission = Convert.ToInt32(reader["ViewPermission"])
                        };
                        permissions.Add(permission);
                    }
                }
            }

            return permissions;
        }

        public class MenuPermission
        {
            public string MenuName { get; set; }
            public int ViewPermission { get; set; }
        }


        public static (string username, string token, long tokenExpiredAt, int idSubRole) GetUserData(string username)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (var command = new SQLiteCommand("SELECT Username, Token, TokenExpiredAt, IdSubRole FROM UserData WHERE Username = @username", connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string retrievedUsername = reader.GetString(0);
                            string token = reader.GetString(1);
                            long tokenExpiredAt = reader.GetInt64(2);
                            int idSubRole = reader.GetInt32(3);
                            return (retrievedUsername, token, tokenExpiredAt, idSubRole);
                        }
                        else
                        {
                            throw new Exception("No user data found for the specified username.");
                        }
                    }
                }
            }
        }
        public static bool IsUserDataPresent()
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM UserData";
                using (var command = new SQLiteCommand(query, connection))
                {
                    long count = (long)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public static bool IsUserLoggedIn()
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT IsLoggedIn FROM UserData WHERE IsLoggedIn = 1 LIMIT 1";
                using (var command = new SQLiteCommand(query, connection))
                {
                    var result = command.ExecuteScalar();
                    return result != null && Convert.ToInt32(result) == 1;
                }
            }
        }
        public static void UpdateLoginStatus(bool isLoggedIn)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE UserData SET IsLoggedIn = @isLoggedIn";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@isLoggedIn", isLoggedIn ? 1 : 0);
                    command.ExecuteNonQuery();
                }
            }
        }

    }
}

