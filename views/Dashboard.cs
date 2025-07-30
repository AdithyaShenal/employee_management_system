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

            // Bar chart
            Chart chart = new Chart();
            chart.Size = new Size(600, 500);
            chart.Location = new Point(400, 200);
            chart.ChartAreas.Add(new ChartArea());
            chart.BackColor = Color.White;
            chart.Titles.Add("Monthly Users");

            Series series = new Series
            {
                Color = Color.CornflowerBlue,
                ChartType = SeriesChartType.Column
            };
            series.Points.AddXY("Jan", 10);
            series.Points.AddXY("Feb", 20);
            series.Points.AddXY("Mar", 15);
            series.Points.AddXY("Apr", 10);
            series.Points.AddXY("May", 20);
            series.Points.AddXY("Jun", 15);
            series.Points.AddXY("Jul", 10);
            series.Points.AddXY("Aug", 20);
            series.Points.AddXY("Sep", 15);
            series.Points.AddXY("Oct", 12);
            series.Points.AddXY("Nov", 20);
            series.Points.AddXY("Dec", 15);

            chart.Series.Add(series);
            this.Controls.Add(chart);

            // Pie chart
            Chart pieChart = new Chart();
            pieChart.Size = new Size(600, 500);
            pieChart.Location = new Point(950, 200);
            pieChart.ChartAreas.Add(new ChartArea());

            Series pieSeries = new Series
            {
                ChartType = SeriesChartType.Pie
            };
            pieSeries.Points.AddXY("HR", 30);
            pieSeries.Points.AddXY("Payroll", 20);
            pieSeries.Points.AddXY("Attendance", 50);

            pieChart.Series.Add(pieSeries);
            pieChart.Titles.Add("Department Ratio");
            this.Controls.Add(pieChart);
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

        private void btnTopbarAction_Click(object sender, EventArgs e)
        {

        }
    }
}
