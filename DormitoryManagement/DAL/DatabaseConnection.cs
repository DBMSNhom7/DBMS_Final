using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class DatabaseConnection
    {
        public static string ServerName
        {
            get => string.IsNullOrEmpty(serverName) ? "(local)" : serverName;
            set => serverName = value;
        }
        public static bool IsSQLAuthentication { get => isSQLAuthentication; set => isSQLAuthentication = value; }
        public static string Username { get => username; set => username = value; }
        public static string Password { get => password; set => password = value; }
        public static string DatabaseName { get => databaseName; set => databaseName = value; }

        static DatabaseConnection()
        {
            SetDefault();
        }

        public static void SetDefault()
        {
            IsSQLAuthentication = System.Convert.ToBoolean(ConfigurationManager.AppSettings["IsSQLAuthentication"]);
            ServerName = ConfigurationManager.AppSettings["ServerName"];
            Username = ConfigurationManager.AppSettings["Username"];
            Password = ConfigurationManager.AppSettings["Password"];
            DatabaseName = ConfigurationManager.AppSettings["DatabaseName"];
        }

        public static void ChangeConnection(bool _isSQLAuthentication, string _username = "", string _password = "")
        {
            IsSQLAuthentication = _isSQLAuthentication;
            Username = _username == "" ? Username : _username;
            Password = _password == "" ? Password : _password;
        }

        public static SqlConnection GetConnection()
        {
            string connStr;
            if (IsSQLAuthentication)
            {
                connStr = $"Data Source={ServerName};"
                   + $"Initial Catalog={DatabaseName};"
                   + $"User ID={Username};"
                   + $"Password={Password};";
            }
            else
            {
                connStr = $"Data Source={ServerName};"
                   + $"Initial Catalog={DatabaseName};"
                   + "Integrated Security=True";
            }

            SqlConnection connection = new SqlConnection(connStr);
            return connection;
        }

        private static string serverName;
        private static bool isSQLAuthentication = false;
        private static string username;
        private static string password;
        private static string databaseName;
    }
}
