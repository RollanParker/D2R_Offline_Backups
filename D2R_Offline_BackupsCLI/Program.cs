using System;

namespace D2R_Offline_BackupsCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== D2R Offline Backup Tool ===\n");

            var backup = new BackupEngine();
            backup.RunBackup();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}