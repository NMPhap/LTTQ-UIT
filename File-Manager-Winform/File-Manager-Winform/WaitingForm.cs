using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace File_Manager_Winform
{
    public partial class WaitingForm : Form
    {
        private Timer timer;
        public WaitingForm( ref Stopwatch st)
        {
            timer = new Timer(); 
            InitializeComponent();
            timer.Tag = 0;
            this.label2.Text = "Enlaspe time: " + this.timer.Tag.ToString() + " ms";
            timer.Start();
            timer.Tick += new EventHandler(Tick);
        }
        private void Tick(object sender, EventArgs e)
        {
            timer.Tag = (int)timer.Tag + 1;
            this.label2.Text = "Enlaspe time: " + this.timer.Tag.ToString() + " ms";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
