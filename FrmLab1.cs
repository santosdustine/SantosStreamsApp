using System.IO;

namespace SantosStreamsApp

{
    public partial class FrmLab1 : Form
    {
        public FrmLab1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                FrmFileName frmName = new FrmFileName();
                frmName.ShowDialog();


                string getInput = txtInput.Text;
                string folderPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "Santos_Dustine_LabStream");
                Directory.CreateDirectory(folderPath);

                using (StreamWriter outputFile = new StreamWriter(Path.Combine(folderPath, FrmFileName.SetFileName)))
                {
                    outputFile.WriteLine(getInput);
                    Console.WriteLine(getInput);
                }
                txtInput.Clear();
            }

            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}