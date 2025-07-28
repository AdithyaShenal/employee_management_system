using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.SqlClient;


namespace employee_management_system.views
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            this.Load += Dashboard_Load;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            LoadStatistics();

         
            LoadDepartmentRatioChart();

            // Sidebar button generator
            Button CreateSidebarButton(string text, Point location)
            {
                RoundedButton btn = new RoundedButton(); // Make sure RoundedButton exists in this project
                btn.Text = text;
                btn.Size = new Size(190, 65);
                btn.Location = location;
                btn.FlatStyle = FlatStyle.Flat;
                btn.ForeColor = Color.White;
                btn.BackColor = Color.Teal;
                btn.FlatAppearance.BorderSize = 3;
                btn.FlatAppearance.BorderColor = Color.White;
                btn.Font = new Font("Microsoft Sans Serif", 15, FontStyle.Bold);
                btn.Cursor = Cursors.Hand;
                return btn;
            }

            int startY = 250;
            int spacing = 90;
            panel1.Controls.Add(CreateSidebarButton("Employees", new Point(20, startY + spacing * 0)));
            panel1.Controls.Add(CreateSidebarButton("Payroll", new Point(20, startY + spacing * 1)));
            panel1.Controls.Add(CreateSidebarButton("Attendance", new Point(20, startY + spacing * 2)));
            panel1.Controls.Add(CreateSidebarButton("Events", new Point(20, startY + spacing * 3)));
            panel1.Controls.Add(CreateSidebarButton("Leave Management", new Point(20, startY + spacing * 4)));

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;

        }


    // Pie chart
    private void LoadDepartmentRatioChart()
    {
        Chart pieChart = new Chart();
        pieChart.Series.Clear();
        pieChart.Invalidate(); // refresh the chart
        pieChart.Size = new Size(600, 500);
        pieChart.Location = new Point(650, 320);
        pieChart.ChartAreas.Add(new ChartArea());
        pieChart.Titles.Add("Department Ratio");
        pieChart.Titles[0].Font = new Font("Arial", 14, FontStyle.Bold);

        Series pieSeries = new Series
        {
            ChartType = SeriesChartType.Pie
        };

        string connStr = "Server=(localdb)\\MSSQLLocalDB;Database=ems_db;Trusted_Connection=True;";
        // 🔧 CHANGE "YourDatabase" to match your actual DB

        using (SqlConnection conn = new SqlConnection(connStr))
        {
            conn.Open();
            string query = "SELECT D.dept_name AS Department, COUNT(E.emp_id) AS Count FROM departments D JOIN employees E ON D.department_id = E.department_id GROUP BY D.dept_name";

            // 🔧 CHANGE table and column names if different

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string dept = reader["Department"].ToString();   // 🔧 column name
                int count = Convert.ToInt32(reader["Count"]);    // 🔧 column name
                pieSeries.Points.AddXY(dept, count);
            }
        }

        pieChart.Series.Add(pieSeries);
        panel3.Controls.Add(pieChart);



    }


        private void LoadStatistics()
        {
            string connStr = "Server=(localdb)\\MSSQLLocalDB;Database=ems_db;Trusted_Connection=True;";

            int totalEmployees = 0;
            int totalPresent = 0;
            int totalAbsent = 0;
            int totalLateComers = 0;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                // Total employees
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM employees", conn))
                {
                    totalEmployees = (int)cmd.ExecuteScalar();
                }

                // Present today
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM employee_attendance WHERE CAST(attendance_date AS DATE) = CAST(GETDATE() AS DATE) AND status = 'Present'", conn))
                {
                    totalPresent = (int)cmd.ExecuteScalar();
                }

                // Late comers today
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM employee_attendance WHERE CAST(attendance_date AS DATE) = CAST(GETDATE() AS DATE) AND check_in_time > '09:00:00'", conn))
                {
                    totalLateComers = (int)cmd.ExecuteScalar();
                }

                // Absent = total - present
                totalAbsent = totalEmployees - totalPresent;
            }

            CreateStatPanel("Employees", totalEmployees, Color.FromArgb(52, 152, 219), "👥", 10);      // Blue
            CreateStatPanel("Present", totalPresent, Color.FromArgb(46, 204, 113), "🧑‍💼", 170);        // Green
            CreateStatPanel("Absent", totalAbsent, Color.FromArgb(231, 76, 60), "👎", 330);            // Red
            CreateStatPanel("Late", totalLateComers, Color.FromArgb(241, 196, 15), "⏰", 490);         // Yellow

        }

        private void CreateStatPanel(string title, int value, Color backColor, string emojiIcon, int left)
        {
            // Parent container
            Panel statPanel = new Panel();
            statPanel.Size = new Size(150, 90);
            statPanel.Location = new Point(left, 50);
            statPanel.BackColor = backColor;

            // Rounded corners via paint event
            statPanel.Paint += (s, e) =>
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                Rectangle bounds = statPanel.ClientRectangle;
                int radius = 20;

                using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
                {
                    path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90);
                    path.AddArc(bounds.Right - radius, bounds.Y, radius, radius, 270, 90);
                    path.AddArc(bounds.Right - radius, bounds.Bottom - radius, radius, radius, 0, 90);
                    path.AddArc(bounds.X, bounds.Bottom - radius, radius, radius, 90, 90);
                    path.CloseAllFigures();
                    statPanel.Region = new Region(path);
                }
            };

            // Icon
            Label iconLabel = new Label();
            iconLabel.Text = emojiIcon;
            iconLabel.Font = new Font("Segoe UI Emoji", 20, FontStyle.Regular);
            iconLabel.Location = new Point(10, 10);
            iconLabel.AutoSize = true;
            iconLabel.ForeColor = Color.White;

            // Value
            Label valueLabel = new Label();
            valueLabel.Text = value.ToString();
            valueLabel.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            valueLabel.Location = new Point(55, 12);
            valueLabel.AutoSize = true;
            valueLabel.ForeColor = Color.White;

            // Title
            Label titleLabel = new Label();
            titleLabel.Text = title;
            titleLabel.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            titleLabel.Location = new Point(15, 55);
            titleLabel.AutoSize = true;
            titleLabel.ForeColor = Color.White;

            statPanel.Controls.Add(iconLabel);
            statPanel.Controls.Add(valueLabel);
            statPanel.Controls.Add(titleLabel);



            panel3.Controls.Add(statPanel);
        }

        // Optional hover effect if you're using button1
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.MediumSeaGreen;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.DarkSeaGreen;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Reserved
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // Reserved
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Reserved
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}