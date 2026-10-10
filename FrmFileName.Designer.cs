namespace SantosStreamsApp
{
    partial class FrmFileName
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
            txtFileName = new TextBox();
            btnOkay = new Button();
            lblFileName = new Label();
            SuspendLayout();
            // 
            // txtFileName
            // 
            txtFileName.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFileName.Location = new Point(9, 64);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(237, 26);
            txtFileName.TabIndex = 0;
            // 
            // btnOkay
            // 
            btnOkay.BackColor = Color.Red;
            btnOkay.FlatAppearance.BorderColor = Color.Gray;
            btnOkay.FlatStyle = FlatStyle.Flat;
            btnOkay.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOkay.ForeColor = Color.White;
            btnOkay.Location = new Point(79, 107);
            btnOkay.Name = "btnOkay";
            btnOkay.Size = new Size(88, 30);
            btnOkay.TabIndex = 1;
            btnOkay.Text = "Okay";
            btnOkay.UseVisualStyleBackColor = false;
            btnOkay.Click += btnOkay_Click;
            // 
            // lblFileName
            // 
            lblFileName.AutoSize = true;
            lblFileName.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFileName.Location = new Point(11, 23);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new Size(129, 19);
            lblFileName.TabIndex = 2;
            lblFileName.Text = "Enter File Name";
            // 
            // FrmFileName
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(254, 159);
            Controls.Add(lblFileName);
            Controls.Add(btnOkay);
            Controls.Add(txtFileName);
            Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmFileName";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmFileName";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFileName;
        private Button btnOkay;
        private Label lblFileName;
    }
}