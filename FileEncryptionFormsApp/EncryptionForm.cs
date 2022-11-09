using FileEncryptionClassLibrary;
using System.Diagnostics;

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
                string fileName = ofd.FileName;
                textBox_FilePath.Text = fileName;

                button_Start.Enabled = true;
                button_Start.Text = 
                    (FileEncription.IsFileEncrypted(fileName) ? "Decrypt" : "Encrypt");
                textBox_Password.Enabled = true;
            }
        }

        private void textBox_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }

        private FileEncription encr;
        private void button_Start_Click(object sender, EventArgs e)
        {
            if(textBox_Password.Text == String.Empty)
            {
                FailOutput("Password was not set");
                return;
            }
            textBox_Password.Enabled = false;

            encr = new FileEncription(textBox_FilePath.Text, textBox_Password.Text);
            encr.ProgressChangedAction = () => backgroundWorker.ReportProgress(encr.Progress);
            backgroundWorker.RunWorkerAsync();
            timer.Start();
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
                timer.Stop();
                MessageBox.Show(
                    $"Name: {encr.FileOutPath}\n" +
                    $"Size: {Math.Round(encr.GetSizeOfFile() / 1024 / 1024.0, 2)}mb\n" +
                    $"Time: {Math.Round(time, 1)}s", 
                    "Process Information", 
                    MessageBoxButtons.OK);
                SetVisualObjToDefault();
            }
        }

        private void SetVisualObjToDefault()
        {
            textBox_FilePath.Text = String.Empty;
            textBox_Password.Text = String.Empty;
            textBox_Password.Enabled = false;
            button_Start.Enabled = false;
            button_Start.Text = "Start";
            progressBar.Value = 0;
            label_Progress.Text = "Progress:";
            label_Time.Text = "Time: 0.0s";
        }

        private void FailOutput(string message)
        {
            MessageBox.Show(message, "Fail", MessageBoxButtons.OK);
        }

        private double time = 0;
        private void timer_Tick(object sender, EventArgs e)
        {
            time += 0.1;
            label_Time.Text = $"Time: {Math.Round(time, 1)}s";
        }
    }
}