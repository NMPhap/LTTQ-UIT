using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic.FileIO;
namespace File_Manager_Winform
{
    public static class CopyMove
    {
        private static void CopyFolder(DirectoryInfo sourcefolder, DirectoryInfo destfolder)
        {
            foreach (DirectoryInfo dir in sourcefolder.GetDirectories())
            {
                CopyFolder(dir, destfolder.CreateSubdirectory(dir.Name));
            }
            foreach (FileInfo file in sourcefolder.GetFiles())
            {
                if (CheckNameExistenceInFolder(destfolder, file.Name, false))
                {
                    file.CopyTo(Path.Combine(destfolder.FullName, file.Name), true);
                }
                else
                {
                    string msg = "The file name " + file.Name + " is already existed in folder "
                        + destfolder.Name + "."
                        + " Do you want to replace it?";
                    DialogResult dr = MessageBox.Show(msg, "Replace or skip file", MessageBoxButtons.OKCancel);
                    if (dr == DialogResult.OK)
                    {
                        file.CopyTo(Path.Combine(destfolder.FullName, file.Name), true);
                    }
                }
            }
        }

        public static void CaseOfCopyFolder(string source, string dest, string defaultDest, ListView sourceLV, ListView destLV, int index)
        {
            string folderName = sourceLV.Items[index].SubItems[0].Text;
            DirectoryInfo destParentDir = new DirectoryInfo(dest);
            if (source != dest)
            {
                string sourceFolderPath = Path.Combine(source, folderName);
                string destFolderPath = Path.Combine(dest, folderName);
                DirectoryInfo sourceDir = new DirectoryInfo(sourceFolderPath);
                DirectoryInfo destDir = new DirectoryInfo(destFolderPath);
                Directory.CreateDirectory(destFolderPath);
                CopyFolder(sourceDir, destDir);
                if (dest == defaultDest)
                {
                    ListViewItem temp = EditDirInfo.NewLVI(new EditDirInfo(destFolderPath));
                    if (CheckNameExistenceInListView(destLV, folderName, true))
                        destLV.Items.Insert(FindIndexInLV(destLV, folderName, true), temp);
                }
            }
            else
            {
                string folderName1 = "";
                int count = 1;
                while (true)
                {
                    if (count == 1)
                    {
                        folderName1 = sourceLV.Items[index].SubItems[0].Text + " - Copy";
                    }
                    else
                    {
                        folderName1 = sourceLV.Items[index].SubItems[0].Text + " - Copy (" + count + ")";
                    }
                    if (CheckNameExistenceInFolder(destParentDir, folderName1, true))
                        break;
                    count++;
                }
                string sourceFolderPath = Path.Combine(source, folderName);
                string destFolderPath = Path.Combine(source, folderName1);
                DirectoryInfo sourceDir = new DirectoryInfo(sourceFolderPath);
                DirectoryInfo destDir = new DirectoryInfo(destFolderPath);
                Directory.CreateDirectory(destFolderPath);
                CopyFolder(sourceDir, destDir);
                ListViewItem temp = EditDirInfo.NewLVI(new EditDirInfo(destFolderPath));
                sourceLV.Items.Insert(FindIndexInLV(sourceLV, folderName, true), temp);
                if (dest == defaultDest)
                {
                    ListViewItem temp1 = EditDirInfo.NewLVI(new EditDirInfo(destFolderPath));
                    destLV.Items.Insert(FindIndexInLV(destLV, folderName, true), temp1);
                }
            }

        }
        public static void CaseOfCopyFile(string source, string dest, string defaultDest, ListView sourceLV, ListView destLV, int index)
        {
            string fileName = sourceLV.Items[index].SubItems[0].Text + "." +
                            sourceLV.Items[index].SubItems[3].Text;
            DirectoryInfo destParentDir = new DirectoryInfo(dest);
            if (source != dest)
            {
                string sourceFilePath = Path.Combine(source, fileName);
                string destFilePath = Path.Combine(dest, fileName);
                if (CheckNameExistenceInFolder(destParentDir, fileName, false))
                {
                    File.Copy(sourceFilePath, destFilePath);
                    if (dest == defaultDest)
                    {
                        ListViewItem temp = EditFileInfo.NewLVI(new EditFileInfo(destFilePath));
                        destLV.Items.Insert(FindIndexInLV(destLV, fileName, false), temp);
                    }

                }
                else
                {
                    string msg = "The file name " + fileName + " is already existed in target folder." +
                        " Do you want to replace it?";
                    DialogResult dr = MessageBox.Show(msg, "Replace or skip file", MessageBoxButtons.OKCancel);
                    if (dr == DialogResult.OK)
                    {
                        Directory.CreateDirectory(dest);
                        File.Delete(destFilePath);
                        File.Copy(sourceFilePath, destFilePath);
                    }
                }
            }
            else
            {
                string fileName1 = "";
                int count = 1;
                while (true)
                {
                    if (count == 1)
                    {
                        fileName1 = sourceLV.Items[index].SubItems[0].Text + " - Copy." +
                            sourceLV.Items[index].SubItems[3].Text;
                    }
                    else
                    {
                        fileName1 = sourceLV.Items[index].SubItems[0].Text + " - Copy (" + count + ")." +
                            sourceLV.Items[index].SubItems[3].Text;
                    }
                    if (CheckNameExistenceInFolder(destParentDir, fileName1, false))
                        break;
                    count++;
                }
                string sourceFilePath = Path.Combine(source, fileName);
                string destFilePath = Path.Combine(source, fileName1);
                File.Copy(sourceFilePath, destFilePath);

                ListViewItem temp = EditFileInfo.NewLVI(new EditFileInfo(destFilePath));
                sourceLV.Items.Insert(FindIndexInLV(sourceLV, fileName1, false), temp);
                if (dest == defaultDest)
                {
                    ListViewItem temp1 = EditFileInfo.NewLVI(new EditFileInfo(destFilePath));
                    destLV.Items.Insert(FindIndexInLV(destLV, fileName1, false), temp1);
                }
            }
        }
        public static bool preCopyMove(string source, string dest, string defaultDest, ListView destLV)
        {
            string temp = FindSubFolderPath(dest, defaultDest);
            DirectoryInfo info = new DirectoryInfo(temp);
            DirectoryInfo defaultFolder = new DirectoryInfo(defaultDest);
            if (dest != defaultDest && dest.Contains(defaultDest) && CheckNameExistenceInFolder(defaultFolder, info.Name, true))
            {
                ListViewItem a = EditDirInfo.NewLVI(new EditDirInfo(temp));
                destLV.Items.Insert(FindIndexInLV(destLV, info.Name, true), a);
            }
            Directory.CreateDirectory(dest);
            return true;
        }
        public static string FindSubFolderPath(string dest, string defaultDest)
        {
            string temp = dest.Substring(defaultDest.Length);
            string temp1 = null;
            if (temp.Contains("\\"))
            {
                int i = temp.IndexOf('\\');
                temp1 = temp.Substring(0, i);
            }
            else
            {
                temp1 = temp;
            }
            temp = defaultDest + temp1;
            return temp;
        }
        public static bool CheckNameExistenceInFolder(DirectoryInfo dir, string Name, bool type)
        {
            if (type == false)
            {
                foreach (FileInfo file in dir.GetFiles())
                {
                    if (Name == file.Name)
                        return false;
                }
            }
            else
            {
                foreach (DirectoryInfo subdir in dir.GetDirectories())
                {
                    if (Name == subdir.Name)
                        return false;
                }
            }

            return true;
        }
        public static int FindIndexInLV(ListView a, string name, bool type)
        {
            if (type == false)
            {
                int i;
                for (i = 0; i < a.Items.Count; i++)
                {
                    if (a.Items[i].SubItems[1].Text == "<DIR>")
                        continue;
                    string b = a.Items[i].SubItems[0].Text + "." + a.Items[i].SubItems[3].Text;
                    if (string.Compare(name, b) >= 0)
                        continue;
                    else
                        return i;
                }
                return i;
            }
            else
            {
                int i;
                for (i = 0; i < a.Items.Count; i++)
                {
                    if (a.Items[i].SubItems[1].Text != "<DIR>")
                        break;
                    string b = a.Items[i].SubItems[0].Text;
                    if (string.Compare(name, b) >= 0)
                        continue;
                    else
                        return i;
                }
                return i;
            }
        }

        public static void CaseOfMoveFolder(string source, string dest, string defaultDest, ListView sourceLV, ListView destLV, int index)
        {
            string folderName = sourceLV.Items[index].SubItems[0].Text;
            DirectoryInfo destParentDir = new DirectoryInfo(dest);
            if (source != dest)
            {
                string sourceFolderPath = Path.Combine(source, folderName);
                string destFolderPath = Path.Combine(dest, folderName);
                DirectoryInfo sourceDir = new DirectoryInfo(sourceFolderPath);
                DirectoryInfo destDir = new DirectoryInfo(destFolderPath);
                Directory.CreateDirectory(destFolderPath);
                MoveFolder(sourceDir, destDir);
                FileSystem.DeleteDirectory(sourceFolderPath, UIOption.AllDialogs, RecycleOption.DeletePermanently);
                sourceLV.Items.RemoveAt(index);
                if (dest == defaultDest)
                {
                    ListViewItem temp = EditDirInfo.NewLVI(new EditDirInfo(destFolderPath));
                    if (CheckNameExistenceInListView(destLV, folderName, true))
                        destLV.Items.Insert(FindIndexInLV(destLV, folderName, true), temp);
                }
            }
        }
        public static void MoveFolder(DirectoryInfo sourceFolder, DirectoryInfo destFolder)
        {
            foreach (DirectoryInfo dir in sourceFolder.GetDirectories())
            {
                MoveFolder(dir, destFolder.CreateSubdirectory(dir.Name));
            }
            foreach (FileInfo file in sourceFolder.GetFiles())
            {
                if (CheckNameExistenceInFolder(destFolder, file.Name, false))
                {
                    string sourceFilePath = Path.Combine(sourceFolder.FullName, file.Name);
                    string destFilePath = Path.Combine(destFolder.FullName, file.Name);
                    File.Move(sourceFilePath, destFilePath);
                }
                else
                {
                    string msg = "The file name " + file.Name + " is already existed in folder "
                        + destFolder.Name + "."
                        + " Do you want to replace it?";
                    DialogResult dr = MessageBox.Show(msg, "Replace or skip file", MessageBoxButtons.OKCancel);
                    if (dr == DialogResult.OK)
                    {
                        string sourceFilePath = Path.Combine(sourceFolder.FullName, file.Name);
                        string destFilePath = Path.Combine(destFolder.FullName, file.Name);
                        File.Delete(destFilePath);
                        File.Move(sourceFilePath, destFilePath);
                    }
                }
            }
        }
        public static void CaseOfMoveFile(string source, string dest, string defaultDest, ListView sourceLV, ListView destLV, int index)
        {
            string fileName = sourceLV.Items[index].SubItems[0].Text + "." +
                            sourceLV.Items[index].SubItems[3].Text;
            DirectoryInfo destParentDir = new DirectoryInfo(dest);
            if (source != dest)
            {
                if (CheckNameExistenceInFolder(destParentDir, fileName, false))
                {
                    string sourceFilePath = Path.Combine(source, fileName);
                    string destFilePath = Path.Combine(dest, fileName);
                    File.Move(sourceFilePath, destFilePath);
                    if (dest == defaultDest)
                    {
                        ListViewItem temp = EditFileInfo.NewLVI(new EditFileInfo(destFilePath));
                        destLV.Items.Insert(FindIndexInLV(destLV, fileName, false), temp);
                    }
                    sourceLV.Items.RemoveAt(index);
                }
                else
                {
                    string msg = "The file name " + fileName + " is already existed in target folder." +
                        " Do you want to replace it?";
                    DialogResult dr = MessageBox.Show(msg, "Replace or skip file", MessageBoxButtons.OKCancel);
                    if (dr == DialogResult.OK)
                    {
                        string sourceFilePath = Path.Combine(source, fileName);
                        string destFilePath = Path.Combine(dest, fileName);
                        File.Delete(destFilePath);
                        File.Move(sourceFilePath, destFilePath);
                        sourceLV.Items.RemoveAt(index);
                    }
                }
            }
        }
        public static void DeleteFolder(DirectoryInfo folder)
        {
            foreach (DirectoryInfo dir in folder.GetDirectories())
            {
                DeleteFolder(dir);
                Directory.Delete(dir.FullName);
            }
            foreach (FileInfo fi in folder.GetFiles())
            {
                File.Delete(Path.Combine(folder.FullName, fi.Name));
            }
        }
        public static bool CheckNameExistenceInListView(ListView a, string name, bool type)
        {
            if (type == false)
            {
                for (int i = 0; i < a.Items.Count; i++)
                {
                    if (a.Items[i].SubItems[1].Text == "<DIR>")
                        continue;
                    string b = a.Items[i].SubItems[0].Text + "." + a.Items[i].SubItems[3].Text;
                    if (name == b)
                        return false;
                }
            }
            else
            {
                for (int i = 0; i < a.Items.Count; i++)
                {
                    if (a.Items[i].SubItems[1].Text != "<DIR>")
                        break;
                    string b = a.Items[i].SubItems[0].Text;
                    if (name == b)
                        return false;
                }
            }
            return true;
        }
    }
}
