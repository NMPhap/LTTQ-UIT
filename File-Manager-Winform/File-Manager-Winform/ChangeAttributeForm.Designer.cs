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
            this.changeAttrGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SystemCheckbox = new System.Windows.Forms.CheckBox();
            this.HiddenCheckBox = new System.Windows.Forms.CheckBox();
            this.ReadOnlyCheckbox = new System.Windows.Forms.CheckBox();
            this.ArchiveCheckBox = new System.Windows.Forms.CheckBox();
            this.RecurseSubdirCheckbox = new System.Windows.Forms.CheckBox();
            this.changeDateTimeGroupBox = new System.Windows.Forms.GroupBox();
            this.openChangeDateTimeFormButton = new System.Windows.Forms.Button();
            this.SetCurrentButton = new System.Windows.Forms.Button();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.ChangeDateTimeCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.changeAttrGroupBox.SuspendLayout();
            this.changeDateTimeGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // changeAttrGroupBox
            // 
            this.changeAttrGroupBox.Controls.Add(this.label1);
            this.changeAttrGroupBox.Controls.Add(this.SystemCheckbox);
            this.changeAttrGroupBox.Controls.Add(this.HiddenCheckBox);
            this.changeAttrGroupBox.Controls.Add(this.ReadOnlyCheckbox);
            this.changeAttrGroupBox.Controls.Add(this.ArchiveCheckBox);
            this.changeAttrGroupBox.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeAttrGroupBox.Location = new System.Drawing.Point(12, 39);
            this.changeAttrGroupBox.Name = "changeAttrGroupBox";
            this.changeAttrGroupBox.Size = new System.Drawing.Size(480, 150);
            this.changeAttrGroupBox.TabIndex = 0;
            this.changeAttrGroupBox.TabStop = false;
            this.changeAttrGroupBox.Text = "Change attributes";
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
            // changeDateTimeGroupBox
            // 
            this.changeDateTimeGroupBox.Controls.Add(this.openChangeDateTimeFormButton);
            this.changeDateTimeGroupBox.Controls.Add(this.SetCurrentButton);
            this.changeDateTimeGroupBox.Controls.Add(this.timeTextBox);
            this.changeDateTimeGroupBox.Controls.Add(this.dateTextBox);
            this.changeDateTimeGroupBox.Controls.Add(this.TimeLabel);
            this.changeDateTimeGroupBox.Controls.Add(this.DateLabel);
            this.changeDateTimeGroupBox.Controls.Add(this.ChangeDateTimeCheckBox);
            this.changeDateTimeGroupBox.Location = new System.Drawing.Point(12, 204);
            this.changeDateTimeGroupBox.Name = "changeDateTimeGroupBox";
            this.changeDateTimeGroupBox.Size = new System.Drawing.Size(480, 86);
            this.changeDateTimeGroupBox.TabIndex = 5;
            this.changeDateTimeGroupBox.TabStop = false;
            // 
            // openChangeDateTimeFormButton
            // 
            this.openChangeDateTimeFormButton.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openChangeDateTimeFormButton.Location = new System.Drawing.Point(326, 49);
            this.openChangeDateTimeFormButton.Name = "openChangeDateTimeFormButton";
            this.openChangeDateTimeFormButton.Size = new System.Drawing.Size(39, 24);
            this.openChangeDateTimeFormButton.TabIndex = 10;
            this.openChangeDateTimeFormButton.Text = ">>";
            this.openChangeDateTimeFormButton.UseVisualStyleBackColor = true;
            this.openChangeDateTimeFormButton.Click += new System.EventHandler(this.button7_Click);
            // 
            // SetCurrentButton
            // 
            this.SetCurrentButton.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetCurrentButton.Location = new System.Drawing.Point(222, 21);
            this.SetCurrentButton.Name = "SetCurrentButton";
            this.SetCurrentButton.Size = new System.Drawing.Size(143, 24);
            this.SetCurrentButton.TabIndex = 9;
            this.SetCurrentButton.Text = "Current";
            this.SetCurrentButton.UseVisualStyleBackColor = true;
            // 
            // timeTextBox
            // 
            this.timeTextBox.Location = new System.Drawing.Point(222, 51);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(98, 22);
            this.timeTextBox.TabIndex = 8;
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(70, 51);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(100, 22);
            this.dateTextBox.TabIndex = 7;
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
            // ChangeDateTimeCheckBox
            // 
            this.ChangeDateTimeCheckBox.AutoSize = true;
            this.ChangeDateTimeCheckBox.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeDateTimeCheckBox.Location = new System.Drawing.Point(18, 21);
            this.ChangeDateTimeCheckBox.Name = "ChangeDateTimeCheckBox";
            this.ChangeDateTimeCheckBox.Size = new System.Drawing.Size(136, 21);
            this.ChangeDateTimeCheckBox.TabIndex = 4;
            this.ChangeDateTimeCheckBox.Text = "Change date/time:";
            this.ChangeDateTimeCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(13, 297);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(479, 156);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(156, 38);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 25);
            this.button3.TabIndex = 4;
            this.button3.Text = "Fewer attributes";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(17, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 25);
            this.button2.TabIndex = 3;
            this.button2.Text = "More attributes";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(218, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Value:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Property: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Plugin:";
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(74, 522);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(108, 25);
            this.OKButton.TabIndex = 5;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(203, 523);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(103, 25);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(326, 522);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(104, 25);
            this.helpButton.TabIndex = 8;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = true;
            // 
            // ChangeAttributeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 560);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.changeDateTimeGroupBox);
            this.Controls.Add(this.RecurseSubdirCheckbox);
            this.Controls.Add(this.changeAttrGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeAttributeForm";
            this.Text = "ChangeAttributeForm";
            this.Load += new System.EventHandler(this.ChangeAttributeForm_Load);
            this.changeAttrGroupBox.ResumeLayout(false);
            this.changeAttrGroupBox.PerformLayout();
            this.changeDateTimeGroupBox.ResumeLayout(false);
            this.changeDateTimeGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox changeAttrGroupBox;
        private System.Windows.Forms.CheckBox SystemCheckbox;
        private System.Windows.Forms.CheckBox HiddenCheckBox;
        private System.Windows.Forms.CheckBox ReadOnlyCheckbox;
        private System.Windows.Forms.CheckBox ArchiveCheckBox;
        private System.Windows.Forms.CheckBox RecurseSubdirCheckbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox changeDateTimeGroupBox;
        private System.Windows.Forms.Button SetCurrentButton;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.CheckBox ChangeDateTimeCheckBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button openChangeDateTimeFormButton;
    }
}