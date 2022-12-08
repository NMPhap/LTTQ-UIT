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
        public string date;
        public string time;
        public ChangeDateTimeForm(DateTime dt)
        {
            dateTime = dt;
            InitializeComponent();
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            date = DatePicker.Value.ToShortDateString();
            time = TimePicker.Value.ToLongTimeString();
            this.Close();
        }

        private void ChangeDateTimeForm_Load(object sender, EventArgs e)
        {
            DatePicker.Text = dateTime.ToShortDateString();
            TimePicker.Text = dateTime.ToLongTimeString();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult=DialogResult.Cancel;
            this.Close();
        }
    }
}
