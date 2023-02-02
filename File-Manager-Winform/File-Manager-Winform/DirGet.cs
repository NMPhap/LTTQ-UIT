using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace File_Manager_Winform
{
    public static class DirGet
    {
        public static string GetExePath(string extension)
        {
            var appName = (string)Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(extension).GetValue(null);
            var openWith = (string)Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(appName + @"\shell\open\command").GetValue(null);
            string appPath = System.Text.RegularExpressions.Regex.Match(openWith, "[a-zA-Z0-9:,\\\\\\. ()]+").Value.Trim();
            return appPath;
        }
        public static  string GetDirectory(TreeNode TP)
        {
            string result = TP.Text;
            while (TP.Parent != null)
            {
                result = TP.Parent.Text + "\\" + result;
                TP = TP.Parent;
            }
            return result;
        }
        public static long DirSize(DirectoryInfo d)
        {
            long size = 0;
            // Add file sizes.
            FileInfo[] fis = d.GetFiles();
            foreach (FileInfo fi in fis)
            {
                size += fi.Length;
            }
            // Add subdirectory sizes.
            DirectoryInfo[] dis = d.GetDirectories();
            foreach (DirectoryInfo di in dis)
            {
                size += DirSize(di);
            }
            return size;
        }
    }
}
