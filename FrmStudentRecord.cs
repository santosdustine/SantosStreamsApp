using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SantosStreamsApp
{
    public partial class FrmStudentRecord : Form
    {
        public FrmStudentRecord()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Path.Combine(
           Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
           "Santos_Dustine_LabStream");
            openFileDialog1.Title = "Find Student Record";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;

            lvRecord.Items.Clear();

            try
            {
                foreach (string line in File.ReadLines(openFileDialog1.FileName))
                    lvRecord.Items.Add(line);
            }
            catch (IOException ex)
            {
                MessageBox.Show("Cannot read the file: " + ex.Message, "Error");
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully Uploaded!");
            lvRecord.Items.Clear();
        }
    }
}
