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

        private void button_Start_Click(object sender, EventArgs e)
        {
            string filePath = textBox_FilePath.Text;
            string password = textBox_Password.Text;
            FileEncription encr = new FileEncription(filePath, password);
            encr.CryptOrUncrypt();
        }
    }
}