using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace employee_management_system.utils
{
    internal class Database
    {
        private static string connectionString = "";

        public static SqlConnection GetConnection()
        { 
            var conn = new SqlConnection(connectionString);
            conn.Open();
            return conn;
        }
    }
}
