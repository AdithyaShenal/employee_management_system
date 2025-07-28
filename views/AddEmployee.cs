// File: AddEmployee.cs

using System;
using System.Windows.Forms;
using System.Xml.Linq;
// Make sure you have this using statement or fully qualify Employee
// using employee_management_system; // If Employee is in this namespace. Assumed already in this namespace.

namespace employee_management_system // Adjust namespace if different
{
    public partial class AddEmployee : Form
    {
        public Employee ResultEmployee { get; private set; }

        // Constructor for adding a new employee
        public AddEmployee()
        {
            InitializeComponent();
            this.Load += AddEmployee_Load; // Ensure you have this method, even if empty

            ResultEmployee = new Employee(); // Initialize a new Employee object
            LoadEmployeeData(ResultEmployee); // Load empty data into controls

            // Show 'Save' button, hide 'Update' button for new additions
            btnSave.Visible = true;
            btnUpdate.Visible = false; // Assuming you have a btnUpdate

            this.btnSave.Click += btnSave_Click;
            this.btnUpdate.Click += btnCancel_Click; // Correctly link Cancel button
            // Removed: this.btnUpdate.Click += btnCancel_Click; // This was incorrect for 'Update'
        }

        // Constructor for editing an existing employee
        public AddEmployee(Employee employeeToEdit)
        {
            InitializeComponent();
            this.Load += AddEmployee_Load; // Ensure you have this method, even if empty

            if (employeeToEdit == null)
            {
                ResultEmployee = new Employee();
                MessageBox.Show("Attempted to edit a null employee. Creating a new one instead.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ResultEmployee = employeeToEdit; // Assign the existing employee to ResultEmployee
            }
            LoadEmployeeData(ResultEmployee); // Load existing data into controls

            // Show 'Update' button, hide 'Save' button for edits
            btnSave.Visible = false;
            btnUpdate.Visible = true; // Assuming you have a btnUpdate

            this.btnUpdate.Click += btnUpdate_Click; // Link Update button to its specific handler
            this.btnUpdate.Click += btnCancel_Click; // Link Cancel button
        }

        // --- Form Load Event Handler ---
        // This method is required if you are subscribing to 'this.Load' in the constructor.
        // Even if it's empty, it must exist with this signature.
        private void AddEmployee_Load(object sender, EventArgs e)
        {
            // Optional: Any setup logic needed when the form first loads
            // Example: Set focus to a specific textbox
            txtName.Focus();
        }


        // Helper method to load employee data into form controls
        private void LoadEmployeeData(Employee emp)
        {
            if (emp != null)
            {
                // For new employees (ID=0), display "New" or keep empty.
                // For existing employees, display the ID.
                lblIDValue.Text = emp.EmployeeId > 0 ? emp.EmployeeId.ToString() : "New (will be assigned)";
                txtName.Text = emp.Name;
                txtRole.Text = emp.Role;
                txtEmail.Text = emp.Email;
                txtPhone.Text = emp.PhoneNumber; // Corrected to txtPhone
            }
            else
            {
                lblIDValue.Text = "New (will be assigned)";
                txtName.Text = "";
                txtRole.Text = "";
                txtEmail.Text = "";
                txtPhone.Text = ""; // Corrected to txtPhone
            }
        }

        // --- Save button click handler (for ADDING new employees) ---
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Employee Name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ensure ResultEmployee is initialized (should be by constructors, but good defensive check)
            if (ResultEmployee == null) ResultEmployee = new Employee();

            // Generate a new ID ONLY if it's a new employee (ID is 0 or not yet assigned)
            if (ResultEmployee.EmployeeId == 0) // Assuming 0 means a new, unassigned ID
            {
                ResultEmployee.EmployeeId = GenerateNewEmployeeId();
            }
            // If it's an existing employee being "saved" via this button (less common, but possible),
            // its ID would already be set and remains unchanged.

            ResultEmployee.Name = txtName.Text;
            ResultEmployee.Role = txtRole.Text;
            ResultEmployee.Email = txtEmail.Text;
            ResultEmployee.PhoneNumber = txtPhone.Text; // Corrected to txtPhone

            this.DialogResult = DialogResult.OK; // Indicate success
            this.Close();
        }

        // --- Update button click handler (for UPDATING existing employees) ---
        // You should have a separate handler for updating if its logic differs or
        // if you want to explicitly separate add vs. update actions.
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Employee Name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // The ResultEmployee (which is the 'employeeToEdit' passed in) is directly updated.
            // No new ID generation needed here as it's an existing employee.
            ResultEmployee.Name = txtName.Text;
            ResultEmployee.Role = txtRole.Text;
            ResultEmployee.Email = txtEmail.Text;
            ResultEmployee.PhoneNumber = txtPhone.Text; // Corrected to txtPhone

            this.DialogResult = DialogResult.OK; // Indicate success
            this.Close();
        }


        // --- Cancel button click handler ---
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; // Indicate cancellation
            this.Close();
        }

        // --- IMPORTANT: Implement a simple ID generation for new employees ---
        private int GenerateNewEmployeeId()
        {
            // For a real app, this would query your data source for the next available ID.
            // For now, let's use a simple random number (ensure it doesn't clash with your hardcoded ones).
            // A better way for simulation: Keep a static counter or list of used IDs.
            return new Random().Next(20000, 99999); // Generates a random ID for demonstration
        }
    }
}