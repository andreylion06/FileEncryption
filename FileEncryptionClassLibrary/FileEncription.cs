namespace FileEncryptionClassLibrary
{
    public class FileEncription
    {
        private const string FileCryptExtension = ".crypt";
        private const string FileDecryptExtension = ".decrypt";

        private string FileInPath { get; set; }
        private string Password { get; set; }
        public FileEncription(string fileInPath, string password)
        {
            FileInPath = fileInPath;
            Password = password;
            Progress = 0;
        }

        private int _Progress;
        public int Progress { 
            get { return _Progress; }
            private set { 
                _Progress = value;
                ProgressChanged(); 
            } 
        }

        public Action ProgressChangedAction;
        protected void ProgressChanged()
        {
            if (ProgressChangedAction != null)
                ProgressChangedAction();
        }

        public void CryptOrUncrypt()
        {
            string fileOutPath = GetOutPath(FileInPath);
            FileStream fileStreamIn = File.OpenRead(FileInPath);
            FileStream fileStreamOut = File.OpenWrite(fileOutPath);

            int symbol, posPassword = 0;
            long posFile = 0, percentOfFileLength = fileStreamIn.Length / 100;

            while ((symbol = fileStreamIn.ReadByte()) != -1)
            {
                //encrypting symbol
                symbol = symbol ^ Password[posPassword++];
                fileStreamOut.WriteByte((byte)symbol);
                if (posPassword >= Password.Length)
                    posPassword = 0;

                //progress counting
                posFile++;
                if (posFile % percentOfFileLength == 0)
                {
                    Progress = (int)(posFile / percentOfFileLength);
                }
            }

            fileStreamIn.Close();
            fileStreamOut.Close();
        }

        private string GetOutPath(string fileInPath)
        {
            if (fileInPath.Contains(FileCryptExtension))
                return fileInPath.Remove(fileInPath.IndexOf(FileCryptExtension)) + FileDecryptExtension;
            else
                return fileInPath + FileCryptExtension;
        }
    }
}