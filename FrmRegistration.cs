using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace SantosStreamsApp
{
    public partial class FrmRegistration : Form
    {
        private string _FullName;
        private int _Age;
        private long _ContactNo;
        private long _StudentNo;
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {
            string[] ListOfProgram = new string[] {
                "BS Information Technology",
                "BS Computer Science",
                "BS Information Systems",
                "BS in Accountancy",
                "BS in Hospitality Management",
                "BS in Tourism Management"
            };
            for (int i = 0; i < 6; i++)
            {
                cbPrograms.Items.Add(ListOfProgram[i].ToString());
            }
        }
      
        private void ResetFields()
        {
            txtStudentNo.Clear();
            txtLastName.Clear();
            txtFirstName.Clear();
            txtMiddleInitial.Clear();
            txtAge.Clear();
            txtContactNo.Clear();
            cbPrograms.SelectedIndex = -1;
            cbGender.SelectedIndex = -1;
            dtpBirthday.Value = DateTime.Now;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string mi = txtMiddleInitial.Text.Trim();
            try
            {
                if (!long.TryParse(txtStudentNo.Text, out long studentNumber))
                    throw new FormatException("Invalid Input. Letters/Special characters are not allowed.");

                if (string.IsNullOrWhiteSpace(txtLastName.Text) || !txtLastName.Text.All(character => char.IsLetter(character) || character == ' '))
                    throw new FormatException("Invalid input. Numbers/Special characters are not allowed.");

                if (string.IsNullOrWhiteSpace(txtFirstName.Text) || !txtFirstName.Text.All(character => char.IsLetter(character) || character == ' '))
                    throw new FormatException("Invalid input. Numbers/Special characters are not allowed.");

                if (!int.TryParse(txtAge.Text, out int age))
                    throw new FormatException("Invalid Input.  Letters/Special characters are not allowed.");

                if (cbGender.SelectedIndex == -1)
                    throw new FormatException("Gender cannot be empty.");

                if (cbPrograms.SelectedIndex == -1)
                    throw new FormatException("Program cannot be empty.");

                if (dtpBirthday.Value.Date > DateTime.Today)
                    throw new FormatException("Invalid birthday. Past to present date only.");

                if (string.IsNullOrWhiteSpace(txtContactNo.Text) || !txtContactNo.Text.All(char.IsDigit))
                    throw new FormatException("Invalid contact number. Letters/Special characters are not allowed.");

                if (mi != "" && !System.Text.RegularExpressions.Regex.IsMatch(mi, @"^[A-Za-z]\.?$"))
                {
                    MessageBox.Show("Middle initial must be letter only.");
                    txtMiddleInitial.Focus();
                    return;   
                }

                string fileName = txtStudentNo.Text + ".txt";

            string folderPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "Santos_Dustine_LabStream");
                 Directory.CreateDirectory(folderPath);
               
                string[] lines =
           {
                "Student No.: " + txtStudentNo.Text,
                "Full Name: " + txtLastName.Text + ", " + txtFirstName.Text + ", " + txtMiddleInitial.Text+ ".",
                "Program: " + cbPrograms.Text,
                "Gender: " + cbGender.Text,
                "Age: " + txtAge.Text,
                "Birthday: " + dtpBirthday.Value.ToString("yyyy-MM-dd"),
                "Contact No.: " + txtContactNo.Text
           };
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(folderPath, fileName)))
            {
                foreach (string line in lines)
                {
                    outputFile.WriteLine(line);
                }
            }
            MessageBox.Show("Registered! File saved as " + fileName);
                ResetFields();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
          
        }

    }
}
