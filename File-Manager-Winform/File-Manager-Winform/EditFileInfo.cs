using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace File_Manager_Winform
{

    public class EditFileInfo:IDisposable
    {
        private int icon;
        private FileInfo fi;
        //private Component component = new Component();
        public void Dispose()
        {
            GC.Collect();
            GC.SuppressFinalize(this);
        }
        ~EditFileInfo()
        {
            Dispose();
        }
        public EditFileInfo(string path)
        {
            fi = new FileInfo(path);
            //list of icon number:
            //default 1
            //png/jpeg/jpg 2
            //rar/zip 3
            //doc/docx 4
            //xls/xlsx 5
            //pdf 6
            //dll 7
            //
            if (Tail() == "png" || Tail() == "jpeg" || Tail() == "jpg")
            {
                icon = 2;
                return;
            }
            if (Tail() == "rar" || Tail() == "zip")
            {
                icon = 3;
                return;
            }
            if (Tail() == "doc" || Tail() == "docx")
            {
                icon = 4;
                return;
            }
            if (Tail() == "xls" || Tail() == "xlsx")
            {
                icon = 5;
                return;
            }
            if (Tail() == "pdf")
            {
                icon = 6;
                return;
            }
            if (Tail() == "dll")
            {
                icon = 7;
                return;
            }
            icon = 1;
        }
        private string Head()
        {
            string temp = "";
            for (int i = fi.Name.Length - 1; i >= 0; i--)
            {
                if (fi.Name[i] == '.')
                {
                    temp = fi.Name.Substring(0, i);
                    break;
                }
            }
            return temp;
        }
        private string Tail()
        {
            string temp = "";
            for (int i = fi.Name.Length - 1; i >= 0; i--)
            {
                if (fi.Name[i] == '.')
                {
                    temp = fi.Name.Substring(i + 1);
                    break;
                }
            }
            return temp;
        }
        static public ListViewItem NewLVI(EditFileInfo a)
        {
            ListViewItem temp = new ListViewItem();
            temp.Text = a.Head();
            temp.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = Convert.ToString(a.fi.Length / 1024) });
            temp.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = Convert.ToString(a.fi.CreationTimeUtc) });
            temp.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = a.Tail() });
            temp.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = Convert.ToString(a.fi.Attributes) });
            temp.ImageIndex = a.icon;
            return temp;
        }
    }
}
