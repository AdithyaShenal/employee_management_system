// File: EmployeeDetailsForm.Designer.cs
namespace employee_management_system
{
    partial class EmployeeDetailsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.picUserProfile = new System.Windows.Forms.PictureBox();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.lblIDValue = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblJob = new System.Windows.Forms.Label();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblRegisteredDate = new System.Windows.Forms.Label();
            this.dtpRegisteredDate = new System.Windows.Forms.DateTimePicker();
            this.lblDependentName = new System.Windows.Forms.Label();
            this.txtDependentName = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblGrade = new System.Windows.Forms.Label();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lblDependentContact = new System.Windows.Forms.Label();
            this.txtDependentContact = new System.Windows.Forms.TextBox();
            this.picProfileImage = new System.Windows.Forms.PictureBox();
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.grpEmployeeInformation = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProfileImage)).BeginInit();
            this.grpEmployeeInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(148)))), ((int)(((byte)(106)))));
            this.panelHeader.Controls.Add(this.button1);
            this.panelHeader.Controls.Add(this.btnHome);
            this.panelHeader.Controls.Add(this.lblUserRole);
            this.panelHeader.Controls.Add(this.lblUserName);
            this.panelHeader.Controls.Add(this.picUserProfile);
            this.panelHeader.Controls.Add(this.lblHeaderTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1045, 70);
            this.panelHeader.TabIndex = 13;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(700, 15);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(40, 40);
            this.btnHome.TabIndex = 5;
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // lblUserRole
            // 
            this.lblUserRole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserRole.AutoSize = true;
            this.lblUserRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserRole.ForeColor = System.Drawing.Color.LightGray;
            this.lblUserRole.Location = new System.Drawing.Point(951, 42);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(36, 13);
            this.lblUserRole.TabIndex = 4;
            this.lblUserRole.Text = "Admin";
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(881, 20);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(136, 16);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "Mr. Adithya Shenal";
            // 
            // picUserProfile
            // 
            this.picUserProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picUserProfile.BackColor = System.Drawing.Color.Transparent;
            this.picUserProfile.Location = new System.Drawing.Point(823, 15);
            this.picUserProfile.Name = "picUserProfile";
            this.picUserProfile.Size = new System.Drawing.Size(40, 40);
            this.picUserProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUserProfile.TabIndex = 2;
            this.picUserProfile.TabStop = false;
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTitle.Location = new System.Drawing.Point(20, 20);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(300, 29);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "Employees Management";
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeID.Location = new System.Drawing.Point(20, 30);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(88, 16);
            this.lblEmployeeID.TabIndex = 0;
            this.lblEmployeeID.Text = "Employee ID:";
            // 
            // lblIDValue
            // 
            this.lblIDValue.Location = new System.Drawing.Point(130, 27);
            this.lblIDValue.Name = "lblIDValue";
            this.lblIDValue.Size = new System.Drawing.Size(200, 22);
            this.lblIDValue.TabIndex = 0;
            this.lblIDValue.Text = "10001";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(20, 70);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(71, 16);
            this.lblFullName.TabIndex = 1;
            this.lblFullName.Text = "Full Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(130, 67);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(300, 22);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "Jhon Doe";
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJob.Location = new System.Drawing.Point(20, 110);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(33, 16);
            this.lblJob.TabIndex = 2;
            this.lblJob.Text = "Job:";
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(130, 107);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(300, 22);
            this.txtRole.TabIndex = 2;
            this.txtRole.Text = "Lecturer";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(20, 150);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(61, 16);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(130, 147);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(300, 40);
            this.txtAddress.TabIndex = 3;
            this.txtAddress.Text = "No 10, Malibu street, New York";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(20, 200);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 16);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(130, 197);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(300, 22);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Text = "jhondoe@gmail.com";
            // 
            // lblRegisteredDate
            // 
            this.lblRegisteredDate.AutoSize = true;
            this.lblRegisteredDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisteredDate.Location = new System.Drawing.Point(20, 240);
            this.lblRegisteredDate.Name = "lblRegisteredDate";
            this.lblRegisteredDate.Size = new System.Drawing.Size(107, 16);
            this.lblRegisteredDate.TabIndex = 5;
            this.lblRegisteredDate.Text = "Registered date:";
            // 
            // dtpRegisteredDate
            // 
            this.dtpRegisteredDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRegisteredDate.Location = new System.Drawing.Point(130, 237);
            this.dtpRegisteredDate.Name = "dtpRegisteredDate";
            this.dtpRegisteredDate.Size = new System.Drawing.Size(200, 22);
            this.dtpRegisteredDate.TabIndex = 5;
            this.dtpRegisteredDate.Value = new System.DateTime(2030, 10, 10, 0, 0, 0, 0);
            // 
            // lblDependentName
            // 
            this.lblDependentName.AutoSize = true;
            this.lblDependentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDependentName.Location = new System.Drawing.Point(20, 280);
            this.lblDependentName.Name = "lblDependentName";
            this.lblDependentName.Size = new System.Drawing.Size(117, 16);
            this.lblDependentName.TabIndex = 6;
            this.lblDependentName.Text = "Dependent Name:";
            // 
            // txtDependentName
            // 
            this.txtDependentName.Location = new System.Drawing.Point(143, 277);
            this.txtDependentName.Name = "txtDependentName";
            this.txtDependentName.Size = new System.Drawing.Size(300, 22);
            this.txtDependentName.TabIndex = 6;
            this.txtDependentName.Text = "Mrs. Lilly White";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(450, 70);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(36, 16);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Title:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(605, 70);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(200, 22);
            this.txtTitle.TabIndex = 7;
            this.txtTitle.Text = "Dr.";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrade.Location = new System.Drawing.Point(450, 110);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(48, 16);
            this.lblGrade.TabIndex = 8;
            this.lblGrade.Text = "Grade:";
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(605, 104);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(200, 22);
            this.txtGrade.TabIndex = 8;
            this.txtGrade.Text = "II";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(450, 150);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(55, 16);
            this.lblContact.TabIndex = 9;
            this.lblContact.Text = "Contact:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(605, 142);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(200, 22);
            this.txtPhone.TabIndex = 9;
            this.txtPhone.Text = "075 412 1236";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfBirth.Location = new System.Drawing.Point(450, 190);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(82, 16);
            this.lblDateOfBirth.TabIndex = 10;
            this.lblDateOfBirth.Text = "Date of Birth:";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(605, 185);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(200, 22);
            this.dtpDateOfBirth.TabIndex = 10;
            this.dtpDateOfBirth.Value = new System.DateTime(2020, 10, 10, 0, 0, 0, 0);
            // 
            // lblDependentContact
            // 
            this.lblDependentContact.AutoSize = true;
            this.lblDependentContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDependentContact.Location = new System.Drawing.Point(450, 223);
            this.lblDependentContact.Name = "lblDependentContact";
            this.lblDependentContact.Size = new System.Drawing.Size(125, 16);
            this.lblDependentContact.TabIndex = 11;
            this.lblDependentContact.Text = "Dependent Contact:";
            this.lblDependentContact.Visible = false;
            // 
            // txtDependentContact
            // 
            this.txtDependentContact.Location = new System.Drawing.Point(605, 223);
            this.txtDependentContact.Name = "txtDependentContact";
            this.txtDependentContact.Size = new System.Drawing.Size(200, 22);
            this.txtDependentContact.TabIndex = 11;
            this.txtDependentContact.Text = "074 125 4569";
            this.txtDependentContact.Visible = false;
            // 
            // picProfileImage
            // 
            this.picProfileImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProfileImage.Location = new System.Drawing.Point(884, 90);
            this.picProfileImage.Name = "picProfileImage";
            this.picProfileImage.Size = new System.Drawing.Size(120, 120);
            this.picProfileImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProfileImage.TabIndex = 14;
            this.picProfileImage.TabStop = false;
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.Location = new System.Drawing.Point(884, 231);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(120, 25);
            this.btnUploadImage.TabIndex = 15;
            this.btnUploadImage.Text = "Upload Image";
            this.btnUploadImage.UseVisualStyleBackColor = true;
            // 
            // grpEmployeeInformation
            // 
            this.grpEmployeeInformation.Controls.Add(this.lblEmployeeID);
            this.grpEmployeeInformation.Controls.Add(this.lblIDValue);
            this.grpEmployeeInformation.Controls.Add(this.lblFullName);
            this.grpEmployeeInformation.Controls.Add(this.txtName);
            this.grpEmployeeInformation.Controls.Add(this.lblJob);
            this.grpEmployeeInformation.Controls.Add(this.txtRole);
            this.grpEmployeeInformation.Controls.Add(this.lblAddress);
            this.grpEmployeeInformation.Controls.Add(this.txtAddress);
            this.grpEmployeeInformation.Controls.Add(this.lblEmail);
            this.grpEmployeeInformation.Controls.Add(this.txtEmail);
            this.grpEmployeeInformation.Controls.Add(this.lblRegisteredDate);
            this.grpEmployeeInformation.Controls.Add(this.dtpRegisteredDate);
            this.grpEmployeeInformation.Controls.Add(this.lblDependentName);
            this.grpEmployeeInformation.Controls.Add(this.txtDependentName);
            this.grpEmployeeInformation.Controls.Add(this.lblTitle);
            this.grpEmployeeInformation.Controls.Add(this.txtTitle);
            this.grpEmployeeInformation.Controls.Add(this.lblGrade);
            this.grpEmployeeInformation.Controls.Add(this.txtGrade);
            this.grpEmployeeInformation.Controls.Add(this.lblContact);
            this.grpEmployeeInformation.Controls.Add(this.txtPhone);
            this.grpEmployeeInformation.Controls.Add(this.lblDateOfBirth);
            this.grpEmployeeInformation.Controls.Add(this.dtpDateOfBirth);
            this.grpEmployeeInformation.Controls.Add(this.lblDependentContact);
            this.grpEmployeeInformation.Controls.Add(this.txtDependentContact);
            this.grpEmployeeInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEmployeeInformation.Location = new System.Drawing.Point(25, 90);
            this.grpEmployeeInformation.Name = "grpEmployeeInformation";
            this.grpEmployeeInformation.Size = new System.Drawing.Size(821, 320);
            this.grpEmployeeInformation.TabIndex = 0;
            this.grpEmployeeInformation.TabStop = false;
            this.grpEmployeeInformation.Text = "Employee Information";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(740, 420);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 30);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(840, 420);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 30);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(701, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 35);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // EmployeeDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 480);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.grpEmployeeInformation);
            this.Controls.Add(this.btnUploadImage);
            this.Controls.Add(this.picProfileImage);
            this.Controls.Add(this.panelHeader);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmployeeDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Details";
            this.Load += new System.EventHandler(this.EmployeeDetailsForm_Load_1);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProfileImage)).EndInit();
            this.grpEmployeeInformation.ResumeLayout(false);
            this.grpEmployeeInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnHome; // Renamed
        private System.Windows.Forms.Label lblUserRole;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.PictureBox picUserProfile; // Changed to PictureBox for the icon
        private System.Windows.Forms.Label lblHeaderTitle; // Renamed
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.TextBox lblIDValue; // Added
        private System.Windows.Forms.Label lblFullName; // Renamed
        private System.Windows.Forms.TextBox txtName; // Renamed
        private System.Windows.Forms.Label lblJob; // Renamed
        private System.Windows.Forms.TextBox txtRole; // Renamed
        private System.Windows.Forms.Label lblAddress; // Added
        private System.Windows.Forms.TextBox txtAddress; // Added
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblRegisteredDate; // Added
        private System.Windows.Forms.DateTimePicker dtpRegisteredDate; // Added
        private System.Windows.Forms.Label lblDependentName; // Added
        private System.Windows.Forms.TextBox txtDependentName; // Added
        private System.Windows.Forms.Label lblTitle; // This is the 'Title' field next to 'Dr.'
        private System.Windows.Forms.TextBox txtTitle; // Added
        private System.Windows.Forms.Label lblGrade; // Added
        private System.Windows.Forms.TextBox txtGrade; // Added
        private System.Windows.Forms.Label lblContact; // Renamed
        private System.Windows.Forms.TextBox txtPhone; // Renamed
        private System.Windows.Forms.Label lblDateOfBirth; // Added
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth; // Added
        private System.Windows.Forms.Label lblDependentContact; // Added
        private System.Windows.Forms.TextBox txtDependentContact; // Added
        private System.Windows.Forms.PictureBox picProfileImage; // Added
        private System.Windows.Forms.Button btnUploadImage; // Added
        private System.Windows.Forms.GroupBox grpEmployeeInformation; // Added
        private System.Windows.Forms.Button btnUpdate; // Renamed from btnCancel
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button1;
    }
}