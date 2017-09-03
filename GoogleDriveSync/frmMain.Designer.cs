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
            this.dgvFolders = new System.Windows.Forms.DataGridView();
            this.isMonitored = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TwoWaySync = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SourceFolder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DestFolder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpMonitoredFolders.SuspendLayout();
            this.cmsTrayMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFolders)).BeginInit();
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
            this.grpMonitoredFolders.Controls.Add(this.dgvFolders);
            this.grpMonitoredFolders.Controls.Add(this.btnAddFolder);
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
            // dgvFolders
            // 
            this.dgvFolders.AllowUserToAddRows = false;
            this.dgvFolders.AllowUserToDeleteRows = false;
            this.dgvFolders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dgvFolders.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvFolders.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvFolders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvFolders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFolders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isMonitored,
            this.TwoWaySync,
            this.SourceFolder,
            this.DestFolder});
            this.dgvFolders.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvFolders.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvFolders.Location = new System.Drawing.Point(3, 56);
            this.dgvFolders.MultiSelect = false;
            this.dgvFolders.Name = "dgvFolders";
            this.dgvFolders.RowHeadersVisible = false;
            this.dgvFolders.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvFolders.RowTemplate.Height = 24;
            this.dgvFolders.Size = new System.Drawing.Size(624, 238);
            this.dgvFolders.TabIndex = 3;
            // 
            // isMonitored
            // 
            this.isMonitored.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.isMonitored.DataPropertyName = "IsMonitored";
            this.isMonitored.HeaderText = "Monitor";
            this.isMonitored.Name = "isMonitored";
            this.isMonitored.ToolTipText = "Is folder pair monitored for changes";
            this.isMonitored.Width = 61;
            // 
            // TwoWaySync
            // 
            this.TwoWaySync.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TwoWaySync.DataPropertyName = "TwoWaySync";
            this.TwoWaySync.HeaderText = "2 Way";
            this.TwoWaySync.Name = "TwoWaySync";
            this.TwoWaySync.ToolTipText = "Enable 2 way folder sync";
            this.TwoWaySync.Width = 54;
            // 
            // SourceFolder
            // 
            this.SourceFolder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SourceFolder.DataPropertyName = "SourceFolder";
            this.SourceFolder.HeaderText = "Source Directory";
            this.SourceFolder.Name = "SourceFolder";
            // 
            // DestFolder
            // 
            this.DestFolder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DestFolder.DataPropertyName = "DestinationFolder";
            this.DestFolder.HeaderText = "Destination Directory";
            this.DestFolder.Name = "DestFolder";
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvFolders)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvFolders;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isMonitored;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TwoWaySync;
        private System.Windows.Forms.DataGridViewTextBoxColumn SourceFolder;
        private System.Windows.Forms.DataGridViewTextBoxColumn DestFolder;
    }
}

