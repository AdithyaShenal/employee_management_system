// File: EmployeeManagementNew.cs
using System;
using System.Collections.Generic;
using System.Drawing; // Needed for Color and Padding
using System.Linq; // Needed for LINQ (Where, ToList)
using System.Windows.Forms;

namespace employee_management_system.views // Keep your namespace structure
{
    public partial class EmployeeManagementNew : Form
    {
        private List<employee_management_system.Employee> _allEmployees;

        public EmployeeManagementNew()
        {
            InitializeComponent();
            this.Load += EmployeeManagementNew_Load;
            btnSearch.Click += btnSearch_Click;
            btnClearSearch.Click += btnClearSearch_Click;
            btnAdd.Click += AddBtn_Click; // This line is now correctly linked to the new method below
        }

        private void EmployeeManagementNew_Load(object sender, EventArgs e)
        {
            _allEmployees = GetLatestEmployeeData();
            DisplayEmployeeCards(_allEmployees);
        }

        // --- Data Simulation Method ---
        private List<employee_management_system.Employee> GetLatestEmployeeData()
        {
            return new List<employee_management_system.Employee>
            {
                new employee_management_system.Employee(10001, "Dr. Amith Pussella", "Senior Lecturer", "amith.pussella@example.com", "078 452 1639"),
                new employee_management_system.Employee(10002, "Jane Doe", "Lead Developer", "jane.doe@example.com", "077 123 4567"),
                new employee_management_system.Employee(10003, "John Smith", "HR Manager", "john.smith@example.com", "071 987 6543"),
                new employee_management_system.Employee(10004, "Emily White", "Marketing Coordinator", "emily.white@example.com", "072 555 1234"),
                new employee_management_system.Employee(10005, "David Lee", "Intern (Updated)", "david.lee@example.com", "078 876 5432"),
                new employee_management_system.Employee(10006, "Anna Johnson", "Junior Analyst", "anna.j@example.com", "075 111 2222"),
                new employee_management_system.Employee(10007, "Michael Brown", "Support Specialist", "michael.b@example.com", "076 999 8888"),
                new employee_management_system.Employee(10008, "Sarah Green", "Project Manager", "sarah.g@example.com", "079 444 3333"),
                new employee_management_system.Employee(10009, "Robert Black", "QA Engineer", "robert.b@example.com", "070 222 1111"),
                new employee_management_system.Employee(10010, "Laura White", "Customer Service", "laura.w@example.com", "071 123 9876"),
                new employee_management_system.Employee(10011, "Chris Red", "Sales Executive", "chris.r@example.com", "077 876 5432"),
                new employee_management_system.Employee(10012, "Olivia Blue", "Product Designer", "olivia.b@example.com", "072 345 6789")
            };
        }

        // --- Method to Display Employee Cards ---
        private void DisplayEmployeeCards(List<employee_management_system.Employee> employeesToDisplay)
        {
            flowLayoutPanelEmployeeCards.Controls.Clear(); // Clear all existing cards

            foreach (employee_management_system.Employee emp in employeesToDisplay)
            {
                employee_management_system.EmployeeCardControlNew card = new employee_management_system.EmployeeCardControlNew();

                card.EmployeeId = emp.EmployeeId.ToString();
                card.EmployeeName = emp.Name;
                card.EmployeeRole = emp.Role;
                card.EmployeeEmail = emp.Email;
                card.EmployeePhoneNumber = emp.PhoneNumber;

                // Subscribe to the View button click event of THIS SPECIFIC card instance
                card.ViewButtonClicked += (s, ev) => Card_ViewButtonClicked(emp);

                // Add margin around each card for visual separation in HD layout
                card.Margin = new Padding(15, 10, 15, 10); // Left, Top, Right, Bottom

                flowLayoutPanelEmployeeCards.Controls.Add(card);
            }
        }

        // --- Event Handler for "View" Button Click on any Card ---
        private void Card_ViewButtonClicked(employee_management_system.Employee employee)
        {
            // This method correctly takes an 'Employee' object because it's passed from the card control.
            employee_management_system.EmployeeDetailsForm detailsForm = new employee_management_system.EmployeeDetailsForm(employee);

            DialogResult result = detailsForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                MessageBox.Show($"Employee '{employee.Name}' details saved. Refreshing list...", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // In a real application, you might update just this employee in _allEmployees
                // or refresh from a database. For this simulation, re-fetching all data is simple.
                _allEmployees = GetLatestEmployeeData(); // Re-fetch all data
                DisplayEmployeeCards(_allEmployees);      // Re-display
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Employee details edit cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // --- CORRECTED AddBtn_Click method for the main "Add" button ---
        // This method must match the EventHandler delegate signature.
        private void AddBtn_Click(object sender, EventArgs e)
        {
            // Create a new instance of the AddEmployee form (which should use its parameterless constructor)
            employee_management_system.AddEmployee addForm = new employee_management_system.AddEmployee();

            DialogResult result = addForm.ShowDialog(); // Show the form as a dialog

            if (result == DialogResult.OK)
            {
                // If the AddEmployee form was closed with DialogResult.OK,
                // it means a new employee was likely created and saved.
                // We retrieve that new employee from the addForm's ResultEmployee property.
                if (addForm.ResultEmployee != null)
                {
                    _allEmployees.Add(addForm.ResultEmployee); // Add the new employee to our list
                    MessageBox.Show($"New employee '{addForm.ResultEmployee.Name}' added successfully!", "Add Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("New employee added, but no employee data was returned from the form.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                DisplayEmployeeCards(_allEmployees); // Re-display all employees, including the new one
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Adding new employee cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // --- Event Handler for Main Form's "Search" Button ---
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearchValue.Text.Trim();
            string selectedOption = cmbSearchOption.SelectedItem?.ToString();

            List<employee_management_system.Employee> filteredEmployees = new List<employee_management_system.Employee>();

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                filteredEmployees = _allEmployees;
            }
            else
            {
                string lowerCaseSearchTerm = searchTerm.ToLower();

                switch (selectedOption)
                {
                    case "Employee ID":
                        if (int.TryParse(searchTerm, out int id))
                        {
                            filteredEmployees = _allEmployees.Where(emp => emp.EmployeeId == id).ToList();
                        }
                        break;
                    case "Name":
                        filteredEmployees = _allEmployees.Where(emp => emp.Name.ToLower().Contains(lowerCaseSearchTerm)).ToList();
                        break;
                    case "Role":
                        filteredEmployees = _allEmployees.Where(emp => emp.Role.ToLower().Contains(lowerCaseSearchTerm)).ToList();
                        break;
                    case "Email":
                        filteredEmployees = _allEmployees.Where(emp => emp.Email.ToLower().Contains(lowerCaseSearchTerm)).ToList();
                        break;
                    case "Phone Number":
                        filteredEmployees = _allEmployees.Where(emp => emp.PhoneNumber.ToLower().Contains(lowerCaseSearchTerm)).ToList();
                        break;
                    default:
                        filteredEmployees = _allEmployees.Where(emp =>
                            emp.Name.ToLower().Contains(lowerCaseSearchTerm) ||
                            emp.Role.ToLower().Contains(lowerCaseSearchTerm) ||
                            emp.Email.ToLower().Contains(lowerCaseSearchTerm) ||
                            emp.PhoneNumber.ToLower().Contains(lowerCaseSearchTerm) ||
                            emp.EmployeeId.ToString().Contains(searchTerm)).ToList();
                        break;
                }
            }

            if (filteredEmployees.Count == 0 && !string.IsNullOrWhiteSpace(searchTerm))
            {
                MessageBox.Show("No employees found matching your search criteria.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            DisplayEmployeeCards(filteredEmployees);
        }

        // --- Event Handler for Main Form's "Clear Search" Button ---
        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearchValue.Text = string.Empty;
            cmbSearchOption.SelectedIndex = -1; // Clear selection
            DisplayEmployeeCards(_allEmployees); // Show all employees again
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {
            // This method seems to be an empty leftover from the designer.
            // You can leave it as is or remove it if it's not used for custom drawing.
        }
    }
}