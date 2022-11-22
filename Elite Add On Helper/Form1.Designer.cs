using Elite_Add_On_Helper.Properties;

namespace Elite_Add_On_Helper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.cb_edengineer = new System.Windows.Forms.CheckBox();
            this.cb_EDMarketConnector = new System.Windows.Forms.CheckBox();
            this.cb_voiceattack = new System.Windows.Forms.CheckBox();
            this.cb_EDDiscovery = new System.Windows.Forms.CheckBox();
            this.cb_edomhl = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePrefsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_warthog = new System.Windows.Forms.CheckBox();
            this.btn_edengineer_path = new System.Windows.Forms.Button();
            this.tb_edengineer = new System.Windows.Forms.TextBox();
            this.tb_edmc = new System.Windows.Forms.TextBox();
            this.btn_edmc_path = new System.Windows.Forms.Button();
            this.tb_voiceattack = new System.Windows.Forms.TextBox();
            this.btn_voiceattack_path = new System.Windows.Forms.Button();
            this.tb_eddisco = new System.Windows.Forms.TextBox();
            this.btn_eddiscovery_path = new System.Windows.Forms.Button();
            this.tb_edomhl = new System.Windows.Forms.TextBox();
            this.btn_edomhl_path = new System.Windows.Forms.Button();
            this.tb_warthog = new System.Windows.Forms.TextBox();
            this.btn_warthog_path = new System.Windows.Forms.Button();
            this.btn_install_EdEngineer = new System.Windows.Forms.Button();
            this.btn_install_edmc = new System.Windows.Forms.Button();
            this.btn_install_EDDiscovery = new System.Windows.Forms.Button();
            this.btn_install_edomhl = new System.Windows.Forms.Button();
            this.cb_edlaunch = new System.Windows.Forms.CheckBox();
            this.btn_edlaunch = new System.Windows.Forms.Button();
            this.tb_edlaunch_path = new System.Windows.Forms.TextBox();
            this.btn_launch_nonvr = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tb_warthogscriptpath = new System.Windows.Forms.TextBox();
            this.btn_warthogscriptpath = new System.Windows.Forms.Button();
            this.cb_warthogscriptdir = new System.Windows.Forms.CheckBox();
            this.btn_autodetect = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.nonvr_profile = new System.Windows.Forms.TabPage();
            this.VR_Profile = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.nonvr_profile.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(3, -87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(568, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Elite Dangerous Add On Helper";
            // 
            // cb_edengineer
            // 
            this.cb_edengineer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_edengineer.AutoSize = true;
            this.cb_edengineer.Location = new System.Drawing.Point(6, 35);
            this.cb_edengineer.Name = "cb_edengineer";
            this.cb_edengineer.Size = new System.Drawing.Size(103, 20);
            this.cb_edengineer.TabIndex = 2;
            this.cb_edengineer.Text = "Ed Engineer";
            this.cb_edengineer.UseVisualStyleBackColor = true;
            // 
            // cb_EDMarketConnector
            // 
            this.cb_EDMarketConnector.AutoSize = true;
            this.cb_EDMarketConnector.Location = new System.Drawing.Point(6, 61);
            this.cb_EDMarketConnector.Name = "cb_EDMarketConnector";
            this.cb_EDMarketConnector.Size = new System.Drawing.Size(156, 20);
            this.cb_EDMarketConnector.TabIndex = 3;
            this.cb_EDMarketConnector.Text = "ED Market Connector";
            this.cb_EDMarketConnector.UseVisualStyleBackColor = true;
            // 
            // cb_voiceattack
            // 
            this.cb_voiceattack.AutoSize = true;
            this.cb_voiceattack.Location = new System.Drawing.Point(6, 87);
            this.cb_voiceattack.Name = "cb_voiceattack";
            this.cb_voiceattack.Size = new System.Drawing.Size(104, 20);
            this.cb_voiceattack.TabIndex = 4;
            this.cb_voiceattack.Text = "Voice Attack";
            this.cb_voiceattack.UseVisualStyleBackColor = true;
            // 
            // cb_EDDiscovery
            // 
            this.cb_EDDiscovery.AutoSize = true;
            this.cb_EDDiscovery.Location = new System.Drawing.Point(6, 113);
            this.cb_EDDiscovery.Name = "cb_EDDiscovery";
            this.cb_EDDiscovery.Size = new System.Drawing.Size(112, 20);
            this.cb_EDDiscovery.TabIndex = 5;
            this.cb_EDDiscovery.Text = "ED Discovery";
            this.cb_EDDiscovery.UseVisualStyleBackColor = true;
            // 
            // cb_edomhl
            // 
            this.cb_edomhl.AutoSize = true;
            this.cb_edomhl.Location = new System.Drawing.Point(6, 139);
            this.cb_edomhl.Name = "cb_edomhl";
            this.cb_edomhl.Size = new System.Drawing.Size(342, 20);
            this.cb_edomhl.TabIndex = 6;
            this.cb_edomhl.Text = "Elite Dangerous Odyssey Materials Helper Launcher";
            this.cb_edomhl.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(948, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.savePrefsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // savePrefsToolStripMenuItem
            // 
            this.savePrefsToolStripMenuItem.Name = "savePrefsToolStripMenuItem";
            this.savePrefsToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.savePrefsToolStripMenuItem.Text = "Save Prefs";
            this.savePrefsToolStripMenuItem.Click += new System.EventHandler(this.SavePrefsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Launch at start?";
            // 
            // cb_warthog
            // 
            this.cb_warthog.AutoSize = true;
            this.cb_warthog.Location = new System.Drawing.Point(6, 165);
            this.cb_warthog.Name = "cb_warthog";
            this.cb_warthog.Size = new System.Drawing.Size(305, 20);
            this.cb_warthog.TabIndex = 10;
            this.cb_warthog.Text = "AussieDroid Warthog Script (Path to TARGET)";
            this.cb_warthog.UseVisualStyleBackColor = true;
            // 
            // btn_edengineer_path
            // 
            this.btn_edengineer_path.Location = new System.Drawing.Point(386, 32);
            this.btn_edengineer_path.Name = "btn_edengineer_path";
            this.btn_edengineer_path.Size = new System.Drawing.Size(111, 24);
            this.btn_edengineer_path.TabIndex = 11;
            this.btn_edengineer_path.Text = "Select Path..";
            this.btn_edengineer_path.UseVisualStyleBackColor = true;
            this.btn_edengineer_path.Click += new System.EventHandler(this.Btn_edengineer_path_Click);
            // 
            // tb_edengineer
            // 
            this.tb_edengineer.Location = new System.Drawing.Point(512, 34);
            this.tb_edengineer.Name = "tb_edengineer";
            this.tb_edengineer.Size = new System.Drawing.Size(307, 22);
            this.tb_edengineer.TabIndex = 12;
            // 
            // tb_edmc
            // 
            this.tb_edmc.Location = new System.Drawing.Point(512, 61);
            this.tb_edmc.Name = "tb_edmc";
            this.tb_edmc.Size = new System.Drawing.Size(307, 22);
            this.tb_edmc.TabIndex = 14;
            // 
            // btn_edmc_path
            // 
            this.btn_edmc_path.Location = new System.Drawing.Point(386, 61);
            this.btn_edmc_path.Name = "btn_edmc_path";
            this.btn_edmc_path.Size = new System.Drawing.Size(111, 23);
            this.btn_edmc_path.TabIndex = 13;
            this.btn_edmc_path.Text = "Select Path..";
            this.btn_edmc_path.UseVisualStyleBackColor = true;
            this.btn_edmc_path.Click += new System.EventHandler(this.Btn_edmc_path_Click);
            // 
            // tb_voiceattack
            // 
            this.tb_voiceattack.Location = new System.Drawing.Point(512, 87);
            this.tb_voiceattack.Name = "tb_voiceattack";
            this.tb_voiceattack.Size = new System.Drawing.Size(307, 22);
            this.tb_voiceattack.TabIndex = 16;
            // 
            // btn_voiceattack_path
            // 
            this.btn_voiceattack_path.Location = new System.Drawing.Point(386, 87);
            this.btn_voiceattack_path.Name = "btn_voiceattack_path";
            this.btn_voiceattack_path.Size = new System.Drawing.Size(111, 23);
            this.btn_voiceattack_path.TabIndex = 15;
            this.btn_voiceattack_path.Text = "Select Path..";
            this.btn_voiceattack_path.UseVisualStyleBackColor = true;
            this.btn_voiceattack_path.Click += new System.EventHandler(this.Btn_voiceattack_path_Click);
            // 
            // tb_eddisco
            // 
            this.tb_eddisco.Location = new System.Drawing.Point(512, 113);
            this.tb_eddisco.Name = "tb_eddisco";
            this.tb_eddisco.Size = new System.Drawing.Size(307, 22);
            this.tb_eddisco.TabIndex = 18;
            // 
            // btn_eddiscovery_path
            // 
            this.btn_eddiscovery_path.Location = new System.Drawing.Point(386, 113);
            this.btn_eddiscovery_path.Name = "btn_eddiscovery_path";
            this.btn_eddiscovery_path.Size = new System.Drawing.Size(111, 23);
            this.btn_eddiscovery_path.TabIndex = 17;
            this.btn_eddiscovery_path.Text = "Select Path..";
            this.btn_eddiscovery_path.UseVisualStyleBackColor = true;
            this.btn_eddiscovery_path.Click += new System.EventHandler(this.Btn_eddiscovery_path_Click);
            // 
            // tb_edomhl
            // 
            this.tb_edomhl.Location = new System.Drawing.Point(512, 139);
            this.tb_edomhl.Name = "tb_edomhl";
            this.tb_edomhl.Size = new System.Drawing.Size(307, 22);
            this.tb_edomhl.TabIndex = 20;
            // 
            // btn_edomhl_path
            // 
            this.btn_edomhl_path.Location = new System.Drawing.Point(386, 139);
            this.btn_edomhl_path.Name = "btn_edomhl_path";
            this.btn_edomhl_path.Size = new System.Drawing.Size(111, 23);
            this.btn_edomhl_path.TabIndex = 19;
            this.btn_edomhl_path.Text = "Select Path..";
            this.btn_edomhl_path.UseVisualStyleBackColor = true;
            this.btn_edomhl_path.Click += new System.EventHandler(this.Btn_edomhl_path_Click);
            // 
            // tb_warthog
            // 
            this.tb_warthog.Location = new System.Drawing.Point(512, 165);
            this.tb_warthog.Name = "tb_warthog";
            this.tb_warthog.Size = new System.Drawing.Size(307, 22);
            this.tb_warthog.TabIndex = 22;
            // 
            // btn_warthog_path
            // 
            this.btn_warthog_path.Location = new System.Drawing.Point(386, 165);
            this.btn_warthog_path.Name = "btn_warthog_path";
            this.btn_warthog_path.Size = new System.Drawing.Size(111, 23);
            this.btn_warthog_path.TabIndex = 21;
            this.btn_warthog_path.Text = "Select Path..";
            this.btn_warthog_path.UseVisualStyleBackColor = true;
            this.btn_warthog_path.Click += new System.EventHandler(this.Btn_warthog_path_Click);
            // 
            // btn_install_EdEngineer
            // 
            this.btn_install_EdEngineer.Location = new System.Drawing.Point(824, 33);
            this.btn_install_EdEngineer.Name = "btn_install_EdEngineer";
            this.btn_install_EdEngineer.Size = new System.Drawing.Size(75, 23);
            this.btn_install_EdEngineer.TabIndex = 23;
            this.btn_install_EdEngineer.Text = "Install?";
            this.btn_install_EdEngineer.UseVisualStyleBackColor = true;
            this.btn_install_EdEngineer.Click += new System.EventHandler(this.Btn_install_EdEngineer_Click);
            // 
            // btn_install_edmc
            // 
            this.btn_install_edmc.Location = new System.Drawing.Point(824, 60);
            this.btn_install_edmc.Name = "btn_install_edmc";
            this.btn_install_edmc.Size = new System.Drawing.Size(75, 23);
            this.btn_install_edmc.TabIndex = 24;
            this.btn_install_edmc.Text = "Install?";
            this.btn_install_edmc.UseVisualStyleBackColor = true;
            this.btn_install_edmc.Click += new System.EventHandler(this.Btn_install_edmc_Click);
            // 
            // btn_install_EDDiscovery
            // 
            this.btn_install_EDDiscovery.Location = new System.Drawing.Point(824, 113);
            this.btn_install_EDDiscovery.Name = "btn_install_EDDiscovery";
            this.btn_install_EDDiscovery.Size = new System.Drawing.Size(75, 23);
            this.btn_install_EDDiscovery.TabIndex = 26;
            this.btn_install_EDDiscovery.Text = "Install?";
            this.btn_install_EDDiscovery.UseVisualStyleBackColor = true;
            this.btn_install_EDDiscovery.Click += new System.EventHandler(this.Btn_install_EDDiscovery_Click);
            // 
            // btn_install_edomhl
            // 
            this.btn_install_edomhl.Location = new System.Drawing.Point(824, 138);
            this.btn_install_edomhl.Name = "btn_install_edomhl";
            this.btn_install_edomhl.Size = new System.Drawing.Size(75, 23);
            this.btn_install_edomhl.TabIndex = 27;
            this.btn_install_edomhl.Text = "Install?";
            this.btn_install_edomhl.UseVisualStyleBackColor = true;
            this.btn_install_edomhl.Click += new System.EventHandler(this.Btn_install_edomhl_Click);
            // 
            // cb_edlaunch
            // 
            this.cb_edlaunch.AutoSize = true;
            this.cb_edlaunch.Location = new System.Drawing.Point(6, 217);
            this.cb_edlaunch.Name = "cb_edlaunch";
            this.cb_edlaunch.Size = new System.Drawing.Size(183, 20);
            this.cb_edlaunch.TabIndex = 28;
            this.cb_edlaunch.Text = "Elite Dangerous Launcher";
            this.cb_edlaunch.UseVisualStyleBackColor = true;
            // 
            // btn_edlaunch
            // 
            this.btn_edlaunch.Location = new System.Drawing.Point(385, 218);
            this.btn_edlaunch.Name = "btn_edlaunch";
            this.btn_edlaunch.Size = new System.Drawing.Size(111, 23);
            this.btn_edlaunch.TabIndex = 29;
            this.btn_edlaunch.Text = "Select Path..";
            this.btn_edlaunch.UseVisualStyleBackColor = true;
            this.btn_edlaunch.Click += new System.EventHandler(this.Btn_edlaunch_Click);
            // 
            // tb_edlaunch_path
            // 
            this.tb_edlaunch_path.Location = new System.Drawing.Point(511, 219);
            this.tb_edlaunch_path.Name = "tb_edlaunch_path";
            this.tb_edlaunch_path.Size = new System.Drawing.Size(307, 22);
            this.tb_edlaunch_path.TabIndex = 30;
            // 
            // btn_launch_nonvr
            // 
            this.btn_launch_nonvr.Location = new System.Drawing.Point(804, 262);
            this.btn_launch_nonvr.Name = "btn_launch_nonvr";
            this.btn_launch_nonvr.Size = new System.Drawing.Size(95, 33);
            this.btn_launch_nonvr.TabIndex = 31;
            this.btn_launch_nonvr.Text = "Launch";
            this.btn_launch_nonvr.UseVisualStyleBackColor = true;
            this.btn_launch_nonvr.Click += new System.EventHandler(this.Button1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 420);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(948, 26);
            this.statusStrip1.TabIndex = 32;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(50, 20);
            this.toolStripStatusLabel1.Text = "Ready";
            // 
            // tb_warthogscriptpath
            // 
            this.tb_warthogscriptpath.Location = new System.Drawing.Point(512, 191);
            this.tb_warthogscriptpath.Name = "tb_warthogscriptpath";
            this.tb_warthogscriptpath.Size = new System.Drawing.Size(307, 22);
            this.tb_warthogscriptpath.TabIndex = 35;
            // 
            // btn_warthogscriptpath
            // 
            this.btn_warthogscriptpath.Location = new System.Drawing.Point(386, 191);
            this.btn_warthogscriptpath.Name = "btn_warthogscriptpath";
            this.btn_warthogscriptpath.Size = new System.Drawing.Size(111, 23);
            this.btn_warthogscriptpath.TabIndex = 34;
            this.btn_warthogscriptpath.Text = "Select Path..";
            this.btn_warthogscriptpath.UseVisualStyleBackColor = true;
            this.btn_warthogscriptpath.Click += new System.EventHandler(this.Btn_warthogscriptpath_Click);
            // 
            // cb_warthogscriptdir
            // 
            this.cb_warthogscriptdir.AutoSize = true;
            this.cb_warthogscriptdir.Location = new System.Drawing.Point(6, 191);
            this.cb_warthogscriptdir.Name = "cb_warthogscriptdir";
            this.cb_warthogscriptdir.Size = new System.Drawing.Size(283, 20);
            this.cb_warthogscriptdir.TabIndex = 33;
            this.cb_warthogscriptdir.Text = "AussieDroid Warthog Script (Path to Script)";
            this.cb_warthogscriptdir.UseVisualStyleBackColor = true;
            // 
            // btn_autodetect
            // 
            this.btn_autodetect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_autodetect.Location = new System.Drawing.Point(471, 0);
            this.btn_autodetect.Name = "btn_autodetect";
            this.btn_autodetect.Size = new System.Drawing.Size(151, 23);
            this.btn_autodetect.TabIndex = 36;
            this.btn_autodetect.Text = "Autodetect Paths..";
            this.btn_autodetect.UseVisualStyleBackColor = true;
            this.btn_autodetect.Click += new System.EventHandler(this.Btn_autodetect_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 363);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(948, 23);
            this.progressBar1.TabIndex = 37;

            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.nonvr_profile);
            this.tabControl1.Controls.Add(this.VR_Profile);
            this.tabControl1.Location = new System.Drawing.Point(12, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(924, 330);
            this.tabControl1.TabIndex = 38;
            // 
            // nonvr_profile
            // 
            this.nonvr_profile.Controls.Add(this.label2);
            this.nonvr_profile.Controls.Add(this.cb_edengineer);
            this.nonvr_profile.Controls.Add(this.btn_autodetect);
            this.nonvr_profile.Controls.Add(this.btn_launch_nonvr);
            this.nonvr_profile.Controls.Add(this.tb_warthogscriptpath);
            this.nonvr_profile.Controls.Add(this.btn_install_edomhl);
            this.nonvr_profile.Controls.Add(this.btn_install_EDDiscovery);
            this.nonvr_profile.Controls.Add(this.cb_EDMarketConnector);
            this.nonvr_profile.Controls.Add(this.btn_install_edmc);
            this.nonvr_profile.Controls.Add(this.cb_voiceattack);
            this.nonvr_profile.Controls.Add(this.btn_install_EdEngineer);
            this.nonvr_profile.Controls.Add(this.btn_warthogscriptpath);
            this.nonvr_profile.Controls.Add(this.tb_edlaunch_path);
            this.nonvr_profile.Controls.Add(this.cb_EDDiscovery);
            this.nonvr_profile.Controls.Add(this.cb_warthogscriptdir);
            this.nonvr_profile.Controls.Add(this.cb_edomhl);
            this.nonvr_profile.Controls.Add(this.cb_warthog);
            this.nonvr_profile.Controls.Add(this.btn_edlaunch);
            this.nonvr_profile.Controls.Add(this.tb_warthog);
            this.nonvr_profile.Controls.Add(this.cb_edlaunch);
            this.nonvr_profile.Controls.Add(this.tb_edomhl);
            this.nonvr_profile.Controls.Add(this.btn_edengineer_path);
            this.nonvr_profile.Controls.Add(this.tb_eddisco);
            this.nonvr_profile.Controls.Add(this.btn_edmc_path);
            this.nonvr_profile.Controls.Add(this.tb_voiceattack);
            this.nonvr_profile.Controls.Add(this.btn_voiceattack_path);
            this.nonvr_profile.Controls.Add(this.tb_edmc);
            this.nonvr_profile.Controls.Add(this.btn_eddiscovery_path);
            this.nonvr_profile.Controls.Add(this.tb_edengineer);
            this.nonvr_profile.Controls.Add(this.btn_edomhl_path);
            this.nonvr_profile.Controls.Add(this.label1);
            this.nonvr_profile.Controls.Add(this.btn_warthog_path);
            this.nonvr_profile.Location = new System.Drawing.Point(4, 25);
            this.nonvr_profile.Name = "nonvr_profile";
            this.nonvr_profile.Padding = new System.Windows.Forms.Padding(3);
            this.nonvr_profile.Size = new System.Drawing.Size(916, 301);
            this.nonvr_profile.TabIndex = 0;
            this.nonvr_profile.Text = "Non VR Profile";
            this.nonvr_profile.UseVisualStyleBackColor = true;
            // 
            // VR_Profile
            // 
            this.VR_Profile.Location = new System.Drawing.Point(4, 25);
            this.VR_Profile.Name = "VR_Profile";
            this.VR_Profile.Padding = new System.Windows.Forms.Padding(3);
            this.VR_Profile.Size = new System.Drawing.Size(916, 301);
            this.VR_Profile.TabIndex = 1;
            this.VR_Profile.Text = "VR Profile";
            this.VR_Profile.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(948, 446);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Elite AddOn Helper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.nonvr_profile.ResumeLayout(false);
            this.nonvr_profile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cb_edengineer;
        private System.Windows.Forms.CheckBox cb_EDMarketConnector;
        private System.Windows.Forms.CheckBox cb_voiceattack;
        private System.Windows.Forms.CheckBox cb_EDDiscovery;
        private System.Windows.Forms.CheckBox cb_edomhl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePrefsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cb_warthog;
        private System.Windows.Forms.Button btn_edengineer_path;
        private System.Windows.Forms.TextBox tb_edengineer;
        private System.Windows.Forms.TextBox tb_edmc;
        private System.Windows.Forms.Button btn_edmc_path;
        private System.Windows.Forms.TextBox tb_voiceattack;
        private System.Windows.Forms.Button btn_voiceattack_path;
        private System.Windows.Forms.TextBox tb_eddisco;
        private System.Windows.Forms.Button btn_eddiscovery_path;
        private System.Windows.Forms.TextBox tb_edomhl;
        private System.Windows.Forms.Button btn_edomhl_path;
        private System.Windows.Forms.TextBox tb_warthog;
        private System.Windows.Forms.Button btn_warthog_path;
        private System.Windows.Forms.Button btn_install_EdEngineer;
        private System.Windows.Forms.Button btn_install_edmc;
        private System.Windows.Forms.Button btn_install_EDDiscovery;
        private System.Windows.Forms.Button btn_install_edomhl;
        private System.Windows.Forms.CheckBox cb_edlaunch;
        private System.Windows.Forms.Button btn_edlaunch;
        private System.Windows.Forms.TextBox tb_edlaunch_path;
        private System.Windows.Forms.Button btn_launch_nonvr;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TextBox tb_warthogscriptpath;
        private System.Windows.Forms.Button btn_warthogscriptpath;
        private System.Windows.Forms.CheckBox cb_warthogscriptdir;
        private System.Windows.Forms.Button btn_autodetect;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage nonvr_profile;
        private System.Windows.Forms.TabPage VR_Profile;
    }
}

