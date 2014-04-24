using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ShipmentGeek
{
    class FileHandling
    {
        public static void BackupShipmentDatabase()
        {
            if (File.Exists(Var.FileInfo.ShipmentFile))
            {
                Directory.CreateDirectory(Var.FolderInfo.Backup);
                File.Copy(Var.FileInfo.ShipmentFile, string.Format("{0}\\{1}.xml", Var.FolderInfo.Backup, Var.DateTimeStr), true);
            }

            if (Directory.Exists(Var.FolderInfo.Backup))
                FileHandling.DeleteOldFiles(Var.FolderInfo.Backup, "xml", (x, y) => x.CreationTime < y.AddDays(-7));
        }

        public delegate bool FileTimeCheckDelegate(FileInfo i, DateTime y);
        public static void DeleteOldFiles(string path, string fileExt, FileTimeCheckDelegate ftcDel)
        {
            try
            {
                string[] files = Directory.GetFiles(path, "*." + fileExt);
                foreach (string file in files)
                {
                    FileInfo fi = new FileInfo(file);
                    if (ftcDel(fi, DateTime.Now))
                    {
                        File.Delete(fi.FullName);
                    }
                }
            }
            catch (Exception exp)
            {
                MsgManager.Show(exp.Message, "Delete old files", System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
    }
}
