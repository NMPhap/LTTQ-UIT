using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace File_Manager_Winform
{
    public partial class ChangeAttributeForm : Form
    {
        private FileInfo fileInfo;
        public ChangeAttributeForm(FileInfo fI)
        {
            InitializeComponent();
            fileInfo = fI;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ChangeDateTimeForm changeDateTimeForm = new ChangeDateTimeForm(fileInfo.CreationTime);
            if(changeDateTimeForm.ShowDialog() == DialogResult.OK)
            {
                dateTextBox.Text = changeDateTimeForm.dateTime.ToShortDateString();
                timeTextBox.Text = changeDateTimeForm.dateTime.ToLongTimeString();
            }
        }

        private void ChangeAttributeForm_Load(object sender, EventArgs e)
        {
            if (fileInfo.Attributes.HasFlag(FileAttributes.ReadOnly))
                this.ReadOnlyCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            if (fileInfo.Attributes.HasFlag(FileAttributes.Hidden))
                this.HiddenCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            if (fileInfo.Attributes.HasFlag(FileAttributes.Archive))
                this.ArchiveCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            if (fileInfo.Attributes.HasFlag(FileAttributes.System))
                this.SystemCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            dateTextBox.Text = fileInfo.CreationTime.ToShortDateString();
            timeTextBox.Text = fileInfo.CreationTime.ToLongTimeString();
        }
    }
}
