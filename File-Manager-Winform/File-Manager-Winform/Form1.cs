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


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Container_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
