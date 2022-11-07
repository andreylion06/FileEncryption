namespace FileEncryptionClassLibrary
{
    public class FileEncription
    {
        private const string FileCryptExtension = ".crypt";
        private const string FileDecryptExtension = ".decrypt";

        private string Password { get; set; }
        private string FileInPath { get; set; }
        public FileEncription(string password, string fileInPath)
        {
            Password = password;
            FileInPath = fileInPath;
        }

        public void CryptOrUncrypt()
        {
            string fileOutPath = GetOutPath(FileInPath);

            Console.WriteLine(fileOutPath);
            FileStream fileStreamIn = File.OpenRead(FileInPath);
            FileStream fileStreamOut = File.OpenWrite(fileOutPath);
            int symbol;
            int posPassword = 0;
            while ((symbol = fileStreamIn.ReadByte()) != -1)
            {
                symbol = symbol ^ Password[posPassword++];
                fileStreamOut.WriteByte((byte)symbol);
                if (posPassword >= Password.Length)
                    posPassword = 0;
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