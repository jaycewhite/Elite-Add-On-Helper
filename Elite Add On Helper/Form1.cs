using Elite_Add_On_Helper.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Elite_Add_On_Helper
{
    
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            Application.DoEvents();
            load_prefs();
        }

        private void load_prefs()
        {
            // load all the textboxes with values from settings file
            tb_edengineer.Text = Properties.Settings.Default["edengineer_path"].ToString();
            tb_edmc.Text = Properties.Settings.Default["edmc_path"].ToString();
            tb_voiceattack.Text = Properties.Settings.Default["voiceattack_path"].ToString();
            tb_edlaunch_path.Text = Properties.Settings.Default["edlaunch_path"].ToString();
            tb_eddisco.Text = Properties.Settings.Default["ed_discovery_path"].ToString();
            tb_edomhl.Text = Properties.Settings.Default["edomhl_path"].ToString();
            tb_warthogscriptpath.Text = Properties.Settings.Default["warthog_pathtoscript"].ToString();
            tb_warthog.Text = Properties.Settings.Default["warthog_path"].ToString();
            cb_edengineer.Checked = (bool)Properties.Settings.Default["edenginner_cb"];
            cb_EDMarketConnector.Checked = (bool)Properties.Settings.Default["edmc_cb"];
            cb_voiceattack.Checked = (bool)Properties.Settings.Default["voiceattack_cb"];
            cb_EDDiscovery.Checked = (bool)Properties.Settings.Default["ed_discovery_cb"];
            cb_edomhl.Checked = (bool)Properties.Settings.Default["edomgl_cb"];
            cb_warthog.Checked = (bool)Properties.Settings.Default["warthoc_cb"];
            cb_edlaunch.Checked = (bool)Properties.Settings.Default["edlaunch_cb"];
            cb_warthogscriptdir.Checked = (bool)Properties.Settings.Default["warthogscriptdir_cb"];
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // My Functions
        private void updatestatus(string status)
        {
            // function to update the status bar
            toolStripStatusLabel1.Text = status;
                        statusStrip1.Invalidate();
                        statusStrip1.Refresh();
        }
        private string folderpath()
        {
            FolderBrowserDialog diag = new FolderBrowserDialog();
            // set the root folder or it defaults to desktop
            diag.RootFolder = Environment.SpecialFolder.MyComputer;
           

            if (diag.ShowDialog() == System.Windows.Forms.DialogResult.OK)

            {
                return diag.SelectedPath;
            }
            else { return null; }
        }

        // form actions
        private void btn_edengineer_path_Click(object sender, EventArgs e)
        {
            string mypath = folderpath();
            if(mypath != null) { 
                tb_edengineer.Text = mypath;
            }

        }

        private void savePrefsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["edengineer_path"] = tb_edengineer.Text;
            Properties.Settings.Default["edmc_path"] = tb_edmc.Text;
            Properties.Settings.Default["edlaunch_path"] = tb_edlaunch_path.Text;
            Properties.Settings.Default["voiceattack_path"] = tb_voiceattack.Text;
            Properties.Settings.Default["ed_discovery_path"] = tb_eddisco.Text;
            Properties.Settings.Default["edomhl_path"] = tb_edomhl.Text;
            Properties.Settings.Default["warthog_path"] = tb_warthog.Text;
            Properties.Settings.Default["warthog_pathtoscript"] = tb_warthogscriptpath.Text;
            Properties.Settings.Default["edenginner_cb"] = cb_edengineer.Checked;
            Properties.Settings.Default["edmc_cb"] = cb_EDMarketConnector.Checked;
            Properties.Settings.Default["voiceattack_cb"] = cb_voiceattack.Checked;
            Properties.Settings.Default["ed_discovery_cb"] = cb_EDDiscovery.Checked;
            Properties.Settings.Default["warthogscriptdir_cb"] = cb_warthogscriptdir.Checked;
            Properties.Settings.Default["edomgl_cb"] = cb_edomhl.Checked;
            Properties.Settings.Default["warthoc_cb"] = cb_warthog.Checked;
            Properties.Settings.Default["edlaunch_cb"] = cb_edlaunch.Checked;
            Properties.Settings.Default.Save(); // Saves settings in application configuration file
        }
        
        private void btn_edmc_path_Click(object sender, EventArgs e)
        {
            string mypath = folderpath();
            if(mypath != null) { 
                tb_edmc.Text = mypath;
             }
        }
        private void btn_warthogscriptpath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Title = "Select A File";
            openDialog.Filter = "Thrustmaster Files (*.tmc)|*.tmc";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                string file = openDialog.FileName;
                tb_warthogscriptpath.Text = file;
            }

        }
        private void btn_voiceattack_path_Click(object sender, EventArgs e)
        {
            string mypath = folderpath();
                if(mypath != null) { 
                tb_voiceattack.Text = mypath;
            }
        }

        private void btn_eddiscovery_path_Click(object sender, EventArgs e)
        {
            string mypath = folderpath();
                if(mypath != null) { 
                tb_eddisco.Text = mypath;
             }
        }

        private void btn_edomhl_path_Click(object sender, EventArgs e)
        {
            string mypath = folderpath();
                if(mypath != null) { 
                tb_edomhl.Text = mypath;
            }
        }

        private void btn_warthog_path_Click(object sender, EventArgs e)
        {
             string mypath = folderpath();
                if(mypath != null) { 
                tb_warthog.Text = mypath;
            }
        }

        private void btn_edlaunch_Click(object sender, EventArgs e)
        {
            string mypath = folderpath();
                if(mypath != null) { 
                tb_edlaunch_path.Text = mypath;
            }
        }

        // launch the apps!
        private void button1_Click(object sender, EventArgs e)
        {
            string procname;
            
            // ok lets launch some apps!
            //ed discovery
            if (cb_EDDiscovery.Checked == true)
                {
                // does the folder exist?
                if (Directory.Exists(tb_eddisco.Text))
                {
                    procname = tb_eddisco.Text + "/EDDiscovery.exe";
                    // does the file exist?
                    if (File.Exists(procname))
                    {
                        //woohoo! lets launch it
                        updatestatus("Launching EdDiscovery..");
                        Process.Start(procname);
                        System.Threading.Thread.Sleep(2000);
                    }
                }
            }
            //ed engineer
            if (cb_edengineer.Checked == true)
            {
                // does the folder exist?
                if (Directory.Exists(tb_edengineer.Text))
                {
                    procname = tb_edengineer.Text + "/EDEngineer.exe";
                    // does the file exist?
                    if (File.Exists(procname))
                    {
                        //woohoo! lets launch it
                        updatestatus("Launching EdEngineer..");

                        Process.Start(procname);
                        System.Threading.Thread.Sleep(2000);
                    }
                }
            }
            //edmc
            if (cb_EDMarketConnector.Checked == true)
            {
                // does the folder exist?
                if (Directory.Exists(tb_edmc.Text))
                {
                    procname = tb_edmc.Text + "/EDMarketConnector.exe";
                    // does the file exist?
                    if (File.Exists(procname))
                    {
                        //woohoo! lets launch it
                        updatestatus("Launching EDMC..");
                        Process.Start(procname);
                        System.Threading.Thread.Sleep(2000);
                    }
                }
            }
            //ed odyysey materials helper
            if (cb_edomhl.Checked == true)
            {
                // does the folder exist?
                if (Directory.Exists(tb_edomhl.Text))
                {
                    procname = tb_edomhl.Text + "/Elite Dangerous Odyssey Materials Helper Launcher.exe";
                    // does the file exist?
                    if (File.Exists(procname))
                    {
                        //woohoo! lets launch it
                        updatestatus("Launching Elite Mats Helper..");
                        Process.Start(procname);
                        System.Threading.Thread.Sleep(2000);
                    }
                }
            }
            //voiceattack
            if (cb_voiceattack.Checked == true)
            {
                // does the folder exist?
                if (Directory.Exists(tb_voiceattack.Text))
                {
                    procname = tb_voiceattack.Text + "/VoiceAttack.exe";
                    // does the file exist?
                    if (File.Exists(procname))
                    {
                        updatestatus("Launching Voice Attack..");

                        //woohoo! lets launch it
                        Process.Start(procname);
                        System.Threading.Thread.Sleep(2000);
                    }
                }
            }
            //warthog  ***************  WORKING ****************
            if (cb_warthog.Checked == true)
            {
                
                // does the folder exist?
                if (Directory.Exists(tb_warthog.Text))
                {
                    procname = tb_warthog.Text + "/TARGETGUI.exe";
                    
                    string targargs = " -r " + "\"" + tb_warthogscriptpath.Text + "\"";
                    // does the file exist?
                    if (File.Exists(procname))
                    {
                        Process TARGETGUI = new Process();
                        TARGETGUI.StartInfo.FileName = procname;
                        TARGETGUI.StartInfo.Arguments = targargs;
                        statusStrip1.Text = targargs;
                        Application.DoEvents();
                        updatestatus("Launching Target..");

                        TARGETGUI.Start();
                        System.Threading.Thread.Sleep(2000);

                        //woohoo! lets launch it
                        //Process.Start(procname);
                    }
                }
            }
            //elite launcer
            if (cb_edlaunch.Checked == true)
            {
                // does the folder exist?
                if (Directory.Exists(tb_edlaunch_path.Text))
                {
                    procname =  tb_edlaunch_path.Text  + "/EDLaunch.exe";
                    // does the file exist?
                    if (File.Exists(procname))
                    {
                        updatestatus("Launching Elite..");
                        //woohoo! lets launch it
                        Process.Start(procname);
                        System.Threading.Thread.Sleep(2000);
                    }
                    else
                    {
                        updatestatus("Elite exe not found!" + procname);
                    }
                }
                else
                {
                    updatestatus("Elite path not found!" + tb_edlaunch_path.Text);
                }
            }
            System.Threading.Thread.Sleep(2000);
            updatestatus("Ready");
            // for ref how to open a webpage in default browser
            //Process.Start("https://www.google.com/");
            //Console.ReadLine();
        }
       
        //try to detect paths for the applications
        private void btn_autodetect_Click(object sender, EventArgs e)
        {
            updatestatus("This may take a while.. Searching for EDMC");
            // lets check the default path
            // 
            string pathtocheck = @"C:\Program Files (x86)\EDMarketConnector";
            if (Directory.Exists(pathtocheck))
            {
                // found it!
                tb_edmc.Text = pathtocheck;
                cb_EDMarketConnector.Checked = true;
            }
            else
            {
                updatestatus("EDMC Not found");

            }
            System.Threading.Thread.Sleep(2000);

            updatestatus("This may take a while.. Searching for Voice Attack");

            // lets check the default path
            // 
            pathtocheck = @"C:\Program Files (x86)\Steam\steamapps\common\VoiceAttack";
            if (Directory.Exists(pathtocheck))
            {
                // found it!
                tb_voiceattack.Text = pathtocheck;
                cb_voiceattack.Checked = true;
            }
            else
            {
                updatestatus("Voice Attack Not found");

            }
            System.Threading.Thread.Sleep(2000);
            updatestatus("This may take a while.. Searching for ED Discovery");
            // lets check the default path
            // 
            pathtocheck = @"C:\Program Files\EDDiscovery";
            if (Directory.Exists(pathtocheck))
            {
                // found it!
                tb_eddisco.Text = pathtocheck;
                cb_EDDiscovery.Checked = true;
            }
            else
            {
               updatestatus("ED Discovery Not found");

            }
            System.Threading.Thread.Sleep(2000);
            updatestatus("This may take a while.. Searching for ED Odyysey Materials Helper");

            // lets check the default path
            // 
            pathtocheck = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Elite Dangerous Odyssey Materials Helper Launcher";
            if (Directory.Exists(pathtocheck))
            {
                // found it!
                tb_edomhl.Text = pathtocheck;
                cb_edomhl.Checked = true;
            }
            else
            {
                updatestatus(" ED Odyysey Materials Helper not found");
            }
            System.Threading.Thread.Sleep(2000);

            updatestatus("This may take a while.. Searching for T.A.R.G.E.T");
            // lets check the default path
            // 
            pathtocheck = @"c:\program files (x86)\Thrustmaster\TARGET\x64";
            if (Directory.Exists(pathtocheck))
            {
                // found it!
                tb_warthog.Text = pathtocheck;
                cb_warthog.Checked = true;
            }
            else
            {
                updatestatus(" ED Odyysey Materials Helper not found");
            }
            System.Threading.Thread.Sleep(2000);

            updatestatus("This may take a while.. Searching for Elite Dangerous");

            // lets check the default path
            // 
            pathtocheck = @"C:\Program Files (x86)\Steam\steamapps\common\Elite Dangerous\";
            if (Directory.Exists(pathtocheck))
            {
                // found it!
                tb_edlaunch_path.Text = pathtocheck;
                cb_edlaunch.Checked = true;
            }
            else
            {
                updatestatus("Elite launcher not found");
            }
            System.Threading.Thread.Sleep(2000);
            updatestatus("Ready");
        }
    }
}

