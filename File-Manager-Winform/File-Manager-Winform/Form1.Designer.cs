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
            this.F1Button = new System.Windows.Forms.Button();
            this.F3Button = new System.Windows.Forms.Button();
            this.F2Button = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.Container_panel = new System.Windows.Forms.Panel();
            this.Directory_Table_layout_Panel = new System.Windows.Forms.TableLayoutPanel();
            this.Directory_Label = new System.Windows.Forms.Label();
            this.Directory_ComboBox = new System.Windows.Forms.ComboBox();
            this.Bottom_Button_Table_layout_panel = new System.Windows.Forms.TableLayoutPanel();
            this.Container_panel.SuspendLayout();
            this.Directory_Table_layout_Panel.SuspendLayout();
            this.Bottom_Button_Table_layout_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // F1Button
            // 
            this.F1Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.F1Button.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F1Button.Location = new System.Drawing.Point(0, 0);
            this.F1Button.Margin = new System.Windows.Forms.Padding(0);
            this.F1Button.Name = "F1Button";
            this.F1Button.Size = new System.Drawing.Size(275, 34);
            this.F1Button.TabIndex = 0;
            this.F1Button.Text = "F1 HELP\r\n";
            this.F1Button.UseVisualStyleBackColor = true;
            this.F1Button.Click += new System.EventHandler(this.Show_Help);
            // 
            // F3Button
            // 
            this.F3Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.F3Button.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F3Button.Location = new System.Drawing.Point(550, 0);
            this.F3Button.Margin = new System.Windows.Forms.Padding(0);
            this.F3Button.Name = "F3Button";
            this.F3Button.Size = new System.Drawing.Size(275, 34);
            this.F3Button.TabIndex = 3;
            this.F3Button.Text = "F3 VIEW";
            this.F3Button.UseVisualStyleBackColor = true;
            // 
            // F2Button
            // 
            this.F2Button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.F2Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.F2Button.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F2Button.Location = new System.Drawing.Point(275, 0);
            this.F2Button.Margin = new System.Windows.Forms.Padding(0);
            this.F2Button.Name = "F2Button";
            this.F2Button.Size = new System.Drawing.Size(275, 34);
            this.F2Button.TabIndex = 4;
            this.F2Button.Text = "F2 CONFIGURATION";
            this.F2Button.UseVisualStyleBackColor = false;
            // 
            // ExitButton
            // 
            this.ExitButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExitButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(825, 0);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(277, 34);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Alt+F4 EXIT";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // Container_panel
            // 
            this.Container_panel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Container_panel.Controls.Add(this.Directory_Table_layout_Panel);
            this.Container_panel.Controls.Add(this.Bottom_Button_Table_layout_panel);
            this.Container_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Container_panel.Location = new System.Drawing.Point(0, 0);
            this.Container_panel.Name = "Container_panel";
            this.Container_panel.Size = new System.Drawing.Size(1102, 630);
            this.Container_panel.TabIndex = 5;
            // 
            // Directory_Table_layout_Panel
            // 
            this.Directory_Table_layout_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Directory_Table_layout_Panel.ColumnCount = 2;
            this.Directory_Table_layout_Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.86003F));
            this.Directory_Table_layout_Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.13998F));
            this.Directory_Table_layout_Panel.Controls.Add(this.Directory_Label, 0, 0);
            this.Directory_Table_layout_Panel.Controls.Add(this.Directory_ComboBox, 1, 0);
            this.Directory_Table_layout_Panel.Location = new System.Drawing.Point(306, 561);
            this.Directory_Table_layout_Panel.Margin = new System.Windows.Forms.Padding(100, 3, 3, 3);
            this.Directory_Table_layout_Panel.Name = "Directory_Table_layout_Panel";
            this.Directory_Table_layout_Panel.RowCount = 1;
            this.Directory_Table_layout_Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Directory_Table_layout_Panel.Size = new System.Drawing.Size(793, 34);
            this.Directory_Table_layout_Panel.TabIndex = 6;
            // 
            // Directory_Label
            // 
            this.Directory_Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Directory_Label.AutoSize = true;
            this.Directory_Label.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Directory_Label.Location = new System.Drawing.Point(54, 7);
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
            this.Directory_ComboBox.Location = new System.Drawing.Point(216, 3);
            this.Directory_ComboBox.Name = "Directory_ComboBox";
            this.Directory_ComboBox.Size = new System.Drawing.Size(574, 27);
            this.Directory_ComboBox.TabIndex = 0;
            this.Directory_ComboBox.Text = "<TextBox>";
            // 
            // Bottom_Button_Table_layout_panel
            // 
            this.Bottom_Button_Table_layout_panel.ColumnCount = 4;
            this.Bottom_Button_Table_layout_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Bottom_Button_Table_layout_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Bottom_Button_Table_layout_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Bottom_Button_Table_layout_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Bottom_Button_Table_layout_panel.Controls.Add(this.F1Button, 0, 0);
            this.Bottom_Button_Table_layout_panel.Controls.Add(this.F3Button, 2, 0);
            this.Bottom_Button_Table_layout_panel.Controls.Add(this.ExitButton, 3, 0);
            this.Bottom_Button_Table_layout_panel.Controls.Add(this.F2Button, 1, 0);
            this.Bottom_Button_Table_layout_panel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Bottom_Button_Table_layout_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Bottom_Button_Table_layout_panel.Location = new System.Drawing.Point(0, 596);
            this.Bottom_Button_Table_layout_panel.Name = "Bottom_Button_Table_layout_panel";
            this.Bottom_Button_Table_layout_panel.RowCount = 1;
            this.Bottom_Button_Table_layout_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Bottom_Button_Table_layout_panel.Size = new System.Drawing.Size(1102, 34);
            this.Bottom_Button_Table_layout_panel.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 630);
            this.Controls.Add(this.Container_panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Container_panel.ResumeLayout(false);
            this.Directory_Table_layout_Panel.ResumeLayout(false);
            this.Directory_Table_layout_Panel.PerformLayout();
            this.Bottom_Button_Table_layout_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button F1Button;
        private System.Windows.Forms.Button F3Button;
        private System.Windows.Forms.Button F2Button;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Panel Container_panel;
        private System.Windows.Forms.ComboBox Directory_ComboBox;
        private System.Windows.Forms.Label Directory_Label;
        private System.Windows.Forms.TableLayoutPanel Bottom_Button_Table_layout_panel;
        private System.Windows.Forms.TableLayoutPanel Directory_Table_layout_Panel;
    }
}

