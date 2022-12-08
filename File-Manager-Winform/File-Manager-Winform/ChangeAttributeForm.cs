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
                dateTextBox.Text = changeDateTimeForm.date;
                timeTextBox.Text = changeDateTimeForm.time;
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
            this.Text = this.Text + " - "+ fileInfo.Name;
        }

        private void SetCurrentButton_Click(object sender, EventArgs e)
        {
            dateTextBox.Text = DateTime.Now.ToShortDateString();
            timeTextBox.Text = DateTime.Now.ToLongTimeString();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (this.fileInfo.Attributes.HasFlag(FileAttributes.Normal))
                fileInfo.Attributes = FileAttributes.ReadOnly;
            if (this.HiddenCheckBox.Checked)
                fileInfo.Attributes |= FileAttributes.Hidden;
            else
                fileInfo.Attributes ^= FileAttributes.Hidden;
            if (this.SystemCheckbox.Checked)
                fileInfo.Attributes |= FileAttributes.System;
            else
                fileInfo.Attributes ^= FileAttributes.System;
            if (this.ArchiveCheckBox.Checked)
                fileInfo.Attributes |= FileAttributes.Archive;
            else
                fileInfo.Attributes ^= FileAttributes.Archive;
            if (this.ReadOnlyCheckbox.Checked)
                fileInfo.Attributes |= FileAttributes.ReadOnly;
            else
                fileInfo.Attributes ^= FileAttributes.ReadOnly;
            if (this.ChangeDateTimeCheckBox.Checked)
            {
                DateTime date = Convert.ToDateTime(dateTextBox.Text);
                DateTime time = Convert.ToDateTime(timeTextBox.Text);
                File.SetCreationTime(fileInfo.FullName,new DateTime(date.Year,date.Month,date.Day,time.Hour,time.Minute,time.Second));
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
