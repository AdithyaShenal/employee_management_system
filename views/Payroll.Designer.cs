namespace employee_management_system.views
{
    partial class Payroll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payroll));
            this.panel1 = new System.Windows.Forms.Panel();
            this.search_button = new System.Windows.Forms.Button();
            this.userinput_textbox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.information_panel = new System.Windows.Forms.Panel();
            this.navigator = new System.Windows.Forms.Panel();
            this.adminname_textbox = new System.Windows.Forms.TextBox();
            this.home_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.emp_name_label = new System.Windows.Forms.Label();
            this.empid_label = new System.Windows.Forms.Label();
            this.empfaculty_label = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.emp_grade_label = new System.Windows.Forms.Label();
            this.basic_salary_label = new System.Windows.Forms.Label();
            this.basic_salary_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bonus_label = new System.Windows.Forms.Label();
            this.tansport_label = new System.Windows.Forms.Label();
            this.increment_textbox = new System.Windows.Forms.TextBox();
            this.bonus_textbox = new System.Windows.Forms.TextBox();
            this.transport_textbox = new System.Windows.Forms.TextBox();
            this.Christmas_label = new System.Windows.Forms.Label();
            this.net_label = new System.Windows.Forms.Label();
            this.Christmas_textbox = new System.Windows.Forms.TextBox();
            this.net_textbox = new System.Windows.Forms.TextBox();
            this.update_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.history_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.information_panel.SuspendLayout();
            this.navigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.history_button);
            this.panel1.Controls.Add(this.save_button);
            this.panel1.Controls.Add(this.update_button);
            this.panel1.Controls.Add(this.search_button);
            this.panel1.Controls.Add(this.userinput_textbox);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.information_panel);
            this.panel1.Controls.Add(this.navigator);
            this.panel1.Location = new System.Drawing.Point(-4, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1338, 769);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // search_button
            // 
            this.search_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_button.Location = new System.Drawing.Point(517, 155);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(105, 28);
            this.search_button.TabIndex = 4;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            // 
            // userinput_textbox
            // 
            this.userinput_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userinput_textbox.Location = new System.Drawing.Point(301, 155);
            this.userinput_textbox.Name = "userinput_textbox";
            this.userinput_textbox.Size = new System.Drawing.Size(173, 24);
            this.userinput_textbox.TabIndex = 3;
            this.userinput_textbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Employee name",
            "Employee ID"});
            this.comboBox1.Location = new System.Drawing.Point(39, 155);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 28);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "Employee ID";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select Option";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // information_panel
            // 
            this.information_panel.BackColor = System.Drawing.Color.White;
            this.information_panel.Controls.Add(this.net_textbox);
            this.information_panel.Controls.Add(this.Christmas_textbox);
            this.information_panel.Controls.Add(this.net_label);
            this.information_panel.Controls.Add(this.Christmas_label);
            this.information_panel.Controls.Add(this.transport_textbox);
            this.information_panel.Controls.Add(this.bonus_textbox);
            this.information_panel.Controls.Add(this.increment_textbox);
            this.information_panel.Controls.Add(this.tansport_label);
            this.information_panel.Controls.Add(this.bonus_label);
            this.information_panel.Controls.Add(this.label3);
            this.information_panel.Controls.Add(this.basic_salary_textbox);
            this.information_panel.Controls.Add(this.basic_salary_label);
            this.information_panel.Controls.Add(this.emp_grade_label);
            this.information_panel.Controls.Add(this.richTextBox1);
            this.information_panel.Controls.Add(this.empfaculty_label);
            this.information_panel.Controls.Add(this.empid_label);
            this.information_panel.Controls.Add(this.emp_name_label);
            this.information_panel.Location = new System.Drawing.Point(39, 234);
            this.information_panel.Name = "information_panel";
            this.information_panel.Size = new System.Drawing.Size(1262, 404);
            this.information_panel.TabIndex = 1;
            this.information_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.information_panel_Paint);
            // 
            // navigator
            // 
            this.navigator.BackColor = System.Drawing.Color.Teal;
            this.navigator.Controls.Add(this.adminname_textbox);
            this.navigator.Controls.Add(this.home_button);
            this.navigator.Controls.Add(this.label1);
            this.navigator.Location = new System.Drawing.Point(3, 3);
            this.navigator.Name = "navigator";
            this.navigator.Size = new System.Drawing.Size(1335, 91);
            this.navigator.TabIndex = 0;
            this.navigator.Paint += new System.Windows.Forms.PaintEventHandler(this.navigator_Paint);
            // 
            // adminname_textbox
            // 
            this.adminname_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminname_textbox.Location = new System.Drawing.Point(1130, 30);
            this.adminname_textbox.Name = "adminname_textbox";
            this.adminname_textbox.Size = new System.Drawing.Size(191, 34);
            this.adminname_textbox.TabIndex = 2;
            this.adminname_textbox.Text = "Mr. Adithya";
            // 
            // home_button
            // 
            this.home_button.BackColor = System.Drawing.Color.Teal;
            this.home_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("home_button.BackgroundImage")));
            this.home_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.home_button.Location = new System.Drawing.Point(995, 21);
            this.home_button.Margin = new System.Windows.Forms.Padding(0);
            this.home_button.Name = "home_button";
            this.home_button.Size = new System.Drawing.Size(62, 61);
            this.home_button.TabIndex = 1;
            this.home_button.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payroll Management";
            // 
            // emp_name_label
            // 
            this.emp_name_label.AutoSize = true;
            this.emp_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_name_label.Location = new System.Drawing.Point(26, 23);
            this.emp_name_label.Name = "emp_name_label";
            this.emp_name_label.Size = new System.Drawing.Size(127, 25);
            this.emp_name_label.TabIndex = 0;
            this.emp_name_label.Text = "Dr. Jhon Doe";
            // 
            // empid_label
            // 
            this.empid_label.AutoSize = true;
            this.empid_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empid_label.Location = new System.Drawing.Point(284, 23);
            this.empid_label.Name = "empid_label";
            this.empid_label.Size = new System.Drawing.Size(78, 25);
            this.empid_label.TabIndex = 1;
            this.empid_label.Text = "100002";
            this.empid_label.Click += new System.EventHandler(this.empid_label_Click);
            // 
            // empfaculty_label
            // 
            this.empfaculty_label.AutoSize = true;
            this.empfaculty_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empfaculty_label.Location = new System.Drawing.Point(486, 24);
            this.empfaculty_label.Name = "empfaculty_label";
            this.empfaculty_label.Size = new System.Drawing.Size(0, 25);
            this.empfaculty_label.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(507, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(371, 57);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = " Science Faculty/ Department of \nComputer Science";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // emp_grade_label
            // 
            this.emp_grade_label.AutoSize = true;
            this.emp_grade_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.emp_grade_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_grade_label.Location = new System.Drawing.Point(1021, 23);
            this.emp_grade_label.Name = "emp_grade_label";
            this.emp_grade_label.Size = new System.Drawing.Size(88, 25);
            this.emp_grade_label.TabIndex = 5;
            this.emp_grade_label.Text = "Grade03";
            this.emp_grade_label.Click += new System.EventHandler(this.emp_grade_label_Click);
            // 
            // basic_salary_label
            // 
            this.basic_salary_label.AutoSize = true;
            this.basic_salary_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basic_salary_label.Location = new System.Drawing.Point(27, 134);
            this.basic_salary_label.Name = "basic_salary_label";
            this.basic_salary_label.Size = new System.Drawing.Size(104, 20);
            this.basic_salary_label.TabIndex = 6;
            this.basic_salary_label.Text = "Basic Salary";
            // 
            // basic_salary_textbox
            // 
            this.basic_salary_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basic_salary_textbox.Location = new System.Drawing.Point(31, 168);
            this.basic_salary_textbox.Name = "basic_salary_textbox";
            this.basic_salary_textbox.Size = new System.Drawing.Size(190, 27);
            this.basic_salary_textbox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(503, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = " Personalized Increment";
            // 
            // bonus_label
            // 
            this.bonus_label.AutoSize = true;
            this.bonus_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bonus_label.Location = new System.Drawing.Point(988, 147);
            this.bonus_label.Name = "bonus_label";
            this.bonus_label.Size = new System.Drawing.Size(139, 20);
            this.bonus_label.TabIndex = 9;
            this.bonus_label.Text = " New Year Bonus";
            // 
            // tansport_label
            // 
            this.tansport_label.AutoSize = true;
            this.tansport_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tansport_label.Location = new System.Drawing.Point(27, 273);
            this.tansport_label.Name = "tansport_label";
            this.tansport_label.Size = new System.Drawing.Size(162, 20);
            this.tansport_label.TabIndex = 10;
            this.tansport_label.Text = "Transport Allowance";
            this.tansport_label.Click += new System.EventHandler(this.tansport_label_Click);
            // 
            // increment_textbox
            // 
            this.increment_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.increment_textbox.Location = new System.Drawing.Point(507, 180);
            this.increment_textbox.Name = "increment_textbox";
            this.increment_textbox.Size = new System.Drawing.Size(190, 27);
            this.increment_textbox.TabIndex = 11;
            this.increment_textbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // bonus_textbox
            // 
            this.bonus_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bonus_textbox.Location = new System.Drawing.Point(992, 180);
            this.bonus_textbox.Name = "bonus_textbox";
            this.bonus_textbox.Size = new System.Drawing.Size(190, 27);
            this.bonus_textbox.TabIndex = 12;
            // 
            // transport_textbox
            // 
            this.transport_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transport_textbox.Location = new System.Drawing.Point(31, 309);
            this.transport_textbox.Name = "transport_textbox";
            this.transport_textbox.Size = new System.Drawing.Size(190, 27);
            this.transport_textbox.TabIndex = 13;
            this.transport_textbox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Christmas_label
            // 
            this.Christmas_label.AutoSize = true;
            this.Christmas_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Christmas_label.Location = new System.Drawing.Point(503, 273);
            this.Christmas_label.Name = "Christmas_label";
            this.Christmas_label.Size = new System.Drawing.Size(172, 20);
            this.Christmas_label.TabIndex = 14;
            this.Christmas_label.Text = " Christmas Allowance";
            // 
            // net_label
            // 
            this.net_label.AutoSize = true;
            this.net_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.net_label.Location = new System.Drawing.Point(988, 273);
            this.net_label.Name = "net_label";
            this.net_label.Size = new System.Drawing.Size(87, 20);
            this.net_label.TabIndex = 15;
            this.net_label.Text = "Net Salary";
            // 
            // Christmas_textbox
            // 
            this.Christmas_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Christmas_textbox.Location = new System.Drawing.Point(507, 309);
            this.Christmas_textbox.Name = "Christmas_textbox";
            this.Christmas_textbox.Size = new System.Drawing.Size(190, 27);
            this.Christmas_textbox.TabIndex = 16;
            // 
            // net_textbox
            // 
            this.net_textbox.BackColor = System.Drawing.Color.Gray;
            this.net_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.net_textbox.Location = new System.Drawing.Point(992, 318);
            this.net_textbox.Name = "net_textbox";
            this.net_textbox.Size = new System.Drawing.Size(190, 27);
            this.net_textbox.TabIndex = 17;
            // 
            // update_button
            // 
            this.update_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_button.Location = new System.Drawing.Point(39, 683);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(105, 41);
            this.update_button.TabIndex = 5;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = true;
            // 
            // save_button
            // 
            this.save_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_button.Location = new System.Drawing.Point(195, 683);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(111, 41);
            this.save_button.TabIndex = 6;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            // 
            // history_button
            // 
            this.history_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.history_button.Location = new System.Drawing.Point(546, 683);
            this.history_button.Name = "history_button";
            this.history_button.Size = new System.Drawing.Size(111, 41);
            this.history_button.TabIndex = 7;
            this.history_button.Text = "History";
            this.history_button.UseVisualStyleBackColor = true;
            // 
            // Payroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 768);
            this.Controls.Add(this.panel1);
            this.Name = "Payroll";
            this.Text = "Payroll";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.information_panel.ResumeLayout(false);
            this.information_panel.PerformLayout();
            this.navigator.ResumeLayout(false);
            this.navigator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel navigator;
        private System.Windows.Forms.Button home_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox adminname_textbox;
        private System.Windows.Forms.Panel information_panel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox userinput_textbox;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Label emp_name_label;
        private System.Windows.Forms.Label empfaculty_label;
        private System.Windows.Forms.Label empid_label;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label emp_grade_label;
        private System.Windows.Forms.TextBox basic_salary_textbox;
        private System.Windows.Forms.Label basic_salary_label;
        private System.Windows.Forms.Label tansport_label;
        private System.Windows.Forms.Label bonus_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox transport_textbox;
        private System.Windows.Forms.TextBox bonus_textbox;
        private System.Windows.Forms.TextBox increment_textbox;
        private System.Windows.Forms.TextBox net_textbox;
        private System.Windows.Forms.TextBox Christmas_textbox;
        private System.Windows.Forms.Label net_label;
        private System.Windows.Forms.Label Christmas_label;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button history_button;
    }
}