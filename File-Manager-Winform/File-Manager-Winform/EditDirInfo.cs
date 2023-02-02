using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Manager_Winform
{
    internal class EditDirInfo:IDisposable
    {
        private int icon;
        private DirectoryInfo di;
        public void Dispose()
        {
            GC.Collect();
            GC.SuppressFinalize(this);
        }
        ~EditDirInfo()
        {
            Dispose();
        }
        public EditDirInfo(string path)
        {
            di = new DirectoryInfo(path);
            icon = 0;
        }
        static public ListViewItem NewLVI(EditDirInfo a)
        {
            ListViewItem temp = new ListViewItem();
            temp.Text = a.di.Name;
            temp.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "<DIR>" });
            temp.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = Convert.ToString(a.di.CreationTimeUtc) });
            temp.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "" });
            temp.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = Convert.ToString(a.di.Attributes) });
            temp.ImageIndex = a.icon;
            temp.Tag = a.di.Parent.FullName;
            return temp;
        }
    }
}
