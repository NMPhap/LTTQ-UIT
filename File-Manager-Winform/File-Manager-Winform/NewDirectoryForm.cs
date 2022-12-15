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
    public partial class NewDirectoryForm : Form
    {
        public NewDirectoryForm()
        {
            InitializeComponent();
        }
        private Form1 parentForm = null;
        public NewDirectoryForm (Form callingForm)
        {
            parentForm = callingForm as Form1;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (parentForm.MakeDir(this.textBox1.Text))
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
