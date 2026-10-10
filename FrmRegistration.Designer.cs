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
            lblRegistration.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegistration.Location = new Point(14, 24);
            lblRegistration.Name = "lblRegistration";
            lblRegistration.Size = new Size(102, 19);
            lblRegistration.TabIndex = 0;
            lblRegistration.Text = "Registration";
            // 
            // lblStudentNo
            // 
            lblStudentNo.AutoSize = true;
            lblStudentNo.Font = new Font("Arial", 12F);
            lblStudentNo.Location = new Point(15, 58);
            lblStudentNo.Name = "lblStudentNo";
            lblStudentNo.Size = new Size(89, 18);
            lblStudentNo.TabIndex = 1;
            lblStudentNo.Text = "Student No.";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Arial", 12F);
            lblLastName.Location = new Point(20, 102);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(84, 18);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Arial", 12F);
            lblAge.Location = new Point(56, 152);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(37, 18);
            lblAge.TabIndex = 3;
            lblAge.Text = "Age";
            // 
            // lblBirthday
            // 
            lblBirthday.AutoSize = true;
            lblBirthday.Font = new Font("Arial", 12F);
            lblBirthday.Location = new Point(39, 205);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(65, 18);
            lblBirthday.TabIndex = 4;
            lblBirthday.Text = "Birthday";
            // 
            // lblPrograms
            // 
            lblPrograms.AutoSize = true;
            lblPrograms.Font = new Font("Arial", 12F);
            lblPrograms.Location = new Point(354, 58);
            lblPrograms.Name = "lblPrograms";
            lblPrograms.Size = new Size(69, 18);
            lblPrograms.TabIndex = 5;
            lblPrograms.Text = "Program";
            // 
            // txtStudentNo
            // 
            txtStudentNo.Font = new Font("Arial", 12F);
            txtStudentNo.Location = new Point(113, 55);
            txtStudentNo.Name = "txtStudentNo";
            txtStudentNo.Size = new Size(201, 26);
            txtStudentNo.TabIndex = 6;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Arial", 12F);
            txtLastName.Location = new Point(113, 105);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(201, 26);
            txtLastName.TabIndex = 7;
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Arial", 12F);
            txtAge.Location = new Point(113, 152);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(87, 26);
            txtAge.TabIndex = 8;
            // 
            // cbPrograms
            // 
            cbPrograms.Font = new Font("Arial", 12F);
            cbPrograms.FormattingEnabled = true;
            cbPrograms.Location = new Point(443, 55);
            cbPrograms.Name = "cbPrograms";
            cbPrograms.Size = new Size(326, 26);
            cbPrograms.TabIndex = 9;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Arial", 12F);
            lblFirstName.Location = new Point(338, 108);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(85, 18);
            lblFirstName.TabIndex = 10;
            lblFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Arial", 12F);
            txtFirstName.Location = new Point(443, 105);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(188, 26);
            txtFirstName.TabIndex = 11;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Arial", 12F);
            lblGender.Location = new Point(367, 160);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(60, 18);
            lblGender.TabIndex = 12;
            lblGender.Text = "Gender";
            // 
            // cbGender
            // 
            cbGender.Font = new Font("Arial", 12F);
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Male", "Female" });
            cbGender.Location = new Point(443, 157);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(133, 26);
            cbGender.TabIndex = 13;
            // 
            // dtpBirthday
            // 
            dtpBirthday.CalendarFont = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpBirthday.Font = new Font("Arial", 12F);
            dtpBirthday.Location = new Point(113, 199);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(263, 26);
            dtpBirthday.TabIndex = 14;
            // 
            // lblMiddleName
            // 
            lblMiddleName.AutoSize = true;
            lblMiddleName.Font = new Font("Arial", 12F);
            lblMiddleName.Location = new Point(651, 108);
            lblMiddleName.Name = "lblMiddleName";
            lblMiddleName.Size = new Size(32, 18);
            lblMiddleName.TabIndex = 15;
            lblMiddleName.Text = "M.I.";
            // 
            // txtMiddleInitial
            // 
            txtMiddleInitial.Font = new Font("Arial", 12F);
            txtMiddleInitial.Location = new Point(682, 102);
            txtMiddleInitial.Name = "txtMiddleInitial";
            txtMiddleInitial.Size = new Size(87, 26);
            txtMiddleInitial.TabIndex = 16;
            // 
            // txtContactNo
            // 
            txtContactNo.Font = new Font("Arial", 12F);
            txtContactNo.Location = new Point(534, 197);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(212, 26);
            txtContactNo.TabIndex = 18;
            // 
            // lblContactNo
            // 
            lblContactNo.AutoSize = true;
            lblContactNo.Font = new Font("Arial", 12F);
            lblContactNo.Location = new Point(438, 202);
            lblContactNo.Name = "lblContactNo";
            lblContactNo.Size = new Size(90, 18);
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
            btnRegister.Location = new Point(338, 255);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(121, 32);
            btnRegister.TabIndex = 19;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // FrmRegistration
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(776, 296);
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
            Font = new Font("Arial", 12F);
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