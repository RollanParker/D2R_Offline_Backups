using System;
using System.IO;

namespace D2R_Offline_BackupsCLI
{
    public class BackupEngine
    {
        private readonly string sourcePath;
        private readonly string backupRoot;

        public BackupEngine()
        {
            string userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

            sourcePath = Path.Combine(userProfile, "Saved Games", "Diablo II Resurrected");
            backupRoot = Path.Combine(userProfile, "D2R_Backups");
        }

        public void RunBackup()
        {
            if (!Directory.Exists(sourcePath))
            {
                Console.WriteLine($"❌ Source folder not found:\n{sourcePath}");
                return;
            }

            string timestamp = DateTime.Now.ToString("yyyy-MM-dd");
            string backupFolder = Path.Combine(backupRoot, timestamp);

            Directory.CreateDirectory(backupFolder);

            string[] validExtensions = { ".d2s", ".map", ".key", ".ma0", ".ma1" };

            int copied = 0;

            foreach (var file in Directory.GetFiles(sourcePath))
            {
                string ext = Path.GetExtension(file).ToLower();

                if (Array.Exists(validExtensions, e => e == ext))
                {
                    string destFile = Path.Combine(backupFolder, Path.GetFileName(file));
                    File.Copy(file, destFile, true);
                    copied++;
                }
            }

            Console.WriteLine($"✅ Backup complete!");
            Console.WriteLine($"📁 Location: {backupFolder}");
            Console.WriteLine($"📄 Files copied: {copied}");
        }
    }
}