using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using employee_management_system.controllers;
using employee_management_system.models;

namespace employee_management_system.views
{
    public partial class Payroll : Form
    {
        private PayrollEntry currentPayrollEntry;

        public Payroll()
        {
            InitializeComponent();
            InitializeFormState();
        }

        private void InitializeFormState()
        {
            SetInformationPanelReadOnly(true);
            search_button.Enabled = true;
            comboBox1.Enabled = true;
            userinput_textbox.Enabled = true;
            update_button.Enabled = false;
            save_button.Enabled = false;
            history_button.Enabled = false;
            if (comboBox1.Items.Count == 0)
            {
                comboBox1.Items.Add("Employee ID");
                comboBox1.Items.Add("Employee name");
                comboBox1.SelectedIndex = 0;
            }
        }

        private void SetInformationPanelReadOnly(bool readOnly)
        {
            basic_salary_textbox.ReadOnly = readOnly;
            transport_textbox.ReadOnly = readOnly;
            bonus_textbox.ReadOnly = readOnly;
            Christmas_textbox.ReadOnly = readOnly;
            net_textbox.ReadOnly = readOnly;
            increment_textbox.ReadOnly = readOnly;
        }

        private void ClearInformationPanel()
        {
            emp_name_label.Text = "Dr. Jhon Doe";
            empid_label.Text = "100002";
            richTextBox1.Text = "Science Faculty/ Department of \nComputer Science";
            emp_grade_label.Text = "Grade03";

            basic_salary_textbox.Clear();
            transport_textbox.Clear();
            bonus_textbox.Clear();
            increment_textbox.Clear();
            Christmas_textbox.Clear();
            net_textbox.Clear();
            userinput_textbox.Clear();
        }

        private void CalculateAndDisplayNetSalary()
        {
            decimal basicSalary = 0;
            decimal transportAllowance = 0;
            decimal bonus = 0;
            decimal increment = 0;
            decimal christmasAllowance = 0;

            decimal.TryParse(basic_salary_textbox.Text, out basicSalary);
            decimal.TryParse(transport_textbox.Text, out transportAllowance);
            decimal.TryParse(bonus_textbox.Text, out bonus);
            decimal.TryParse(increment_textbox.Text, out increment);
            decimal.TryParse(Christmas_textbox.Text, out christmasAllowance);

            decimal netSalary = basicSalary + transportAllowance + bonus + increment + christmasAllowance;
            net_textbox.Text = netSalary.ToString("F2");
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            string searchTerm = userinput_textbox.Text.Trim();
            if (string.IsNullOrEmpty(searchTerm))
            {
                MessageBox.Show("Please enter an Employee ID or Name to search.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string searchBy = comboBox1.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(searchBy))
            {
                MessageBox.Show("Please select a search option (Employee ID or Employee Name).", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PayrollEntry foundPayrollEntry = null;

            if (searchBy == "Employee ID")
            {
                if (int.TryParse(searchTerm, out int empId))
                {
                    foundPayrollEntry = EmployeeController.GetPayrollEntryById(empId);
                }
                else
                {
                    MessageBox.Show("Please enter a valid Employee ID (numeric).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else if (searchBy == "Employee name")
            {
                foundPayrollEntry = EmployeeController.GetPayrollEntryByName(searchTerm);
            }

            if (foundPayrollEntry != null)
            {
                currentPayrollEntry = foundPayrollEntry;
                DisplayPayrollInformation(foundPayrollEntry);
                update_button.Enabled = true;
                history_button.Enabled = true;
                save_button.Enabled = false;
            }
            else
            {
                MessageBox.Show("Employee/Payroll entry not found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInformationPanel();
                InitializeFormState();
            }
        }

        private void DisplayPayrollInformation(PayrollEntry payrollEntry)
        {
            emp_name_label.Text = payrollEntry.EmpName;
            empid_label.Text = payrollEntry.EmpId.ToString();
            richTextBox1.Text = payrollEntry.DepartmentName;
            emp_grade_label.Text = "Grade" + payrollEntry.GradeId.ToString("D2"); // Using GradeId directly

            basic_salary_textbox.Text = payrollEntry.BasicSalary.ToString("F2");
            transport_textbox.Text = payrollEntry.TransportAllowance.ToString("F2");
            bonus_textbox.Text = payrollEntry.NewYearBonus.ToString("F2");
            increment_textbox.Text = payrollEntry.PersonalizedIncrement.ToString("F2");
            Christmas_textbox.Text = payrollEntry.ChristmasAllowance.ToString("F2");
            // Net Salary is calculated and displayed, not read from DB
            CalculateAndDisplayNetSalary();

            SetInformationPanelReadOnly(true);
            increment_textbox.ReadOnly = true;
        }


        private void update_button_Click(object sender, EventArgs e)
        {
            if (currentPayrollEntry != null)
            {
                SetInformationPanelReadOnly(true);
                increment_textbox.ReadOnly = false;

                save_button.Enabled = true;
                update_button.Enabled = false;
                MessageBox.Show("You can now edit the 'Personalized Increment'. Click 'Save' when done.", "Edit Mode", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please search for an employee first to update.", "No Employee Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (currentPayrollEntry == null)
            {
                MessageBox.Show("No payroll entry selected to save changes for.", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(increment_textbox.Text, out decimal newIncrement))
            {
                MessageBox.Show("Please enter a valid numeric value for Personalized Increment.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            currentPayrollEntry.PersonalizedIncrement = newIncrement;

            // Net Salary is calculated here for the current object, but NOT sent to DB for update
            currentPayrollEntry.NetSalary = currentPayrollEntry.BasicSalary +
                                            currentPayrollEntry.TransportAllowance +
                                            currentPayrollEntry.NewYearBonus +
                                            currentPayrollEntry.PersonalizedIncrement +
                                            currentPayrollEntry.ChristmasAllowance;

            // Only personalized_increment is updated in the database
            if (EmployeeController.UpdatePayrollEntryIncrement(currentPayrollEntry.EmpId, currentPayrollEntry.PersonalizedIncrement))
            {
                MessageBox.Show("Personalized Increment updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayPayrollInformation(currentPayrollEntry); // Re-display with updated values
                SetInformationPanelReadOnly(true);
                save_button.Enabled = false;
                update_button.Enabled = true;
            }
            else
            {
                MessageBox.Show("Failed to update personalized increment. Please try again.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void history_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("History functionality is not yet implemented.", "Coming Soon", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void navigator_Paint(object sender, PaintEventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void information_panel_Paint(object sender, PaintEventArgs e) { }
        private void richTextBox1_TextChanged(object sender, EventArgs e) { }
        private void emp_grade_label_Click(object sender, EventArgs e) { }
        private void empid_label_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged_1(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void tansport_label_Click(object sender, EventArgs e) { }
    }
}