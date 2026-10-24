namespace SantosStreamsApp
{
    partial class FrmStudentRecord
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
            lvRecord = new ListView();
            lblViewRecord = new Label();
            btnRegister = new Button();
            btnFind = new Button();
            openFileDialog1 = new OpenFileDialog();
            btnUpload = new Button();
            SuspendLayout();
            // 
            // lvRecord
            // 
            lvRecord.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lvRecord.Location = new Point(12, 51);
            lvRecord.Name = "lvRecord";
            lvRecord.Size = new Size(377, 190);
            lvRecord.TabIndex = 0;
            lvRecord.UseCompatibleStateImageBehavior = false;
            lvRecord.View = View.List;
            // 
            // lblViewRecord
            // 
            lblViewRecord.AutoSize = true;
            lblViewRecord.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblViewRecord.Location = new Point(12, 21);
            lblViewRecord.Name = "lblViewRecord";
            lblViewRecord.Size = new Size(119, 22);
            lblViewRecord.TabIndex = 1;
            lblViewRecord.Text = "View Record";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Red;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Arial", 11.25F);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(395, 52);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(117, 31);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnFind
            // 
            btnFind.BackColor = Color.Red;
            btnFind.FlatAppearance.BorderSize = 0;
            btnFind.FlatStyle = FlatStyle.Flat;
            btnFind.Font = new Font("Arial", 11.25F);
            btnFind.ForeColor = Color.White;
            btnFind.Location = new Point(395, 94);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(117, 31);
            btnFind.TabIndex = 3;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnUpload
            // 
            btnUpload.BackColor = Color.Red;
            btnUpload.FlatAppearance.BorderSize = 0;
            btnUpload.FlatStyle = FlatStyle.Flat;
            btnUpload.Font = new Font("Arial", 11.25F);
            btnUpload.ForeColor = Color.White;
            btnUpload.Location = new Point(395, 136);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(117, 31);
            btnUpload.TabIndex = 3;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = false;
            btnUpload.Click += btnUpload_Click;
            // 
            // FrmStudentRecord
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(520, 254);
            Controls.Add(btnFind);
            Controls.Add(btnUpload);
            Controls.Add(btnRegister);
            Controls.Add(lblViewRecord);
            Controls.Add(lvRecord);
            Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmStudentRecord";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmStudentRecord";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvRecord;
        private Label lblViewRecord;
        private Button btnRegister;
        private Button btnFind;
        private OpenFileDialog openFileDialog1;
        private Button btnUpload;
    }
}