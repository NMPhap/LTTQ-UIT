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
        public Form1()
        {
            InitializeComponent();
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
    }
}
