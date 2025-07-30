//namespace employee_management_system.views
//{
//    partial class Login
//    {
//        private System.ComponentModel.IContainer components = null;

//        private System.Windows.Forms.Panel panel1;
//        private System.Windows.Forms.Label lblHeader;
//        private System.Windows.Forms.Label lblUsername;
//        private System.Windows.Forms.TextBox txtUsername;
//        private System.Windows.Forms.Label lblPassword;
//        private System.Windows.Forms.TextBox txtPassword;
//        private System.Windows.Forms.Button btnLogin;
//        private System.Windows.Forms.LinkLabel linkCreateAccount;

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
//            this.linkCreateAccount = new System.Windows.Forms.LinkLabel();
//            this.btnLogin = new System.Windows.Forms.Button();
//            this.txtPassword = new System.Windows.Forms.TextBox();
//            this.lblPassword = new System.Windows.Forms.Label();
//            this.txtUsername = new System.Windows.Forms.TextBox();
//            this.lblUsername = new System.Windows.Forms.Label();
//            this.lblHeader = new System.Windows.Forms.Label();
//            this.panel1.SuspendLayout();
//            this.SuspendLayout();
//            // 
//            // panel1
//            // 
//            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
//            this.panel1.Controls.Add(this.linkCreateAccount);
//            this.panel1.Controls.Add(this.btnLogin);
//            this.panel1.Controls.Add(this.txtPassword);
//            this.panel1.Controls.Add(this.lblPassword);
//            this.panel1.Controls.Add(this.txtUsername);
//            this.panel1.Controls.Add(this.lblUsername);
//            this.panel1.Controls.Add(this.lblHeader);
//            this.panel1.Location = new System.Drawing.Point(0, 0);
//            this.panel1.Name = "panel1";
//            this.panel1.Size = new System.Drawing.Size(600, 500);
//            this.panel1.TabIndex = 0;
//            // 
//            // linkCreateAccount
//            // 
//            this.linkCreateAccount.AutoSize = true;
//            this.linkCreateAccount.Font = new System.Drawing.Font("Segoe UI", 10F);
//            this.linkCreateAccount.Location = new System.Drawing.Point(213, 351);
//            this.linkCreateAccount.Name = "linkCreateAccount";
//            this.linkCreateAccount.Size = new System.Drawing.Size(162, 23);
//            this.linkCreateAccount.TabIndex = 6;
//            this.linkCreateAccount.TabStop = true;
//            this.linkCreateAccount.Text = "Create new account";
//            this.linkCreateAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkCreateAccount_LinkClicked);
//            // 
//            // btnLogin
//            // 
//            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 14F);
//            this.btnLogin.Location = new System.Drawing.Point(230, 260);
//            this.btnLogin.Name = "btnLogin";
//            this.btnLogin.Size = new System.Drawing.Size(140, 50);
//            this.btnLogin.TabIndex = 5;
//            this.btnLogin.Text = "Login";
//            this.btnLogin.UseVisualStyleBackColor = true;
//            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
//            // 
//            // txtPassword
//            // 
//            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 14F);
//            this.txtPassword.Location = new System.Drawing.Point(180, 175);
//            this.txtPassword.Name = "txtPassword";
//            this.txtPassword.Size = new System.Drawing.Size(250, 39);
//            this.txtPassword.TabIndex = 4;
//            this.txtPassword.UseSystemPasswordChar = true;
//            // 
//            // lblPassword
//            // 
//            this.lblPassword.AutoSize = true;
//            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 14F);
//            this.lblPassword.Location = new System.Drawing.Point(50, 180);
//            this.lblPassword.Name = "lblPassword";
//            this.lblPassword.Size = new System.Drawing.Size(111, 32);
//            this.lblPassword.TabIndex = 3;
//            this.lblPassword.Text = "Password";
//            // 
//            // txtUsername
//            // 
//            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 14F);
//            this.txtUsername.Location = new System.Drawing.Point(180, 95);
//            this.txtUsername.Name = "txtUsername";
//            this.txtUsername.Size = new System.Drawing.Size(250, 39);
//            this.txtUsername.TabIndex = 2;
//            // 
//            // lblUsername
//            // 
//            this.lblUsername.AutoSize = true;
//            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 14F);
//            this.lblUsername.Location = new System.Drawing.Point(50, 100);
//            this.lblUsername.Name = "lblUsername";
//            this.lblUsername.Size = new System.Drawing.Size(121, 32);
//            this.lblUsername.TabIndex = 1;
//            this.lblUsername.Text = "Username";
//            // 
//            // lblHeader
//            // 
//            this.lblHeader.AutoSize = true;
//            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
//            this.lblHeader.Location = new System.Drawing.Point(230, 20);
//            this.lblHeader.Name = "lblHeader";
//            this.lblHeader.Size = new System.Drawing.Size(145, 54);
//            this.lblHeader.TabIndex = 0;
//            this.lblHeader.Text = "LOGIN";
//            // 
//            // Login
//            // 
//            this.ClientSize = new System.Drawing.Size(1920, 1055);
//            this.Controls.Add(this.panel1);
//            this.Name = "Login";
//            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
//            this.Text = "Login";
//            this.panel1.ResumeLayout(false);
//            this.panel1.PerformLayout();
//            this.ResumeLayout(false);

//        }
//    }
//}
using System.Drawing;
using System.Windows.Forms;

namespace employee_management_system.views
{
    partial class Login
    {
        private System.ComponentModel.IContainer components = null;

        private Guna.UI2.WinForms.Guna2Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2BorderlessForm borderlessForm;
        private System.Windows.Forms.LinkLabel linkCreateAccount;
        private Guna.UI2.WinForms.Guna2ImageButton btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;

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
            this.btnClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.linkCreateAccount = new System.Windows.Forms.LinkLabel();
            this.borderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BorderRadius = 20;
            this.panel1.BorderThickness = 1;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.linkCreateAccount);
            this.panel1.FillColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(448, 250);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1055, 500);
            this.panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.CheckedState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnClose.HoverState.ImageSize = new System.Drawing.Size(32, 32);
            this.btnClose.Image = global::employee_management_system.Properties.Resources.close_image;
            this.btnClose.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnClose.ImageRotate = 0F;
            this.btnClose.ImageSize = new System.Drawing.Size(30, 30);
            this.btnClose.Location = new System.Drawing.Point(1012, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedState.ImageSize = new System.Drawing.Size(28, 28);
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 6;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::employee_management_system.Properties.Resources.login_image;
            this.pictureBox1.Location = new System.Drawing.Point(542, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(489, 463);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = false;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.lblTitle.Location = new System.Drawing.Point(70, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Welcome Back";
            this.lblTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUsername
            // 
            this.txtUsername.BorderRadius = 10;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtUsername.Location = new System.Drawing.Point(70, 138);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PlaceholderText = "Username";
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(400, 45);
            this.txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderRadius = 10;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPassword.Location = new System.Drawing.Point(70, 195);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(400, 45);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BorderRadius = 10;
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 14F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(70, 276);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(400, 50);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // linkCreateAccount
            // 
            this.linkCreateAccount.AutoSize = true;
            this.linkCreateAccount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.linkCreateAccount.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.linkCreateAccount.Location = new System.Drawing.Point(183, 363);
            this.linkCreateAccount.Name = "linkCreateAccount";
            this.linkCreateAccount.Size = new System.Drawing.Size(162, 23);
            this.linkCreateAccount.TabIndex = 4;
            this.linkCreateAccount.TabStop = true;
            this.linkCreateAccount.Text = "Create new account";
            this.linkCreateAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkCreateAccount_LinkClicked);
            // 
            // borderlessForm
            // 
            this.borderlessForm.ContainerControl = this;
            this.borderlessForm.DockIndicatorTransparencyValue = 0.5D;
            this.borderlessForm.TransparentWhileDrag = true;
            // 
            // Login
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
