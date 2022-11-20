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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ShortcutGB = new System.Windows.Forms.GroupBox();
            this.MakeDirB = new System.Windows.Forms.Button();
            this.RenameMoveB = new System.Windows.Forms.Button();
            this.PackFileB = new System.Windows.Forms.Button();
            this.CopyB = new System.Windows.Forms.Button();
            this.DetailFileB = new System.Windows.Forms.Button();
            this.EditB = new System.Windows.Forms.Button();
            this.Container_panel = new System.Windows.Forms.Panel();
            this.MiddlepartTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changesAttributesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.packToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unpackSpecificFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testArchivesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compareByContentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.associateWithToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internetAssociationsTotalCommanderOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateOccupiedSpaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiRenameToolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCommentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.splitFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.combineFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encodeFileMIMEUUEXXEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decodeFileMIMEUUEXXEBinHexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createChecksumFilesCRC32MD5SHA1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verifyChecksumsfromChecksumFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unselectGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unselectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllWithSameExtensionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.saveSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSelectionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadSelectionFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.copySelecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyNamesWithPathToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToClipboardWithAllDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToClipboardWithPathDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.compareDirectoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markNewerHideSameFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cDTreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchInSeperateProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volumeLabelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.synchronizeDirsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directoryHotlistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goBackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.openCommandPromptWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.branchViewWithSubdirsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDesktopFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundTransferManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.targetSourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.netToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.networkConnectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectNetworkDrivesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shareCurrentDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAdminSharesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.fTPConnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fTPNewConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fTPDisconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fTPShowHiddenFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fTPDownloadFromListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pORTConnectionToOtherPCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.briefToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customColumnsModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customViewModesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.separateTreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thumbnailViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quickViewPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalArrangementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFolderTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.allFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.customToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlySelectedFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.nameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extensionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unsortedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.reversedOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rereadSourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.rereadSourceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonBar2VerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeSettingsFilesDirectlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkNormalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeStartMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeMainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keyboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrationInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ShortcutGB.SuspendLayout();
            this.Container_panel.SuspendLayout();
            this.MiddlepartTableLayoutPanel.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.Directory_Table_layout_Panel.SuspendLayout();
            this.Bottom_Button_Table_layout_panel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // ShortcutGB
            // 
            this.ShortcutGB.BackColor = System.Drawing.SystemColors.Control;
            this.ShortcutGB.Controls.Add(this.MakeDirB);
            this.ShortcutGB.Controls.Add(this.RenameMoveB);
            this.ShortcutGB.Controls.Add(this.PackFileB);
            this.ShortcutGB.Controls.Add(this.CopyB);
            this.ShortcutGB.Controls.Add(this.DetailFileB);
            this.ShortcutGB.Controls.Add(this.EditB);
            this.ShortcutGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShortcutGB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShortcutGB.Location = new System.Drawing.Point(631, 2);
            this.ShortcutGB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShortcutGB.Name = "ShortcutGB";
            this.ShortcutGB.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShortcutGB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShortcutGB.Size = new System.Drawing.Size(44, 712);
            this.ShortcutGB.TabIndex = 0;
            this.ShortcutGB.TabStop = false;
            // 
            // MakeDirB
            // 
            this.MakeDirB.BackgroundImage = global::File_Manager_Winform.Properties.Resources.Folder_Add;
            this.MakeDirB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MakeDirB.Location = new System.Drawing.Point(9, 173);
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
            this.RenameMoveB.Location = new System.Drawing.Point(9, 139);
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
            this.PackFileB.Location = new System.Drawing.Point(9, 207);
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
            this.CopyB.Location = new System.Drawing.Point(9, 105);
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
            this.DetailFileB.Location = new System.Drawing.Point(9, 31);
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
            this.EditB.Location = new System.Drawing.Point(9, 65);
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
            this.Container_panel.Controls.Add(this.MiddlepartTableLayoutPanel);
            this.Container_panel.Controls.Add(this.Directory_Table_layout_Panel);
            this.Container_panel.Controls.Add(this.Bottom_Button_Table_layout_panel);
            this.Container_panel.Controls.Add(this.menuStrip1);
            this.Container_panel.Location = new System.Drawing.Point(-1, 0);
            this.Container_panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Container_panel.Name = "Container_panel";
            this.Container_panel.Size = new System.Drawing.Size(1306, 812);
            this.Container_panel.TabIndex = 6;
            // 
            // MiddlepartTableLayoutPanel
            // 
            this.MiddlepartTableLayoutPanel.ColumnCount = 3;
            this.MiddlepartTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MiddlepartTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.MiddlepartTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MiddlepartTableLayoutPanel.Controls.Add(this.LeftPanel, 0, 0);
            this.MiddlepartTableLayoutPanel.Controls.Add(this.RightPanel, 2, 0);
            this.MiddlepartTableLayoutPanel.Controls.Add(this.ShortcutGB, 1, 0);
            this.MiddlepartTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MiddlepartTableLayoutPanel.Location = new System.Drawing.Point(0, 28);
            this.MiddlepartTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MiddlepartTableLayoutPanel.Name = "MiddlepartTableLayoutPanel";
            this.MiddlepartTableLayoutPanel.RowCount = 1;
            this.MiddlepartTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MiddlepartTableLayoutPanel.Size = new System.Drawing.Size(1306, 716);
            this.MiddlepartTableLayoutPanel.TabIndex = 2;
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LeftPanel.Controls.Add(this.listView1);
            this.LeftPanel.Controls.Add(this.label1);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftPanel.Location = new System.Drawing.Point(3, 3);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(622, 710);
            this.LeftPanel.TabIndex = 8;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(1, 50);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(600, 200);
            this.listView1.SmallImageList = this.imageList2;
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Width = 30;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Width = 70;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder_icon.png");
            this.imageList1.Images.SetKeyName(1, "file._icon.png");
            this.imageList1.Images.SetKeyName(2, "picture_icon.png");
            this.imageList1.Images.SetKeyName(3, "zip_icon.jpg");
            this.imageList1.Images.SetKeyName(4, "word_icon.png");
            this.imageList1.Images.SetKeyName(5, "Excel_icon.png");
            this.imageList1.Images.SetKeyName(6, "pdf_icon.png");
            this.imageList1.Images.SetKeyName(7, "dll_icon.png");
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "folder_icon.png");
            this.imageList2.Images.SetKeyName(1, "file._icon.png");
            this.imageList2.Images.SetKeyName(2, "picture_icon.png");
            this.imageList2.Images.SetKeyName(3, "zip_icon.jpg");
            this.imageList2.Images.SetKeyName(4, "word_icon.png");
            this.imageList2.Images.SetKeyName(5, "Excel_icon.png");
            this.imageList2.Images.SetKeyName(6, "pdf_icon.png");
            this.imageList2.Images.SetKeyName(7, "dll_icon.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHAN CUA AN";
            // 
            // RightPanel
            // 
            this.RightPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.RightPanel.Controls.Add(this.label2);
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightPanel.Location = new System.Drawing.Point(681, 3);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(622, 710);
            this.RightPanel.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(244, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "PHAN CUA YOKU";
            // 
            // Directory_Table_layout_Panel
            // 
            this.Directory_Table_layout_Panel.ColumnCount = 2;
            this.Directory_Table_layout_Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.86003F));
            this.Directory_Table_layout_Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.13998F));
            this.Directory_Table_layout_Panel.Controls.Add(this.Directory_Label, 0, 0);
            this.Directory_Table_layout_Panel.Controls.Add(this.Directory_ComboBox, 1, 0);
            this.Directory_Table_layout_Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Directory_Table_layout_Panel.Location = new System.Drawing.Point(0, 744);
            this.Directory_Table_layout_Panel.Margin = new System.Windows.Forms.Padding(100, 2, 3, 2);
            this.Directory_Table_layout_Panel.Name = "Directory_Table_layout_Panel";
            this.Directory_Table_layout_Panel.RowCount = 1;
            this.Directory_Table_layout_Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Directory_Table_layout_Panel.Size = new System.Drawing.Size(1306, 34);
            this.Directory_Table_layout_Panel.TabIndex = 6;
            // 
            // Directory_Label
            // 
            this.Directory_Label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Directory_Label.AutoSize = true;
            this.Directory_Label.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Directory_Label.Location = new System.Drawing.Point(242, 7);
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
            this.Directory_ComboBox.Location = new System.Drawing.Point(353, 2);
            this.Directory_ComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Directory_ComboBox.Name = "Directory_ComboBox";
            this.Directory_ComboBox.Size = new System.Drawing.Size(950, 27);
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
            this.Bottom_Button_Table_layout_panel.Location = new System.Drawing.Point(0, 778);
            this.Bottom_Button_Table_layout_panel.Margin = new System.Windows.Forms.Padding(0);
            this.Bottom_Button_Table_layout_panel.Name = "Bottom_Button_Table_layout_panel";
            this.Bottom_Button_Table_layout_panel.RowCount = 1;
            this.Bottom_Button_Table_layout_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Bottom_Button_Table_layout_panel.Size = new System.Drawing.Size(1306, 34);
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
            this.F3Button.Size = new System.Drawing.Size(186, 34);
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
            this.F5Button.Location = new System.Drawing.Point(372, 0);
            this.F5Button.Margin = new System.Windows.Forms.Padding(0);
            this.F5Button.Name = "F5Button";
            this.F5Button.Size = new System.Drawing.Size(186, 34);
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
            this.F6Button.Location = new System.Drawing.Point(558, 0);
            this.F6Button.Margin = new System.Windows.Forms.Padding(0);
            this.F6Button.Name = "F6Button";
            this.F6Button.Size = new System.Drawing.Size(186, 34);
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
            this.F4Button.Location = new System.Drawing.Point(186, 0);
            this.F4Button.Margin = new System.Windows.Forms.Padding(0);
            this.F4Button.Name = "F4Button";
            this.F4Button.Size = new System.Drawing.Size(186, 34);
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
            this.F7Button.Location = new System.Drawing.Point(744, 0);
            this.F7Button.Margin = new System.Windows.Forms.Padding(0);
            this.F7Button.Name = "F7Button";
            this.F7Button.Size = new System.Drawing.Size(186, 34);
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
            this.F8Button.Location = new System.Drawing.Point(930, 0);
            this.F8Button.Margin = new System.Windows.Forms.Padding(0);
            this.F8Button.Name = "F8Button";
            this.F8Button.Size = new System.Drawing.Size(186, 34);
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
            this.ExitButton.Location = new System.Drawing.Point(1116, 0);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(190, 34);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "Alt+F4 Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.markToolStripMenuItem,
            this.commandsToolStripMenuItem,
            this.netToolStripMenuItem,
            this.showToolStripMenuItem,
            this.configurationToolStripMenuItem,
            this.startToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1306, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changesAttributesToolStripMenuItem,
            this.packToolStripMenuItem,
            this.unpackSpecificFilesToolStripMenuItem,
            this.testArchivesToolStripMenuItem,
            this.compareByContentToolStripMenuItem,
            this.associateWithToolStripMenuItem,
            this.internetAssociationsTotalCommanderOnlyToolStripMenuItem,
            this.toolStripMenuItem8,
            this.calculateOccupiedSpaceToolStripMenuItem,
            this.multiRenameToolToolStripMenuItem,
            this.editCommentToolStripMenuItem,
            this.printToolStripMenuItem,
            this.toolStripSeparator2,
            this.splitFileToolStripMenuItem,
            this.combineFilesToolStripMenuItem,
            this.encodeFileMIMEUUEXXEToolStripMenuItem,
            this.decodeFileMIMEUUEXXEBinHexToolStripMenuItem,
            this.createChecksumFilesCRC32MD5SHA1ToolStripMenuItem,
            this.verifyChecksumsfromChecksumFilesToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.fileToolStripMenuItem.Text = "Files";
            // 
            // changesAttributesToolStripMenuItem
            // 
            this.changesAttributesToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.changesAttributesToolStripMenuItem.Name = "changesAttributesToolStripMenuItem";
            this.changesAttributesToolStripMenuItem.Size = new System.Drawing.Size(405, 26);
            this.changesAttributesToolStripMenuItem.Text = "Changes Attributes...";
            // 
            // packToolStripMenuItem
            // 
            this.packToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.packToolStripMenuItem.Name = "packToolStripMenuItem";
            this.packToolStripMenuItem.ShortcutKeyDisplayString = "Alt+F5";
            this.packToolStripMenuItem.Size = new System.Drawing.Size(405, 26);
            this.packToolStripMenuItem.Text = "Pack...";
            // 
            // unpackSpecificFilesToolStripMenuItem
            // 
            this.unpackSpecificFilesToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.unpackSpecificFilesToolStripMenuItem.Name = "unpackSpecificFilesToolStripMenuItem";
            this.unpackSpecificFilesToolStripMenuItem.ShortcutKeyDisplayString = "Alt+F9";
            this.unpackSpecificFilesToolStripMenuItem.Size = new System.Drawing.Size(405, 26);
            this.unpackSpecificFilesToolStripMenuItem.Text = "Unpack Specific Files...";
            // 
            // testArchivesToolStripMenuItem
            // 
            this.testArchivesToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.testArchivesToolStripMenuItem.Name = "testArchivesToolStripMenuItem";
            this.testArchivesToolStripMenuItem.ShortcutKeyDisplayString = "Alt+Shift+F9";
            this.testArchivesToolStripMenuItem.Size = new System.Drawing.Size(405, 26);
            this.testArchivesToolStripMenuItem.Text = "Test Archive(s)";
            // 
            // compareByContentToolStripMenuItem
            // 
            this.compareByContentToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.compareByContentToolStripMenuItem.Name = "compareByContentToolStripMenuItem";
            this.compareByContentToolStripMenuItem.Size = new System.Drawing.Size(405, 26);
            this.compareByContentToolStripMenuItem.Text = "Compare By Content...";
            // 
            // associateWithToolStripMenuItem
            // 
            this.associateWithToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.associateWithToolStripMenuItem.Name = "associateWithToolStripMenuItem";
            this.associateWithToolStripMenuItem.Size = new System.Drawing.Size(405, 26);
            this.associateWithToolStripMenuItem.Text = "Associate With...";
            // 
            // internetAssociationsTotalCommanderOnlyToolStripMenuItem
            // 
            this.internetAssociationsTotalCommanderOnlyToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.internetAssociationsTotalCommanderOnlyToolStripMenuItem.Name = "internetAssociationsTotalCommanderOnlyToolStripMenuItem";
            this.internetAssociationsTotalCommanderOnlyToolStripMenuItem.Size = new System.Drawing.Size(405, 26);
            this.internetAssociationsTotalCommanderOnlyToolStripMenuItem.Text = "Internet Associations (Total Commander Only)...";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.ShortcutKeyDisplayString = "Alt+Enter";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(405, 26);
            this.toolStripMenuItem8.Text = "Properties...";
            // 
            // calculateOccupiedSpaceToolStripMenuItem
            // 
            this.calculateOccupiedSpaceToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.calculateOccupiedSpaceToolStripMenuItem.Name = "calculateOccupiedSpaceToolStripMenuItem";
            this.calculateOccupiedSpaceToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+L";
            this.calculateOccupiedSpaceToolStripMenuItem.Size = new System.Drawing.Size(405, 26);
            this.calculateOccupiedSpaceToolStripMenuItem.Text = "Calculate Occupied Space...";
            // 
            // multiRenameToolToolStripMenuItem
            // 
            this.multiRenameToolToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.multiRenameToolToolStripMenuItem.Name = "multiRenameToolToolStripMenuItem";
            this.multiRenameToolToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+M";
            this.multiRenameToolToolStripMenuItem.Size = new System.Drawing.Size(405, 26);
            this.multiRenameToolToolStripMenuItem.Text = "Multi-Rename Tool...";
            // 
            // editCommentToolStripMenuItem
            // 
            this.editCommentToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.editCommentToolStripMenuItem.Name = "editCommentToolStripMenuItem";
            this.editCommentToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Z";
            this.editCommentToolStripMenuItem.Size = new System.Drawing.Size(405, 26);
            this.editCommentToolStripMenuItem.Text = "Edit Comment...";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(405, 26);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripSeparator2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(402, 6);
            // 
            // splitFileToolStripMenuItem
            // 
            this.splitFileToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.splitFileToolStripMenuItem.Name = "splitFileToolStripMenuItem";
            this.splitFileToolStripMenuItem.Size = new System.Drawing.Size(405, 26);
            this.splitFileToolStripMenuItem.Text = "Split File...";
            // 
            // combineFilesToolStripMenuItem
            // 
            this.combineFilesToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.combineFilesToolStripMenuItem.Name = "combineFilesToolStripMenuItem";
            this.combineFilesToolStripMenuItem.Size = new System.Drawing.Size(405, 26);
            this.combineFilesToolStripMenuItem.Text = "Combine Files...";
            // 
            // encodeFileMIMEUUEXXEToolStripMenuItem
            // 
            this.encodeFileMIMEUUEXXEToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.encodeFileMIMEUUEXXEToolStripMenuItem.Name = "encodeFileMIMEUUEXXEToolStripMenuItem";
            this.encodeFileMIMEUUEXXEToolStripMenuItem.Size = new System.Drawing.Size(405, 26);
            this.encodeFileMIMEUUEXXEToolStripMenuItem.Text = "Encode File (MIME,UUE,XXE)...";
            // 
            // decodeFileMIMEUUEXXEBinHexToolStripMenuItem
            // 
            this.decodeFileMIMEUUEXXEBinHexToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.decodeFileMIMEUUEXXEBinHexToolStripMenuItem.Name = "decodeFileMIMEUUEXXEBinHexToolStripMenuItem";
            this.decodeFileMIMEUUEXXEBinHexToolStripMenuItem.Size = new System.Drawing.Size(405, 26);
            this.decodeFileMIMEUUEXXEBinHexToolStripMenuItem.Text = "Decode File (MIME,UUE,XXE,BinHex)...";
            // 
            // createChecksumFilesCRC32MD5SHA1ToolStripMenuItem
            // 
            this.createChecksumFilesCRC32MD5SHA1ToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.createChecksumFilesCRC32MD5SHA1ToolStripMenuItem.Name = "createChecksumFilesCRC32MD5SHA1ToolStripMenuItem";
            this.createChecksumFilesCRC32MD5SHA1ToolStripMenuItem.Size = new System.Drawing.Size(405, 26);
            this.createChecksumFilesCRC32MD5SHA1ToolStripMenuItem.Text = "Create Checksum File(s) (CRC32, MD5, SHA1)...";
            // 
            // verifyChecksumsfromChecksumFilesToolStripMenuItem
            // 
            this.verifyChecksumsfromChecksumFilesToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.verifyChecksumsfromChecksumFilesToolStripMenuItem.Name = "verifyChecksumsfromChecksumFilesToolStripMenuItem";
            this.verifyChecksumsfromChecksumFilesToolStripMenuItem.Size = new System.Drawing.Size(405, 26);
            this.verifyChecksumsfromChecksumFilesToolStripMenuItem.Text = "Verify Checksums (from checksum files)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripSeparator1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(402, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeyDisplayString = "Alt+F4";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(405, 26);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // markToolStripMenuItem
            // 
            this.markToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectGroupToolStripMenuItem,
            this.unselectGroupToolStripMenuItem,
            this.selectAllToolStripMenuItem,
            this.unselectAllToolStripMenuItem,
            this.invertSelectionToolStripMenuItem,
            this.selectAllWithSameExtensionToolStripMenuItem,
            this.toolStripSeparator3,
            this.saveSelectionToolStripMenuItem,
            this.restoreSelectionToolStripMenuItem,
            this.saveSelectionToolStripMenuItem1,
            this.loadSelectionFromFileToolStripMenuItem,
            this.toolStripSeparator4,
            this.copySelecToolStripMenuItem,
            this.copyNamesWithPathToClipboardToolStripMenuItem,
            this.copyToClipboardWithAllDetailsToolStripMenuItem,
            this.copyToClipboardWithPathDetailsToolStripMenuItem,
            this.toolStripSeparator5,
            this.compareDirectoriesToolStripMenuItem,
            this.markNewerHideSameFilesToolStripMenuItem});
            this.markToolStripMenuItem.Name = "markToolStripMenuItem";
            this.markToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.markToolStripMenuItem.Text = "Mark";
            // 
            // selectGroupToolStripMenuItem
            // 
            this.selectGroupToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.selectGroupToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.selectGroupToolStripMenuItem.Name = "selectGroupToolStripMenuItem";
            this.selectGroupToolStripMenuItem.ShortcutKeyDisplayString = "Num +";
            this.selectGroupToolStripMenuItem.Size = new System.Drawing.Size(375, 26);
            this.selectGroupToolStripMenuItem.Text = "Select Group...";
            // 
            // unselectGroupToolStripMenuItem
            // 
            this.unselectGroupToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.unselectGroupToolStripMenuItem.Name = "unselectGroupToolStripMenuItem";
            this.unselectGroupToolStripMenuItem.ShortcutKeyDisplayString = "Num -";
            this.unselectGroupToolStripMenuItem.Size = new System.Drawing.Size(375, 26);
            this.unselectGroupToolStripMenuItem.Text = "Unselect Group...";
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl Num +";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(375, 26);
            this.selectAllToolStripMenuItem.Text = "Select All";
            // 
            // unselectAllToolStripMenuItem
            // 
            this.unselectAllToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.unselectAllToolStripMenuItem.Name = "unselectAllToolStripMenuItem";
            this.unselectAllToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl Num -";
            this.unselectAllToolStripMenuItem.Size = new System.Drawing.Size(375, 26);
            this.unselectAllToolStripMenuItem.Text = "Unselect All";
            // 
            // invertSelectionToolStripMenuItem
            // 
            this.invertSelectionToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.invertSelectionToolStripMenuItem.Name = "invertSelectionToolStripMenuItem";
            this.invertSelectionToolStripMenuItem.ShortcutKeyDisplayString = "Num *";
            this.invertSelectionToolStripMenuItem.Size = new System.Drawing.Size(375, 26);
            this.invertSelectionToolStripMenuItem.Text = "Invert Selection";
            // 
            // selectAllWithSameExtensionToolStripMenuItem
            // 
            this.selectAllWithSameExtensionToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.selectAllWithSameExtensionToolStripMenuItem.Name = "selectAllWithSameExtensionToolStripMenuItem";
            this.selectAllWithSameExtensionToolStripMenuItem.ShortcutKeyDisplayString = "Alt Num +";
            this.selectAllWithSameExtensionToolStripMenuItem.Size = new System.Drawing.Size(375, 26);
            this.selectAllWithSameExtensionToolStripMenuItem.Text = "Select All With Same Extension";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(372, 6);
            // 
            // saveSelectionToolStripMenuItem
            // 
            this.saveSelectionToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.saveSelectionToolStripMenuItem.Name = "saveSelectionToolStripMenuItem";
            this.saveSelectionToolStripMenuItem.Size = new System.Drawing.Size(375, 26);
            this.saveSelectionToolStripMenuItem.Text = "Save Selection";
            // 
            // restoreSelectionToolStripMenuItem
            // 
            this.restoreSelectionToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.restoreSelectionToolStripMenuItem.Name = "restoreSelectionToolStripMenuItem";
            this.restoreSelectionToolStripMenuItem.ShortcutKeyDisplayString = "Num /";
            this.restoreSelectionToolStripMenuItem.Size = new System.Drawing.Size(375, 26);
            this.restoreSelectionToolStripMenuItem.Text = "Restore Selection";
            // 
            // saveSelectionToolStripMenuItem1
            // 
            this.saveSelectionToolStripMenuItem1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.saveSelectionToolStripMenuItem1.Name = "saveSelectionToolStripMenuItem1";
            this.saveSelectionToolStripMenuItem1.Size = new System.Drawing.Size(375, 26);
            this.saveSelectionToolStripMenuItem1.Text = "Save Selection To File";
            // 
            // loadSelectionFromFileToolStripMenuItem
            // 
            this.loadSelectionFromFileToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.loadSelectionFromFileToolStripMenuItem.Name = "loadSelectionFromFileToolStripMenuItem";
            this.loadSelectionFromFileToolStripMenuItem.Size = new System.Drawing.Size(375, 26);
            this.loadSelectionFromFileToolStripMenuItem.Text = "Load Selection From File";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(372, 6);
            // 
            // copySelecToolStripMenuItem
            // 
            this.copySelecToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.copySelecToolStripMenuItem.Name = "copySelecToolStripMenuItem";
            this.copySelecToolStripMenuItem.Size = new System.Drawing.Size(375, 26);
            this.copySelecToolStripMenuItem.Text = "Copy Selected Names To Clipboard";
            // 
            // copyNamesWithPathToClipboardToolStripMenuItem
            // 
            this.copyNamesWithPathToClipboardToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.copyNamesWithPathToClipboardToolStripMenuItem.Name = "copyNamesWithPathToClipboardToolStripMenuItem";
            this.copyNamesWithPathToClipboardToolStripMenuItem.Size = new System.Drawing.Size(375, 26);
            this.copyNamesWithPathToClipboardToolStripMenuItem.Text = "Copy Names With Path To Clipboard";
            // 
            // copyToClipboardWithAllDetailsToolStripMenuItem
            // 
            this.copyToClipboardWithAllDetailsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.copyToClipboardWithAllDetailsToolStripMenuItem.Name = "copyToClipboardWithAllDetailsToolStripMenuItem";
            this.copyToClipboardWithAllDetailsToolStripMenuItem.Size = new System.Drawing.Size(375, 26);
            this.copyToClipboardWithAllDetailsToolStripMenuItem.Text = "Copy To Clipboard With All Details";
            // 
            // copyToClipboardWithPathDetailsToolStripMenuItem
            // 
            this.copyToClipboardWithPathDetailsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.copyToClipboardWithPathDetailsToolStripMenuItem.Name = "copyToClipboardWithPathDetailsToolStripMenuItem";
            this.copyToClipboardWithPathDetailsToolStripMenuItem.Size = new System.Drawing.Size(375, 26);
            this.copyToClipboardWithPathDetailsToolStripMenuItem.Text = "Copy To Clipboard With Path+ Details";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(372, 6);
            // 
            // compareDirectoriesToolStripMenuItem
            // 
            this.compareDirectoriesToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.compareDirectoriesToolStripMenuItem.Name = "compareDirectoriesToolStripMenuItem";
            this.compareDirectoriesToolStripMenuItem.ShortcutKeyDisplayString = "Shift+F2";
            this.compareDirectoriesToolStripMenuItem.Size = new System.Drawing.Size(375, 26);
            this.compareDirectoriesToolStripMenuItem.Text = "Compare Directories";
            // 
            // markNewerHideSameFilesToolStripMenuItem
            // 
            this.markNewerHideSameFilesToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.markNewerHideSameFilesToolStripMenuItem.Name = "markNewerHideSameFilesToolStripMenuItem";
            this.markNewerHideSameFilesToolStripMenuItem.Size = new System.Drawing.Size(375, 26);
            this.markNewerHideSameFilesToolStripMenuItem.Text = "Mark Newer, Hide Same Files";
            // 
            // commandsToolStripMenuItem
            // 
            this.commandsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cDTreeToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.searchInSeperateProcessToolStripMenuItem,
            this.volumeLabelToolStripMenuItem,
            this.systemInformationToolStripMenuItem,
            this.synchronizeDirsToolStripMenuItem,
            this.directoryHotlistToolStripMenuItem,
            this.goBackToolStripMenuItem,
            this.toolStripSeparator8,
            this.openCommandPromptWindowToolStripMenuItem,
            this.toolStripSeparator7,
            this.branchViewWithSubdirsToolStripMenuItem,
            this.openDesktopFolderToolStripMenuItem,
            this.backgroundTransferManagerToolStripMenuItem,
            this.toolStripSeparator6,
            this.aToolStripMenuItem,
            this.targetSourceToolStripMenuItem});
            this.commandsToolStripMenuItem.Name = "commandsToolStripMenuItem";
            this.commandsToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.commandsToolStripMenuItem.Text = "Commands";
            // 
            // cDTreeToolStripMenuItem
            // 
            this.cDTreeToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cDTreeToolStripMenuItem.Name = "cDTreeToolStripMenuItem";
            this.cDTreeToolStripMenuItem.ShortcutKeyDisplayString = "Alt+F10";
            this.cDTreeToolStripMenuItem.Size = new System.Drawing.Size(368, 26);
            this.cDTreeToolStripMenuItem.Text = "CD Tree...";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.ShortcutKeyDisplayString = "Alt+F7";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(368, 26);
            this.searchToolStripMenuItem.Text = "Search...";
            // 
            // searchInSeperateProcessToolStripMenuItem
            // 
            this.searchInSeperateProcessToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.searchInSeperateProcessToolStripMenuItem.Name = "searchInSeperateProcessToolStripMenuItem";
            this.searchInSeperateProcessToolStripMenuItem.ShortcutKeyDisplayString = "Alt+Shift+F7";
            this.searchInSeperateProcessToolStripMenuItem.Size = new System.Drawing.Size(368, 26);
            this.searchInSeperateProcessToolStripMenuItem.Text = "Search in separate Process...";
            // 
            // volumeLabelToolStripMenuItem
            // 
            this.volumeLabelToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.volumeLabelToolStripMenuItem.Name = "volumeLabelToolStripMenuItem";
            this.volumeLabelToolStripMenuItem.Size = new System.Drawing.Size(368, 26);
            this.volumeLabelToolStripMenuItem.Text = "Volume Label...";
            // 
            // systemInformationToolStripMenuItem
            // 
            this.systemInformationToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.systemInformationToolStripMenuItem.Name = "systemInformationToolStripMenuItem";
            this.systemInformationToolStripMenuItem.Size = new System.Drawing.Size(368, 26);
            this.systemInformationToolStripMenuItem.Text = "System Information...";
            // 
            // synchronizeDirsToolStripMenuItem
            // 
            this.synchronizeDirsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.synchronizeDirsToolStripMenuItem.Name = "synchronizeDirsToolStripMenuItem";
            this.synchronizeDirsToolStripMenuItem.Size = new System.Drawing.Size(368, 26);
            this.synchronizeDirsToolStripMenuItem.Text = "Synchronize Dirs...";
            // 
            // directoryHotlistToolStripMenuItem
            // 
            this.directoryHotlistToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.directoryHotlistToolStripMenuItem.Name = "directoryHotlistToolStripMenuItem";
            this.directoryHotlistToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+D";
            this.directoryHotlistToolStripMenuItem.Size = new System.Drawing.Size(368, 26);
            this.directoryHotlistToolStripMenuItem.Text = "Directory Hotlist";
            // 
            // goBackToolStripMenuItem
            // 
            this.goBackToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.goBackToolStripMenuItem.Name = "goBackToolStripMenuItem";
            this.goBackToolStripMenuItem.ShortcutKeyDisplayString = "Alt+Left Arrow";
            this.goBackToolStripMenuItem.Size = new System.Drawing.Size(368, 26);
            this.goBackToolStripMenuItem.Text = "Go Back";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(365, 6);
            // 
            // openCommandPromptWindowToolStripMenuItem
            // 
            this.openCommandPromptWindowToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.openCommandPromptWindowToolStripMenuItem.Name = "openCommandPromptWindowToolStripMenuItem";
            this.openCommandPromptWindowToolStripMenuItem.Size = new System.Drawing.Size(368, 26);
            this.openCommandPromptWindowToolStripMenuItem.Text = "Open command prompt window";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(365, 6);
            // 
            // branchViewWithSubdirsToolStripMenuItem
            // 
            this.branchViewWithSubdirsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.branchViewWithSubdirsToolStripMenuItem.Name = "branchViewWithSubdirsToolStripMenuItem";
            this.branchViewWithSubdirsToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+B";
            this.branchViewWithSubdirsToolStripMenuItem.Size = new System.Drawing.Size(368, 26);
            this.branchViewWithSubdirsToolStripMenuItem.Text = "Branch View (With Subdirs)";
            // 
            // openDesktopFolderToolStripMenuItem
            // 
            this.openDesktopFolderToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.openDesktopFolderToolStripMenuItem.Name = "openDesktopFolderToolStripMenuItem";
            this.openDesktopFolderToolStripMenuItem.Size = new System.Drawing.Size(368, 26);
            this.openDesktopFolderToolStripMenuItem.Text = "Open Desktop Folder";
            // 
            // backgroundTransferManagerToolStripMenuItem
            // 
            this.backgroundTransferManagerToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.backgroundTransferManagerToolStripMenuItem.Name = "backgroundTransferManagerToolStripMenuItem";
            this.backgroundTransferManagerToolStripMenuItem.Size = new System.Drawing.Size(368, 26);
            this.backgroundTransferManagerToolStripMenuItem.Text = "Background Transfer Manager...";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(365, 6);
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+U";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(368, 26);
            this.aToolStripMenuItem.Text = "Source< - > Target";
            // 
            // targetSourceToolStripMenuItem
            // 
            this.targetSourceToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.targetSourceToolStripMenuItem.Name = "targetSourceToolStripMenuItem";
            this.targetSourceToolStripMenuItem.Size = new System.Drawing.Size(368, 26);
            this.targetSourceToolStripMenuItem.Text = "Target=Source";
            // 
            // netToolStripMenuItem
            // 
            this.netToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.networkConnectionsToolStripMenuItem,
            this.disconnectNetworkDrivesToolStripMenuItem,
            this.shareCurrentDirectoryToolStripMenuItem,
            this.showAdminSharesToolStripMenuItem,
            this.toolStripSeparator9,
            this.fTPConnectToolStripMenuItem,
            this.fTPNewConnectionToolStripMenuItem,
            this.fTPDisconnectToolStripMenuItem,
            this.fTPShowHiddenFilesToolStripMenuItem,
            this.fTPDownloadFromListToolStripMenuItem,
            this.pORTConnectionToOtherPCToolStripMenuItem});
            this.netToolStripMenuItem.Name = "netToolStripMenuItem";
            this.netToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.netToolStripMenuItem.Text = "Net";
            // 
            // networkConnectionsToolStripMenuItem
            // 
            this.networkConnectionsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.networkConnectionsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.networkConnectionsToolStripMenuItem.Name = "networkConnectionsToolStripMenuItem";
            this.networkConnectionsToolStripMenuItem.Size = new System.Drawing.Size(297, 26);
            this.networkConnectionsToolStripMenuItem.Text = "Network Connections...";
            // 
            // disconnectNetworkDrivesToolStripMenuItem
            // 
            this.disconnectNetworkDrivesToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.disconnectNetworkDrivesToolStripMenuItem.Name = "disconnectNetworkDrivesToolStripMenuItem";
            this.disconnectNetworkDrivesToolStripMenuItem.Size = new System.Drawing.Size(297, 26);
            this.disconnectNetworkDrivesToolStripMenuItem.Text = "Disconnect Network Drives...";
            // 
            // shareCurrentDirectoryToolStripMenuItem
            // 
            this.shareCurrentDirectoryToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.shareCurrentDirectoryToolStripMenuItem.Name = "shareCurrentDirectoryToolStripMenuItem";
            this.shareCurrentDirectoryToolStripMenuItem.Size = new System.Drawing.Size(297, 26);
            this.shareCurrentDirectoryToolStripMenuItem.Text = "Share Current Directory...";
            // 
            // showAdminSharesToolStripMenuItem
            // 
            this.showAdminSharesToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.showAdminSharesToolStripMenuItem.Name = "showAdminSharesToolStripMenuItem";
            this.showAdminSharesToolStripMenuItem.Size = new System.Drawing.Size(297, 26);
            this.showAdminSharesToolStripMenuItem.Text = "Show Admin Shares";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(294, 6);
            // 
            // fTPConnectToolStripMenuItem
            // 
            this.fTPConnectToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.fTPConnectToolStripMenuItem.Name = "fTPConnectToolStripMenuItem";
            this.fTPConnectToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+F";
            this.fTPConnectToolStripMenuItem.Size = new System.Drawing.Size(297, 26);
            this.fTPConnectToolStripMenuItem.Text = "FTP Connect...";
            // 
            // fTPNewConnectionToolStripMenuItem
            // 
            this.fTPNewConnectionToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.fTPNewConnectionToolStripMenuItem.Name = "fTPNewConnectionToolStripMenuItem";
            this.fTPNewConnectionToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+N";
            this.fTPNewConnectionToolStripMenuItem.Size = new System.Drawing.Size(297, 26);
            this.fTPNewConnectionToolStripMenuItem.Text = "FTP New Connection...";
            // 
            // fTPDisconnectToolStripMenuItem
            // 
            this.fTPDisconnectToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.fTPDisconnectToolStripMenuItem.Name = "fTPDisconnectToolStripMenuItem";
            this.fTPDisconnectToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Shift+F";
            this.fTPDisconnectToolStripMenuItem.Size = new System.Drawing.Size(297, 26);
            this.fTPDisconnectToolStripMenuItem.Text = "FTP Disconnect";
            // 
            // fTPShowHiddenFilesToolStripMenuItem
            // 
            this.fTPShowHiddenFilesToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.fTPShowHiddenFilesToolStripMenuItem.Name = "fTPShowHiddenFilesToolStripMenuItem";
            this.fTPShowHiddenFilesToolStripMenuItem.Size = new System.Drawing.Size(297, 26);
            this.fTPShowHiddenFilesToolStripMenuItem.Text = "FTP Show Hidden Files";
            // 
            // fTPDownloadFromListToolStripMenuItem
            // 
            this.fTPDownloadFromListToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.fTPDownloadFromListToolStripMenuItem.Name = "fTPDownloadFromListToolStripMenuItem";
            this.fTPDownloadFromListToolStripMenuItem.Size = new System.Drawing.Size(297, 26);
            this.fTPDownloadFromListToolStripMenuItem.Text = "FTP Download From List...";
            // 
            // pORTConnectionToOtherPCToolStripMenuItem
            // 
            this.pORTConnectionToOtherPCToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pORTConnectionToOtherPCToolStripMenuItem.Name = "pORTConnectionToOtherPCToolStripMenuItem";
            this.pORTConnectionToOtherPCToolStripMenuItem.Size = new System.Drawing.Size(297, 26);
            this.pORTConnectionToOtherPCToolStripMenuItem.Text = "PORT Connection To Other PC...";
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.briefToolStripMenuItem,
            this.fullToolStripMenuItem,
            this.commentsToolStripMenuItem,
            this.customColumnsModeToolStripMenuItem,
            this.customViewModesToolStripMenuItem,
            this.treeToolStripMenuItem,
            this.separateTreeToolStripMenuItem,
            this.thumbnailViewToolStripMenuItem,
            this.quickViewPanelToolStripMenuItem,
            this.verticalArrangementToolStripMenuItem,
            this.newFolderTabToolStripMenuItem,
            this.toolStripSeparator13,
            this.allFilesToolStripMenuItem,
            this.programsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.customToolStripMenuItem,
            this.onlySelectedFilesToolStripMenuItem,
            this.toolStripSeparator12,
            this.nameToolStripMenuItem,
            this.extensionToolStripMenuItem,
            this.timeToolStripMenuItem,
            this.sizeToolStripMenuItem,
            this.unsortedToolStripMenuItem,
            this.toolStripSeparator11,
            this.reversedOrderToolStripMenuItem,
            this.rereadSourceToolStripMenuItem,
            this.toolStripSeparator10,
            this.rereadSourceToolStripMenuItem1});
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.showToolStripMenuItem.Text = "Show";
            // 
            // briefToolStripMenuItem
            // 
            this.briefToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.briefToolStripMenuItem.Name = "briefToolStripMenuItem";
            this.briefToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+F1";
            this.briefToolStripMenuItem.Size = new System.Drawing.Size(310, 26);
            this.briefToolStripMenuItem.Text = "Brief";
            // 
            // fullToolStripMenuItem
            // 
            this.fullToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.fullToolStripMenuItem.Name = "fullToolStripMenuItem";
            this.fullToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+F2";
            this.fullToolStripMenuItem.Size = new System.Drawing.Size(310, 26);
            this.fullToolStripMenuItem.Text = "Full";
            // 
            // commentsToolStripMenuItem
            // 
            this.commentsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.commentsToolStripMenuItem.Name = "commentsToolStripMenuItem";
            this.commentsToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Shift+F2";
            this.commentsToolStripMenuItem.Size = new System.Drawing.Size(310, 26);
            this.commentsToolStripMenuItem.Text = "Comments";
            // 
            // customColumnsModeToolStripMenuItem
            // 
            this.customColumnsModeToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.customColumnsModeToolStripMenuItem.Name = "customColumnsModeToolStripMenuItem";
            this.customColumnsModeToolStripMenuItem.ShortcutKeyDisplayString = "Shift+F1";
            this.customColumnsModeToolStripMenuItem.Size = new System.Drawing.Size(310, 26);
            this.customColumnsModeToolStripMenuItem.Text = "Custom Columns Mode";
            // 
            // customViewModesToolStripMenuItem
            // 
            this.customViewModesToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.customViewModesToolStripMenuItem.Name = "customViewModesToolStripMenuItem";
            this.customViewModesToolStripMenuItem.Size = new System.Drawing.Size(310, 26);
            this.customViewModesToolStripMenuItem.Text = "Custom View Modes";
            // 
            // treeToolStripMenuItem
            // 
            this.treeToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.treeToolStripMenuItem.Name = "treeToolStripMenuItem";
            this.treeToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+F8";
            this.treeToolStripMenuItem.Size = new System.Drawing.Size(310, 26);
            this.treeToolStripMenuItem.Text = "Tree";
            // 
            // separateTreeToolStripMenuItem
            // 
            this.separateTreeToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.separateTreeToolStripMenuItem.Name = "separateTreeToolStripMenuItem";
            this.separateTreeToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Shift+F8";
            this.separateTreeToolStripMenuItem.Size = new System.Drawing.Size(310, 26);
            this.separateTreeToolStripMenuItem.Text = "Separate Tree";
            // 
            // thumbnailViewToolStripMenuItem
            // 
            this.thumbnailViewToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.thumbnailViewToolStripMenuItem.Name = "thumbnailViewToolStripMenuItem";
            this.thumbnailViewToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Shift+F1";
            this.thumbnailViewToolStripMenuItem.Size = new System.Drawing.Size(310, 26);
            this.thumbnailViewToolStripMenuItem.Text = "Thumbnail View";
            // 
            // quickViewPanelToolStripMenuItem
            // 
            this.quickViewPanelToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.quickViewPanelToolStripMenuItem.Name = "quickViewPanelToolStripMenuItem";
            this.quickViewPanelToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Q";
            this.quickViewPanelToolStripMenuItem.Size = new System.Drawing.Size(310, 26);
            this.quickViewPanelToolStripMenuItem.Text = "Quick View Panel";
            // 
            // verticalArrangementToolStripMenuItem
            // 
            this.verticalArrangementToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.verticalArrangementToolStripMenuItem.Name = "verticalArrangementToolStripMenuItem";
            this.verticalArrangementToolStripMenuItem.Size = new System.Drawing.Size(310, 26);
            this.verticalArrangementToolStripMenuItem.Text = "Vertical Arrangement";
            // 
            // newFolderTabToolStripMenuItem
            // 
            this.newFolderTabToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.newFolderTabToolStripMenuItem.Name = "newFolderTabToolStripMenuItem";
            this.newFolderTabToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+T";
            this.newFolderTabToolStripMenuItem.Size = new System.Drawing.Size(310, 26);
            this.newFolderTabToolStripMenuItem.Text = "New Folder Tab";
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(307, 6);
            // 
            // allFilesToolStripMenuItem
            // 
            this.allFilesToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.allFilesToolStripMenuItem.Name = "allFilesToolStripMenuItem";
            this.allFilesToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+F10";
            this.allFilesToolStripMenuItem.Size = new System.Drawing.Size(310, 26);
            this.allFilesToolStripMenuItem.Text = "All Files";
            // 
            // programsToolStripMenuItem
            // 
            this.programsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.programsToolStripMenuItem.Name = "programsToolStripMenuItem";
            this.programsToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+F11";
            this.programsToolStripMenuItem.Size = new System.Drawing.Size(310, 26);
            this.programsToolStripMenuItem.Text = "Programs";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(310, 26);
            this.toolStripMenuItem2.Text = "*.*";
            // 
            // customToolStripMenuItem
            // 
            this.customToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.customToolStripMenuItem.Name = "customToolStripMenuItem";
            this.customToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+F12";
            this.customToolStripMenuItem.Size = new System.Drawing.Size(310, 26);
            this.customToolStripMenuItem.Text = "Custom...";
            // 
            // onlySelectedFilesToolStripMenuItem
            // 
            this.onlySelectedFilesToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.onlySelectedFilesToolStripMenuItem.Name = "onlySelectedFilesToolStripMenuItem";
            this.onlySelectedFilesToolStripMenuItem.Size = new System.Drawing.Size(310, 26);
            this.onlySelectedFilesToolStripMenuItem.Text = "Only Selected Files";
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(307, 6);
            // 
            // nameToolStripMenuItem
            // 
            this.nameToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nameToolStripMenuItem.Name = "nameToolStripMenuItem";
            this.nameToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+F3";
            this.nameToolStripMenuItem.Size = new System.Drawing.Size(310, 26);
            this.nameToolStripMenuItem.Text = "Name";
            // 
            // extensionToolStripMenuItem
            // 
            this.extensionToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.extensionToolStripMenuItem.Name = "extensionToolStripMenuItem";
            this.extensionToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+F4";
            this.extensionToolStripMenuItem.Size = new System.Drawing.Size(310, 26);
            this.extensionToolStripMenuItem.Text = "Extension";
            // 
            // timeToolStripMenuItem
            // 
            this.timeToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.timeToolStripMenuItem.Name = "timeToolStripMenuItem";
            this.timeToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+F5";
            this.timeToolStripMenuItem.Size = new System.Drawing.Size(310, 26);
            this.timeToolStripMenuItem.Text = "Time";
            // 
            // sizeToolStripMenuItem
            // 
            this.sizeToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.sizeToolStripMenuItem.Name = "sizeToolStripMenuItem";
            this.sizeToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+F6";
            this.sizeToolStripMenuItem.Size = new System.Drawing.Size(310, 26);
            this.sizeToolStripMenuItem.Text = "Size";
            // 
            // unsortedToolStripMenuItem
            // 
            this.unsortedToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.unsortedToolStripMenuItem.Name = "unsortedToolStripMenuItem";
            this.unsortedToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+F7";
            this.unsortedToolStripMenuItem.Size = new System.Drawing.Size(310, 26);
            this.unsortedToolStripMenuItem.Text = "Unsorted";
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(307, 6);
            // 
            // reversedOrderToolStripMenuItem
            // 
            this.reversedOrderToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.reversedOrderToolStripMenuItem.Name = "reversedOrderToolStripMenuItem";
            this.reversedOrderToolStripMenuItem.Size = new System.Drawing.Size(310, 26);
            this.reversedOrderToolStripMenuItem.Text = "Reversed Order";
            // 
            // rereadSourceToolStripMenuItem
            // 
            this.rereadSourceToolStripMenuItem.Name = "rereadSourceToolStripMenuItem";
            this.rereadSourceToolStripMenuItem.Size = new System.Drawing.Size(310, 26);
            this.rereadSourceToolStripMenuItem.Text = "Reread Source";
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripSeparator10.ForeColor = System.Drawing.SystemColors.Desktop;
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(307, 6);
            // 
            // rereadSourceToolStripMenuItem1
            // 
            this.rereadSourceToolStripMenuItem1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.rereadSourceToolStripMenuItem1.Name = "rereadSourceToolStripMenuItem1";
            this.rereadSourceToolStripMenuItem1.ShortcutKeyDisplayString = "Ctrl+R";
            this.rereadSourceToolStripMenuItem1.Size = new System.Drawing.Size(310, 26);
            this.rereadSourceToolStripMenuItem1.Text = "Reread Source";
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.buttonBarToolStripMenuItem,
            this.buttonBar2VerticalToolStripMenuItem,
            this.changeSettingsFilesDirectlyToolStripMenuItem,
            this.darkNormalToolStripMenuItem,
            this.savePositionToolStripMenuItem,
            this.saveSettingsToolStripMenuItem});
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.configurationToolStripMenuItem.Text = "Configuration";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(287, 26);
            this.optionsToolStripMenuItem.Text = "Options...";
            // 
            // buttonBarToolStripMenuItem
            // 
            this.buttonBarToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonBarToolStripMenuItem.Name = "buttonBarToolStripMenuItem";
            this.buttonBarToolStripMenuItem.Size = new System.Drawing.Size(287, 26);
            this.buttonBarToolStripMenuItem.Text = "Button Bar..";
            // 
            // buttonBar2VerticalToolStripMenuItem
            // 
            this.buttonBar2VerticalToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonBar2VerticalToolStripMenuItem.Name = "buttonBar2VerticalToolStripMenuItem";
            this.buttonBar2VerticalToolStripMenuItem.Size = new System.Drawing.Size(287, 26);
            this.buttonBar2VerticalToolStripMenuItem.Text = "Button Bar 2 (Vertical)...";
            // 
            // changeSettingsFilesDirectlyToolStripMenuItem
            // 
            this.changeSettingsFilesDirectlyToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.changeSettingsFilesDirectlyToolStripMenuItem.Name = "changeSettingsFilesDirectlyToolStripMenuItem";
            this.changeSettingsFilesDirectlyToolStripMenuItem.Size = new System.Drawing.Size(287, 26);
            this.changeSettingsFilesDirectlyToolStripMenuItem.Text = "Change Settings Files Directly";
            // 
            // darkNormalToolStripMenuItem
            // 
            this.darkNormalToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.darkNormalToolStripMenuItem.Name = "darkNormalToolStripMenuItem";
            this.darkNormalToolStripMenuItem.Size = new System.Drawing.Size(287, 26);
            this.darkNormalToolStripMenuItem.Text = "Dark<->Normal";
            // 
            // savePositionToolStripMenuItem
            // 
            this.savePositionToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.savePositionToolStripMenuItem.Name = "savePositionToolStripMenuItem";
            this.savePositionToolStripMenuItem.Size = new System.Drawing.Size(287, 26);
            this.savePositionToolStripMenuItem.Text = "Save Position";
            // 
            // saveSettingsToolStripMenuItem
            // 
            this.saveSettingsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.saveSettingsToolStripMenuItem.Name = "saveSettingsToolStripMenuItem";
            this.saveSettingsToolStripMenuItem.Size = new System.Drawing.Size(287, 26);
            this.saveSettingsToolStripMenuItem.Text = "Save Settings";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeStartMenuToolStripMenuItem,
            this.changeMainMenuToolStripMenuItem});
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.startToolStripMenuItem.Text = "Start";
            // 
            // changeStartMenuToolStripMenuItem
            // 
            this.changeStartMenuToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.changeStartMenuToolStripMenuItem.Name = "changeStartMenuToolStripMenuItem";
            this.changeStartMenuToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.changeStartMenuToolStripMenuItem.Text = "Change Start Menu...";
            // 
            // changeMainMenuToolStripMenuItem
            // 
            this.changeMainMenuToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.changeMainMenuToolStripMenuItem.Name = "changeMainMenuToolStripMenuItem";
            this.changeMainMenuToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.changeMainMenuToolStripMenuItem.Text = "Change Main Menu...";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.helpToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.indexToolStripMenuItem,
            this.keyboardToolStripMenuItem,
            this.registrationInfoToolStripMenuItem,
            this.visitToolStripMenuItem,
            this.toolStripSeparator14,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.indexToolStripMenuItem.Text = "Index";
            // 
            // keyboardToolStripMenuItem
            // 
            this.keyboardToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.keyboardToolStripMenuItem.Name = "keyboardToolStripMenuItem";
            this.keyboardToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.keyboardToolStripMenuItem.Text = "Keyboard";
            // 
            // registrationInfoToolStripMenuItem
            // 
            this.registrationInfoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.registrationInfoToolStripMenuItem.Name = "registrationInfoToolStripMenuItem";
            this.registrationInfoToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.registrationInfoToolStripMenuItem.Text = "Registration Info";
            // 
            // visitToolStripMenuItem
            // 
            this.visitToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.visitToolStripMenuItem.Name = "visitToolStripMenuItem";
            this.visitToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.visitToolStripMenuItem.Text = "Visit Totalcmd\'s Website";
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(249, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.aboutToolStripMenuItem.Text = "About Form1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 812);
            this.Controls.Add(this.Container_panel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ShortcutGB.ResumeLayout(false);
            this.Container_panel.ResumeLayout(false);
            this.Container_panel.PerformLayout();
            this.MiddlepartTableLayoutPanel.ResumeLayout(false);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.RightPanel.ResumeLayout(false);
            this.RightPanel.PerformLayout();
            this.Directory_Table_layout_Panel.ResumeLayout(false);
            this.Directory_Table_layout_Panel.PerformLayout();
            this.Bottom_Button_Table_layout_panel.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
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
        private System.Windows.Forms.Button F7Button;
        private System.Windows.Forms.Button F8Button;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button F6Button;
        private System.Windows.Forms.Button F4Button;
        private System.Windows.Forms.Button MakeDirB;
        private System.Windows.Forms.Button RenameMoveB;
        private System.Windows.Forms.Button PackFileB;
        private System.Windows.Forms.Button CopyB;
        private System.Windows.Forms.Button EditB;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Button DetailFileB;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ToolStripMenuItem markToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changesAttributesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem packToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unpackSpecificFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testArchivesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compareByContentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem associateWithToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internetAssociationsTotalCommanderOnlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem calculateOccupiedSpaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiRenameToolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCommentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem splitFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem combineFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encodeFileMIMEUUEXXEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decodeFileMIMEUUEXXEBinHexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createChecksumFilesCRC32MD5SHA1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verifyChecksumsfromChecksumFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem netToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unselectGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unselectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invertSelectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllWithSameExtensionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem saveSelectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreSelectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSelectionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loadSelectionFromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem copySelecToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyNamesWithPathToClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToClipboardWithAllDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToClipboardWithPathDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem compareDirectoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markNewerHideSameFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchInSeperateProcessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volumeLabelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem synchronizeDirsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directoryHotlistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goBackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openCommandPromptWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem branchViewWithSubdirsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDesktopFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundTransferManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cDTreeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem targetSourceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem networkConnectionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectNetworkDrivesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shareCurrentDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAdminSharesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem fTPConnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fTPNewConnectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fTPDisconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fTPShowHiddenFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fTPDownloadFromListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pORTConnectionToOtherPCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem briefToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customColumnsModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customViewModesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem treeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem separateTreeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thumbnailViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quickViewPanelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalArrangementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFolderTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem customToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onlySelectedFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extensionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unsortedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reversedOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rereadSourceToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem rereadSourceToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buttonBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buttonBar2VerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeSettingsFilesDirectlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkNormalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePositionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeStartMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeMainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keyboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrationInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel MiddlepartTableLayoutPanel;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}

