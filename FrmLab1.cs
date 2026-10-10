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
            FrmFileName fileNameForm = new FrmFileName();
            fileNameForm.ShowDialog();

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

        }
    }
}
