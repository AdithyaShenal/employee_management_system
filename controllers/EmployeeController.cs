using System;
using System.Data;
using System.Data.SqlClient;
using employee_management_system.models;
using employee_management_system.utils;
using System.Windows.Forms;

namespace employee_management_system.controllers
{
    public static class EmployeeController
    {
        public static PayrollEntry GetPayrollEntryById(int empId)
        {
            PayrollEntry payrollEntry = null;
            using (SqlConnection conn = Database.GetConnection())
            {
                if (conn == null) return null;

                string query = @"
                    SELECT
                        E.emp_id,
                        E.emp_name,
                        E.department_id,
                        D.dept_name AS DepartmentName, -- Alias for UI display
                        E.grade_id,                    -- Direct selection of grade_id
                        G.basic_salary,
                        G.transport_allowance,
                        G.new_year_bonus,
                        G.christmas_bonus AS ChristmasAllowance, -- Alias for UI display
                        E.personalized_increment
                        -- Removed net_salary from SELECT as it's calculated, not stored
                    FROM
                        Employees AS E
                    JOIN
                        grades AS G ON E.grade_id = G.grade_id
                    JOIN
                        departments AS D ON E.department_id = D.department_id
                    WHERE
                        E.emp_id = @EmpId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@EmpId", empId);
                    try
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                payrollEntry = new PayrollEntry
                                {
                                    EmpId = reader.GetInt32(reader.GetOrdinal("emp_id")),
                                    EmpName = reader.GetString(reader.GetOrdinal("emp_name")),
                                    DepartmentId = reader.GetInt32(reader.GetOrdinal("department_id")),
                                    DepartmentName = reader.GetString(reader.GetOrdinal("DepartmentName")),
                                    GradeId = reader.GetInt32(reader.GetOrdinal("grade_id")), // Read grade_id directly
                                    BasicSalary = reader.GetDecimal(reader.GetOrdinal("basic_salary")),
                                    TransportAllowance = reader.GetDecimal(reader.GetOrdinal("transport_allowance")),
                                    NewYearBonus = reader.GetDecimal(reader.GetOrdinal("new_year_bonus")),
                                    ChristmasAllowance = reader.GetDecimal(reader.GetOrdinal("ChristmasAllowance")),
                                    PersonalizedIncrement = reader.GetDecimal(reader.GetOrdinal("personalized_increment"))
                                    // NetSalary is not read from DB, it will be calculated by the form
                                };
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Database error during search by ID: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            return payrollEntry;
        }

        public static PayrollEntry GetPayrollEntryByName(string empName)
        {
            PayrollEntry payrollEntry = null;
            using (SqlConnection conn = Database.GetConnection())
            {
                if (conn == null) return null;

                string query = @"
                    SELECT
                        E.emp_id,
                        E.emp_name,
                        E.department_id,
                        D.dept_name AS DepartmentName,
                        E.grade_id,
                        G.basic_salary,
                        G.transport_allowance,
                        G.new_year_bonus,
                        G.christmas_bonus AS ChristmasAllowance,
                        E.personalized_increment
                        -- Removed net_salary from SELECT as it's calculated, not stored
                    FROM
                        Employees AS E
                    JOIN
                        grades AS G ON E.grade_id = G.grade_id
                    JOIN
                        departments AS D ON E.department_id = D.department_id
                    WHERE
                        E.emp_name LIKE @EmpName";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@EmpName", "%" + empName + "%");
                    try
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                payrollEntry = new PayrollEntry
                                {
                                    EmpId = reader.GetInt32(reader.GetOrdinal("emp_id")),
                                    EmpName = reader.GetString(reader.GetOrdinal("emp_name")),
                                    DepartmentId = reader.GetInt32(reader.GetOrdinal("department_id")),
                                    DepartmentName = reader.GetString(reader.GetOrdinal("DepartmentName")),
                                    GradeId = reader.GetInt32(reader.GetOrdinal("grade_id")),
                                    BasicSalary = reader.GetDecimal(reader.GetOrdinal("basic_salary")),
                                    TransportAllowance = reader.GetDecimal(reader.GetOrdinal("transport_allowance")),
                                    NewYearBonus = reader.GetDecimal(reader.GetOrdinal("new_year_bonus")),
                                    ChristmasAllowance = reader.GetDecimal(reader.GetOrdinal("ChristmasAllowance")),
                                    PersonalizedIncrement = reader.GetDecimal(reader.GetOrdinal("personalized_increment"))
                                    // NetSalary is not read from DB, it will be calculated by the form
                                };
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Database error during search by Name: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            return payrollEntry;
        }

        // Updated signature: removed newNetSalary parameter as it's not stored in DB
        public static bool UpdatePayrollEntryIncrement(int empId, decimal newIncrement)
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                if (conn == null) return false;

                // Removed net_salary from UPDATE statement as it's not stored
                string query = "UPDATE Employees SET personalized_increment = @NewIncrement " +
                               "WHERE emp_id = @EmpId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@NewIncrement", newIncrement);
                    cmd.Parameters.AddWithValue("@EmpId", empId);

                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Database error during update: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }
    }
}