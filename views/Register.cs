﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;
using employee_management_system.controllers;
using employee_management_system.models;

namespace employee_management_system.views
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();

            this.Load += Register_Load;
            this.Resize += Register_Resize;

            // Event handlers for hover effect on btnRegister
            btnRegister.MouseEnter += (s, e) =>
            {
                btnRegister.BackColor = Color.FromArgb(0, 150, 255);
            };
            btnRegister.MouseLeave += (s, e) =>
            {
                btnRegister.BackColor = Color.FromArgb(0, 120, 215);
            };
        }

        private void Register_Load(object sender, EventArgs e)
        {
            CenterPanel();
        }

        private void Register_Resize(object sender, EventArgs e)
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

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text.Trim();
            string username = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (string.IsNullOrEmpty(fullName) ||
                string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill in all fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            User newUser = new User(fullName, password, email, username);


            bool registerStatus = LoginController.Register( newUser, out string errorMsg);

            if (!registerStatus)
            {
                MessageBox.Show(errorMsg, "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            MessageBox.Show($"Account created for {fullName}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); // Close the Register form
            new Login().Show(); // Show the Login form
        }

        private void LinkBackToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var loginForm = new Login();
            loginForm.Show();
        }

        private void BtnClose_Click(object sender, EventArgs e) 
        {
            this.Close();
        }
    }
}

