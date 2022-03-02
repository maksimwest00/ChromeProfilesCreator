namespace ChromeProfilesCreator
{
    partial class frmMain
    {

        private System.ComponentModel.IContainer components = null;
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ExitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Importer = new System.Windows.Forms.OpenFileDialog();
            this.Browsec = new System.Windows.Forms.FolderBrowserDialog();
            this.MainBox = new System.Windows.Forms.GroupBox();
            this.CounterExistProfiles = new System.Windows.Forms.Label();
            this.AppDataTextBox = new System.Windows.Forms.TextBox();
            this.PathToAppDataLabel = new System.Windows.Forms.Label();
            this.CreateChromeProfilebtn = new System.Windows.Forms.Button();
            this.SaveAllbtn = new System.Windows.Forms.Button();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.CloseAllChromeProcessesBtn = new System.Windows.Forms.Button();
            this.LaunchWithUrlLabel = new System.Windows.Forms.Label();
            this.StartChromeWithUrlTextBox = new System.Windows.Forms.TextBox();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.ExportFileNameTextBox = new System.Windows.Forms.TextBox();
            this.ImportProfilesBtn = new System.Windows.Forms.Button();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.MainBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            resources.ApplyResources(this.notifyIcon1, "notifyIcon1");
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // ExitToolStripMenuItem1
            // 
            this.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1";
            resources.ApplyResources(this.ExitToolStripMenuItem1, "ExitToolStripMenuItem1");
            this.ExitToolStripMenuItem1.Click += new System.EventHandler(this.ExitToolStripMenuItem1_Click);
            // 
            // Importer
            // 
            resources.ApplyResources(this.Importer, "Importer");
            // 
            // Browsec
            // 
            resources.ApplyResources(this.Browsec, "Browsec");
            // 
            // MainBox
            // 
            this.MainBox.Controls.Add(this.CounterExistProfiles);
            this.MainBox.Controls.Add(this.AppDataTextBox);
            this.MainBox.Controls.Add(this.PathToAppDataLabel);
            this.MainBox.Controls.Add(this.CreateChromeProfilebtn);
            this.MainBox.Controls.Add(this.SaveAllbtn);
            this.MainBox.Controls.Add(this.AmountTextBox);
            this.MainBox.Controls.Add(this.CloseAllChromeProcessesBtn);
            this.MainBox.Controls.Add(this.LaunchWithUrlLabel);
            this.MainBox.Controls.Add(this.StartChromeWithUrlTextBox);
            this.MainBox.Controls.Add(this.FileNameLabel);
            this.MainBox.Controls.Add(this.ExportFileNameTextBox);
            this.MainBox.Controls.Add(this.ImportProfilesBtn);
            this.MainBox.Controls.Add(this.AmountLabel);
            resources.ApplyResources(this.MainBox, "MainBox");
            this.MainBox.Name = "MainBox";
            this.MainBox.TabStop = false;
            // 
            // CounterExistProfiles
            // 
            resources.ApplyResources(this.CounterExistProfiles, "CounterExistProfiles");
            this.CounterExistProfiles.Name = "CounterExistProfiles";
            // 
            // AppDataTextBox
            // 
            resources.ApplyResources(this.AppDataTextBox, "AppDataTextBox");
            this.AppDataTextBox.Name = "AppDataTextBox";
            // 
            // PathToAppDataLabel
            // 
            resources.ApplyResources(this.PathToAppDataLabel, "PathToAppDataLabel");
            this.PathToAppDataLabel.Name = "PathToAppDataLabel";
            // 
            // CreateChromeProfilebtn
            // 
            resources.ApplyResources(this.CreateChromeProfilebtn, "CreateChromeProfilebtn");
            this.CreateChromeProfilebtn.Name = "CreateChromeProfilebtn";
            this.CreateChromeProfilebtn.UseVisualStyleBackColor = true;
            this.CreateChromeProfilebtn.Click += new System.EventHandler(this.CreateChromeProfilebtn_Click);
            // 
            // SaveAllbtn
            // 
            resources.ApplyResources(this.SaveAllbtn, "SaveAllbtn");
            this.SaveAllbtn.Name = "SaveAllbtn";
            this.SaveAllbtn.UseVisualStyleBackColor = true;
            this.SaveAllbtn.Click += new System.EventHandler(this.SaveAll_btn);
            // 
            // AmountTextBox
            // 
            resources.ApplyResources(this.AmountTextBox, "AmountTextBox");
            this.AmountTextBox.Name = "AmountTextBox";
            // 
            // CloseAllChromeProcessesBtn
            // 
            resources.ApplyResources(this.CloseAllChromeProcessesBtn, "CloseAllChromeProcessesBtn");
            this.CloseAllChromeProcessesBtn.Name = "CloseAllChromeProcessesBtn";
            this.CloseAllChromeProcessesBtn.UseVisualStyleBackColor = true;
            this.CloseAllChromeProcessesBtn.Click += new System.EventHandler(this.CloseAllChromeProcessesBtn_Click);
            // 
            // LaunchWithUrlLabel
            // 
            resources.ApplyResources(this.LaunchWithUrlLabel, "LaunchWithUrlLabel");
            this.LaunchWithUrlLabel.Name = "LaunchWithUrlLabel";
            // 
            // StartChromeWithUrlTextBox
            // 
            resources.ApplyResources(this.StartChromeWithUrlTextBox, "StartChromeWithUrlTextBox");
            this.StartChromeWithUrlTextBox.Name = "StartChromeWithUrlTextBox";
            // 
            // FileNameLabel
            // 
            resources.ApplyResources(this.FileNameLabel, "FileNameLabel");
            this.FileNameLabel.Name = "FileNameLabel";
            // 
            // ExportFileNameTextBox
            // 
            resources.ApplyResources(this.ExportFileNameTextBox, "ExportFileNameTextBox");
            this.ExportFileNameTextBox.Name = "ExportFileNameTextBox";
            // 
            // ImportProfilesBtn
            // 
            resources.ApplyResources(this.ImportProfilesBtn, "ImportProfilesBtn");
            this.ImportProfilesBtn.Name = "ImportProfilesBtn";
            this.ImportProfilesBtn.UseVisualStyleBackColor = true;
            this.ImportProfilesBtn.Click += new System.EventHandler(this.ImportProfilesBtn_Click);
            // 
            // AmountLabel
            // 
            resources.ApplyResources(this.AmountLabel, "AmountLabel");
            this.AmountLabel.Name = "AmountLabel";
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.MainBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.SizeChanged += new System.EventHandler(this.frmMain_SizeChanged);
            this.contextMenuStrip1.ResumeLayout(false);
            this.MainBox.ResumeLayout(false);
            this.MainBox.PerformLayout();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.OpenFileDialog Importer;
        private System.Windows.Forms.FolderBrowserDialog Browsec;
        private System.Windows.Forms.GroupBox MainBox;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.Button CloseAllChromeProcessesBtn;
        private System.Windows.Forms.Label LaunchWithUrlLabel;
        private System.Windows.Forms.TextBox StartChromeWithUrlTextBox;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.TextBox ExportFileNameTextBox;
        private System.Windows.Forms.Button ImportProfilesBtn;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Button SaveAllbtn;
        //private System.Windows.Forms.Button CreateChromeProfilebtn0;
        private System.Windows.Forms.Label CounterExistProfiles;
        private System.Windows.Forms.Button CreateChromeProfilebtn;
        private System.Windows.Forms.TextBox AppDataTextBox;
        private System.Windows.Forms.Label PathToAppDataLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem1;
    }
}

