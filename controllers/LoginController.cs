using employee_management_system.models;
using employee_management_system.utils;
using System;
using System.Data.SqlClient;

namespace employee_management_system.controllers
{
    internal class LoginController
    {

        // User login method
        public static bool Login(string username, string password, out string name)
        {
            name = null;

            using (SqlConnection conn = Database.GetConnection())
            {

                string sql = "SELECT name FROM admins WHERE username = @username AND password = @password";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    name = reader.GetString(reader.GetOrdinal("name"));
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        // User Registration Method
        public static bool Register(User newUser, out string errorMsg)
        {
            errorMsg = null;

            using (SqlConnection conn = Database.GetConnection())
            {

                string checkSql = "SELECT COUNT(*) FROM admins WHERE username = @username";
                SqlCommand cmd = new SqlCommand(checkSql, conn);
                cmd.Parameters.AddWithValue("@username", newUser.username);
                int existingUserCount = (int)cmd.ExecuteScalar();

                if (existingUserCount > 0)
                {
                    errorMsg = "Username already exists.";
                    return false;
                }

                string insertSql = @"
                    INSERT INTO admins (username, password, name, email) 
                    VALUES (@username, @password, @name, @email)";

                SqlCommand insertCmd = new SqlCommand(insertSql, conn);
                insertCmd.Parameters.AddWithValue("@username", newUser.username);
                insertCmd.Parameters.AddWithValue("@password", newUser.password);
                insertCmd.Parameters.AddWithValue("@name", newUser.name);
                insertCmd.Parameters.AddWithValue("@email", newUser.email);

                int rowsAffected = insertCmd.ExecuteNonQuery();

                if (rowsAffected == 1)
                {
                    return true;
                }
                else
                {
                    errorMsg = "Registration failed. Please try again.";
                    return false;
                }
            }
        }
    }
}
