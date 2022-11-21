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
        private Panel selectedPanel;
        public Form1()
        {
            InitializeComponent();
            selectedPanel = directoryLeftPanel;
        }

        private void Show_Help(object sender, EventArgs e)
        {
            HelpForm i = new HelpForm();
            i.ShowDialog(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EditDirInfo edi = new EditDirInfo("C:\\Users\\admin\\OneDrive\\Pictures");
            listView1.Items.Add(EditDirInfo.NewLVI(edi));

            EditFileInfo efi = new EditFileInfo("C:\\Users\\admin\\OneDrive\\Pictures\\avtdisc.png");            
            listView1.Items.Add(EditFileInfo.NewLVI(efi));
            
            EditFileInfo efi1 = new EditFileInfo("C:\\Users\\admin\\OneDrive\\Desktop\\Expense.xlsx");
            listView1.Items.Add(EditFileInfo.NewLVI(efi1));

            EditFileInfo efi2 = new EditFileInfo("C:\\Users\\admin\\OneDrive\\Desktop\\GBA & games\\Armymen\\army-men-rts.rar");
            listView1.Items.Add(EditFileInfo.NewLVI(efi2));

            EditFileInfo efi3 = new EditFileInfo("C:\\Users\\admin\\OneDrive\\Desktop\\Năm 2\\HDH\\21521812 Lab1.docx");
            listView1.Items.Add(EditFileInfo.NewLVI(efi3));

            EditFileInfo efi4 = new EditFileInfo("C:\\Users\\admin\\OneDrive\\Desktop\\Năm 2\\HDH\\Lab1 21521812.pdf");
            listView1.Items.Add(EditFileInfo.NewLVI(efi4));


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
        private void treeView1_AfterExpand(object sender, TreeViewEventArgs e)
        {
            foreach (TreeNode node in e.Node.Nodes)
                ListDirectory(node);
        }
        private void ListDirectory(TreeNode TP)
        {
            try
            {
                string[] dirlist = System.IO.Directory.GetDirectories(TP.Text);
                foreach (string dir in dirlist)
                    TP.Nodes.Add(new TreeNode(dir));
            }
            catch { }
        }

        private void LeftPanel_Click(object sender, EventArgs e)
        {
            selectedPanel = (Panel)sender;
            if(selectedPanel.Width != selectedPanel.Parent.Width)
                SwitchThroughTreePanelOptionBtn.Checked = true;
            else
                SwitchThroughTreePanelOptionBtn.Checked = false;
        }
    }
}
