//namespace employee_management_system.views
//{
//    partial class Register
//    {
//        private System.ComponentModel.IContainer components = null;

//        private System.Windows.Forms.Panel panel1;
//        private System.Windows.Forms.Label lblHeader;
//        private System.Windows.Forms.Label lblFullName;
//        private System.Windows.Forms.TextBox txtFullName;
//        private System.Windows.Forms.Label lblUsername;
//        private System.Windows.Forms.TextBox txtUsername;
//        private System.Windows.Forms.Label lblEmail;
//        private System.Windows.Forms.TextBox txtEmail;
//        private System.Windows.Forms.Label lblPassword;
//        private System.Windows.Forms.TextBox txtPassword;
//        private System.Windows.Forms.Label lblConfirmPassword;
//        private System.Windows.Forms.TextBox txtConfirmPassword;
//        private System.Windows.Forms.Button btnRegister;
//        private System.Windows.Forms.LinkLabel linkBackToLogin;

//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        private void InitializeComponent()
//        {
//            this.panel1 = new System.Windows.Forms.Panel();
//            this.lblHeader = new System.Windows.Forms.Label();

//            this.lblFullName = new System.Windows.Forms.Label();
//            this.txtFullName = new System.Windows.Forms.TextBox();

//            this.lblUsername = new System.Windows.Forms.Label();
//            this.txtUsername = new System.Windows.Forms.TextBox();

//            this.lblEmail = new System.Windows.Forms.Label();
//            this.txtEmail = new System.Windows.Forms.TextBox();

//            this.lblPassword = new System.Windows.Forms.Label();
//            this.txtPassword = new System.Windows.Forms.TextBox();

//            this.lblConfirmPassword = new System.Windows.Forms.Label();
//            this.txtConfirmPassword = new System.Windows.Forms.TextBox();

//            this.btnRegister = new System.Windows.Forms.Button();
//            this.linkBackToLogin = new System.Windows.Forms.LinkLabel();

//            this.panel1.SuspendLayout();
//            this.SuspendLayout();

//            // 
//            // panel1
//            // 
//            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
//            this.panel1.Controls.Add(this.linkBackToLogin);
//            this.panel1.Controls.Add(this.btnRegister);

//            this.panel1.Controls.Add(this.txtConfirmPassword);
//            this.panel1.Controls.Add(this.lblConfirmPassword);

//            this.panel1.Controls.Add(this.txtPassword);
//            this.panel1.Controls.Add(this.lblPassword);

//            this.panel1.Controls.Add(this.txtEmail);
//            this.panel1.Controls.Add(this.lblEmail);

//            this.panel1.Controls.Add(this.txtUsername);
//            this.panel1.Controls.Add(this.lblUsername);

//            this.panel1.Controls.Add(this.txtFullName);
//            this.panel1.Controls.Add(this.lblFullName);

//            this.panel1.Controls.Add(this.lblHeader);

//            this.panel1.Name = "panel1";
//            this.panel1.Size = new System.Drawing.Size(600, 650);
//            this.panel1.TabIndex = 0;

//            // 
//            // lblHeader
//            // 
//            this.lblHeader.AutoSize = true;
//            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
//            this.lblHeader.Location = new System.Drawing.Point(210, 20);
//            this.lblHeader.Name = "lblHeader";
//            this.lblHeader.Size = new System.Drawing.Size(180, 60);
//            this.lblHeader.TabIndex = 0;
//            this.lblHeader.Text = "REGISTER";

//            // 
//            // lblFullName
//            // 
//            this.lblFullName.AutoSize = true;
//            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 14F);
//            this.lblFullName.Location = new System.Drawing.Point(50, 100);
//            this.lblFullName.Name = "lblFullName";
//            this.lblFullName.Size = new System.Drawing.Size(115, 32);
//            this.lblFullName.TabIndex = 1;
//            this.lblFullName.Text = "Full Name";

//            // 
//            // txtFullName
//            // 
//            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 14F);
//            this.txtFullName.Location = new System.Drawing.Point(230, 95);
//            this.txtFullName.Name = "txtFullName";
//            this.txtFullName.Size = new System.Drawing.Size(300, 39);
//            this.txtFullName.TabIndex = 2;


//            // 
//            // lblUsername
//            // 
//            this.lblUsername.AutoSize = true;
//            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 14F);
//            this.lblUsername.Location = new System.Drawing.Point(50, 160);
//            this.lblUsername.Name = "lblUsername";
//            this.lblUsername.Size = new System.Drawing.Size(110, 32);
//            this.lblUsername.TabIndex = 3;
//            this.lblUsername.Text = "Username";

//            // 
//            // txtUsername
//            // 
//            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 14F);
//            this.txtUsername.Location = new System.Drawing.Point(230, 155);
//            this.txtUsername.Name = "txtUsername";
//            this.txtUsername.Size = new System.Drawing.Size(300, 39);
//            this.txtUsername.TabIndex = 4;


//            // 
//            // lblEmail
//            // 
//            this.lblEmail.AutoSize = true;
//            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 14F);
//            this.lblEmail.Location = new System.Drawing.Point(50, 220);
//            this.lblEmail.Name = "lblEmail";
//            this.lblEmail.Size = new System.Drawing.Size(70, 32);
//            this.lblEmail.TabIndex = 5;
//            this.lblEmail.Text = "Email";

//            // 
//            // txtEmail
//            // 
//            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 14F);
//            this.txtEmail.Location = new System.Drawing.Point(230, 215);
//            this.txtEmail.Name = "txtEmail";
//            this.txtEmail.Size = new System.Drawing.Size(300, 39);
//            this.txtEmail.TabIndex = 6;


//            // 
//            // lblPassword
//            // 
//            this.lblPassword.AutoSize = true;
//            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 14F);
//            this.lblPassword.Location = new System.Drawing.Point(50, 280);
//            this.lblPassword.Name = "lblPassword";
//            this.lblPassword.Size = new System.Drawing.Size(106, 32);
//            this.lblPassword.TabIndex = 7;
//            this.lblPassword.Text = "Password";

//            // 
//            // txtPassword
//            // 
//            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 14F);
//            this.txtPassword.Location = new System.Drawing.Point(230, 275);
//            this.txtPassword.Name = "txtPassword";
//            this.txtPassword.Size = new System.Drawing.Size(300, 39);
//            this.txtPassword.TabIndex = 8;
//            this.txtPassword.UseSystemPasswordChar = true;


//            // 
//            // lblConfirmPassword
//            // 
//            this.lblConfirmPassword.AutoSize = true;
//            this.lblConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 14F);
//            this.lblConfirmPassword.Location = new System.Drawing.Point(50, 340);
//            this.lblConfirmPassword.Name = "lblConfirmPassword";
//            this.lblConfirmPassword.Size = new System.Drawing.Size(187, 32);
//            this.lblConfirmPassword.TabIndex = 9;
//            this.lblConfirmPassword.Text = "Confirm Password";

//            // 
//            // txtConfirmPassword
//            // 
//            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 14F);
//            this.txtConfirmPassword.Location = new System.Drawing.Point(230, 335);
//            this.txtConfirmPassword.Name = "txtConfirmPassword";
//            this.txtConfirmPassword.Size = new System.Drawing.Size(300, 39);
//            this.txtConfirmPassword.TabIndex = 10;
//            this.txtConfirmPassword.UseSystemPasswordChar = true;


//            // 
//            // btnRegister
//            // 
//            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
//            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
//            this.btnRegister.ForeColor = System.Drawing.Color.White;
//            this.btnRegister.Location = new System.Drawing.Point(230, 400);
//            this.btnRegister.Name = "btnRegister";
//            this.btnRegister.Size = new System.Drawing.Size(140, 50);
//            this.btnRegister.TabIndex = 11;
//            this.btnRegister.Text = "Register";
//            this.btnRegister.UseVisualStyleBackColor = false;
//            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);

//            // 
//            // linkBackToLogin
//            // 
//            this.linkBackToLogin.AutoSize = true;
//            this.linkBackToLogin.Font = new System.Drawing.Font("Segoe UI", 10F);
//            this.linkBackToLogin.Location = new System.Drawing.Point(240, 470);
//            this.linkBackToLogin.Name = "linkBackToLogin";
//            this.linkBackToLogin.Size = new System.Drawing.Size(118, 23);
//            this.linkBackToLogin.TabIndex = 12;
//            this.linkBackToLogin.TabStop = true;
//            this.linkBackToLogin.Text = "Back to Login";
//            this.linkBackToLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkBackToLogin_LinkClicked);

//            // 
//            // Register Form
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
//            this.ClientSize = new System.Drawing.Size(1920, 1080);
//            this.Controls.Add(this.panel1);
//            this.Name = "Register";
//            this.Text = "Register";
//            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

//            this.panel1.ResumeLayout(false);
//            this.panel1.PerformLayout();
//            this.ResumeLayout(false);
//        }
//    }
//}

using System.Windows.Forms;
using System.Drawing;

namespace employee_management_system.views
{
    partial class Register
    {
        private System.ComponentModel.IContainer components = null;

        private Guna.UI2.WinForms.Guna2Panel panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblHeader;
        private Guna.UI2.WinForms.Guna2TextBox txtFullName;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirmPassword;
        private Guna.UI2.WinForms.Guna2Button btnRegister;
        private LinkLabel linkBackToLogin;
        private Guna.UI2.WinForms.Guna2BorderlessForm borderlessForm;
        private Guna.UI2.WinForms.Guna2ImageButton btnClose;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblHeader = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtFullName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnRegister = new Guna.UI2.WinForms.Guna2Button();
            this.linkBackToLogin = new System.Windows.Forms.LinkLabel();
            this.btnClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.borderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BorderRadius = 20;
            this.panel1.BorderThickness = 1;
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Controls.Add(this.txtFullName);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtConfirmPassword);
            this.panel1.Controls.Add(this.btnRegister);
            this.panel1.Controls.Add(this.linkBackToLogin);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.FillColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(380, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1055, 620);
            this.panel1.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = false;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.lblHeader.Location = new System.Drawing.Point(71, 68);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(400, 60);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Create Account";
            this.lblHeader.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFullName
            // 
            this.txtFullName.BorderRadius = 10;
            this.txtFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFullName.DefaultText = "";
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtFullName.Location = new System.Drawing.Point(71, 155);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PlaceholderText = "Full Name";
            this.txtFullName.SelectedText = "";
            this.txtFullName.Size = new System.Drawing.Size(400, 45);
            this.txtFullName.TabIndex = 1;
            // 
            // txtUsername
            // 
            this.txtUsername.BorderRadius = 10;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtUsername.Location = new System.Drawing.Point(71, 215);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PlaceholderText = "Username";
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(400, 45);
            this.txtUsername.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderRadius = 10;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtEmail.Location = new System.Drawing.Point(71, 275);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(400, 45);
            this.txtEmail.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderRadius = 10;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPassword.Location = new System.Drawing.Point(71, 335);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(400, 45);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BorderRadius = 10;
            this.txtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmPassword.DefaultText = "";
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtConfirmPassword.Location = new System.Drawing.Point(71, 395);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PlaceholderText = "Confirm Password";
            this.txtConfirmPassword.SelectedText = "";
            this.txtConfirmPassword.Size = new System.Drawing.Size(400, 45);
            this.txtConfirmPassword.TabIndex = 5;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // btnRegister
            // 
            this.btnRegister.BorderRadius = 10;
            this.btnRegister.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(71, 469);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(400, 50);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register";
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // linkBackToLogin
            // 
            this.linkBackToLogin.AutoSize = true;
            this.linkBackToLogin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.linkBackToLogin.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.linkBackToLogin.Location = new System.Drawing.Point(219, 541);
            this.linkBackToLogin.Name = "linkBackToLogin";
            this.linkBackToLogin.Size = new System.Drawing.Size(113, 23);
            this.linkBackToLogin.TabIndex = 7;
            this.linkBackToLogin.TabStop = true;
            this.linkBackToLogin.Text = "Back to Login";
            this.linkBackToLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkBackToLogin_LinkClicked);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::employee_management_system.Properties.Resources.close_image;
            this.btnClose.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnClose.ImageRotate = 0F;
            this.btnClose.ImageSize = new System.Drawing.Size(30, 30);
            this.btnClose.Location = new System.Drawing.Point(1012, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 8;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // borderlessForm
            // 
            this.borderlessForm.ContainerControl = this;
            this.borderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.borderlessForm.TransparentWhileDrag = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::employee_management_system.Properties.Resources.login_image;
            this.pictureBox1.Location = new System.Drawing.Point(538, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(489, 565);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Register
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private PictureBox pictureBox1;
    }
}
