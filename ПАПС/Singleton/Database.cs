using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПАПС
{
    class Database
    {
        public DatabaseConnection conn;

        public DatabaseConnection GetConnection()
        {
            return DatabaseConnection.GetDatabaseConnection();
        }

    }
}
