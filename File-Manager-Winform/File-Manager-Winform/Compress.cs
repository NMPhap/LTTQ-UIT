using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace File_Manager_Winform
{
    public static class Compress
    {
        public static string CompressFiles(string rarPackagePath, Dictionary<int, string> accFiles)
        {
            string error = "";
            try
            {
                string[] files = new string[accFiles.Count];
                int i = 0;
                foreach (var fList_item in accFiles)
                {
                    files[i] = "\"" + fList_item.Value;
                    i++;
                }
                string fileList = string.Join("\" ", files);
                fileList += "\"";
                System.Diagnostics.ProcessStartInfo sdp = new System.Diagnostics.ProcessStartInfo();
                string cmdArgs = string.Format("A {0} {1} -ep1 -r",
                    String.Format("\"{0}\"", rarPackagePath),
                    fileList);
                sdp.ErrorDialog = false;
                sdp.UseShellExecute = true;
                sdp.Arguments = cmdArgs;
                sdp.FileName = Properties.Settings.Default.winRARdir;
                sdp.CreateNoWindow = false;
                sdp.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                System.Diagnostics.Process process = System.Diagnostics.Process.Start(sdp);
                process.WaitForExit();
                error = "OK";
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return error;
        }
        public static string DeCompressFiles(string SourceFile, string DestinationPath)
        {
            string error = "";
            try
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.FileName = Properties.Settings.Default.winRARdir;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                process.EnableRaisingEvents = false;
                process.StartInfo.Arguments = string.Format("x -o+ \"{0}\" \"{1}\"", SourceFile, DestinationPath);
                process.Start();
                process.WaitForExit();
                error = "OK";
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return error;
        }
    }
}
