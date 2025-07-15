using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace employee_management_system.utils
{
    internal class Database
    {
        private static string connectionString = "Server=DESKTOP-VISKOLU\\SQLEXPRESS;Database=ems_db;Trusted_Connection=True;";

        public static SqlConnection GetConnection()
        {
            var conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                return conn;
            }
            catch (SqlException ex)
            {
                // Log or handle exception as needed
                MessageBox.Show("Error opening connection: " + ex.Message, "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null; // or throw if you want to handle it elsewhere
            }
        }

    }
}
