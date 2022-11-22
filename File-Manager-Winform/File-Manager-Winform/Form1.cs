using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace File_Manager_Winform
{
    public partial class Form1 : Form
    {
        private ListView selectedPanel;
        private Label directoryLeftLabel;
        private Label directoryRightLabel;
        public Form1()
        {
            InitializeComponent();
            selectedPanel = directoryLeftListView;
        }

        private void Show_Help(object sender, EventArgs e)
        {
            HelpForm i = new HelpForm();
            i.ShowDialog(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            directoryLeftLabel = new Label();
            directoryLeftLabel.Text = Properties.Settings.Default.dirLeft;
            ChangeDirectory(directoryLeftListView,directoryLeftLabel.Text);
            directoryRightLabel = new Label();
            directoryRightLabel.Text = Properties.Settings.Default.dirRight; ;
            ChangeDirectory(directoryRightListView,directoryRightLabel.Text);
        }

        private void SwitchThroughTreePanelOptionBtn_Clicked(object sender, EventArgs e)
        {
            ToolStripButton button = (ToolStripButton)sender;
            TableLayoutPanel tableLayoutPanel = (TableLayoutPanel)selectedPanel.Parent;
            TreeView treeView = (TreeView)tableLayoutPanel.GetControlFromPosition(0, 0);
            if(selectedPanel.Width == selectedPanel.Parent.Width)
            {
                treeView.Nodes.Clear();
                tableLayoutPanel.ColumnStyles[0] = new ColumnStyle(SizeType.Percent, 50F);
                tableLayoutPanel.ColumnStyles[1] = new ColumnStyle(SizeType.Percent, 50F);
                System.IO.DriveInfo[] DriveList = System.IO.DriveInfo.GetDrives();
                for (int i = 0; i < DriveList.Length; i++)
                {
                    TreeNode node = new TreeNode(DriveList[i].Name);
                    treeView.Nodes.Add(node);
                    ListDirectory(node);
                }
                button.Checked = true;
            }
            else 
            {
                tableLayoutPanel.ColumnStyles[0] = new ColumnStyle(SizeType.Percent, 0F);
                tableLayoutPanel.ColumnStyles[1] = new ColumnStyle(SizeType.Percent, 100F);
                button.Checked = false;
                treeView.Nodes.Clear();
            }

        }
        private void TreeView_AfterExpand(object sender, TreeViewEventArgs e)
        {
            foreach (TreeNode node in e.Node.Nodes)
                ListDirectory(node);
        }
        private void ListDirectory(TreeNode TP)
        {
            try
            {
                string[] dirlist = System.IO.Directory.GetDirectories(GetDirectory(TP));
                foreach (string dir in dirlist)
                {  
                    TreeNode node = new TreeNode(new System.IO.DirectoryInfo(dir).Name,0,0);
                    TP.Nodes.Add(node);
                }
            }
            catch { }
        }
        private string GetDirectory(TreeNode TP)
        {
            string result = TP.Text;
            while(TP.Parent != null)
            {
                result = TP.Parent.Text + "\\" + result;
                TP = TP.Parent;
            }
            return result;
        }
        private void LeftPanel_Click(object sender, EventArgs e)
        {
            selectedPanel = (ListView)sender;
            Directory_Label.Text = (selectedPanel == directoryLeftListView) ? directoryLeftLabel.Text : directoryRightLabel.Text; 
            PopulateDirectoryConboBox(Directory_Label.Text);
            if(selectedPanel.Width != selectedPanel.Parent.Width)
                SwitchThroughTreePanelOptionBtn.Checked = true;
            else
                SwitchThroughTreePanelOptionBtn.Checked = false;
        }

        private void DirectoryLeftTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string Directory = GetDirectory(e.Node);
            ChangeDirectory(selectedPanel, Directory);
        }

        private void PopulateListView(ListView listView, string path)
        {
            listView.Items.Clear();
            string[] DirList = System.IO.Directory.GetDirectories(path);
            string[] FileList = System.IO.Directory.GetFiles(path);
            foreach (string Dir in DirList)
            {
                try
                {
                    EditDirInfo edir = new EditDirInfo(Dir);
                    listView.Items.Add(EditDirInfo.NewLVI(edir));
                }
                catch { }
            }
            foreach (string File in FileList)
            {
                try
                {
                    EditFileInfo efi = new EditFileInfo(File);
                    listView.Items.Add(EditFileInfo.NewLVI(efi));
                }
                catch { }
            }
        }
        private void PopulateDirectoryConboBox(string path)
        {
            Directory_ComboBox.Items.Clear();
            string[] DirList = System.IO.Directory.GetDirectories(path);
            foreach (string Directory in DirList)
                Directory_ComboBox.Items.Add("\\" + new System.IO.DirectoryInfo(Directory).Name);
        }

        private void Directory_ComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            string Directory = Directory_Label.Text + Directory_ComboBox.Text;
            ChangeDirectory(selectedPanel, Directory);
        }
        private void ChangeDirectory(ListView listView, string Directory)
        {
            try
            {
                PopulateListView(listView, Directory);
                Directory_Label.Text = Directory;
                if(listView == directoryLeftListView)
                    directoryLeftLabel.Text = Directory;
                else
                    directoryRightLabel.Text = Directory;
                PopulateDirectoryConboBox(Directory_Label.Text);
            }
            catch(UnauthorizedAccessException ex)
            {
                MessageBox.Show("Access Denial", "Access denied to" + Directory + "Please check your access authority to this folder");
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.dirLeft = directoryLeftLabel.Text;
            Properties.Settings.Default.dirRight = directoryRightLabel.Text;
            Properties.Settings.Default.Save();
        }

        private void ThumbnailViewBtn_Click(object sender, EventArgs e)
        {
            switch (directoryRightListView.View)
            {
                case View.Details:
                    directoryRightListView.View = View.LargeIcon;
                    break;
                case View.LargeIcon:
                    directoryRightListView.View = View.Details;
                    break;
            }
            switch (directoryLeftListView.View)
            {
                case View.Details:
                    directoryLeftListView.View = View.LargeIcon;
                    break;
                case View.LargeIcon:
                    directoryLeftListView.View = View.Details;
                    break;
            }
        }
        private void ListViewOnlyName(ListView listview)
        {
            foreach (ListViewItem item in listview.Items)
            {
                item.SubItems.RemoveAt(4);
                item.SubItems.RemoveAt(3);
                item.SubItems.RemoveAt(2);
                item.SubItems.RemoveAt(1);
            }
        }
        private bool onlyname = false;

        private void OnlyFileNamesBtn_Click(object sender, EventArgs e)
        {
            if (directoryLeftListView.View == View.LargeIcon)
            {
                directoryLeftListView.View = View.Details;
                directoryRightListView.View = View.Details;
            }
                
            if (onlyname == true)
            {
                ListViewOnlyName(directoryLeftListView);
                ListViewOnlyName(directoryRightListView);
                onlyname = false;
            }
        }

        private void AllFileDetailsBtn_Click(object sender, EventArgs e)
        {
            if (directoryLeftListView.View == View.LargeIcon)
            {
                directoryLeftListView.View = View.Details;
                directoryRightListView.View = View.Details;
            }
            if (onlyname == false)
            {
                ChangeDirectory(directoryLeftListView, directoryLeftLabel.Text);
                ChangeDirectory(directoryRightListView, directoryRightLabel.Text);
                onlyname = true;
            }
        }
        private void dRLVsizechange(object sender, EventArgs e)
        {
            int a = directoryRightListView.Width - System.Windows.Forms.SystemInformation.VerticalScrollBarWidth;
            directoryRightListView.Columns[0].Width = a / 100 * 50;
            directoryRightListView.Columns[1].Width = a / 100 * 10;
            directoryRightListView.Columns[2].Width = a / 100 * 20;
            directoryRightListView.Columns[3].Width = a / 100 * 10;
            directoryRightListView.Columns[4].Width = a / 100 * 10;
        }
        private void dLLVsizechange(object sender, EventArgs e)
        {
            int a = directoryLeftListView.Width - System.Windows.Forms.SystemInformation.VerticalScrollBarWidth;
            directoryLeftListView.Columns[0].Width = a / 100 * 50;
            directoryLeftListView.Columns[1].Width = a / 100 * 10;
            directoryLeftListView.Columns[2].Width = a / 100 * 20;
            directoryLeftListView.Columns[3].Width = a / 100 * 10;
            directoryLeftListView.Columns[4].Width = a / 100 * 10;
        }
    }
}
