using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            directoryLeftLabel.Text = Properties.Settings.Default.dirLeft;
            ChangeDirectory(directoryLeftListView,directoryLeftLabel.Text);
            directoryRightLabel.Text = Properties.Settings.Default.dirRight; ;
            ChangeDirectory(directoryRightListView,directoryRightLabel.Text);
            System.IO.DriveInfo[] driveList = System.IO.DriveInfo.GetDrives();
            foreach (System.IO.DriveInfo drive in driveList)
            {
                leftDriveComboBox.Items.Add(drive);
                rightDriveComboBox.Items.Add(drive);
            }
        }

        private void SwitchThroughTreePanelOptionBtn_Clicked(object sender, EventArgs e)
        {
            ToolStripButton button = (ToolStripButton)sender;
            TableLayoutPanel tableLayoutPanel = (TableLayoutPanel)selectedPanel.Parent.Parent;
            TreeView treeView = (TreeView)tableLayoutPanel.GetControlFromPosition(0, 0);
            if(selectedPanel.Width == selectedPanel.Parent.Parent.Width)
            {
                treeView.Nodes.Clear();
                tableLayoutPanel.ColumnStyles[0] = new ColumnStyle(SizeType.Percent, 50F);
                tableLayoutPanel.ColumnStyles[1] = new ColumnStyle(SizeType.Percent, 50F);
                System.IO.DriveInfo[] DriveList = System.IO.DriveInfo.GetDrives();
                for (int i = 0; i < DriveList.Length; i++)
                {
                    TreeNode node = new TreeNode(DriveList[i].Name);
                    //imageList2.Images.Add(Icon.);
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
            if(selectedPanel.Width != selectedPanel.Parent.Parent.Width)
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
            string[] DirList = System.IO.Directory.GetFileSystemEntries(path);
            foreach (string Dir in DirList)
            {
                try
                {
                    System.IO.FileInfo fileInfo = new System.IO.FileInfo(Dir);
                    if (System.IO.File.GetAttributes(fileInfo.FullName).HasFlag(System.IO.FileAttributes.Directory))
                    {
                        EditDirInfo edir = new EditDirInfo(fileInfo.FullName);
                        listView.Items.Add(EditDirInfo.NewLVI(edir));
                    }
                    else
                    {
                        EditFileInfo edir = new EditFileInfo(fileInfo.FullName);
                        listView.Items.Add(EditFileInfo.NewLVI(edir));
                    }
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

    }
}
