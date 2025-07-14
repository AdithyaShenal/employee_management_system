using System;
using System.Drawing;
using System.Windows.Forms;

namespace employee_management_system.views
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            this.Load += Login_Load;
            this.Resize += Login_Resize;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            CenterPanel();
        }

        private void Login_Resize(object sender, EventArgs e)
        {
            CenterPanel();
        }

        private void CenterPanel()
        {
            panel1.Location = new Point(
                (this.ClientSize.Width - panel1.Width) / 2,
                (this.ClientSize.Height - panel1.Height) / 2
            );
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // TODO: Add your login authentication here
            MessageBox.Show($"Welcome, {username}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LinkCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();              // Hide current Login form
            new Register().Show();    // Show Register form
        }

    }
}
