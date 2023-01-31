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
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Runtime.CompilerServices;
using System.Reflection;
using System.Net.Configuration;
using Microsoft.VisualBasic.FileIO;
using System.Security.Permissions;
namespace File_Manager_Winform
{

    public partial class Form1 : Form
    {
        ListViewColumnSorter lvwleftColumnSorter;
        ListViewColumnSorter lvwrightColumnSorter;
        private ListView selectedPanel;//Xac dinh list view nao dang duoc chon de thuc thi cac thao tac

        private List<string> leftHistory;//Mang du lieu chua thong tin lich su duyet folder cua listview ben trai
        private List<string> rightHistory;//Mang du lieu chua thong tin lich su duyet folder cua listview ben phai
        
        private List<string> searchHistory;//Mang du lieu chua thong tin lich su tim kiem tren hai thanh tim kiem

        private string _leftDirectory;//Duong dan cua list view ben trai
        public string leftDirectory//thuoc tinh ao cho _leftDirectory nham goi thuc thi cac ham khi thay doi duong dan
        {
            get { return _leftDirectory; }
            set
            {
                try
                {
                    _leftDirectory = value;
                    ChangeDirectory(directoryLeftListView, _leftDirectory);
                    if (button1.BackColor == SystemColors.ControlDark)
                        comboBox1.Text = _leftDirectory;
                }
                catch (UnauthorizedAccessException)//xu ly loi khong co quyen truy cap duong dan
                {
                    MessageBox.Show("Access Denial", "Quyền truy cập bi từ chối từ" + _leftDirectory + "\nXin hãy kiểm tra lại đường dẫn");
                    leftDirectory = leftHistory[leftHistory.Count - 2];
                }
                catch (DirectoryNotFoundException)
                {
                    MessageBox.Show("Không tìm thấy đường dẫn");
                    leftDirectory = leftHistory[leftHistory.Count - 1];
                }
                catch (Exception ) { }
            }
        }

        private string _rightDirectory;//Duong dan cua listView ben phai
        public string rightDirectory//thuoc tinh ao cho _rightDirectory nham goi thuc thi cac ham khi thay doi duong dan
        {
            get { return _rightDirectory; }
            set
            {
                try
                {
                    _rightDirectory = value;
                    ChangeDirectory(directoryRightListView, _rightDirectory);
                    if(button5.BackColor == SystemColors.ControlDark)
                        comboBox3.Text = _rightDirectory;
                }
                catch (UnauthorizedAccessException)//xu ly loi khong co quyen truy cap duong dan
                {
                    MessageBox.Show("Access Denial", "Quyền truy cập bi từ chối từ" + _rightDirectory + "\nXin hãy kiểm tra lại đường dẫn");
                    leftDirectory = leftHistory[leftHistory.Count - 2];
                }
                catch (DirectoryNotFoundException)
                {
                    MessageBox.Show("Không tìm thấy đường dẫn");
                    rightDirectory = rightHistory[rightHistory.Count - 1];
                }
                catch (Exception) { }
            }
        }
        public Form1()
        {
            InitializeComponent();
            this.quickViewPanel = new System.Windows.Forms.Panel();
            this.quickViewPanel.Location = directoryLeftListView.Location;
            this.quickViewPanel.Size = directoryLeftListView.Size;
            this.quickViewPanel.BackColor = Color.White;
            this.quickViewPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quickViewPanel.Visible = false;
            this.quickViewPanel.AutoScroll = true;
            this.rightListViewContainer.Controls.Add(this.quickViewPanel, 0, 1);
            directoryLeftListView.DoubleBuffered(Enabled);
            directoryRightListView.DoubleBuffered(Enabled);
            selectedPanel = directoryLeftListView;
            this.KeyPreview = true;
        }
        /// <summary>
        /// Handle cho Help Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Show_Help(object sender, EventArgs e)
        {
            HelpForm i = new HelpForm();
            i.ShowDialog(this);
        }
        /// <summary>
        /// Handler cho form_load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            fullToolStripMenuItem.Checked = true;
            leftHistory = new List<string>();
            rightHistory = new List<string>();
            DriveInfo leftDrive;
            DriveInfo rightDrive;
            NumberFormatInfo format = new CultureInfo("en-US", false).NumberFormat;
            try//Thu lay du lieu tu setting.Default(La duong dan tu lan su dung trc duoc luu lai sau khi tat chuong trinh)
            {
                leftDrive = new DriveInfo(new DirectoryInfo(Properties.Settings.Default.dirLeft).Root.Name);
                leftDirectory = Properties.Settings.Default.dirLeft;
            }
            catch (Exception ex)//Neu xay ra loi, duong dan ban dau se la phan tu dau tien trong danh sach cac drive tra ve tu ham directory.GetDrives()
            {
                leftDrive = DriveInfo.GetDrives()[0];
                leftDirectory = leftDrive.Name;
            }
            leftHistory.Add(leftDirectory);
            comboBox2.Items.Add(leftDirectory);
            DropDownWidth(comboBox2);
            try//Tuong tu nhu cua ben phai da giai thich o tren
            {
                rightDrive = new DriveInfo(new DirectoryInfo(Properties.Settings.Default.dirRight).Root.Name);
                rightDirectory = Properties.Settings.Default.dirRight;
            }
            catch (Exception ex)
            {
                rightDrive = DriveInfo.GetDrives()[0];
                rightDirectory = rightDrive.Name;
            }
            rightHistory.Add(rightDirectory);
            comboBox4.Items.Add(rightDirectory);
            DropDownWidth(comboBox4);//Xac dinh lai chieu nganh cua comboBox4 sau khi them phan tu nham hien thi du tat cac cac item
            //Tao chuoi the hien thong so ve kich thuoc va phan con trong trong drive cua dunog dan dang duoc hien thi
            directoryLeftLabel.Text = String.Concat("[", leftDrive.VolumeLabel, "] ", Convert.ToString((double)leftDrive.AvailableFreeSpace / 1024, format), " k of ", Convert.ToString((double)leftDrive.TotalSize / 1024, format), " k free");
            directoryRightLabel.Text = String.Concat("[", rightDrive.VolumeLabel, "] ", Convert.ToString((double)rightDrive.AvailableFreeSpace / 1024, format), " k of ", Convert.ToString((double)rightDrive.TotalSize / 1024, format), " k free");
            //Them drive vao DriveCombobox
            System.IO.DriveInfo[] driveList = System.IO.DriveInfo.GetDrives();
            foreach (System.IO.DriveInfo drive in driveList)
            {
                leftDriveComboBox.Items.Add(drive);
                rightDriveComboBox.Items.Add(drive);
            }

            //Thuc hien viec thay doi Text cua leftDriveComboBox nhung khong trigger handle TextChange
            leftDriveComboBox.TextChanged -= rightDriveComboBox_TextChanged;
            leftDriveComboBox.Text = leftDrive.Name;
            leftDriveComboBox.TextChanged += rightDriveComboBox_TextChanged;
            rightDriveComboBox.TextChanged -= rightDriveComboBox_TextChanged;
            rightDriveComboBox.Text = rightDrive.Name;
            rightDriveComboBox.TextChanged += rightDriveComboBox_TextChanged;
            lvwleftColumnSorter = new ListViewColumnSorter();
            this.directoryLeftListView.ListViewItemSorter = lvwleftColumnSorter;
            lvwrightColumnSorter = new ListViewColumnSorter();
            this.directoryRightListView.ListViewItemSorter = lvwrightColumnSorter;

            //Trich xuat lich su tim kiem tu setting
            searchHistory = new List<string>(Properties.Settings.Default.searchHistory.Split('|'));
            for(int i = 0; i < searchHistory.Count; i++)
                if(String.IsNullOrEmpty(searchHistory[i]))
                {
                    searchHistory.Remove(searchHistory[i]);
                    i--;
                }
            comboBox1.Items.AddRange(searchHistory.ToArray());
            comboBox3.Items.AddRange(searchHistory.ToArray());
            button1_Click(null, null);
            button5_Click(null, null);
            //Lấy đường dẫn winRAR
            Properties.Settings.Default.winRARdir = DirGet.GetExePath(".rar");
           // Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Ham dong mo TreeView panel
        /// De giai quyet van de ve toc do xu ly, TreeView se khong load toan bo
        /// tat ca duong dan ma se chi load con cua duong dan va con cua con duong dan
        /// Viec toi gian nay da xu ly duoc van de cham xu ly ma van giu duoc do hieu
        /// qua.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SwitchThroughTreePanelOptionBtn_Clicked(object sender, EventArgs e)
        {
            ToolStripButton button = (ToolStripButton)sender;
            TableLayoutPanel tableLayoutPanel = (TableLayoutPanel)selectedPanel.Parent.Parent;
            TreeView treeView = (TreeView)tableLayoutPanel.GetControlFromPosition(0, 0);
            //Xac dinh panel dang duoc chon co bat treeView chua
            if (selectedPanel.Width == selectedPanel.Parent.Parent.Width)//TreeView chua bat => Bat
            {
                treeView.Nodes.Clear();//Xoa toan bo treeView de tao lai
                //Chinh lai kich thuoc cua listView va TreeView trong TableLayoutPanel
                //Neu TreeView dang khong bat thi ListView se co 100% kich thuoc cua TableLayoutPanel
                //Neu khong thi TreeView se chiem 50% conf ListView chiem 50%
                tableLayoutPanel.ColumnStyles[0] = new ColumnStyle(SizeType.Percent, 50F);
                tableLayoutPanel.ColumnStyles[1] = new ColumnStyle(SizeType.Percent, 50F);
                //Khi moi mo TreeView se chi co cac not la cac Drive trong may
                System.IO.DriveInfo[] DriveList = System.IO.DriveInfo.GetDrives();
                for (int i = 0; i < DriveList.Length; i++)
                {
                    //Tao node moi
                    TreeNode node = new TreeNode(DriveList[i].Name);
                    //Them node vao cay
                    treeView.Nodes.Add(node);
                    //Them con cua node vao node do
                    ListDirectory(node);
                }
                button.Checked = true;//Chuyen Button ve check
            }
            else//Da bat TreeView => Tat
            {
                tableLayoutPanel.ColumnStyles[0] = new ColumnStyle(SizeType.Percent, 0F);
                tableLayoutPanel.ColumnStyles[1] = new ColumnStyle(SizeType.Percent, 100F);
                button.Checked = false;
                treeView.Nodes.Clear();
            }

        }
        /// <summary>
        /// Ham TreeView_AfterExpand them cac node con vao node con cua node con
        /// vao cay khi node duoc mo trong.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TreeView_AfterExpand(object sender, TreeViewEventArgs e)
        {
            foreach (TreeNode node in e.Node.Nodes)
                ListDirectory(node);
        }
        /// <summary>
        /// Ham ListDirectory co dau vao la mot TreeNode TP. Ham se them cac 
        /// subdirectory(node) cua duong dan tai node TP vao danh sach node 
        /// con cua TP.
        /// </summary>
        /// <param name="TP"></param>
        private void ListDirectory(TreeNode TP)
        {
            try
            {
                string[] dirlist = System.IO.Directory.GetDirectories(DirGet.GetDirectory(TP));
                foreach (string dir in dirlist)
                {
                    TreeNode node = new TreeNode(new System.IO.DirectoryInfo(dir).Name, 0, 0);
                    TP.Nodes.Add(node);
                }
            }
            catch { }
        }

        /// <summary>
        /// Xu ly event Click cua LeftPanel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LeftPanel_Click(object sender, EventArgs e)
        {
            if ((sender as ListView).Parent.Controls.Contains(this.quickViewPanel))
            {
                (sender as ListView).Parent.Controls.Remove(this.quickViewPanel);
                (selectedPanel.Parent as TableLayoutPanel).Controls.Add(this.quickViewPanel, 0, 1);
            }
            //Chuyen selectPanel thanh object goi handle nay
            selectedPanel = (ListView)sender;
            //Thay doi danh sach Item cua ComboBox duoi de phu hop voi Duong dan cua panel dang chon
            Directory_Label.Text = (selectedPanel == directoryLeftListView) ? _leftDirectory : _rightDirectory;
            PopulateDirectoryConboBox(Directory_ComboBox, Directory_Label.Text);
            //Xac dinh lai tinh trang bat/Tat cua TreeView tai Panel duoc an
            if (selectedPanel.Width != selectedPanel.Parent.Parent.Width)
                SwitchThroughTreePanelOptionBtn.Checked = true;
            else
                SwitchThroughTreePanelOptionBtn.Checked = false;
        }
        /// <summary>
        /// Xu ly event Chon Node cua TreeView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DirectoryLeftTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeView tree = sender as TreeView;
            if (tree.Name.Contains("Left"))
            {
                leftDirectoryIntoHistory(DirGet.GetDirectory(e.Node));
                if (leftTableLayoutPanel.ColumnStyles[1].Width == 0)
                {
                    leftTableLayoutPanel.ColumnStyles[0] = new ColumnStyle(SizeType.Percent, 50F);
                    leftTableLayoutPanel.ColumnStyles[1] = new ColumnStyle(SizeType.Percent, 50F);
                }
            }
            else
            {
                rightDirectoryIntoHistory(DirGet.GetDirectory(e.Node));
                if (rightTableLayoutPanel.ColumnStyles[1].Width == 0)
                {
                    rightTableLayoutPanel.ColumnStyles[0] = new ColumnStyle(SizeType.Percent, 100F);
                    rightTableLayoutPanel.ColumnStyles[1] = new ColumnStyle(SizeType.Percent, 0F);
                }
            }

        }
        /// <summary>
        /// Lam day ListView voi doi so la duong dan.
        /// </summary>
        /// <param name="listView"></param>
        /// <param name="path"></param>
        private void PopulateListView(ListView listView, string path)
        {
            listView.Items.Clear();//Xoa Danh sach cu
            string[] DirList = System.IO.Directory.GetDirectories(path);//Lay danh sach folder
            string[] FileList = System.IO.Directory.GetFiles(path);//Lay danh sach file
            foreach (string Dir in DirList)
            {
                try
                {
                    using (EditDirInfo edir = new EditDirInfo(Dir))
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
        /// <summary>
        /// Lam dat comboBox
        /// </summary>
        /// <param name="path"></param>
        private void PopulateDirectoryConboBox(ComboBox comboBox, string path)
        {
            comboBox.Items.Clear();
            string[] DirList = System.IO.Directory.GetDirectories(path);
            foreach (string Directory in DirList)
                comboBox.Items.Add("\\" + new System.IO.DirectoryInfo(Directory).Name);
        }
        /// <summary>
        /// Xu ly event khi phan tu trong comboBox duoc chon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Directory_ComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            string Directory = Directory_Label.Text + Directory_ComboBox.Text;
            if (selectedPanel.Name == "directoryLeftListView")
                leftDirectoryIntoHistory(Directory);
            else
                rightDirectoryIntoHistory(Directory);
        }
        /// <summary>
        /// Xu ly cac cong viec khi thay doi duong dan.
        /// Ham duoc goi khi leftDirectory hoac rightDirectory goi ham set.
        /// Cac cong viec can thuc hien hoac kiem tra se duoc thuc hien trong
        /// ham nay
        /// </summary>
        /// <param name="listView"></param>
        /// <param name="Directory"></param>
        private void ChangeDirectory(ListView listView, string Directory)
        {
                PopulateListView(listView, Directory);
                Directory_Label.Text = Directory;
                PopulateDirectoryConboBox(Directory_ComboBox,Directory_Label.Text);
        }
        /// <summary>
        /// Xu ly event Form_close
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.dirLeft = _leftDirectory;
            Properties.Settings.Default.dirRight = _rightDirectory;
            string a = "";
            int length = searchHistory.Count > 10 ? 10 : searchHistory.Count;
            for (int i = 0; i < length; i++)
                if(!String.IsNullOrEmpty(searchHistory[i]))
                    a += searchHistory[i] + "|";
            Properties.Settings.Default.searchHistory = a;  
            Properties.Settings.Default.Save();
        }
        /// <summary>
        /// <event> Chuyển đổi View (giữa Large Icon và Detail) của ListView</event>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            AllFileDetailsBtn.Checked = false;
            OnlyFileNamesBtn.Checked = false;
            briefToolStripMenuItem.Checked = false;
            fullToolStripMenuItem.Checked = false;
            commentsToolStripMenuItem.Checked = true;
        }
        /// <summary>
        /// <Method> xóa các cột chỉ để lại cột TÊN của các ListViewItem </Method> 
        /// </summary>
        /// <param name="listview"></param>
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
        /// <summary>
        /// <event> Chỉ thể hiện tên của các LítViewItem </event>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnlyFileNamesBtn_Click(object sender, EventArgs e)
        {
            if (directoryLeftListView.View == View.LargeIcon)
            {
                directoryLeftListView.View = View.Details;
                directoryRightListView.View = View.Details;
            }

            if (onlyname == false)
            {
                ListViewOnlyName(directoryLeftListView);
                ListViewOnlyName(directoryRightListView);
                onlyname = true;
            }
            AllFileDetailsBtn.Checked = false;
            ThumbnailViewBtn.Checked = false;
            briefToolStripMenuItem.Checked = true;
            fullToolStripMenuItem.Checked = false;
            commentsToolStripMenuItem.Checked = false;
        }
        /// <summary>
        /// <event> Thể hiện lại tất cả các cột của ListViewItem </event>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AllFileDetailsBtn_Click(object sender, EventArgs e)
        {
            if (directoryLeftListView.View == View.LargeIcon)
            {
                directoryLeftListView.View = View.Details;
                directoryRightListView.View = View.Details;
            }
            if (onlyname == true)
            {
                ChangeDirectory(directoryLeftListView, _leftDirectory);
                ChangeDirectory(directoryRightListView, _rightDirectory);
                onlyname = false;
            }
            ThumbnailViewBtn.Checked = false;
            OnlyFileNamesBtn.Checked = false;
            briefToolStripMenuItem.Checked = false;
            fullToolStripMenuItem.Checked = true;
            commentsToolStripMenuItem.Checked = false;
        }
        /// <summary>
        /// <event> Set lại width của các cột khi width của Left ListView thay đổi</event>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dRLVsizechange(object sender, EventArgs e)
        {
            int a = directoryRightListView.Width - System.Windows.Forms.SystemInformation.VerticalScrollBarWidth;
            directoryRightListView.Columns[0].Width = a / 100 * 50;
            directoryRightListView.Columns[1].Width = a / 100 * 10;
            directoryRightListView.Columns[2].Width = a / 100 * 20;
            directoryRightListView.Columns[3].Width = a / 100 * 10;
            directoryRightListView.Columns[4].Width = a / 100 * 10;
        }
        /// <summary>
        /// <event> Set lại width của các cột khi width của Right ListView thay đổi </event>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dLLVsizechange(object sender, EventArgs e)
        {
            int a = directoryLeftListView.Width - System.Windows.Forms.SystemInformation.VerticalScrollBarWidth;
            directoryLeftListView.Columns[0].Width = a / 100 * 50;
            directoryLeftListView.Columns[1].Width = a / 100 * 10;
            directoryLeftListView.Columns[2].Width = a / 100 * 20;
            directoryLeftListView.Columns[3].Width = a / 100 * 10;
            directoryLeftListView.Columns[4].Width = a / 100 * 10;
        }
        /// <summary>
        /// Xu ly event TextChange ComboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rightDriveComboBox_TextChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox.Name.Contains("left"))
                leftDirectoryIntoHistory(comboBox.Text);
            else
                rightDirectoryIntoHistory(comboBox.Text);
            ListView listView = comboBox.Name.Contains("left") ? directoryLeftListView : directoryRightListView;
            ChangeDirectory(listView, comboBox.Text);
            if (comboBox.Name.Contains("left"))
            {
                DriveInfo leftDrive = new DriveInfo(new DirectoryInfo(_leftDirectory).Root.Name);
                directoryLeftLabel.Text = String.Concat("[", leftDrive.VolumeLabel, "] ", Convert.ToString((double)leftDrive.AvailableFreeSpace / 1024), " k of ", Convert.ToString((double)leftDrive.TotalSize / 1024), " k free");
            }
            else
            {
                DriveInfo rightDrive = new DriveInfo(new DirectoryInfo(_rightDirectory).Root.Name);
                directoryRightLabel.Text = String.Concat("[", rightDrive.VolumeLabel, "] ", Convert.ToString((double)rightDrive.AvailableFreeSpace / 1024), " k of ", Convert.ToString((double)rightDrive.TotalSize / 1024), " k free");
            }
        }

        private void directoryRightListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string Directory = Directory_Label.Text + "\\" + directoryRightListView.SelectedItems[0].Text;
            FileAttributes attr = File.GetAttributes(Directory + "." + directoryRightListView.SelectedItems[0].SubItems[3].Text);
            if (attr.HasFlag(FileAttributes.Directory))
                rightDirectoryIntoHistory(Directory);
            else
            {
                ProcessStartInfo psStartInfo = new ProcessStartInfo();
                psStartInfo.FileName = Directory + "." + directoryRightListView.SelectedItems[0].SubItems[3].Text;
                Process ps = Process.Start(psStartInfo);
            }
        }
        /// <summary>
        /// Xu ly event double_click Item trong listView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void directoryLeftListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string Directory = Directory_Label.Text + "\\" + directoryLeftListView.SelectedItems[0].Text;
            FileAttributes attr = File.GetAttributes(Directory + "." + directoryLeftListView.SelectedItems[0].SubItems[3].Text);

            if (attr.HasFlag(FileAttributes.Directory))//La file hay folder
                leftDirectoryIntoHistory(Directory);
            else
            {
                ProcessStartInfo psStartInfo = new ProcessStartInfo();//Tao tien tring moi
                psStartInfo.FileName = Directory + "." + directoryLeftListView.SelectedItems[0].SubItems[3].Text;
                Process ps = Process.Start(psStartInfo);//Mo file
            }
        }
        /// <summary>
        /// Xu ly event Click cua not GoBack
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GoBackBtn_Click(object sender, EventArgs e)
        {
            try//Thu lay gia tri o sau vi tri 
            {
                if (selectedPanel.Name == "directoryLeftListView")
                    if (leftHistory.IndexOf(leftDirectory) <= 0)
                        leftDirectory = new DirectoryInfo(leftDirectory).Parent.FullName;
                    else
                        leftDirectory = leftHistory[leftHistory.IndexOf(leftDirectory) - 1];
                else
                    if (rightHistory.IndexOf(rightDirectory) <= 0)
                        rightDirectory = new DirectoryInfo(rightDirectory).Parent.FullName;
                    else
                        rightDirectory = leftHistory[rightHistory.IndexOf(rightDirectory) - 1];
            }
            catch { }//Loi

        }

        /// <summary>
        /// Xu ly event Click cua GoForward
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GoForwardBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedPanel.Name == "directoryLeftListView")
                    leftDirectory = leftHistory[leftHistory.IndexOf(leftDirectory) + 1];
                else
                    rightDirectory = rightHistory[rightHistory.IndexOf(rightDirectory) + 1];
            }
            catch { }
        }

        private void leftDirectoryIntoHistory(string Directory)
        {
            if (leftHistory.IndexOf(leftDirectory) == leftHistory.Count - 1)
                leftHistory.Add(Directory);
            else
            {
                leftHistory.RemoveRange(leftHistory.IndexOf(leftDirectory) + 1, leftHistory.Count - leftHistory.IndexOf(leftDirectory) - 1);
                leftHistory.Add(Directory);
            }
            leftDirectory = Directory;
            populateHistoryConboBox(comboBox2, leftHistory);
            DropDownWidth(comboBox2);
        }
        private void rightDirectoryIntoHistory(string Directory)
        {
            if (rightHistory.IndexOf(rightDirectory) == rightHistory.Count - 1)
                rightHistory.Add(Directory);
            else
            {
                rightHistory.RemoveRange(rightHistory.IndexOf(rightDirectory) + 1, rightHistory.Count - rightHistory.IndexOf(rightDirectory) - 1);
                rightHistory.Add(Directory);
            }
            rightDirectory = Directory;
            populateHistoryConboBox(comboBox4, rightHistory);
            DropDownWidth(comboBox4);
        }
        private void DropDownWidth(ComboBox myCombo)
        {
            int maxWidth = 0, temp = 0;
            foreach (var obj in myCombo.Items)
            {
                temp = TextRenderer.MeasureText(obj.ToString(), myCombo.Font).Width;
                if (temp > maxWidth)
                {
                    maxWidth = temp;
                }
            }
            myCombo.DropDownWidth = maxWidth + 30;
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            leftDirectory = comboBox.SelectedItem as string;
        }
        private void comboBox4_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            rightDirectory = comboBox.SelectedItem as string;
        }
        private void directoryRightListView_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void directoryLeftListView_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                Copy();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void directoryLeftListView_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void directoryRightListView_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                Copy();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void directoryRightListView_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(e.Item, DragDropEffects.Copy);
        }

        private void directoryLeftListView_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(e.Item, DragDropEffects.Copy);
        }

        private void changesAttributesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((selectedPanel as ListView).SelectedItems.Count > 1)
                MessageBox.Show("Chi duoc chon mot file", "TooManyItem");
            else
                try
                {
                    string Directory = Directory_Label.Text + "\\" + (selectedPanel as ListView).SelectedItems[0].Text;
                    FileInfo fileInfo = new FileInfo(Directory + "." + (selectedPanel as ListView).SelectedItems[0].SubItems[3].Text);
                    ChangeAttributeForm changeAttributeForm = new ChangeAttributeForm(fileInfo);
                    changeAttributeForm.ShowDialog();
                }
                catch (ArgumentOutOfRangeException ex)
                { MessageBox.Show("Hay chon mot file", "ArgumentOutOfRangeException"); }
        }
        private void leftListViewColumnSort(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == lvwleftColumnSorter.SortColumn)
                // Reverse the current sort direction for this column.
                if (lvwleftColumnSorter.Order == SortOrder.Ascending)
                    lvwleftColumnSorter.Order = SortOrder.Descending;
                else
                    lvwleftColumnSorter.Order = SortOrder.Ascending;
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwleftColumnSorter.SortColumn = e.Column;
                lvwleftColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            this.directoryLeftListView.Sort();
        }
        private void rightListViewColumnSort(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == lvwrightColumnSorter.SortColumn)
                // Reverse the current sort direction for this column.
                if (lvwrightColumnSorter.Order == SortOrder.Ascending)
                    lvwrightColumnSorter.Order = SortOrder.Descending;
                else
                    lvwrightColumnSorter.Order = SortOrder.Ascending;
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwrightColumnSorter.SortColumn = e.Column;
                lvwrightColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            this.directoryRightListView.Sort();
        }
        private void populateHistoryConboBox(ComboBox comboBox, List<string> history)
        {
            comboBox.Items.Clear();
            foreach (string historyItem in history)
                comboBox.Items.Add(historyItem);
        }

        [DllImport("shell32.dll", CharSet = CharSet.Auto)]
        static extern bool ShellExecuteEx(ref SHELLEXECUTEINFO lpExecInfo);

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct SHELLEXECUTEINFO
        {
            public int cbSize;
            public uint fMask;
            public IntPtr hwnd;
            [MarshalAs(UnmanagedType.LPTStr)]
            public string lpVerb;
            [MarshalAs(UnmanagedType.LPTStr)]
            public string lpFile;
            [MarshalAs(UnmanagedType.LPTStr)]
            public string lpParameters;
            [MarshalAs(UnmanagedType.LPTStr)]
            public string lpDirectory;
            public int nShow;
            public IntPtr hInstApp;
            public IntPtr lpIDList;
            [MarshalAs(UnmanagedType.LPTStr)]
            public string lpClass;
            public IntPtr hkeyClass;
            public uint dwHotKey;
            public IntPtr hIcon;
            public IntPtr hProcess;
        }

        private const int SW_SHOW = 5;
        private const uint SEE_MASK_INVOKEIDLIST = 12;
        public static bool ShowFileProperties(string Filename)
        {
            SHELLEXECUTEINFO info = new SHELLEXECUTEINFO();
            info.cbSize = System.Runtime.InteropServices.Marshal.SizeOf(info);
            info.lpVerb = "properties";
            info.lpFile = Filename;
            info.nShow = SW_SHOW;
            info.fMask = SEE_MASK_INVOKEIDLIST;
            return ShellExecuteEx(ref info);
        }
        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            if ((selectedPanel as ListView).SelectedItems.Count > 1)
                MessageBox.Show("Chi duoc chon mot file", "TooManyItem");
            else
            {
                if ((selectedPanel as ListView).SelectedItems[0].SubItems[1].Text == "<DIR>")
                    ShowFileProperties(Path.Combine(Directory_Label.Text, (selectedPanel as ListView).SelectedItems[0].Text));
                else
                    ShowFileProperties(Path.Combine(Directory_Label.Text, (selectedPanel as ListView).SelectedItems[0].Text + "." + (selectedPanel as ListView).SelectedItems[0].SubItems[3].Text));
            }
        }
        private void comboBox1_keyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                    if (button1.BackColor == System.Drawing.SystemColors.ControlDark)
                        leftDirectory = comboBox1.Text;
                    else
                        if (!leftBackgroundWorker.IsBusy)
                        leftBackgroundWorker.RunWorkerAsync();
            }
            catch (Exception ex)
            { }
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string str = "";
                comboBox1.Invoke(new Action(() => { str = comboBox1.Text; }));//Lay gia tri tu comboBox1
                if (str != "")
                {
                    BackgroundWorker worker = sender as BackgroundWorker;
                    directoryLeftListView.Invoke(new Action(() => { directoryLeftListView.Items.Clear(); }));
                    foreach (string dir in Directory.GetFileSystemEntries(leftDirectory))
                        if (worker.CancellationPending == true)
                        {
                            e.Cancel = true;
                            break;
                        }
                        else
                        {
                            FileInfo temp = new FileInfo(dir);
                            if (temp.Attributes.HasFlag(FileAttributes.Directory))
                            {
                                if (temp.Name.Contains(str))
                                    directoryLeftListView.Invoke(new Action(() => { directoryLeftListView.Items.Add(EditDirInfo.NewLVI(new EditDirInfo(temp.FullName))); }));
                            }
                            else
                                if (temp.Name.Contains(str))
                                directoryLeftListView.Invoke(new Action(() => { directoryLeftListView.Items.Add(EditFileInfo.NewLVI(new EditFileInfo(temp.FullName))); }));
                        }
                    if (!searchHistory.Contains(str))
                    {
                        searchHistory.Add(str);
                        comboBox1.Invoke(new Action(() => { comboBox1.Items.Add(str); }));
                        comboBox3.Invoke(new Action(() => { comboBox3.Items.Add(str); }));
                    }
                }
                else
                    this.Invoke(new Action(() => { PopulateListView(directoryLeftListView, leftDirectory); }));
            }
            catch (Exception ex)
            { }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
                Console.WriteLine("Cancel!!");
            if (e.Error != null)
                MessageBox.Show(e.Error.ToString());
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (leftBackgroundWorker.IsBusy)
                leftBackgroundWorker.CancelAsync();
        }

        private void comboBox2_keyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                    if (button3.BackColor == System.Drawing.SystemColors.ControlDark)
                        rightDirectory = comboBox3.Text;
                    else
                        if (!rightBackgroundWorker.IsBusy)
                        rightBackgroundWorker.RunWorkerAsync();
            }
            catch (Exception ex)
            { }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string str = "";
                comboBox3.Invoke(new Action(() => { str = comboBox3.Text; }));
                if (str != "")
                {
                    BackgroundWorker worker = sender as BackgroundWorker;
                    Stack<FileInfo> dirList = new Stack<FileInfo>();
                    directoryRightListView.Invoke(new Action(() => { directoryRightListView.Items.Clear(); }));
                    foreach (string dir in Directory.GetFileSystemEntries(rightDirectory))
                        dirList.Push(new FileInfo(dir));
                    while (dirList.Count >= 1)
                        if (worker.CancellationPending == true)
                        {
                            e.Cancel = true;
                            break;
                        }
                        else
                        {
                            FileInfo temp = dirList.Pop();
                            if (temp.Attributes.HasFlag(FileAttributes.Directory))
                            {
                                if (temp.Name.Contains(str))
                                    directoryRightListView.Invoke(new Action(() => { directoryRightListView.Items.Add(EditDirInfo.NewLVI(new EditDirInfo(temp.FullName))); }));
                                foreach (string dir in Directory.GetFileSystemEntries(temp.FullName))
                                    dirList.Push(new FileInfo(dir));
                            }
                            else
                                if (temp.Name.Contains(str))
                                directoryRightListView.Invoke(new Action(() => { directoryRightListView.Items.Add(EditFileInfo.NewLVI(new EditFileInfo(temp.FullName))); }));
                        }
                    if (!searchHistory.Contains(str))
                    {
                        searchHistory.Add(str);
                        comboBox1.Invoke(new Action(() => { comboBox1.Items.Add(str); }));
                        comboBox3.Invoke(new Action(() => { comboBox3.Items.Add(str); }));
                    }
                }
                else
                {
                    this.Invoke(new Action(() => { PopulateListView(directoryRightListView, rightDirectory); }));
                }
            }
            catch (Exception ex)
            { }
        }

        private void comboBox3_TextChanged(object sender, EventArgs e)
        {
            if (rightBackgroundWorker.IsBusy)
                rightBackgroundWorker.CancelAsync();
        }

        private void treeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedPanel.Name == "directoryLeftListView")
            {
                directoryLeftTreeView.Nodes.Clear();//Xoa toan bo treeView de tao lai
                //Khi moi mo TreeView se chi co cac not la cac Drive trong may
                System.IO.DriveInfo[] DriveList = System.IO.DriveInfo.GetDrives();
                for (int i = 0; i < DriveList.Length; i++)
                {
                    //Tao node moi
                    TreeNode node = new TreeNode(DriveList[i].Name);
                    //Them node vao cay
                    directoryLeftTreeView.Nodes.Add(node);
                    //Them con cua node vao node do
                    ListDirectory(node);
                }
                leftTableLayoutPanel.ColumnStyles[0] = new ColumnStyle(SizeType.Percent, 100F);
                leftTableLayoutPanel.ColumnStyles[1] = new ColumnStyle(SizeType.Percent, 0F);
            }
            else
            {
                directoryRightTreeView.Nodes.Clear();//Xoa toan bo treeView de tao lai
                //Khi moi mo TreeView se chi co cac not la cac Drive trong may
                System.IO.DriveInfo[] DriveList = System.IO.DriveInfo.GetDrives();
                for (int i = 0; i < DriveList.Length; i++)
                {
                    //Tao node moi
                    TreeNode node = new TreeNode(DriveList[i].Name);
                    //Them node vao cay
                    directoryLeftTreeView.Nodes.Add(node);
                    //Them con cua node vao node do
                    ListDirectory(node);
                }
                rightTableLayoutPanel.ColumnStyles[0] = new ColumnStyle(SizeType.Percent, 100F);
                rightTableLayoutPanel.ColumnStyles[1] = new ColumnStyle(SizeType.Percent, 0F);
            }
            SwitchThroughTreePanelOptionBtn.Checked = true;
        }

        private void RereadSourceBtn_Click(object sender, EventArgs e)
        {
            RefreshDir();
        }
        //Shortcut Key
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if(e.KeyCode == Keys.F1)
                    OnlyFileNamesBtn_Click(sender, e);
                if (e.KeyCode == Keys.F2)
                    if (e.Alt)
                        ThumbnailViewBtn_Click(sender, e);
                    else
                        AllFileDetailsBtn_Click(sender, e);
                if (e.KeyCode == Keys.F3)
                    changeListViewSort(0);
                if (e.KeyCode == Keys.F4)
                    changeListViewSort(1);
                if (e.KeyCode == Keys.F5)
                    changeListViewSort(2);
                if (e.KeyCode == Keys.F6)
                    changeListViewSort(3);
            }
            else
            {
                if (e.Alt && e.KeyCode == Keys.F4)
                    this.Close();
                if (e.KeyCode == Keys.F2)
                    try
                    {
                        RenameForm newDirectory = new RenameForm(this);
                        newDirectory.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                    }
                if (e.KeyCode == Keys.F4)
                    try
                    {
                        EditFile();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                    }
                if (e.KeyCode == Keys.F5)
                    try
                    {
                        Copy();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                    }
                if (e.Alt && e.KeyCode == Keys.Enter)
                    if ((selectedPanel as ListView).SelectedItems.Count > 1)
                        MessageBox.Show("Chi duoc chon mot file", "TooManyItem");
                    else
                        if ((selectedPanel as ListView).SelectedItems[0].SubItems[1].Text == "<DIR>")
                        ShowFileProperties(Path.Combine(Directory_Label.Text, (selectedPanel as ListView).SelectedItems[0].Text));
                    else
                        ShowFileProperties(Path.Combine(Directory_Label.Text, (selectedPanel as ListView).SelectedItems[0].Text + "." + (selectedPanel as ListView).SelectedItems[0].SubItems[3].Text));
                if (e.KeyCode == Keys.F6)
                    try
                    {
                        move();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                    }
                if (e.KeyCode == Keys.F7)
                    try
                    {
                        NewDirectoryForm newDirectory = new NewDirectoryForm(this);
                        newDirectory.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                    }
                if (e.KeyCode == Keys.F8)
                    try
                    {
                        if (Control.ModifierKeys == Keys.Shift)
                            Delete(true);
                        else
                            Delete(false);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                    }
            }
        }
        //Close Form
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //CopyFile
        public void Copy()
        {
            string[] name;
            string[] ext;
            string[] path;
            string realDest;
            if (selectedPanel.SelectedItems.Count > 0)
            {
                string defaulttext;
                string msg = "Copy " + selectedPanel.SelectedItems.Count + " item(s) to:";
                if (selectedPanel == directoryLeftListView)
                    defaulttext = _rightDirectory;
                else
                    defaulttext = _leftDirectory;
                CopyMoveForm temp = new CopyMoveForm(this, msg, "Copy", defaulttext);
                DialogResult dr = temp.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    name = new string[selectedPanel.SelectedItems.Count];
                    ext = new string[selectedPanel.SelectedItems.Count];
                    path = new string[selectedPanel.SelectedItems.Count];
                    for (int i = 0; i < selectedPanel.SelectedItems.Count; i++)
                    {
                        name[i] = selectedPanel.SelectedItems[i].SubItems[0].Text;
                        ext[i] = selectedPanel.SelectedItems[i].SubItems[3].Text;
                        path[i] = selectedPanel.SelectedItems[i].Tag.ToString();
                    }
                    DirectoryInfo a = new DirectoryInfo(temp.getPath());
                    realDest = a.FullName;
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("No files selected!", "Error");
                return;
            }
            if (selectedPanel == directoryLeftListView)
            {
                for (int i = 0; i < name.Length; i++)
                {
                    int index = -1;
                    foreach (ListViewItem LVI in directoryLeftListView.Items)
                    {
                        if (LVI.SubItems[0].Text == name[i] && LVI.SubItems[3].Text == ext[i])
                        {
                            index = LVI.Index;
                            break;
                        }
                    }
                    string source = path[i];
                    string defaultDest = new DirectoryInfo(_rightDirectory).FullName;
                    if (directoryLeftListView.Items[index].SubItems[1].Text != "<DIR>")
                    {
                        if (CopyMove.preCopyMove(source, realDest, defaultDest, directoryRightListView) == true)
                            CopyMove.CaseOfCopyFile(source, realDest, defaultDest, directoryLeftListView, directoryRightListView, index);
                    }
                    else
                    {
                        if (CopyMove.preCopyMove(source, realDest, defaultDest, directoryRightListView) == true)
                            CopyMove.CaseOfCopyFolder(source, realDest, defaultDest, directoryLeftListView, directoryRightListView, index);
                    }
                }
            }
            if (selectedPanel == directoryRightListView)
            {
                for (int i = 0; i < name.Length; i++)
                {
                    int index = -1;
                    foreach (ListViewItem LVI in directoryRightListView.Items)
                    {
                        if (LVI.SubItems[0].Text == name[i] && LVI.SubItems[3].Text == ext[i])
                        {
                            index = LVI.Index;
                            break;
                        }
                    }
                    string source = path[i];
                    string defaultDest = new DirectoryInfo(_leftDirectory).FullName;
                    if (directoryRightListView.Items[index].SubItems[1].Text != "<DIR>")
                    {
                        if (CopyMove.preCopyMove(source, realDest, defaultDest, directoryLeftListView) == true)
                            CopyMove.CaseOfCopyFile(source, realDest, defaultDest, directoryRightListView, directoryLeftListView, index);
                    }
                    else
                    {
                        if (CopyMove.preCopyMove(source, realDest, defaultDest, directoryLeftListView) == true)
                            CopyMove.CaseOfCopyFolder(source, realDest, defaultDest, directoryRightListView, directoryLeftListView, index);
                    }
                }
            }
        }
        //CopyFile Event
        private void F5Button_Click(object sender, EventArgs e)
        {
            try
            {
                Copy();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }

        private void CopyB_Click(object sender, EventArgs e)
        {
            try
            {
                Copy();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        //DeleteFile
        private void Delete(bool deleteOption)
        {
            string[] name;
            string[] ext;
            string[] path;
            if (selectedPanel.SelectedItems.Count > 0)
            {
                string msg = null;
                if (deleteOption == false)
                {
                    msg = "Move " + selectedPanel.SelectedItems.Count + " item(s) to recycle bin?";
                }
                else
                {
                    msg = "Delete " + selectedPanel.SelectedItems.Count + " item(s) permanently?";
                }
                if (MessageBox.Show(msg, "Delete item", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    name = new string[selectedPanel.SelectedItems.Count];
                    ext = new string[selectedPanel.SelectedItems.Count];
                    path = new string[selectedPanel.SelectedItems.Count];
                    for (int i = 0; i < selectedPanel.SelectedItems.Count; i++)
                    {
                        name[i] = selectedPanel.SelectedItems[i].SubItems[0].Text;
                        ext[i] = selectedPanel.SelectedItems[i].SubItems[3].Text;
                        path[i] = selectedPanel.SelectedItems[i].Tag.ToString();
                    }
                }
                else
                {
                    return;
                }
            }
            else
            {
                return;
            }
            if (selectedPanel == directoryLeftListView)
            {
                for (int i = 0; i < name.Length; i++)
                {
                    int index = -1;
                    foreach (ListViewItem LVI in directoryLeftListView.Items)
                    {
                        if (LVI.SubItems[0].Text == name[i] && LVI.SubItems[3].Text == ext[i])
                        {
                            index = LVI.Index;
                            break;
                        }
                    }
                    if (directoryLeftListView.Items[index].SubItems[1].Text != "<DIR>")
                    {
                        string fileName = directoryLeftListView.Items[index].SubItems[0].Text + "."
                            + directoryLeftListView.Items[index].SubItems[3].Text;
                        string filePath = Path.Combine(_leftDirectory, fileName);
                        if (deleteOption == true)
                        {
                            File.Delete(filePath);
                        }
                        else
                        {
                            FileSystem.DeleteFile(filePath, UIOption.AllDialogs, RecycleOption.SendToRecycleBin);
                        }
                    }
                    else
                    {
                        string folderName = directoryLeftListView.Items[index].SubItems[0].Text;
                        string folderPath = Path.Combine(_leftDirectory, folderName);
                        if (deleteOption == true)
                        {
                            CopyMove.DeleteFolder(new DirectoryInfo(folderPath));
                            Directory.Delete(folderPath);
                        }
                        else
                        {
                            FileSystem.DeleteDirectory(folderPath, UIOption.AllDialogs, RecycleOption.SendToRecycleBin);
                        }
                    }
                    directoryLeftListView.Items.RemoveAt(index);
                    if (_leftDirectory == _rightDirectory)
                        directoryRightListView.Items.RemoveAt(index);
                }
            }
            if (selectedPanel == directoryRightListView)
            {

                for (int i = 0; i < name.Length; i++)
                {
                    int index = -1;
                    foreach (ListViewItem LVI in directoryRightListView.Items)
                    {
                        if (LVI.SubItems[0].Text == name[i] && LVI.SubItems[3].Text == ext[i])
                        {
                            index = LVI.Index;
                            break;
                        }
                    }
                    if (directoryRightListView.Items[index].SubItems[1].Text != "<DIR>")
                    {
                        string fileName = directoryRightListView.Items[index].SubItems[0].Text + "."
                            + directoryRightListView.Items[index].SubItems[3].Text;
                        string filePath = Path.Combine(_rightDirectory, fileName);
                        if (deleteOption == true)
                        {
                            File.Delete(filePath);
                        }
                        else
                        {
                            FileSystem.DeleteFile(filePath, UIOption.AllDialogs, RecycleOption.SendToRecycleBin);
                        }
                    }
                    else
                    {
                        string folderName = directoryRightListView.Items[index].SubItems[0].Text;
                        string folderPath = Path.Combine(_rightDirectory, folderName);
                        if (deleteOption == true)
                        {
                            CopyMove.DeleteFolder(new DirectoryInfo(folderPath));
                            Directory.Delete(folderPath);
                        }
                        else
                        {
                            FileSystem.DeleteDirectory(folderPath, UIOption.AllDialogs, RecycleOption.SendToRecycleBin);
                        }
                    }
                    directoryRightListView.Items.RemoveAt(index);
                    if (_leftDirectory == _rightDirectory)
                        directoryLeftListView.Items.RemoveAt(index);
                }
            }
        }
        //DeleteFile Event
        private void F8Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (Control.ModifierKeys == Keys.Shift)
                    Delete(true);
                else
                    Delete(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        //MoveFile
        private void move()
        {
            string[] name;
            string[] ext;
            string[] path;
            string realDest;
            if (selectedPanel.SelectedItems.Count > 0)
            {
                string defaulttext;
                string msg = "Move " + selectedPanel.SelectedItems.Count + " item(s) to:";
                if (selectedPanel == directoryLeftListView)
                    defaulttext = _rightDirectory;
                else
                    defaulttext = _leftDirectory;
                CopyMoveForm temp = new CopyMoveForm(this, msg, "Move", defaulttext);
                DialogResult dr = temp.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    name = new string[selectedPanel.SelectedItems.Count];
                    ext = new string[selectedPanel.SelectedItems.Count];
                    path = new string[selectedPanel.SelectedItems.Count];
                    for (int i = 0; i < selectedPanel.SelectedItems.Count; i++)
                    {
                        name[i] = selectedPanel.SelectedItems[i].SubItems[0].Text;
                        ext[i] = selectedPanel.SelectedItems[i].SubItems[3].Text;
                        path[i] = selectedPanel.SelectedItems[i].Tag.ToString();
                    }
                    DirectoryInfo a = new DirectoryInfo(temp.getPath());
                    realDest = a.FullName;
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("No files seleected!", "Error");
                return;
            }
            if (selectedPanel == directoryLeftListView)
            {
                for (int i = 0; i < name.Length; i++)
                {
                    int index = -1;
                    foreach (ListViewItem LVI in directoryLeftListView.Items)
                    {
                        if (LVI.SubItems[0].Text == name[i] && LVI.SubItems[3].Text == ext[i])
                        {
                            index = LVI.Index;
                            break;
                        }
                    }
                    string source = path[i];
                    string defaultDest = new DirectoryInfo(_rightDirectory).FullName;
                    if (directoryLeftListView.Items[index].SubItems[1].Text != "<DIR>")
                    {
                        if (CopyMove.preCopyMove(source, realDest, defaultDest, directoryRightListView) == true)
                            CopyMove.CaseOfMoveFile(source, realDest, defaultDest, directoryLeftListView, directoryRightListView, index);
                    }
                    else
                    {
                        if (CopyMove.preCopyMove(source, realDest, defaultDest, directoryRightListView) == true)
                            CopyMove.CaseOfMoveFolder(source, realDest, defaultDest, directoryLeftListView, directoryRightListView, index);
                    }
                }
            }
            if (selectedPanel == directoryRightListView)
            {
                for (int i = 0; i < name.Length; i++)
                {
                    int index = -1;
                    foreach (ListViewItem LVI in directoryRightListView.Items)
                    {
                        if (LVI.SubItems[0].Text == name[i] && LVI.SubItems[3].Text == ext[i])
                        {
                            index = LVI.Index;
                            break;
                        }
                    }
                    string source = path[i];
                    string defaultDest = new DirectoryInfo(_leftDirectory).FullName;
                    if (directoryRightListView.Items[index].SubItems[1].Text != "<DIR>")
                    {
                        if (CopyMove.preCopyMove(source, realDest, defaultDest, directoryLeftListView) == true)
                            CopyMove.CaseOfMoveFile(source, realDest, defaultDest, directoryRightListView, directoryLeftListView, index);
                    }
                    else
                    {
                        if (CopyMove.preCopyMove(source, realDest, defaultDest, directoryLeftListView) == true)
                            CopyMove.CaseOfMoveFolder(source, realDest, defaultDest, directoryRightListView, directoryLeftListView, index);
                    }
                }
            }
        }
        //MoveFile Event
        private void RenameMoveB_Click(object sender, EventArgs e)
        {
            try
            {
                move();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void F6Button_Click(object sender, EventArgs e)
        {
            try
            {
                move();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void copySelecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string data = "";
            foreach (ListViewItem item in selectedPanel.SelectedItems)
                if (item.SubItems[1].Text == "<DIR>")
                    data += item.Text + @"\" + "\n";
                else
                    data += item.Text + "." + item.SubItems[3].Text + "\n";
            Clipboard.SetText(data);
        }

        private void copyNamesWithPathToClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string data = "";
            string root = selectedPanel.Name == "directoryLeftListView" ? leftDirectory : rightDirectory;
            root += @"\";
            foreach (ListViewItem item in selectedPanel.SelectedItems)
                if (item.SubItems[1].Text == "<DIR>")
                    data += root + item.Text + @"\" + "\n";
                else
                    data += root + item.Text + "." + item.SubItems[3].Text + "\n";
            Clipboard.SetText(data);
        }

        private void copyToClipboardWithAllDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string data = "";
            foreach (ListViewItem item in selectedPanel.SelectedItems)
                if (item.SubItems[1].Text == "<DIR>")
                    data += item.Text + @"\" + "\t" + item.SubItems[1].Text + "\t" + item.SubItems[2].Text + "\t" + item.SubItems[4].Text + "\n";
                else
                    data += item.Text + "." + item.SubItems[3].Text + "\t" + item.SubItems[1].Text + "\t" + item.SubItems[2].Text + "\t" + item.SubItems[4].Text + "\n";
            Clipboard.SetText(data);
        }

        private void copyToClipboardWithPathDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string data = "";
            string root = selectedPanel.Name == "directoryLeftListView" ? leftDirectory : rightDirectory;
            root += @"\";
            foreach (ListViewItem item in selectedPanel.SelectedItems)
                if (item.SubItems[1].Text == "<DIR>")
                    data += root + item.Text + @"\" + "\t" + item.SubItems[1].Text + "\t" + item.SubItems[2].Text + "\t" + item.SubItems[4].Text + "\n";
                else
                    data += root + item.Text + "." + item.SubItems[3].Text + "\t" + item.SubItems[1].Text + "\t" + item.SubItems[2].Text + "\t" + item.SubItems[4].Text + "\n";
            Clipboard.SetText(data);
        }

        private void Directory_ComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                if (selectedPanel.Name == "directoryLeftListView")
                    leftDirectory = Directory_ComboBox.Text;
                else
                    rightDirectory = Directory_ComboBox.Text;
            Directory_ComboBox.Text = "";
        }

        private void selectAllWithSameExtensionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in selectedPanel.Items)
                if (item.SubItems[3].Text == selectedPanel.SelectedItems[0].SubItems[3].Text)
                    item.Selected = true;
        }

        private void NotepadBtn_Click(object sender, EventArgs e)
        {
            if ((selectedPanel as ListView).SelectedItems.Count > 1)
                MessageBox.Show("Chi duoc chon mot file", "TooManyItem");
            else
            {
                string Directory = Directory_Label.Text + "\\" + selectedPanel.SelectedItems[0].Text;
                Process.Start("notepad.exe", Directory + "." + selectedPanel.SelectedItems[0].SubItems[3].Text);
            }
        }

        private void nameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeListViewSort(0);
        }

        private void changeListViewSort(int column)
        {
            if ((selectedPanel.ListViewItemSorter as ListViewColumnSorter).SortColumn == column)
                if ((selectedPanel.ListViewItemSorter as ListViewColumnSorter).Order == SortOrder.Ascending)
                    (selectedPanel.ListViewItemSorter as ListViewColumnSorter).Order = SortOrder.Descending;
                else
                    (selectedPanel.ListViewItemSorter as ListViewColumnSorter).Order = SortOrder.Ascending;
            else
            {
                (selectedPanel.ListViewItemSorter as ListViewColumnSorter).SortColumn = column;
                (selectedPanel.ListViewItemSorter as ListViewColumnSorter).Order = SortOrder.Ascending;
            }
            selectedPanel.Sort();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch ((selectedPanel.ListViewItemSorter as ListViewColumnSorter).SortColumn)
            {
                case 0:
                    nameToolStripMenuItem.Checked = true;
                    break;
                case 1:
                    sizeToolStripMenuItem.Checked = true;
                    break;
                case 2:
                    timeToolStripMenuItem.Checked = true;
                    break;
                case 3:
                    extensionToolStripMenuItem.Checked = true;
                    break;
                default:
                    unsortedToolStripMenuItem.Checked = true;
                    break;
            }
        }

        private void showToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            nameToolStripMenuItem.Checked = false;
            sizeToolStripMenuItem.Checked = false;
            timeToolStripMenuItem.Checked = false;
            extensionToolStripMenuItem.Checked = false;
        }

        private void extensionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeListViewSort(3);
        }

        private void timeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeListViewSort(2);
        }
        //New Directory
        /// <summary>
        /// Tạo một directory với đường dẫn
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool MakeDir(string name)
        {
            if (name == "")
            {
                MessageBox.Show("Enter a name", "Error");
                return false;
            }

            if (CopyMove.CheckNameExistenceInListView(selectedPanel, name, true))
            {
                if (selectedPanel == directoryLeftListView)
                {
                    Directory.CreateDirectory(Path.Combine(_leftDirectory, name));
                    PopulateListView(directoryLeftListView, _leftDirectory);
                    PopulateListView(directoryRightListView, _rightDirectory);
                }
                else
                {
                    Directory.CreateDirectory(Path.Combine(_rightDirectory, name));
                    PopulateListView(directoryLeftListView, _leftDirectory);
                    PopulateListView(directoryRightListView, _rightDirectory);
                }
                return true;
            }
            else
            {
                string msg = "The folder name: " + name + " is already exists. Please speccify a different name.";
                MessageBox.Show(msg, "Error");
                return false;
            }
        }
        //New Directory Event
        private void F7Button_Click(object sender, EventArgs e)
        {
            try
            {
                NewDirectoryForm newDirectory = new NewDirectoryForm(this);
                newDirectory.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }

        private void MakeDirB_Click(object sender, EventArgs e)
        {
            try
            {
                NewDirectoryForm newDirectory = new NewDirectoryForm(this);
                newDirectory.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        //Edit File (notepad)
        private void EditFile()
        {
            if (selectedPanel.SelectedItems.Count == 1)
            {
                if (selectedPanel.SelectedItems[0].SubItems[1].Text != "<DIR>")
                {
                    string fileName = selectedPanel.SelectedItems[0].SubItems[0].Text + "."
                    + selectedPanel.SelectedItems[0].SubItems[3].Text;
                    string filePath;
                    if (selectedPanel == directoryLeftListView)
                    {
                        filePath = Path.Combine(_leftDirectory, fileName);
                    }
                    else
                    {
                        filePath = Path.Combine(_rightDirectory, fileName);
                    }
                    Process.Start("Notepad.Exe", filePath);
                }
                else
                {
                    MessageBox.Show("No file selected!", "Error");
                }
            }
        }
        private void EditB_Click(object sender, EventArgs e)
        {
            try
            {
                EditFile();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void F4Button_Click(object sender, EventArgs e)
        {
            try
            {
                EditFile();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        //Rename
        public bool Rename(string shortName)
        {
            if (shortName == "")
            {
                MessageBox.Show("Enter a name", "Error");
                return false;
            }
            if (selectedPanel.SelectedItems[0].SubItems[1].Text != "<DIR>")
            {
                string oldName = selectedPanel.SelectedItems[0].SubItems[0].Text + "."
                + selectedPanel.SelectedItems[0].SubItems[3].Text;
                string newName = shortName + "." + selectedPanel.SelectedItems[0].SubItems[3].Text;
                if (CopyMove.CheckNameExistenceInListView(selectedPanel, newName, false))
                {
                    if (selectedPanel == directoryLeftListView)
                    {
                        File.Move(Path.Combine(_leftDirectory, oldName), Path.Combine(_leftDirectory, newName));
                    }
                    else
                    {
                        File.Move(Path.Combine(_rightDirectory, oldName), Path.Combine(_rightDirectory, newName));
                    }
                    PopulateListView(directoryLeftListView, _leftDirectory);
                    PopulateListView(directoryRightListView, _rightDirectory);
                    return true;
                }
                else
                {
                    string msg = "This file name: " + shortName + " is already exists. Please speccify a different name.";
                    MessageBox.Show(msg, "Error");
                    return false;
                }
            }
            else
            {
                string oldName = selectedPanel.SelectedItems[0].SubItems[0].Text;
                if (CopyMove.CheckNameExistenceInListView(selectedPanel, shortName, true))
                {
                    if (selectedPanel == directoryLeftListView)
                    {
                        string oldFolderPath = Path.Combine(_leftDirectory, oldName);
                        string newFolderPath = Path.Combine(_leftDirectory, shortName);
                        Directory.Move(oldFolderPath, newFolderPath);
                    }
                    else
                    {
                        string oldFolderPath = Path.Combine(_rightDirectory, oldName);
                        string newFolderPath = Path.Combine(_rightDirectory, shortName);
                        Directory.Move(oldFolderPath, newFolderPath);
                    }
                    PopulateListView(directoryLeftListView, _leftDirectory);
                    PopulateListView(directoryRightListView, _rightDirectory);
                    return true;
                }
                else
                {
                    string msg = "This folder name: " + shortName + " is already exists. Please speccify a different name.";
                    MessageBox.Show(msg, "Error");
                    return false;
                }
            }
        }
        //Rename Event
        private void F2Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedPanel.SelectedItems.Count == 1)
                {
                    RenameForm newDirectory = new RenameForm(this);
                    newDirectory.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void sizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeListViewSort(1);
        }

        private void unsortedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RereadSourceBtn_Click(sender, e);
        }

        private void quickViewPanelToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (quickViewPanelToolStripMenuItem.Checked  && (selectedPanel.Parent as TableLayoutPanel).ColumnStyles[0].Width != (selectedPanel.Parent as TableLayoutPanel).ColumnStyles[0].Width)
            {
                this.quickViewPanel.Visible = true;
                GetInformation(quickViewPanel, selectedPanel.SelectedItems[0]);
            }
            else
                this.quickViewPanel.Visible = false;
        }

        public static int FileCount(DirectoryInfo d)
        {
            int count = 0;
            // Add file sizes.
            FileInfo[] fis = d.GetFiles();
            count = fis.Length;
            // Add subdirectory sizes.
            DirectoryInfo[] dis = d.GetDirectories();
            foreach (DirectoryInfo di in dis)
            {
                count += FileCount(di);
            }
            return count;
        }
        public static int FolderCount(DirectoryInfo d)
        {
            int count = 0;
            // Add file sizes.
            DirectoryInfo[] dis = d.GetDirectories();
            count = dis.Length;
            foreach (DirectoryInfo di in dis)
            {
                count += FolderCount(di);
            }
            return count;
        }

        private void GetInformation(Panel panel, ListViewItem listViewItem)
        {
            if (panel.Visible)
            {
                panel.Controls.Clear();
                string dir = Directory_Label.Text + @"\" + listViewItem.SubItems[0].Text;
                try
                {
                    if (listViewItem.SubItems[1].Text == "<DIR>")
                    {
                        RichTextBox richTextBox = new RichTextBox();
                        richTextBox.Size = this.quickViewPanel.Size;
                        richTextBox.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        richTextBox.Dock = DockStyle.Fill;
                        richTextBox.Margin = new System.Windows.Forms.Padding(0);
                        richTextBox.Text = dir + "\n\n";
                        richTextBox.Text += "Total space occupied:\n\n";
                        richTextBox.Text += DirGet.DirSize(new DirectoryInfo(dir)) + " bytes in " + FileCount(new DirectoryInfo(dir)) + "files \n\n";
                        richTextBox.Text += "in " + FolderCount(new DirectoryInfo(dir)) + " directories\n";
                        this.quickViewPanel.Controls.Add(richTextBox);
                    }
                    else
                    {
                        if (listViewItem.SubItems[3].Text == "png" || listViewItem.SubItems[3].Text == "jpeg" || listViewItem.SubItems[3].Text == "jpg")
                        {
                            Image img = Image.FromFile(dir + "." + listViewItem.SubItems[3].Text);
                            PictureBox pictureBox = new PictureBox();
                            pictureBox.Size = this.quickViewPanel.Size;
                            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
                            pictureBox.Image = img;
                            pictureBox.Size = img.Size;
                            pictureBox.Margin = new System.Windows.Forms.Padding(0);
                            panel.Controls.Add(pictureBox);
                        }
                        else
                        {
                            RichTextBox richTextBox = new RichTextBox();
                            richTextBox.Size = this.quickViewPanel.Size;
                            richTextBox.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            richTextBox.Dock = DockStyle.Fill;
                            richTextBox.Margin = new System.Windows.Forms.Padding(0);
                            richTextBox.Text = File.ReadAllText(dir + "." + listViewItem.SubItems[3].Text, Encoding.UTF8);
                            this.quickViewPanel.Controls.Add(richTextBox);
                        }
                    }
                }
                catch { }
            }
        }
        private void directoryLeftListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            GetInformation(quickViewPanel, e.Item);
        }

        private void InvertSelectionBtn_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in selectedPanel.Items)
            {
                if (item.Selected)
                    item.Selected = false;
                else if (!item.Selected)
                    item.Selected = true;
            }
        }
        public static string DeCompressFiles(string SourceFile, string DestinationPath)
        {
            string error = "";
            try
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.FileName = @"C:\\Program Files (x86)\\WinRAR\\WinRAR.exe";
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
                sdp.FileName = "C:\\Program Files (x86)\\WinRAR\\WinRAR.exe";//Winrar.exe path
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

        private void Pack()
        {
            foreach (ListViewItem item in selectedPanel.SelectedItems)
            {
                string Directory = Directory_Label.Text + "\\" + item.SubItems[0].Text;
                FileAttributes attr = File.GetAttributes(Directory + "." + item.SubItems[3].Text);
                if (attr.HasFlag(FileAttributes.Directory))
                {
                    string filecompressed = Directory;
                    Dictionary<int, string> accFiles = new Dictionary<int, string>();
                    accFiles.Add(1, filecompressed);
                    Compress.CompressFiles(filecompressed, accFiles);
                }
                else
                {
                    string filecompressed = Directory + "." + item.SubItems[3].Text;
                    Dictionary<int, string> accFiles = new Dictionary<int, string>();
                    accFiles.Add(1, filecompressed);
                    Compress.CompressFiles(filecompressed += ".rar", accFiles);
                }
            }
        }

        private void PackBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Pack();
                RefreshDir();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void UnPack()
        {
            foreach (ListViewItem item in selectedPanel.SelectedItems)
            {
                string Directory = Directory_Label.Text + "\\" + item.SubItems[0].Text;
                FileAttributes attr = File.GetAttributes(Directory + "." + item.SubItems[3].Text);
                string filecompressed = Directory + "." + item.SubItems[3].Text;
                if (item.SubItems[3].Text == "rar")
                {
                    Compress.DeCompressFiles(filecompressed, Directory_Label.Text);
                }
                else
                {
                    MessageBox.Show("Not rar file", "File type error");
                }
            }
        }
        private void UnpackBtn_Click(object sender, EventArgs e)
        {
            try
            {
                UnPack();
                RefreshDir();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void RefreshDir()
        {
            DriveInfo leftDrive;
            DriveInfo rightDrive;
            NumberFormatInfo format = new CultureInfo("en-US", false).NumberFormat;
            try
            {
                leftDrive = new DriveInfo(new DirectoryInfo(leftDirectory).Root.Name);
                leftDirectory = leftDirectory;
            }
            catch
            {
                leftDrive = DriveInfo.GetDrives()[0];
                leftDirectory = leftDrive.Name;
            }
            leftHistory.Add(leftDirectory);
            comboBox2.Items.Add(leftDirectory);
            DropDownWidth(comboBox2);
            try
            {
                rightDrive = new DriveInfo(new DirectoryInfo(rightDirectory).Root.Name);
                rightDirectory = rightDirectory;
            }
            catch
            {
                rightDrive = DriveInfo.GetDrives()[0];
                rightDirectory = rightDrive.Name;
            }
            rightHistory.Add(rightDirectory);
            comboBox4.Items.Add(rightDirectory);
        }

        private void ShowAllFilesInCurrentDirBtn_Click(object sender, EventArgs e)
        {
            List<string> fileList = new List<string>();
            string dir = selectedPanel == directoryLeftListView ? leftDirectory : rightDirectory;
            Stack<string> dirStack = new Stack<string>();
            dirStack.Push(dir);
            while(dirStack.Count > 0)
            {
                string dirName = dirStack.Pop();
                FileInfo[] sundirfileList = new DirectoryInfo(dirName).GetFiles();
                foreach (FileInfo file in sundirfileList)
                    fileList.Add(file.FullName);
                DirectoryInfo[] subdirlist = new DirectoryInfo(dirName).GetDirectories();
                foreach(DirectoryInfo subdir in subdirlist)
                    dirStack.Push(subdir.FullName);
            }
            populateListView(selectedPanel, fileList.ToArray());
        }
        protected override void WndProc(ref Message msg)
        {
            if(msg.WParam.ToInt64() == 66059)
                GoBackBtn_Click(null, null);
            if (msg.WParam.ToInt64() == 131595)
                GoForwardBtn_Click(null, null);
            base.WndProc(ref msg);
        }
        private void populateListView(ListView lw, string[] dir)
        {
            lw.Items.Clear();
            foreach(string dirItem in dir)
            {
                if(new FileInfo(dirItem).Attributes.HasFlag(FileAttributes.Directory))
                {
                    try
                    {
                        lw.Items.Add( EditDirInfo.NewLVI(new EditDirInfo(dirItem)));
                    }
                    catch { }
                }
                else
                {
                    try
                    {
                        lw.Items.Add(EditFileInfo.NewLVI(new EditFileInfo(dirItem)));
                    }
                    catch { }
                }    
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Text = leftDirectory;
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(leftHistory.ToArray());
            button1.BackColor = SystemColors.ControlDark;
            button3.BackColor = SystemColors.Control;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(searchHistory.ToArray());
            button3.BackColor = SystemColors.ControlDark;
            button1.BackColor = SystemColors.Control;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            comboBox3.Text = leftDirectory;
            comboBox3.Items.Clear();
            comboBox3.Items.AddRange(leftHistory.ToArray());
            button5.BackColor = SystemColors.ControlDark;
            button7.BackColor = SystemColors.Control;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            comboBox3.Text = "";
            comboBox3.Items.Clear();
            comboBox3.Items.AddRange(searchHistory.ToArray());
            button7.BackColor = SystemColors.ControlDark;
            button5.BackColor = SystemColors.Control;
        }
    }

}