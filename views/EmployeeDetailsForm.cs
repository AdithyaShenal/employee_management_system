// File: EmployeeDetailsForm.cs
using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace employee_management_system
{
    public partial class EmployeeDetailsForm : Form
    {
        private Employee _currentEmployee; // Holds the employee object being edited

        // Constructor: Accepts the Employee object to work with
        public EmployeeDetailsForm(Employee employee)
        {
            InitializeComponent();
            _currentEmployee = employee;
            this.Load += EmployeeDetailsForm_Load; // Hook up the Load event
        }


        private void EmployeeDetailsForm_Load(object sender, EventArgs e)
        {
            // Populate controls with the employee's data
            if (_currentEmployee != null)
            {
                lblIDValue.Text = _currentEmployee.EmployeeId.ToString();
                txtName.Text = _currentEmployee.Name;
                txtRole.Text = _currentEmployee.Role;
                txtEmail.Text = _currentEmployee.Email;
                txtPhone.Text = _currentEmployee.PhoneNumber;
            }
            else
            {
                // This part would be for creating a NEW employee if you implement that
                lblIDValue.Text = "New (Not Saved)";
                MessageBox.Show("Error: No employee data provided.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close(); // Close if no data provided for an existing employee
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Update the Employee object with values from the TextBoxes
            if (_currentEmployee != null)
            {
                _currentEmployee.Name = txtName.Text;
                _currentEmployee.Role = txtRole.Text;
                _currentEmployee.Email = txtEmail.Text;
                _currentEmployee.PhoneNumber = txtPhone.Text;

                // *** IMPORTANT: In a real application, you would save these changes ***
                // *** to your database or persistent storage here.                   ***
                // Example: DataAccessLayer.SaveEmployee(_currentEmployee);
                // For this tutorial, we are just updating the in-memory object.

                MessageBox.Show("Employee data updated (simulated save).", "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // The DialogResult.OK on the button will automatically close the form
                // and return OK to the calling form (EmployeeManagementNew).
            }
        }

        private void EmployeeDetailsForm_Load_1(object sender, EventArgs e)
        {

        }
        // No specific code needed for btnCancel_Click because its DialogResult is set to Cancel.
        // It will just close the form and return DialogResult.Cancel.
    }
}