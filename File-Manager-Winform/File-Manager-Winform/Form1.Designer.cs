namespace File_Manager_Winform
{
    partial class Form1
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
            this.ShortcutGB = new System.Windows.Forms.GroupBox();
            this.MakeDirB = new System.Windows.Forms.Button();
            this.RenameMoveB = new System.Windows.Forms.Button();
            this.PackFileB = new System.Windows.Forms.Button();
            this.CopyB = new System.Windows.Forms.Button();
            this.DetailFileB = new System.Windows.Forms.Button();
            this.EditB = new System.Windows.Forms.Button();
            this.Container_panel = new System.Windows.Forms.Panel();
            this.Directory_Table_layout_Panel = new System.Windows.Forms.TableLayoutPanel();
            this.Directory_Label = new System.Windows.Forms.Label();
            this.Directory_ComboBox = new System.Windows.Forms.ComboBox();
            this.Bottom_Button_Table_layout_panel = new System.Windows.Forms.TableLayoutPanel();
            this.F3Button = new System.Windows.Forms.Button();
            this.F5Button = new System.Windows.Forms.Button();
            this.F6Button = new System.Windows.Forms.Button();
            this.F4Button = new System.Windows.Forms.Button();
            this.F7Button = new System.Windows.Forms.Button();
            this.F8Button = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.ShortcutGB.SuspendLayout();
            this.Container_panel.SuspendLayout();
            this.Directory_Table_layout_Panel.SuspendLayout();
            this.Bottom_Button_Table_layout_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShortcutGB
            // 
            this.ShortcutGB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ShortcutGB.BackColor = System.Drawing.SystemColors.Control;
            this.ShortcutGB.Controls.Add(this.MakeDirB);
            this.ShortcutGB.Controls.Add(this.RenameMoveB);
            this.ShortcutGB.Controls.Add(this.PackFileB);
            this.ShortcutGB.Controls.Add(this.CopyB);
            this.ShortcutGB.Controls.Add(this.DetailFileB);
            this.ShortcutGB.Controls.Add(this.EditB);
            this.ShortcutGB.Location = new System.Drawing.Point(407, 70);
            this.ShortcutGB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShortcutGB.Name = "ShortcutGB";
            this.ShortcutGB.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShortcutGB.Size = new System.Drawing.Size(60, 359);
            this.ShortcutGB.TabIndex = 0;
            this.ShortcutGB.TabStop = false;
            this.ShortcutGB.Enter += new System.EventHandler(this.ShortcutGB_Enter);
            // 
            // MakeDirB
            // 
            this.MakeDirB.BackgroundImage = global::File_Manager_Winform.Properties.Resources.Folder_Add;
            this.MakeDirB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MakeDirB.Location = new System.Drawing.Point(15, 201);
            this.MakeDirB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MakeDirB.Name = "MakeDirB";
            this.MakeDirB.Size = new System.Drawing.Size(29, 30);
            this.MakeDirB.TabIndex = 1;
            this.MakeDirB.UseVisualStyleBackColor = true;
            // 
            // RenameMoveB
            // 
            this.RenameMoveB.BackColor = System.Drawing.SystemColors.ControlDark;
            this.RenameMoveB.BackgroundImage = global::File_Manager_Winform.Properties.Resources.Rename_Move_File;
            this.RenameMoveB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RenameMoveB.Location = new System.Drawing.Point(15, 139);
            this.RenameMoveB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RenameMoveB.Name = "RenameMoveB";
            this.RenameMoveB.Size = new System.Drawing.Size(29, 30);
            this.RenameMoveB.TabIndex = 0;
            this.RenameMoveB.UseVisualStyleBackColor = false;
            // 
            // PackFileB
            // 
            this.PackFileB.BackgroundImage = global::File_Manager_Winform.Properties.Resources.File_Packet;
            this.PackFileB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PackFileB.Location = new System.Drawing.Point(15, 238);
            this.PackFileB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PackFileB.Name = "PackFileB";
            this.PackFileB.Size = new System.Drawing.Size(29, 30);
            this.PackFileB.TabIndex = 1;
            this.PackFileB.UseVisualStyleBackColor = true;
            // 
            // CopyB
            // 
            this.CopyB.BackgroundImage = global::File_Manager_Winform.Properties.Resources.Copy_File;
            this.CopyB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CopyB.Location = new System.Drawing.Point(15, 103);
            this.CopyB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CopyB.Name = "CopyB";
            this.CopyB.Size = new System.Drawing.Size(29, 30);
            this.CopyB.TabIndex = 0;
            this.CopyB.UseVisualStyleBackColor = true;
            // 
            // DetailFileB
            // 
            this.DetailFileB.BackgroundImage = global::File_Manager_Winform.Properties.Resources.Preview_File;
            this.DetailFileB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DetailFileB.Location = new System.Drawing.Point(15, 31);
            this.DetailFileB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DetailFileB.Name = "DetailFileB";
            this.DetailFileB.Size = new System.Drawing.Size(29, 30);
            this.DetailFileB.TabIndex = 0;
            this.DetailFileB.UseVisualStyleBackColor = true;
            // 
            // EditB
            // 
            this.EditB.BackgroundImage = global::File_Manager_Winform.Properties.Resources.Edit_File;
            this.EditB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditB.Location = new System.Drawing.Point(15, 66);
            this.EditB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditB.Name = "EditB";
            this.EditB.Size = new System.Drawing.Size(29, 30);
            this.EditB.TabIndex = 0;
            this.EditB.UseVisualStyleBackColor = true;
            // 
            // Container_panel
            // 
            this.Container_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Container_panel.BackColor = System.Drawing.SystemColors.Control;
            this.Container_panel.Controls.Add(this.Directory_Table_layout_Panel);
            this.Container_panel.Controls.Add(this.Bottom_Button_Table_layout_panel);
            this.Container_panel.Controls.Add(this.ShortcutGB);
            this.Container_panel.Location = new System.Drawing.Point(0, 0);
            this.Container_panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Container_panel.Name = "Container_panel";
            this.Container_panel.Size = new System.Drawing.Size(880, 510);
            this.Container_panel.TabIndex = 6;
            this.Container_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Container_panel_Paint);
            // 
            // Directory_Table_layout_Panel
            // 
            this.Directory_Table_layout_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Directory_Table_layout_Panel.ColumnCount = 2;
            this.Directory_Table_layout_Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.86003F));
            this.Directory_Table_layout_Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.13998F));
            this.Directory_Table_layout_Panel.Controls.Add(this.Directory_Label, 0, 0);
            this.Directory_Table_layout_Panel.Controls.Add(this.Directory_ComboBox, 1, 0);
            this.Directory_Table_layout_Panel.Location = new System.Drawing.Point(135, 436);
            this.Directory_Table_layout_Panel.Margin = new System.Windows.Forms.Padding(100, 2, 3, 2);
            this.Directory_Table_layout_Panel.Name = "Directory_Table_layout_Panel";
            this.Directory_Table_layout_Panel.RowCount = 1;
            this.Directory_Table_layout_Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Directory_Table_layout_Panel.Size = new System.Drawing.Size(745, 34);
            this.Directory_Table_layout_Panel.TabIndex = 6;
            // 
            // Directory_Label
            // 
            this.Directory_Label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Directory_Label.AutoSize = true;
            this.Directory_Label.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Directory_Label.Location = new System.Drawing.Point(92, 7);
            this.Directory_Label.Name = "Directory_Label";
            this.Directory_Label.Size = new System.Drawing.Size(105, 19);
            this.Directory_Label.TabIndex = 1;
            this.Directory_Label.Text = "<Duong Dan>";
            // 
            // Directory_ComboBox
            // 
            this.Directory_ComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Directory_ComboBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Directory_ComboBox.FormattingEnabled = true;
            this.Directory_ComboBox.Location = new System.Drawing.Point(203, 2);
            this.Directory_ComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Directory_ComboBox.Name = "Directory_ComboBox";
            this.Directory_ComboBox.Size = new System.Drawing.Size(539, 27);
            this.Directory_ComboBox.TabIndex = 0;
            this.Directory_ComboBox.Text = "<TextBox>";
            // 
            // Bottom_Button_Table_layout_panel
            // 
            this.Bottom_Button_Table_layout_panel.ColumnCount = 7;
            this.Bottom_Button_Table_layout_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.Bottom_Button_Table_layout_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.Bottom_Button_Table_layout_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.Bottom_Button_Table_layout_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.Bottom_Button_Table_layout_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.Bottom_Button_Table_layout_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.Bottom_Button_Table_layout_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.Bottom_Button_Table_layout_panel.Controls.Add(this.F3Button, 0, 0);
            this.Bottom_Button_Table_layout_panel.Controls.Add(this.F5Button, 2, 0);
            this.Bottom_Button_Table_layout_panel.Controls.Add(this.F6Button, 3, 0);
            this.Bottom_Button_Table_layout_panel.Controls.Add(this.F4Button, 1, 0);
            this.Bottom_Button_Table_layout_panel.Controls.Add(this.F7Button, 4, 0);
            this.Bottom_Button_Table_layout_panel.Controls.Add(this.F8Button, 5, 0);
            this.Bottom_Button_Table_layout_panel.Controls.Add(this.ExitButton, 6, 0);
            this.Bottom_Button_Table_layout_panel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Bottom_Button_Table_layout_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Bottom_Button_Table_layout_panel.Location = new System.Drawing.Point(0, 476);
            this.Bottom_Button_Table_layout_panel.Margin = new System.Windows.Forms.Padding(0);
            this.Bottom_Button_Table_layout_panel.Name = "Bottom_Button_Table_layout_panel";
            this.Bottom_Button_Table_layout_panel.RowCount = 1;
            this.Bottom_Button_Table_layout_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Bottom_Button_Table_layout_panel.Size = new System.Drawing.Size(880, 34);
            this.Bottom_Button_Table_layout_panel.TabIndex = 5;
            // 
            // F3Button
            // 
            this.F3Button.BackColor = System.Drawing.SystemColors.Control;
            this.F3Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.F3Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.F3Button.FlatAppearance.BorderSize = 0;
            this.F3Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.F3Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.F3Button.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F3Button.Location = new System.Drawing.Point(0, 0);
            this.F3Button.Margin = new System.Windows.Forms.Padding(0);
            this.F3Button.Name = "F3Button";
            this.F3Button.Size = new System.Drawing.Size(125, 34);
            this.F3Button.TabIndex = 0;
            this.F3Button.Text = "F3 VIEW";
            this.F3Button.UseVisualStyleBackColor = false;
            // 
            // F5Button
            // 
            this.F5Button.BackColor = System.Drawing.SystemColors.Control;
            this.F5Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.F5Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.F5Button.FlatAppearance.BorderSize = 0;
            this.F5Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.F5Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.F5Button.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F5Button.Location = new System.Drawing.Point(250, 0);
            this.F5Button.Margin = new System.Windows.Forms.Padding(0);
            this.F5Button.Name = "F5Button";
            this.F5Button.Size = new System.Drawing.Size(125, 34);
            this.F5Button.TabIndex = 3;
            this.F5Button.Text = "F5 Copy";
            this.F5Button.UseVisualStyleBackColor = false;
            // 
            // F6Button
            // 
            this.F6Button.BackColor = System.Drawing.SystemColors.Control;
            this.F6Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.F6Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.F6Button.FlatAppearance.BorderSize = 0;
            this.F6Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.F6Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.F6Button.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F6Button.Location = new System.Drawing.Point(375, 0);
            this.F6Button.Margin = new System.Windows.Forms.Padding(0);
            this.F6Button.Name = "F6Button";
            this.F6Button.Size = new System.Drawing.Size(125, 34);
            this.F6Button.TabIndex = 2;
            this.F6Button.Text = "F6 Move";
            this.F6Button.UseVisualStyleBackColor = false;
            // 
            // F4Button
            // 
            this.F4Button.BackColor = System.Drawing.SystemColors.Control;
            this.F4Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.F4Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.F4Button.FlatAppearance.BorderSize = 0;
            this.F4Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.F4Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.F4Button.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F4Button.Location = new System.Drawing.Point(125, 0);
            this.F4Button.Margin = new System.Windows.Forms.Padding(0);
            this.F4Button.Name = "F4Button";
            this.F4Button.Size = new System.Drawing.Size(125, 34);
            this.F4Button.TabIndex = 4;
            this.F4Button.Text = "F4 Edit";
            this.F4Button.UseVisualStyleBackColor = false;
            // 
            // F7Button
            // 
            this.F7Button.BackColor = System.Drawing.SystemColors.Control;
            this.F7Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.F7Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.F7Button.FlatAppearance.BorderSize = 0;
            this.F7Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.F7Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.F7Button.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F7Button.Location = new System.Drawing.Point(500, 0);
            this.F7Button.Margin = new System.Windows.Forms.Padding(0);
            this.F7Button.Name = "F7Button";
            this.F7Button.Size = new System.Drawing.Size(125, 34);
            this.F7Button.TabIndex = 5;
            this.F7Button.Text = "F7 NewFolder";
            this.F7Button.UseVisualStyleBackColor = false;
            // 
            // F8Button
            // 
            this.F8Button.BackColor = System.Drawing.SystemColors.Control;
            this.F8Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.F8Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.F8Button.FlatAppearance.BorderSize = 0;
            this.F8Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.F8Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.F8Button.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F8Button.Location = new System.Drawing.Point(625, 0);
            this.F8Button.Margin = new System.Windows.Forms.Padding(0);
            this.F8Button.Name = "F8Button";
            this.F8Button.Size = new System.Drawing.Size(125, 34);
            this.F8Button.TabIndex = 6;
            this.F8Button.Text = "F8 Delete";
            this.F8Button.UseVisualStyleBackColor = false;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.Control;
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ExitButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(750, 0);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(130, 34);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "Alt+F4 Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 510);
            this.Controls.Add(this.Container_panel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ShortcutGB.ResumeLayout(false);
            this.Container_panel.ResumeLayout(false);
            this.Directory_Table_layout_Panel.ResumeLayout(false);
            this.Directory_Table_layout_Panel.PerformLayout();
            this.Bottom_Button_Table_layout_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox ShortcutGB;
        private System.Windows.Forms.Panel Container_panel;
        private System.Windows.Forms.TableLayoutPanel Directory_Table_layout_Panel;
        private System.Windows.Forms.Label Directory_Label;
        private System.Windows.Forms.ComboBox Directory_ComboBox;
        private System.Windows.Forms.TableLayoutPanel Bottom_Button_Table_layout_panel;
        private System.Windows.Forms.Button F3Button;
        private System.Windows.Forms.Button F5Button;
        private System.Windows.Forms.Button F6Button;
        private System.Windows.Forms.Button F4Button;
        private System.Windows.Forms.Button MakeDirB;
        private System.Windows.Forms.Button RenameMoveB;
        private System.Windows.Forms.Button PackFileB;
        private System.Windows.Forms.Button CopyB;
        private System.Windows.Forms.Button EditB;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Button DetailFileB;
        private System.Windows.Forms.Button F7Button;
        private System.Windows.Forms.Button F8Button;
        private System.Windows.Forms.Button ExitButton;
    }
}

