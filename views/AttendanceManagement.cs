using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace employee_management_system.views
{
    public partial class AttendanceManagement : Form
    {
        public AttendanceManagement()
        {
            InitializeComponent();
            LoadAttendanceData();
        }

        private void AttendanceManagement_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void LoadAttendanceData()
        {
            string connectionString = @"Server=DESKTOP-EDMBL1C\SQLEXPRESS;Database=ems_db;Trusted_Connection=True;";
            string query = "SELECT emp_id, attendance_date, check_in_time, check_out_time, status, remarks FROM employee_attendance";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGridViewAttendance.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchType = comboBoxSearchType.SelectedItem?.ToString();
            string searchValue = textBoxSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchType) || string.IsNullOrEmpty(searchValue))
            {
                MessageBox.Show("Please select a search type and enter a value.");
                return;
            }

            string connectionString = @"Server=DESKTOP-EDMBL1C\SQLEXPRESS;Database=ems_db;Trusted_Connection=True;";
            string query = "";

            if (searchType == "Employee ID")
            {
                query = "SELECT emp_id, attendance_date, check_in_time, check_out_time, status, remarks " +
                        "FROM employee_attendance WHERE emp_id LIKE @search";
            }
            else if (searchType == "Employee Name")
            {
                // Assuming there’s a relation between employee_attendance and employee table
                query = "SELECT ea.emp_id, attendance_date, check_in_time, check_out_time, status, remarks " +
                        "FROM employee_attendance ea " +
                        "JOIN employees e ON ea.emp_id = e.emp_id " +
                        "WHERE e.emp_name LIKE @search";
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@search", "%" + searchValue + "%");
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGridViewAttendance.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search failed: " + ex.Message);
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            LoadAttendanceData();
            textBoxSearch.Text = "";
            comboBoxSearchType.SelectedIndex = -1;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AttendanceManagement_Load_1(object sender, EventArgs e)
        {

        }
    }
}