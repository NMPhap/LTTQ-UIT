using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Manager_Winform
{
    public partial class CopyMoveForm : Form
    {
        public CopyMoveForm()
        {
            InitializeComponent();
        }
        private Form1 parentForm = null;
        public CopyMoveForm(Form callingForm, string intro, string buttontext, string defaulttext)
        {
            parentForm = callingForm as Form1;
            InitializeComponent();
            this.label1.Text = intro;
            this.button1.Text = buttontext;
            textBox1.Text = defaulttext;
        }
        public string getPath()
        {
            return textBox1.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowser.SelectedPath;
            }
        }
    }
}
