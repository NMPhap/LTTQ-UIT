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

namespace File_Manager_Winform
{

    public partial class Form1 : Form
    {
        ListViewColumnSorter lvwleftColumnSorter;
        ListViewColumnSorter lvwrightColumnSorter;
        private ListView selectedPanel;//Xac dinh list view nao dang duoc chon de thuc thi cac thao tac

        private List<string> leftHistory;//Mang du lieu chua thong tin lich su duyet folder cua listview ben trai
        private List<string> rightHistory;//Mang du lieu chua thong tin lich su duyet folder cua listview ben phair

        private string _leftDirectory;//Duong dan cua list view ben trai
        public string leftDirectory//thuoc tinh ao cho _leftDirectory nham goi thuc thi cac ham khi thay doi duong dan
        {
            get { return _leftDirectory; }
            set
            {
                _leftDirectory = value;

                ChangeDirectory(directoryLeftListView, _leftDirectory);
            }
        }

        private string _rightDirectory;//Duong dan cua listView ben phai
        public string rightDirectory//thuoc tinh ao cho _rightDirectory nham goi thuc thi cac ham khi thay doi duong dan
        {
            get { return _rightDirectory; }
            set
            {
                _rightDirectory = value;
                ChangeDirectory(directoryRightListView, _rightDirectory);
            }
        }
        public Form1()
        {
            InitializeComponent();
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
                string[] dirlist = System.IO.Directory.GetDirectories(GetDirectory(TP));
                foreach (string dir in dirlist)
                {
                    TreeNode node = new TreeNode(new System.IO.DirectoryInfo(dir).Name, 0, 0);
                    TP.Nodes.Add(node);
                }
            }
            catch { }
        }
        /// <summary>
        /// Ham GetDirectory se tra ve duong dan ma node duong 
        /// truyen vao dai dien trong he thong thu muc
        /// </summary>
        /// <param name="TP"></param>
        /// <returns></returns>
        private string GetDirectory(TreeNode TP)
        {
            string result = TP.Text;
            while (TP.Parent != null)
            {
                result = TP.Parent.Text + "\\" + result;
                TP = TP.Parent;
            }
            return result;
        }
        /// <summary>
        /// Xu ly event Click cua LeftPanel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LeftPanel_Click(object sender, EventArgs e)
        {
            //Chuyen selectPanel thanh object goi handle nay
            selectedPanel = (ListView)sender;
            //Thay doi danh sach Item cua ComboBox duoi de phu hop voi Duong dan cua panel dang chon
            Directory_Label.Text = (selectedPanel == directoryLeftListView) ? _leftDirectory : _rightDirectory;
            PopulateDirectoryConboBox(Directory_Label.Text);
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
                leftDirectoryIntoHistory(GetDirectory(e.Node));
                if (leftTableLayoutPanel.ColumnStyles[1].Width == 0)
                {
                    leftTableLayoutPanel.ColumnStyles[0] = new ColumnStyle(SizeType.Percent, 50F);
                    leftTableLayoutPanel.ColumnStyles[1] = new ColumnStyle(SizeType.Percent, 50F);
                }
            }
            else
            {
                rightDirectoryIntoHistory(GetDirectory(e.Node));
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
        private void PopulateDirectoryConboBox(string path)
        {
            Directory_ComboBox.Items.Clear();
            string[] DirList = System.IO.Directory.GetDirectories(path);
            foreach (string Directory in DirList)
                Directory_ComboBox.Items.Add("\\" + new System.IO.DirectoryInfo(Directory).Name);
        }
        /// <summary>
        /// Xu ly event khi phan tu trong comboBox duoc chon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Directory_ComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            string Directory = Directory_Label.Text + Directory_ComboBox.Text;
            if (selectedPanel.Name == "directoryleftListView")
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
            try
            {
                PopulateListView(listView, Directory);
                Directory_Label.Text = Directory;
                PopulateDirectoryConboBox(Directory_Label.Text);
            }
            catch (UnauthorizedAccessException ex)//xu ly loi khong co quyen truy cap duong dan
            {
                MessageBox.Show("Access Denial", "Access denied to" + Directory + "Please check your access authority to this folder");
            }
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

            if (onlyname == true)
            {
                ListViewOnlyName(directoryLeftListView);
                ListViewOnlyName(directoryRightListView);
                onlyname = false;
            }
            AllFileDetailsBtn.Checked = false;
            ThumbnailViewBtn.Checked = false;
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
            if (onlyname == false)
            {
                ChangeDirectory(directoryLeftListView, _leftDirectory);
                ChangeDirectory(directoryRightListView, _rightDirectory);
                onlyname = true;
            }
            ThumbnailViewBtn.Checked = false;
            OnlyFileNamesBtn.Checked = false;
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
                    leftDirectory = leftHistory[leftHistory.IndexOf(leftDirectory) - 1];
                else
                    rightDirectory = rightHistory[rightHistory.IndexOf(rightDirectory) - 1];
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
            if (leftDirectory == rightDirectory)
                e.Effect = DragDropEffects.None;
            else if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void directoryLeftListView_DragDrop(object sender, DragEventArgs e)
        {
            string typestring = "Type";
            string s = e.Data.GetData(typestring.GetType()).ToString();
            string orig_string = e.Data.GetData(typestring.GetType()).ToString();
            s = s.Substring(s.IndexOf(":") + 1).Trim();
            s = s.Substring(1, s.Length - 2);
            for (int i = 0; i < this.directoryRightListView.Items.Count; i++)
                if (this.directoryRightListView.Items[i].SubItems[0].Text.ToString() == s)
                {
                    ListViewItem temp = new ListViewItem(s);
                    for (int j = 1; j < this.directoryRightListView.Items[i].SubItems.Count; j++)
                        temp.SubItems.Add(this.directoryRightListView.Items[i].SubItems[j].Text.ToString());
                    temp.ImageIndex = this.directoryRightListView.Items[i].ImageIndex;
                    this.directoryLeftListView.Items.Add(temp);
                    break;
                }

            System.Collections.IEnumerator enumerator = directoryRightListView.Items.GetEnumerator();
            int whichIdx = -1;
            int idx = 0;
            while (enumerator.MoveNext())
            {
                string s2 = enumerator.Current.ToString();
                if (s2.Equals(orig_string))
                {
                    whichIdx = idx;
                    break;
                }
                idx++;
            }
            this.directoryRightListView.Items.RemoveAt(whichIdx);
        }

        private void directoryLeftListView_DragEnter(object sender, DragEventArgs e)
        {
            if (leftDirectory == rightDirectory)
                e.Effect = DragDropEffects.None;
            else if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }

        private void directoryRightListView_DragDrop(object sender, DragEventArgs e)
        {
            string typestring = "Type";
            string s = e.Data.GetData(typestring.GetType()).ToString();
            string orig_string = e.Data.GetData(typestring.GetType()).ToString();
            s = s.Substring(s.IndexOf(":") + 1).Trim();
            s = s.Substring(1, s.Length - 2);
            for (int i = 0; i < this.directoryLeftListView.Items.Count; i++)
                if (this.directoryLeftListView.Items[i].SubItems[0].Text.ToString() == s)
                {
                    ListViewItem temp = new ListViewItem(s);
                    for (int j = 1; j < this.directoryLeftListView.Items[i].SubItems.Count; j++)
                        temp.SubItems.Add(this.directoryLeftListView.Items[i].SubItems[j].Text.ToString());
                    temp.ImageIndex = this.directoryLeftListView.Items[i].ImageIndex;
                    this.directoryRightListView.Items.Add(temp);
                    break;
                }

            System.Collections.IEnumerator enumerator = directoryLeftListView.Items.GetEnumerator();
            int whichIdx = -1;
            int idx = 0;
            while (enumerator.MoveNext())
            {
                string s2 = enumerator.Current.ToString();
                if (s2.Equals(orig_string))
                {
                    whichIdx = idx;
                    break;
                }
                idx++;
            }
            this.directoryLeftListView.Items.RemoveAt(whichIdx);
        }

        private void directoryRightListView_ItemDrag(object sender, ItemDragEventArgs e)
        {
            string s = e.Item.ToString();
            DoDragDrop(s, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void directoryLeftListView_ItemDrag(object sender, ItemDragEventArgs e)
        {
            string s = e.Item.ToString();
            DoDragDrop(s, DragDropEffects.Copy | DragDropEffects.Move);
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
            if (e.KeyCode == Keys.Enter)
            {
                Console.WriteLine(comboBox1.Text);
                if(!leftBackgroundWorker.IsBusy)
                    leftBackgroundWorker.RunWorkerAsync();
            }
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string str = "";
                comboBox1.Invoke(new Action(() => { str = comboBox1.Text; }));
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
                }
                else
                {
                    this.Invoke(new Action(() => { PopulateListView(directoryLeftListView, leftDirectory); }));
                }
            }
            catch (UnauthorizedAccessException ex)
            { }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(e.Cancelled == true)
                Console.WriteLine("Cancel!!");
            if(e.Error != null)
                MessageBox.Show(e.Error.ToString());
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if(leftBackgroundWorker.IsBusy)
                leftBackgroundWorker.CancelAsync();
        }

        private void comboBox2_keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Console.WriteLine(comboBox3.Text);
                if (!rightBackgroundWorker.IsBusy)
                    rightBackgroundWorker.RunWorkerAsync();
            }
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
                }
                else
                {
                    this.Invoke(new Action(() => { PopulateListView(directoryRightListView, rightDirectory); }));
                }
            }
            catch (UnauthorizedAccessException ex)
            { }
        }

        private void comboBox3_TextChanged(object sender, EventArgs e)
        {
            if (rightBackgroundWorker.IsBusy)
                rightBackgroundWorker.CancelAsync();
        }

        private void treeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(selectedPanel.Name == "directoryLeftListView")
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
            DriveInfo leftDrive;
            DriveInfo rightDrive;
            NumberFormatInfo format = new CultureInfo("en-US", false).NumberFormat;
            try
            {
                leftDrive = new DriveInfo(new DirectoryInfo(leftDirectory).Root.Name);
                leftDirectory = leftDirectory;
            }
            catch (Exception ex)
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
            catch (Exception ex)
            {
                rightDrive = DriveInfo.GetDrives()[0];
                rightDirectory = rightDrive.Name;
            }
            rightHistory.Add(rightDirectory);
            comboBox4.Items.Add(rightDirectory);
        }
        //Shortcut Key
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F4)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.F2)
            {
                try
                {
                    if (selectedPanel.SelectedItems.Count == 1)
                    {
                        RenameForm newDirectory = new RenameForm(this);
                        newDirectory.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }

            if (e.KeyCode == Keys.F4)
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
            if (e.KeyCode == Keys.F5)
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
            if (e.Alt && e.KeyCode == Keys.Enter)
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
            if (e.KeyCode == Keys.F6)
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
            if (e.KeyCode == Keys.F7)
            {
                try
                {
                    NewDirectoryForm newDirectory = new NewDirectoryForm(this);
                    newDirectory.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
            if (e.KeyCode == Keys.F8)
            {
                try
                {
                    Delete();
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
        private int FindIndexInLV(ListView a, string name, bool type)
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
        //CopyFile
        private void Copy()
        {
            string[] name;
            string[] ext;
            if (selectedPanel.SelectedItems.Count > 0)
            {
                string msg = "Copy " + selectedPanel.SelectedItems.Count + " item(s) ?";
                if (MessageBox.Show(msg, "Copy item", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    name = new string[selectedPanel.SelectedItems.Count];
                    ext = new string[selectedPanel.SelectedItems.Count];
                    for (int i = 0; i < selectedPanel.SelectedItems.Count; i++)
                    {
                        name[i] = selectedPanel.SelectedItems[i].SubItems[0].Text;
                        ext[i] = selectedPanel.SelectedItems[i].SubItems[3].Text;
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
                        CaseOfCopyFile(_leftDirectory, _rightDirectory, directoryLeftListView, directoryRightListView, index);
                    }
                    else
                    {
                        CaseOfCopyFolder(_leftDirectory, _rightDirectory, directoryLeftListView, directoryRightListView, index);
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
                    if (directoryRightListView.Items[index].SubItems[1].Text != "<DIR>")
                    {
                        CaseOfCopyFile(_rightDirectory, _leftDirectory, directoryRightListView, directoryLeftListView, index);
                    }
                    else
                    {
                        CaseOfCopyFolder(_rightDirectory, _leftDirectory, directoryRightListView, directoryLeftListView, index);
                    }
                }
            }
        }
        /// <summary>
        /// Kiếm tra tên của file/folder đã tồn tại trong listview hay không
        /// </summary>
        /// <param name="a"></param>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        private bool CheckNameExistenceInListView(ListView a, string name, bool type)
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
        /// <summary>
        /// Kiểm tra tên của file đã tồn tại trong folder hay không
        /// </summary>
        /// <param name="dir"></param>
        /// <param name="Name"></param>
        /// <returns></returns>
        private bool CheckNameExistenceInFolder(DirectoryInfo dir, string Name)
        {
            foreach (FileInfo file in dir.GetFiles())
            {
                if (Name == file.Name)
                    return false;
            }
            return true;
        }
        /// <summary>
        /// Các trường hợp khi copy file
        /// </summary>
        /// <param name="source"></param>
        /// <param name="dest"></param>
        /// <param name="sourceLV"></param>
        /// <param name="destLV"></param>
        /// <param name="index"></param>
        private void CaseOfCopyFile(string source, string dest, ListView sourceLV, ListView destLV, int index)
        {
            string fileName = sourceLV.Items[index].SubItems[0].Text + "." +
                            sourceLV.Items[index].SubItems[3].Text;
            if (source != dest)
            {
                if (CheckNameExistenceInListView(destLV, fileName, false))
                {
                    string sourceFilePath = Path.Combine(source, fileName);
                    string destFilePath = Path.Combine(dest, fileName);
                    File.Copy(sourceFilePath, destFilePath);
                    ListViewItem temp = EditFileInfo.NewLVI(new EditFileInfo(destFilePath));
                    destLV.Items.Insert(FindIndexInLV(destLV, fileName, false), temp);
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
                    if (CheckNameExistenceInListView(sourceLV, fileName1, false))
                        break;
                    count++;
                }
                string sourceFilePath = Path.Combine(source, fileName);
                string destFilePath = Path.Combine(source, fileName1);
                File.Copy(sourceFilePath, destFilePath);
                ListViewItem temp = EditFileInfo.NewLVI(new EditFileInfo(destFilePath));
                ListViewItem temp1 = EditFileInfo.NewLVI(new EditFileInfo(destFilePath));
                destLV.Items.Insert(FindIndexInLV(destLV, fileName1, false), temp);
                sourceLV.Items.Insert(FindIndexInLV(sourceLV, fileName1, false) , temp1);
            }
        }
        /// <summary>
        /// Các trường hợp khi copy folder
        /// </summary>
        /// <param name="source"></param>
        /// <param name="dest"></param>
        /// <param name="sourceLV"></param>
        /// <param name="destLV"></param>
        /// <param name="index"></param>
        private void CaseOfCopyFolder(string source, string dest, ListView sourceLV, ListView destLV, int index)
        {
            string folderName = sourceLV.Items[index].SubItems[0].Text;
            if (source != dest)
            {
                string sourceFolderPath = Path.Combine(source, folderName);
                string destFolderPath = Path.Combine(dest, folderName);
                DirectoryInfo sourceDir = new DirectoryInfo(sourceFolderPath);
                DirectoryInfo destDir = new DirectoryInfo(destFolderPath);
                Directory.CreateDirectory(destFolderPath);
                CopyFolder(sourceDir, destDir);
                ListViewItem temp = EditDirInfo.NewLVI(new EditDirInfo(destFolderPath));
                if (CheckNameExistenceInListView(destLV, folderName, true))
                    destLV.Items.Insert(FindIndexInLV(destLV, folderName, true), temp);
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
                    if (CheckNameExistenceInListView(sourceLV, folderName1, true))
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
                ListViewItem temp1 = EditDirInfo.NewLVI(new EditDirInfo(destFolderPath));
                destLV.Items.Insert(FindIndexInLV(destLV, folderName, true), temp);
                sourceLV.Items.Insert(FindIndexInLV(sourceLV, folderName, true), temp1);
            }

        }
        private void CopyFolder(DirectoryInfo sourcefolder, DirectoryInfo destfolder)
        {
            foreach (DirectoryInfo dir in sourcefolder.GetDirectories())
            {
                CopyFolder(dir, destfolder.CreateSubdirectory(dir.Name));
            }
            foreach (FileInfo file in sourcefolder.GetFiles())
            {
                if (CheckNameExistenceInFolder(destfolder, file.Name))
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
        private void Delete()
        {
            string[] name;
            string[] ext;
            if (selectedPanel.SelectedItems.Count > 0)
            {
                string msg = "Delete " + selectedPanel.SelectedItems.Count + " item(s) ?";
                if (MessageBox.Show(msg, "Delete item", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    name = new string[selectedPanel.SelectedItems.Count];
                    ext = new string[selectedPanel.SelectedItems.Count];
                    for (int i = 0; i < selectedPanel.SelectedItems.Count; i++)
                    {
                        name[i] = selectedPanel.SelectedItems[i].SubItems[0].Text;
                        ext[i] = selectedPanel.SelectedItems[i].SubItems[3].Text;
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
                        File.Delete(filePath);                        
                    }
                    else
                    {
                        string folderName = directoryLeftListView.Items[index].SubItems[0].Text;
                        string folderPath = Path.Combine(_leftDirectory, folderName);
                        DirectoryInfo dir = new DirectoryInfo(folderPath);
                        DeleteFolder(dir);
                        Directory.Delete(folderPath);
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
                        File.Delete(filePath);
                    }
                    else
                    {
                        string folderName = directoryRightListView.Items[index].SubItems[0].Text;
                        string folderPath = Path.Combine(_rightDirectory, folderName);
                        DirectoryInfo dir = new DirectoryInfo(folderPath);
                        DeleteFolder(dir);
                        Directory.Delete(folderPath);
                    }
                    directoryRightListView.Items.RemoveAt(index);
                    if (_leftDirectory == _rightDirectory)
                        directoryLeftListView.Items.RemoveAt(index);
                }
            }
        }
        private void DeleteFolder(DirectoryInfo folder)
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
        //DeleteFile Event
        private void F8Button_Click(object sender, EventArgs e)
        {
            try
            {
                Delete();
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
            if (selectedPanel.SelectedItems.Count > 0)
            {
                string msg = "Move " + selectedPanel.SelectedItems.Count + " item(s) ?";
                if (MessageBox.Show(msg, "Move item", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    name = new string[selectedPanel.SelectedItems.Count];
                    ext = new string[selectedPanel.SelectedItems.Count];
                    for (int i = 0; i < selectedPanel.SelectedItems.Count; i++)
                    {
                        name[i] = selectedPanel.SelectedItems[i].SubItems[0].Text;
                        ext[i] = selectedPanel.SelectedItems[i].SubItems[3].Text;
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
                        CaseOfMoveFile(_leftDirectory, _rightDirectory, directoryLeftListView, directoryRightListView, index);
                    }
                    else
                    {
                        CaseOfMoveFolder(_leftDirectory, _rightDirectory, directoryLeftListView, directoryRightListView, index);
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
                    if (directoryRightListView.Items[index].SubItems[1].Text != "<DIR>")
                    {
                        CaseOfMoveFile(_rightDirectory, _leftDirectory, directoryRightListView, directoryLeftListView, index);
                    }
                    else
                    {
                        CaseOfMoveFolder(_rightDirectory, _leftDirectory, directoryRightListView, directoryLeftListView, index);
                    }
                }
            }
        }
        /// <summary>
        /// các trường hợp khi move file
        /// </summary>
        /// <param name="source"></param>
        /// <param name="dest"></param>
        /// <param name="sourceLV"></param>
        /// <param name="destLV"></param>
        /// <param name="index"></param>
        private void CaseOfMoveFile(string source, string dest, ListView sourceLV, ListView destLV, int index)
        {
            string fileName = sourceLV.Items[index].SubItems[0].Text + "." +
                            sourceLV.Items[index].SubItems[3].Text;
            if (source != dest)
            {
                if (CheckNameExistenceInListView(destLV, fileName, false))
                {
                    string sourceFilePath = Path.Combine(source, fileName);
                    string destFilePath = Path.Combine(dest, fileName);
                    File.Move(sourceFilePath, destFilePath);
                    ListViewItem temp = EditFileInfo.NewLVI(new EditFileInfo(destFilePath));
                    destLV.Items.Insert(FindIndexInLV(destLV, fileName, false), temp);
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
        /// <summary>
        /// các trường hợp khi move folder
        /// </summary>
        /// <param name="source"></param>
        /// <param name="dest"></param>
        /// <param name="sourceLV"></param>
        /// <param name="destLV"></param>
        /// <param name="index"></param>
        private void CaseOfMoveFolder(string source, string dest, ListView sourceLV, ListView destLV, int index)
        {
            string folderName = sourceLV.Items[index].SubItems[0].Text;
            if (source != dest)
            {
                string sourceFolderPath = Path.Combine(source, folderName);
                string destFolderPath = Path.Combine(dest, folderName);
                DirectoryInfo sourceDir = new DirectoryInfo(sourceFolderPath);
                DirectoryInfo destDir = new DirectoryInfo(destFolderPath);
                Directory.CreateDirectory(destFolderPath);
                MoveFolder(sourceDir, destDir);
                DeleteFolder(sourceDir);
                Directory.Delete(sourceFolderPath);
                sourceLV.Items.RemoveAt(index);
                ListViewItem temp = EditDirInfo.NewLVI(new EditDirInfo(destFolderPath));
                if (CheckNameExistenceInListView(destLV, folderName, true))
                    destLV.Items.Insert(FindIndexInLV(destLV, folderName, true), temp);
            }
        }
        private void MoveFolder(DirectoryInfo sourceFolder, DirectoryInfo destFolder)
        {
            foreach (DirectoryInfo dir in sourceFolder.GetDirectories())
            {
                MoveFolder(dir, destFolder.CreateSubdirectory(dir.Name));
            }
            foreach (FileInfo file in sourceFolder.GetFiles())
            {
                if (CheckNameExistenceInFolder(destFolder, file.Name))
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
                
            if (CheckNameExistenceInListView(selectedPanel, name, true))
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
                newDirectory.Show();
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
                newDirectory.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        
        //Edit File (notepad)
        private void EditFile()
        {
            if(selectedPanel.SelectedItems.Count == 1 )
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
            catch(Exception ex)
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
                if (CheckNameExistenceInListView(selectedPanel, newName, false))
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
                if (CheckNameExistenceInListView(selectedPanel, shortName, true))
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
                    newDirectory.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
