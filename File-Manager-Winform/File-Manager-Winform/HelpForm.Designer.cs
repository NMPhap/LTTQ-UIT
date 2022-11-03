namespace File_Manager_Winform
{
    partial class HelpForm
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
            this.Info_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Info_RichTextBox
            // 
            this.Info_RichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Info_RichTextBox.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Info_RichTextBox.Location = new System.Drawing.Point(0, 0);
            this.Info_RichTextBox.Name = "Info_RichTextBox";
            this.Info_RichTextBox.Size = new System.Drawing.Size(618, 512);
            this.Info_RichTextBox.TabIndex = 0;
            this.Info_RichTextBox.Text = "To get more infomation about this application, please go to this URL: https://www" +
    ".facebook.com/profile.php?id=100011497204419";
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(618, 512);
            this.Controls.Add(this.Info_RichTextBox);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "HelpForm";
            this.Text = "Help Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox Info_RichTextBox;
    }
}