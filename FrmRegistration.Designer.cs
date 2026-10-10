namespace SantosStreamsApp
{
    partial class FrmRegistration
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
            lblRegistration = new Label();
            lblStudentNo = new Label();
            lblLastName = new Label();
            lblAge = new Label();
            lblBirthday = new Label();
            lblPrograms = new Label();
            txtStudentNo = new TextBox();
            txtLastName = new TextBox();
            txtAge = new TextBox();
            cbPrograms = new ComboBox();
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblGender = new Label();
            cbGender = new ComboBox();
            dtpBirthday = new DateTimePicker();
            lblMiddleName = new Label();
            txtMiddleInitial = new TextBox();
            txtContactNo = new TextBox();
            lblContactNo = new Label();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // lblRegistration
            // 
            lblRegistration.AutoSize = true;
            lblRegistration.Font = new Font("Arial", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegistration.Location = new Point(27, 24);
            lblRegistration.Name = "lblRegistration";
            lblRegistration.Size = new Size(150, 27);
            lblRegistration.TabIndex = 0;
            lblRegistration.Text = "Registration";
            // 
            // lblStudentNo
            // 
            lblStudentNo.AutoSize = true;
            lblStudentNo.Location = new Point(24, 94);
            lblStudentNo.Name = "lblStudentNo";
            lblStudentNo.Size = new Size(105, 21);
            lblStudentNo.TabIndex = 1;
            lblStudentNo.Text = "Student No.";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(27, 135);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(96, 21);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(82, 181);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(41, 21);
            lblAge.TabIndex = 3;
            lblAge.Text = "Age";
            // 
            // lblBirthday
            // 
            lblBirthday.AutoSize = true;
            lblBirthday.Location = new Point(47, 228);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(76, 21);
            lblBirthday.TabIndex = 4;
            lblBirthday.Text = "Birthday";
            // 
            // lblPrograms
            // 
            lblPrograms.AutoSize = true;
            lblPrograms.Location = new Point(365, 94);
            lblPrograms.Name = "lblPrograms";
            lblPrograms.Size = new Size(78, 21);
            lblPrograms.TabIndex = 5;
            lblPrograms.Text = "Program";
            // 
            // txtStudentNo
            // 
            txtStudentNo.Font = new Font("Arial", 10.2F);
            txtStudentNo.Location = new Point(147, 91);
            txtStudentNo.Name = "txtStudentNo";
            txtStudentNo.Size = new Size(179, 27);
            txtStudentNo.TabIndex = 6;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Arial", 10.2F);
            txtLastName.Location = new Point(147, 135);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(179, 27);
            txtLastName.TabIndex = 7;
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Arial", 10.2F);
            txtAge.Location = new Point(147, 181);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(78, 27);
            txtAge.TabIndex = 8;
            // 
            // cbPrograms
            // 
            cbPrograms.Font = new Font("Arial", 10.2F);
            cbPrograms.FormattingEnabled = true;
            cbPrograms.Location = new Point(458, 91);
            cbPrograms.Name = "cbPrograms";
            cbPrograms.Size = new Size(297, 27);
            cbPrograms.TabIndex = 9;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(346, 135);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(97, 21);
            lblFirstName.TabIndex = 10;
            lblFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Arial", 10.2F);
            txtFirstName.Location = new Point(458, 135);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(168, 27);
            txtFirstName.TabIndex = 11;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(373, 184);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(70, 21);
            lblGender.TabIndex = 12;
            lblGender.Text = "Gender";
            // 
            // cbGender
            // 
            cbGender.Font = new Font("Arial", 10.2F);
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Male", "Female" });
            cbGender.Location = new Point(458, 181);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(119, 27);
            cbGender.TabIndex = 13;
            // 
            // dtpBirthday
            // 
            dtpBirthday.CalendarFont = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpBirthday.Location = new Point(147, 222);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(296, 28);
            dtpBirthday.TabIndex = 14;
            // 
            // lblMiddleName
            // 
            lblMiddleName.AutoSize = true;
            lblMiddleName.Location = new Point(636, 133);
            lblMiddleName.Name = "lblMiddleName";
            lblMiddleName.Size = new Size(39, 21);
            lblMiddleName.TabIndex = 15;
            lblMiddleName.Text = "M.I.";
            // 
            // txtMiddleInitial
            // 
            txtMiddleInitial.Font = new Font("Arial", 10.2F);
            txtMiddleInitial.Location = new Point(677, 129);
            txtMiddleInitial.Name = "txtMiddleInitial";
            txtMiddleInitial.Size = new Size(78, 27);
            txtMiddleInitial.TabIndex = 16;
            // 
            // txtContactNo
            // 
            txtContactNo.Font = new Font("Arial", 10.2F);
            txtContactNo.Location = new Point(569, 223);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(179, 27);
            txtContactNo.TabIndex = 18;
            // 
            // lblContactNo
            // 
            lblContactNo.AutoSize = true;
            lblContactNo.Location = new Point(458, 229);
            lblContactNo.Name = "lblContactNo";
            lblContactNo.Size = new Size(105, 21);
            lblContactNo.TabIndex = 17;
            lblContactNo.Text = "Contact No.";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Red;
            btnRegister.FlatAppearance.BorderColor = Color.DimGray;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(303, 302);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(164, 39);
            btnRegister.TabIndex = 19;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // FrmRegistration
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(769, 361);
            Controls.Add(btnRegister);
            Controls.Add(txtContactNo);
            Controls.Add(lblContactNo);
            Controls.Add(txtMiddleInitial);
            Controls.Add(lblMiddleName);
            Controls.Add(dtpBirthday);
            Controls.Add(cbGender);
            Controls.Add(lblGender);
            Controls.Add(txtFirstName);
            Controls.Add(lblFirstName);
            Controls.Add(cbPrograms);
            Controls.Add(txtAge);
            Controls.Add(txtLastName);
            Controls.Add(txtStudentNo);
            Controls.Add(lblPrograms);
            Controls.Add(lblBirthday);
            Controls.Add(lblAge);
            Controls.Add(lblLastName);
            Controls.Add(lblStudentNo);
            Controls.Add(lblRegistration);
            Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "FrmRegistration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmRegistration";
            Load += FrmRegistration_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRegistration;
        private Label lblStudentNo;
        private Label lblLastName;
        private Label lblAge;
        private Label lblBirthday;
        private Label lblPrograms;
        private TextBox txtStudentNo;
        private TextBox txtLastName;
        private TextBox txtAge;
        private ComboBox cbPrograms;
        private Label lblFirstName;
        private TextBox txtFirstName;
        private Label lblGender;
        private ComboBox cbGender;
        private DateTimePicker dtpBirthday;
        private Label lblMiddleName;
        private TextBox txtMiddleInitial;
        private TextBox txtContactNo;
        private Label lblContactNo;
        private Button btnRegister;
    }
}