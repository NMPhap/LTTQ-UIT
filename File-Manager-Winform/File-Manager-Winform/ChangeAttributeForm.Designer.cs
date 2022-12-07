namespace File_Manager_Winform
{
    partial class ChangeAttributeForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ArchiveCheckBox = new System.Windows.Forms.CheckBox();
            this.ReadOnlyCheckbox = new System.Windows.Forms.CheckBox();
            this.HiddenCheckBox = new System.Windows.Forms.CheckBox();
            this.SystemCheckbox = new System.Windows.Forms.CheckBox();
            this.RecurseSubdirCheckbox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DateTimeGroupbox = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.DateLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.DateTimeGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.SystemCheckbox);
            this.groupBox1.Controls.Add(this.HiddenCheckBox);
            this.groupBox1.Controls.Add(this.ReadOnlyCheckbox);
            this.groupBox1.Controls.Add(this.ArchiveCheckBox);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Change attributes";
            // 
            // ArchiveCheckBox
            // 
            this.ArchiveCheckBox.AutoSize = true;
            this.ArchiveCheckBox.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArchiveCheckBox.Location = new System.Drawing.Point(18, 22);
            this.ArchiveCheckBox.Name = "ArchiveCheckBox";
            this.ArchiveCheckBox.Size = new System.Drawing.Size(87, 21);
            this.ArchiveCheckBox.TabIndex = 0;
            this.ArchiveCheckBox.Text = "a Archive";
            this.ArchiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // ReadOnlyCheckbox
            // 
            this.ReadOnlyCheckbox.AutoSize = true;
            this.ReadOnlyCheckbox.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadOnlyCheckbox.Location = new System.Drawing.Point(18, 48);
            this.ReadOnlyCheckbox.Name = "ReadOnlyCheckbox";
            this.ReadOnlyCheckbox.Size = new System.Drawing.Size(102, 21);
            this.ReadOnlyCheckbox.TabIndex = 1;
            this.ReadOnlyCheckbox.Text = "r Read Only";
            this.ReadOnlyCheckbox.UseVisualStyleBackColor = true;
            // 
            // HiddenCheckBox
            // 
            this.HiddenCheckBox.AutoSize = true;
            this.HiddenCheckBox.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HiddenCheckBox.Location = new System.Drawing.Point(18, 74);
            this.HiddenCheckBox.Name = "HiddenCheckBox";
            this.HiddenCheckBox.Size = new System.Drawing.Size(83, 21);
            this.HiddenCheckBox.TabIndex = 2;
            this.HiddenCheckBox.Text = "h Hidden";
            this.HiddenCheckBox.UseVisualStyleBackColor = true;
            // 
            // SystemCheckbox
            // 
            this.SystemCheckbox.AutoSize = true;
            this.SystemCheckbox.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SystemCheckbox.Location = new System.Drawing.Point(18, 100);
            this.SystemCheckbox.Name = "SystemCheckbox";
            this.SystemCheckbox.Size = new System.Drawing.Size(83, 21);
            this.SystemCheckbox.TabIndex = 3;
            this.SystemCheckbox.Text = "s System";
            this.SystemCheckbox.UseVisualStyleBackColor = true;
            // 
            // RecurseSubdirCheckbox
            // 
            this.RecurseSubdirCheckbox.AutoSize = true;
            this.RecurseSubdirCheckbox.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecurseSubdirCheckbox.Location = new System.Drawing.Point(12, 12);
            this.RecurseSubdirCheckbox.Name = "RecurseSubdirCheckbox";
            this.RecurseSubdirCheckbox.Size = new System.Drawing.Size(164, 21);
            this.RecurseSubdirCheckbox.TabIndex = 4;
            this.RecurseSubdirCheckbox.Text = "Recurse subdirectoríes";
            this.RecurseSubdirCheckbox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "(gray = unchanged, checked = set attribute)";
            // 
            // DateTimeGroupbox
            // 
            this.DateTimeGroupbox.Controls.Add(this.button1);
            this.DateTimeGroupbox.Controls.Add(this.textBox2);
            this.DateTimeGroupbox.Controls.Add(this.textBox1);
            this.DateTimeGroupbox.Controls.Add(this.TimeLabel);
            this.DateTimeGroupbox.Controls.Add(this.DateLabel);
            this.DateTimeGroupbox.Controls.Add(this.checkBox1);
            this.DateTimeGroupbox.Location = new System.Drawing.Point(12, 204);
            this.DateTimeGroupbox.Name = "DateTimeGroupbox";
            this.DateTimeGroupbox.Size = new System.Drawing.Size(373, 86);
            this.DateTimeGroupbox.TabIndex = 5;
            this.DateTimeGroupbox.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(18, 21);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(136, 21);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Change date/time:";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(24, 54);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(40, 17);
            this.DateLabel.TabIndex = 5;
            this.DateLabel.Text = "Date:";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new System.Drawing.Point(176, 54);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(40, 17);
            this.TimeLabel.TabIndex = 6;
            this.TimeLabel.Text = "Time:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(222, 51);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(98, 22);
            this.textBox2.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(222, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 24);
            this.button1.TabIndex = 9;
            this.button1.Text = "CurrentButton";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ChangeAttributeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 483);
            this.Controls.Add(this.DateTimeGroupbox);
            this.Controls.Add(this.RecurseSubdirCheckbox);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ChangeAttributeForm";
            this.Text = "ChangeAttributeForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.DateTimeGroupbox.ResumeLayout(false);
            this.DateTimeGroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox SystemCheckbox;
        private System.Windows.Forms.CheckBox HiddenCheckBox;
        private System.Windows.Forms.CheckBox ReadOnlyCheckbox;
        private System.Windows.Forms.CheckBox ArchiveCheckBox;
        private System.Windows.Forms.CheckBox RecurseSubdirCheckbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox DateTimeGroupbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}