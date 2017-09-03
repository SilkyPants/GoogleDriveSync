namespace GoogleDriveSync
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnToggleMonitoring = new System.Windows.Forms.Button();
            this.btnAddFolder = new System.Windows.Forms.Button();
            this.fbdAddFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.grpMonitoredFolders = new System.Windows.Forms.GroupBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.nfiTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsTrayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clhSourceDirectory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhDestination = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhTwoWay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvFolders = new System.Windows.Forms.ListView();
            this.grpMonitoredFolders.SuspendLayout();
            this.cmsTrayMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnToggleMonitoring
            // 
            this.btnToggleMonitoring.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToggleMonitoring.Location = new System.Drawing.Point(511, 12);
            this.btnToggleMonitoring.Name = "btnToggleMonitoring";
            this.btnToggleMonitoring.Size = new System.Drawing.Size(131, 34);
            this.btnToggleMonitoring.TabIndex = 0;
            this.btnToggleMonitoring.Text = "Start Monitoring";
            this.btnToggleMonitoring.UseVisualStyleBackColor = true;
            this.btnToggleMonitoring.Click += new System.EventHandler(this.btnToggleMonitoring_Click);
            // 
            // btnAddFolder
            // 
            this.btnAddFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddFolder.Location = new System.Drawing.Point(493, 21);
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.Size = new System.Drawing.Size(131, 29);
            this.btnAddFolder.TabIndex = 2;
            this.btnAddFolder.Text = "Add Folder";
            this.btnAddFolder.UseVisualStyleBackColor = true;
            this.btnAddFolder.Click += new System.EventHandler(this.OnAddFolder_Click);
            // 
            // fbdAddFolderDialog
            // 
            this.fbdAddFolderDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.fbdAddFolderDialog.ShowNewFolderButton = false;
            // 
            // grpMonitoredFolders
            // 
            this.grpMonitoredFolders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMonitoredFolders.Controls.Add(this.btnAddFolder);
            this.grpMonitoredFolders.Controls.Add(this.lsvFolders);
            this.grpMonitoredFolders.Location = new System.Drawing.Point(12, 52);
            this.grpMonitoredFolders.Name = "grpMonitoredFolders";
            this.grpMonitoredFolders.Size = new System.Drawing.Size(630, 297);
            this.grpMonitoredFolders.TabIndex = 3;
            this.grpMonitoredFolders.TabStop = false;
            this.grpMonitoredFolders.Text = "Monitored Folders";
            // 
            // txtLog
            // 
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtLog.Enabled = false;
            this.txtLog.Location = new System.Drawing.Point(0, 352);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(654, 191);
            this.txtLog.TabIndex = 4;
            // 
            // nfiTrayIcon
            // 
            this.nfiTrayIcon.ContextMenuStrip = this.cmsTrayMenu;
            this.nfiTrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("nfiTrayIcon.Icon")));
            this.nfiTrayIcon.Text = "Google Drive Sync";
            this.nfiTrayIcon.Visible = true;
            this.nfiTrayIcon.DoubleClick += new System.EventHandler(this.OpenSettings);
            // 
            // cmsTrayMenu
            // 
            this.cmsTrayMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsTrayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.quitToolStripMenuItem});
            this.cmsTrayMenu.Name = "cmsTrayMenu";
            this.cmsTrayMenu.Size = new System.Drawing.Size(147, 62);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.settingsToolStripMenuItem.Text = "Settings...";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.OpenSettings);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(143, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.QuitApplication);
            // 
            // clhSourceDirectory
            // 
            this.clhSourceDirectory.Text = "Source";
            this.clhSourceDirectory.Width = 272;
            // 
            // clhDestination
            // 
            this.clhDestination.Text = "Destination";
            this.clhDestination.Width = 265;
            // 
            // clhTwoWay
            // 
            this.clhTwoWay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lsvFolders
            // 
            this.lsvFolders.CheckBoxes = true;
            this.lsvFolders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhSourceDirectory,
            this.clhDestination,
            this.clhTwoWay});
            this.lsvFolders.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lsvFolders.Location = new System.Drawing.Point(3, 56);
            this.lsvFolders.Name = "lsvFolders";
            this.lsvFolders.Size = new System.Drawing.Size(624, 238);
            this.lsvFolders.TabIndex = 1;
            this.lsvFolders.UseCompatibleStateImageBehavior = false;
            this.lsvFolders.View = System.Windows.Forms.View.Details;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 543);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.grpMonitoredFolders);
            this.Controls.Add(this.btnToggleMonitoring);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Google Drive Sync";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsFormClosing);
            this.Load += new System.EventHandler(this.SettingsFormLoaded);
            this.grpMonitoredFolders.ResumeLayout(false);
            this.cmsTrayMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnToggleMonitoring;
        private System.Windows.Forms.Button btnAddFolder;
        private System.Windows.Forms.FolderBrowserDialog fbdAddFolderDialog;
        private System.Windows.Forms.GroupBox grpMonitoredFolders;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.NotifyIcon nfiTrayIcon;
        private System.Windows.Forms.ContextMenuStrip cmsTrayMenu;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ListView lsvFolders;
        private System.Windows.Forms.ColumnHeader clhSourceDirectory;
        private System.Windows.Forms.ColumnHeader clhDestination;
        private System.Windows.Forms.ColumnHeader clhTwoWay;
    }
}

