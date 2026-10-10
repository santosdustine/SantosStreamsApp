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
            txtFileName.Location = new Point(11, 75);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(298, 28);
            txtFileName.TabIndex = 0;
            // 
            // btnOkay
            // 
            btnOkay.BackColor = Color.DarkGray;
            btnOkay.FlatAppearance.BorderColor = Color.Gray;
            btnOkay.FlatStyle = FlatStyle.Flat;
            btnOkay.Location = new Point(110, 129);
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
            lblFileName.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFileName.Location = new Point(11, 23);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new Size(151, 23);
            lblFileName.TabIndex = 2;
            lblFileName.Text = "Enter File Name";
            // 
            // FrmFileName
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(321, 184);
            Controls.Add(lblFileName);
            Controls.Add(btnOkay);
            Controls.Add(txtFileName);
            Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmFileName";
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