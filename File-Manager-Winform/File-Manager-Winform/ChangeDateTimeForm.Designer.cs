namespace File_Manager_Winform
{
    partial class ChangeDateTimeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.TimePicker = new System.Windows.Forms.DateTimePicker();
            this.OKbutton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DatePicker
            // 
            this.DatePicker.CustomFormat = "dd/MM/yyyy";
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePicker.Location = new System.Drawing.Point(12, 12);
            this.DatePicker.MaxDate = new System.DateTime(2034, 12, 31, 0, 0, 0, 0);
            this.DatePicker.MinDate = new System.DateTime(2001, 1, 4, 0, 0, 0, 0);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(133, 22);
            this.DatePicker.TabIndex = 1;
            this.DatePicker.Value = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            // 
            // TimePicker
            // 
            this.TimePicker.Checked = false;
            this.TimePicker.CustomFormat = "hh:mm:ss tt";
            this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimePicker.Location = new System.Drawing.Point(151, 12);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.ShowUpDown = true;
            this.TimePicker.Size = new System.Drawing.Size(122, 22);
            this.TimePicker.TabIndex = 2;
            // 
            // OKbutton
            // 
            this.OKbutton.Location = new System.Drawing.Point(12, 58);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(124, 30);
            this.OKbutton.TabIndex = 3;
            this.OKbutton.Text = "OK";
            this.OKbutton.UseVisualStyleBackColor = true;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(142, 58);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(131, 30);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ChangeDateTimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(285, 93);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.TimePicker);
            this.Controls.Add(this.DatePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeDateTimeForm";
            this.Text = "ChangeDateTimeForm";
            this.Load += new System.EventHandler(this.ChangeDateTimeForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.DateTimePicker TimePicker;
        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.Button CancelButton;
    }
}