using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SantosStreamsApp
{
    
    public partial class FrmFileName : Form
    {
        public static string SetFileName;
        public FrmFileName()
        {
            InitializeComponent();
            SetFileName = null;
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFileName.Text))
            {
                MessageBox.Show("Please enter a valid file name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }   

            SetFileName = txtFileName.Text + ".txt";
            MessageBox.Show("Registered! File saved as " + SetFileName);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
