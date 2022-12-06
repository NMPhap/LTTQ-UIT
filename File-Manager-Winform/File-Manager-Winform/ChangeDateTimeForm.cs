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
    public partial class ChangeDateTimeForm : Form
    {
        public DateTime dateTime;
        public ChangeDateTimeForm(DateTime dt)
        {
            dateTime = dt;
            InitializeComponent();
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Visible = false;
        }

        private void ChangeDateTimeForm_Load(object sender, EventArgs e)
        {
            DatePicker.Text = dateTime.ToShortDateString();
            TImePicker.Text = dateTime.ToLongTimeString();
        }
    }
}
