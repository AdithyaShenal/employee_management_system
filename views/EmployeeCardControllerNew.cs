// File: EmployeeCardControlNew.cs
using System;
using System.Drawing;
using System.Windows.Forms;

namespace employee_management_system // Ensure this matches your project's root namespace
{
    public partial class EmployeeCardControlNew : UserControl // Make sure the class name is correct here
    {
        public EmployeeCardControlNew()
        {
            InitializeComponent();
        }

        // Public properties to set the card's data dynamically
        public string EmployeeId
        {
            get { return lblEmployeeIDValue.Text; }
            set { lblEmployeeIDValue.Text = value; }
        }

        public string EmployeeName
        {
            get { return lblEmployeeName.Text; }
            set { lblEmployeeName.Text = value; }
        }

        public string EmployeeRole
        {
            get { return lblEmployeeRole.Text; }
            set { lblEmployeeRole.Text = value; }
        }

        public string EmployeeEmail
        {
            get { return lblEmployeeEmail.Text; }
            set { lblEmployeeEmail.Text = value; }
        }

        public string EmployeePhoneNumber
        {
            get { return lblEmployeePhone.Text; }
            set { lblEmployeePhone.Text = value; }
        }

        // Define an event that the parent form can subscribe to
        public event EventHandler ViewButtonClicked;

        // Event handler for the View button click
        private void btnView_Click(object sender, EventArgs e)
        {
            // Raise the event, notifying any subscribers (like EmployeeManagementNew)
            ViewButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void EmployeeCardControlNew_Load(object sender, EventArgs e)
        {

        }

        private void pnlCardContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnView_Click_1(object sender, EventArgs e)
        {

        }

        // Optional: If you need a Load event for the UserControl, uncomment/add this:
        // private void EmployeeCardControlNew_Load(object sender, EventArgs e)
        // {
        //     // Any code you want to run when the card control itself loads
        // }
    }
}