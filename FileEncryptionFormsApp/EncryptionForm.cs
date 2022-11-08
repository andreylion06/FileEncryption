using FileEncryptionClassLibrary;

namespace FileEncryptionFormsApp
{
    public partial class EncryptionForm : Form
    {
        public EncryptionForm()
        {
            InitializeComponent();
        }

        private void button_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                textBox_FilePath.Text = ofd.FileName;
            }
        }

        private FileEncription encr;
        private void button_Start_Click(object sender, EventArgs e)
        {
            if (textBox_FilePath.Text == String.Empty)
            {
                FailOutput("File for encryption was not selected");
                return;
            }
            if(textBox_Password.Text == String.Empty)
            {
                FailOutput("Password was not set");
                return;
            }
            textBox_Password.Enabled = false;

            encr = new FileEncription(textBox_FilePath.Text, textBox_Password.Text);
            encr.ProgressChangedAction = () => backgroundWorker.ReportProgress(encr.Progress);
            backgroundWorker.RunWorkerAsync();
        }

        private void FailOutput(string message)
        {
            MessageBox.Show(message, "Fail", MessageBoxButtons.OK);
        }

        private void backgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            encr.CryptOrUncrypt();
        }

        private void backgroundWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            label_Progress.Text = $"Progress: {e.ProgressPercentage}%";

            if(e.ProgressPercentage == 100)
            {
                // show info
                // empty objects
            }
        }
    }
}