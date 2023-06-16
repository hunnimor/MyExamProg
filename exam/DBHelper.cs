using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    public class DBHelper {

        private static MySqlConnection? conn = null;
        public DBHelper(string host, int port, string user, string password, string database)
        {
            var connStr = $"Server={host};port={port};database={database};User Id={user};password={password}";
            conn = new MySqlConnection(connStr);
            conn?.Open();
        }

        public void RegiterNewUser(string login, string password)
        {
                var queryStr = "INSERT INTO users (login, password)"
                    +"values(@login, @password)";
                var cmd = conn?.CreateCommand();
                cmd.CommandText = queryStr;
                cmd.Parameters.Add("@login", MySqlDbType.String).Value = login;
                cmd.Parameters.Add("@password", MySqlDbType.String).Value = password;
                int rowCount = cmd.ExecuteNonQuery();
        }

        public bool CheckLogin(string need_login)
        {
            var queryStr = $"SELECT * FROM users WHERE login='{need_login}'";
            var cmd = conn?.CreateCommand();
            cmd.CommandText = queryStr;
            using (var reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    return true;
                }
            }
            return false;
        }

        public bool LogIn(string need_login, string need_pass)
        {
            var queryStr = "SELECT * FROM users";
            var cmd = conn?.CreateCommand();
            cmd.CommandText = queryStr;
            using (var reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int loginIndex = reader.GetOrdinal("login");
                        int passIndex = reader.GetOrdinal("password");
                        string login = reader.GetString(loginIndex);
                        string pass = reader.GetString(passIndex);
                        if (login == need_login && pass == need_pass)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public void InsertPicture(string login, byte[] picture)
        {
            var queryStr = "INSERT INTO graphics (login, picture) values(@login, @picture)";
            var cmd = conn?.CreateCommand();
            cmd.CommandText = queryStr;
            cmd.Parameters.AddWithValue("@login", MySqlDbType.String).Value = login;
            cmd.Parameters.AddWithValue("@picture", picture);
            int rowCount = cmd.ExecuteNonQuery();
        }
    }
}
