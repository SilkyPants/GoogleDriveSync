using System;
using System.ComponentModel;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;

using Newtonsoft.Json;

namespace GoogleDriveSync
{
    public partial class frmMain : Form
    {
        Settings m_Settings = new Settings();

        bool m_IsMonitoringFolders = false;
        bool IsMonitoringFolders
        {
            get { return m_IsMonitoringFolders; }
            set
            {
                m_IsMonitoringFolders = value;
                grpMonitoredFolders.Enabled = !value;

                if (m_IsMonitoringFolders)
                {
                    StartMonitoring();
                }
                else
                {
                    StopMonitoring();
                }
            }
        }

        public frmMain()
        {
            InitializeComponent();
        }
        
        private void OnAddFolder_Click(object sender, EventArgs e)
        {
            fbdAddFolderDialog.Description = "Select Source Folder";
            fbdAddFolderDialog.ShowNewFolderButton = false;

            if (fbdAddFolderDialog.ShowDialog() == DialogResult.OK)
            {
                string sourceDir = fbdAddFolderDialog.SelectedPath;

                fbdAddFolderDialog.Description = "Select Destination Folder";
                fbdAddFolderDialog.ShowNewFolderButton = true;

                if (fbdAddFolderDialog.ShowDialog() == DialogResult.OK)
                {
                    string destDir = fbdAddFolderDialog.SelectedPath;

                    CheckAndAddForMonitoring(sourceDir, destDir);
                }
            }
        }

        void CheckAndAddForMonitoring(string source, string dest)
        {
            // Validate by:
            // Check that Dest does not exist under source
            // Check that source does not exist under Dest?
            // Check folder pair does not already exist in list

            var newFolderPair = new MonitoredFolder()
            {
                SourceFolder = source,
                DestinationFolder = dest,
                IsMonitored = true
            };

            newFolderPair.SetupWatcher(Watcher_OnChange, Watcher_Renamed);

            m_Settings.MonitoredFolders.Add(newFolderPair);

            UpdateListView();
        }

        void UpdateListView()
        {
            lsvFolders.Items.Clear();

            foreach (var pair in m_Settings.MonitoredFolders)
            {
                var item = new ListViewItem(pair.SourceFolder);
                item.SubItems.Add(pair.DestinationFolder);
                item.Checked = pair.IsMonitored;

                lsvFolders.Items.Add(item);
            }
        }

        private void btnToggleMonitoring_Click(object sender, EventArgs e)
        {
            IsMonitoringFolders = !IsMonitoringFolders;
        }

        void StartMonitoring()
        {
            foreach(var pair in m_Settings.MonitoredFolders)
            {
                if (!pair.IsMonitored) return;

                //Start monitoring.
                pair.Watcher.EnableRaisingEvents = true;
            }
        }

        void StopMonitoring()
        {
            foreach (var pair in m_Settings.MonitoredFolders)
            {
                //Start monitoring.
                pair.Watcher.EnableRaisingEvents = false;
            }
        }

        private void Watcher_Renamed(object sender, RenamedEventArgs e)
        {
            if (sender is FileSystemWatcher)
            {
                var watcher = sender as FileSystemWatcher;

                foreach (var pair in m_Settings.MonitoredFolders)
                {
                    var oldPath = e.OldFullPath.Replace(pair.SourceFolder, pair.DestinationFolder);
                    var newPath = e.FullPath.Replace(pair.SourceFolder, pair.DestinationFolder);

                    if (File.GetAttributes(oldPath).HasFlag(FileAttributes.Directory))
                    {
                        Directory.Move(oldPath, newPath);
                    }
                    else
                    {
                        File.Move(oldPath, newPath);
                    }
                }
            }
        }

        private void Watcher_OnChange(object sender, FileSystemEventArgs e)
        {
            if (sender is FileSystemWatcher)
            {
                var watcher = sender as FileSystemWatcher;

                foreach (var pair in m_Settings.MonitoredFolders)
                {
                    if (watcher != pair.Watcher) continue;

                    // Specify what is done when a file is changed.
                    WriteLine("{0}, with path {1} has been {2}{3}", e.Name, e.FullPath, e.ChangeType, Environment.NewLine);

                    Copy(pair.SourceFolder, pair.DestinationFolder);
                }
            }
        }

        public void WriteLine(string format, params object[] args)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action(() => WriteLine(format, args)));
                return;
            }

            txtLog.Text += string.Format(format, args) + Environment.NewLine;
        }

        public void Copy(string sourceDirectory, string targetDirectory)
        {
            DirectoryInfo diSource = new DirectoryInfo(sourceDirectory);
            DirectoryInfo diTarget = new DirectoryInfo(targetDirectory);

            CopyAll(diSource, diTarget);
        }

        public void CopyAll(DirectoryInfo source, DirectoryInfo target)
        {
            Directory.CreateDirectory(target.FullName);

            // Copy each file into the new directory.
            foreach (FileInfo fi in source.GetFiles())
            {
                WriteLine(@"Copying {0}\{1}", target.FullName, fi.Name);
                fi.CopyTo(Path.Combine(target.FullName, fi.Name), true);
            }

            // Copy each subdirectory using recursion.
            foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir =
                    target.CreateSubdirectory(diSourceSubDir.Name);
                CopyAll(diSourceSubDir, nextTargetSubDir);
            }
        }

        private void OpenSettings(object sender, EventArgs e)
        {
            this.Visible = true;
            this.ShowInTaskbar = true;
        }

        void CloseSettings()
        {
            this.Visible = false;
            this.ShowInTaskbar = false;

            SaveSettings();
        }

        void LoadSettings()
        {
            if (File.Exists("settings.json"))
            {
                var json = File.ReadAllText("settings.json");
                m_Settings = JsonConvert.DeserializeObject<Settings>(json);
                m_Settings.SetupWatchers(Watcher_OnChange, Watcher_Renamed);

                UpdateListView();
            }
        }

        void SaveSettings()
        {
            var json = JsonConvert.SerializeObject(m_Settings);
            File.WriteAllText("settings.json", json);
        }

        private void QuitApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SettingsFormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                CloseSettings();
            }
        }

        private void SettingsFormLoaded(object sender, EventArgs e)
        {
            LoadSettings();
        }
    }

    [Serializable]
    class Settings
    {
        public bool StartMonitorOnLoad { get; set; } = false;
        public List<MonitoredFolder> MonitoredFolders { get; private set; } = new List<MonitoredFolder>();

        public void SetupWatchers(FileSystemEventHandler onChanged, RenamedEventHandler onRenamed)
        {
            foreach (var pair in MonitoredFolders)
            {
                pair.SetupWatcher(onChanged, onRenamed);
            }
        }
    }

    [Serializable]
    [JsonObject(MemberSerialization.OptIn)]
    class MonitoredFolder
    {
        [JsonProperty] public string SourceFolder { get; set; }
        [JsonProperty] public string DestinationFolder { get; set; }
        [JsonProperty]
        public bool IsMonitored { get; set; } = true;
        [JsonProperty]
        public bool TwoWaySync { get; set; } = false;

        public FileSystemWatcher Watcher { get; private set; }
        
        public void SetupWatcher(FileSystemEventHandler onChanged, RenamedEventHandler onRenamed)
        {
            Watcher = new FileSystemWatcher(this.SourceFolder, "*.*");

            // Watch both files and subdirectories.
            Watcher.IncludeSubdirectories = true;

            // Watch for all changes specified in the NotifyFilters
            //enumeration.
            Watcher.NotifyFilter =
            NotifyFilters.CreationTime |
            NotifyFilters.DirectoryName |
            NotifyFilters.FileName |
            NotifyFilters.LastWrite |
            NotifyFilters.Size;

            // Watch all files.
            Watcher.Filter = "*.*";

            // Add event handlers.
            Watcher.Created += onChanged;
            Watcher.Changed += onChanged;
            Watcher.Deleted += onChanged;
            Watcher.Renamed += onRenamed;
        }
    }
}
