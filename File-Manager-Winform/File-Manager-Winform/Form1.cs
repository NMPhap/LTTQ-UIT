using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace File_Manager_Winform
{
    public partial class Form1 : Form
    {
        private ListView selectedPanel;
        private string leftDirectory;
        private string rightDirectory;
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
            DriveInfo leftDrive;
            DriveInfo rightDrive;
            NumberFormatInfo format = new CultureInfo("en-US",false).NumberFormat;
            try
            {
                leftDrive = new DriveInfo(new DirectoryInfo(Properties.Settings.Default.dirLeft).Root.Name);
                leftDirectory = Properties.Settings.Default.dirLeft;
            }
            catch(ArgumentException ex)
            {
                leftDrive = DriveInfo.GetDrives()[0];
                leftDirectory = leftDrive.Name;
            }
            ChangeDirectory(directoryLeftListView,leftDirectory);
            try
            {
                rightDrive = new DriveInfo(new DirectoryInfo(Properties.Settings.Default.dirRight).Root.Name);
                rightDirectory = Properties.Settings.Default.dirRight;
            }
            catch (ArgumentException ex)
            {
                rightDrive = DriveInfo.GetDrives()[0];
                rightDirectory = rightDrive.Name;
            }
            ChangeDirectory(directoryRightListView,rightDirectory);
            directoryLeftLabel.Text = String.Concat("[",leftDrive.VolumeLabel,"] ", Convert.ToString((double)leftDrive.AvailableFreeSpace/1024,format)," k of ", Convert.ToString((double) leftDrive.TotalSize/1024, format), " k free");
            directoryRightLabel.Text = String.Concat("[", rightDrive.VolumeLabel, "] ", Convert.ToString((double)rightDrive.AvailableFreeSpace / 1024, format), " k of ", Convert.ToString((double)rightDrive.TotalSize / 1024, format), " k free");
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
            Directory_Label.Text = (selectedPanel == directoryLeftListView) ? leftDirectory : rightDirectory; 
            PopulateDirectoryConboBox(Directory_Label.Text);
            if(selectedPanel.Width != selectedPanel.Parent.Parent.Width)
                SwitchThroughTreePanelOptionBtn.Checked = true;
            else
                SwitchThroughTreePanelOptionBtn.Checked = false;
        }

        private void DirectoryLeftTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeView tree = sender as TreeView;
            ListView listView = tree.Name.Contains("Left") ? directoryLeftListView : directoryRightListView;
            string Directory = GetDirectory(e.Node);
            ChangeDirectory(listView, Directory);
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
                //FileInfo temp = new FileInfo(File);
                //Icon i = SystemIcons.WinLogo;
                //if (!imageList1.Images.ContainsKey(temp.Extension))
                //{
                //    i = Icon.ExtractAssociatedIcon(File);
                //    imageList1.Images.Add(temp.Extension, i);
                //}
                //if (!imageList2.Images.ContainsKey(temp.Extension))
                //{
                //    i = Icon.ExtractAssociatedIcon(File);                    
                //    imageList2.Images.Add(temp.Extension, i);
                //}
                try
                {
                    EditFileInfo efi = new EditFileInfo(File);
                    //item.ImageKey = temp.Extension;
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
                    leftDirectory = Directory;
                else
                    rightDirectory = Directory;
                PopulateDirectoryConboBox(Directory_Label.Text);
            }
            catch(UnauthorizedAccessException ex)
            {
                MessageBox.Show("Access Denial", "Access denied to" + Directory + "Please check your access authority to this folder");
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.dirLeft = leftDirectory;
            Properties.Settings.Default.dirRight = rightDirectory;
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

        private void OnlyFileNamesBtn_Click(object sender, EventArgs e)
        {
            if (directoryLeftListView.View == View.LargeIcon)
                return;
            ToolStripButton a = (ToolStripButton)sender;
            if (a.Checked == true)
            {
                ListViewOnlyName(directoryLeftListView);
                ListViewOnlyName(directoryRightListView);
                AllFileDetailsBtn.Checked = false;
            }
            else
            {
                a.Checked = true;
            }
        }

        private void AllFileDetailsBtn_Click(object sender, EventArgs e)
        {
            if (directoryLeftListView.View == View.LargeIcon)
                return;
            ToolStripButton a = (ToolStripButton)sender;
            if (a.Checked == true)
            {
                ChangeDirectory(directoryLeftListView, leftDirectory);
                ChangeDirectory(directoryRightListView, rightDirectory);
                OnlyFileNamesBtn.Checked = false;
            }
            else
            {
                a.Checked = true;
            }
        }
    }
}
