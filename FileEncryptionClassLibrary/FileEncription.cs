namespace FileEncryptionClassLibrary
{
    public class FileEncription
    {
        private const string FileCryptExtension = ".crypt";

        public string FileInPath { get; private set; }
        public string FileOutPath { get; private set; }
        private string Password { get; set; }
        public FileEncription(string fileInPath, string password)
        {
            FileInPath = fileInPath;
            FileOutPath = GetOutPath(fileInPath);
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
            FileStream fileStreamIn = File.OpenRead(FileInPath);
            FileStream fileStreamOut = File.OpenWrite(FileOutPath);

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
            if (IsFileEncrypted(fileInPath))
                return fileInPath.Remove(fileInPath.IndexOf(FileCryptExtension));
            else
                return fileInPath + FileCryptExtension;
        }

        static public bool IsFileEncrypted(string fullFilePath)
        {
            return fullFilePath.Contains(FileCryptExtension);
        }

        public long GetSizeOfFile()
        {
            FileStream fileStreamIn = File.OpenRead(FileInPath);
            long length = fileStreamIn.Length;
            fileStreamIn.Close();
            return length;
        }
    }
}