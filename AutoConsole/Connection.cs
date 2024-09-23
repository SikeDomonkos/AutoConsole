using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoConsole
{
    internal class Connection
    {
        public MySqlConnection connection;
        public string Host;
        public string Database;
        public string Password;
        public string User;
        public string ConnectionString;
        
        public Connection()
        {
            Host = "localhost";
            Database = "auto";
            User = "root";
            Password = "";
            connection = new MySqlConnection(ConnectionString);
            ConnectionString = "SERVER=" + Host + ";DATABASE=" + Database + ";UID=" + User + ";PASSWORD=" + Password + ";SslMode=None";
        }
    }
    
}
