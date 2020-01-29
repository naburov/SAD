using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПАПС
{
    class DatabaseConnection
    {
        static DatabaseConnection connection;

        public string provider { get; private set; }
        public string username { get; private set; }
        public string password { get; private set; }
        public string dBName { get; private set; }

        private DatabaseConnection(string provider, string username, string password, string dBName) 
        {
            this.provider = provider;
            this.username = username;
            this.password = password;
            this.dBName = dBName;
        }

        public static DatabaseConnection GetDatabaseConnection()
        {
            if (connection == null)
                connection = new DatabaseConnection("postgres", "user", "1234", "sensors");
            return connection;

        }
    }
}
