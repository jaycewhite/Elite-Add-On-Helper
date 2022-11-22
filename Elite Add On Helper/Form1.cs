using Elite_Add_On_Helper.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Management;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data;
using System.Drawing;

namespace Elite_Add_On_Helper
{

    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            Application.DoEvents();
            Load_prefs();
        }
        
        private void Load_prefs()
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

        // test region
      
        
        //end test region

        // My Functions
        private string Findfile(string FILENAME)
        {
            const string FOLDER = @"c:\";
            string[] res;
            DirectoryInfo info = new DirectoryInfo(FOLDER);
            try
            {
                foreach (DirectoryInfo childInfo in info.GetDirectories())
                {
                    Updatestatus(childInfo.FullName);
                    Console.WriteLine(childInfo.FullName);
                    try
                    {
                        res = Directory.GetFiles(childInfo.FullName, FILENAME, SearchOption.AllDirectories);
                        Console.WriteLine(res);
                    }
                    catch (Exception ex)
                    {
                        string errorMsg = string.Format("Exception Folder : {0}, Error : {1}", info.FullName, ex.Message);
                        Console.WriteLine(errorMsg);

                    }
                }
            }
            catch (Exception ex)
            {
                string errorMsg = string.Format("Exception Folder : {0}, Error : {1}", info.FullName, ex.Message);
                Console.WriteLine(errorMsg);
                
            }

            System.Threading.Thread.Sleep(2000);

            System.Threading.Thread.Sleep(2000);


            var files = new List<string>();

            foreach (DriveInfo d in DriveInfo.GetDrives().Where(x => x.IsReady == true))
            {
                try
                {
                    Updatestatus("Searching " + d.RootDirectory.FullName);
                    System.Threading.Thread.Sleep(2000);
                    files.AddRange(Directory.GetFiles(d.RootDirectory.FullName, FILENAME, SearchOption.AllDirectories));
                }
                catch { }
            }
            if (files.Count == 0) { return "Not Found"; } else {
                return files.First(); }
        }
        void DownloadFileAndExecute(string link)
        {
            WebClient wc = new WebClient();
            string filename = Path.GetFileName(link);
            wc.DownloadFile(link, filename);
            Process.Start(filename);
        }
        private void Updatestatus(string status)
        {
            // function to update the status bar
            toolStripStatusLabel1.Text = status;
            statusStrip1.Invalidate();
            statusStrip1.Refresh();
        }
        private string Folderpath()
        {
            FolderBrowserDialog diag = new FolderBrowserDialog
            {
                // set the root folder or it defaults to desktop
                RootFolder = Environment.SpecialFolder.MyComputer
            };
            if (diag.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                return diag.SelectedPath;
            }
            else { return null; }
        }
        // form actions
        // menu actions
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SavePrefsToolStripMenuItem_Click(object sender, EventArgs e)
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
        // button actions
        private void Btn_edengineer_path_Click(object sender, EventArgs e)
        {
            string mypath = Folderpath();
            if (mypath != null)
            {
                tb_edengineer.Text = mypath;
            }

        }
        private void Btn_edmc_path_Click(object sender, EventArgs e)
        {
            string mypath = Folderpath();
            if (mypath != null)
            {
                tb_edmc.Text = mypath;
            }
        }
        private void Btn_warthogscriptpath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog
            {
                Title = "Select A File",
                Filter = "Thrustmaster Files (*.tmc)|*.tmc"
            };
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                string file = openDialog.FileName;
                tb_warthogscriptpath.Text = file;
            }
        }
        private void Btn_voiceattack_path_Click(object sender, EventArgs e)
        {
            string mypath = Folderpath();
            if (mypath != null)
            {
                tb_voiceattack.Text = mypath;
            }
        }
        private void Btn_eddiscovery_path_Click(object sender, EventArgs e)
        {
            string mypath = Folderpath();
            if (mypath != null)
            {
                tb_eddisco.Text = mypath;
            }
        }
        private void Btn_edomhl_path_Click(object sender, EventArgs e)
        {
            string mypath = Folderpath();
            if (mypath != null)
            {
                tb_edomhl.Text = mypath;
            }
        }
        private void Btn_warthog_path_Click(object sender, EventArgs e)
        {
            string mypath = Folderpath();
            if (mypath != null)
            {
                tb_warthog.Text = mypath;
            }
        }
        private void Btn_edlaunch_Click(object sender, EventArgs e)
        {
            string mypath = Folderpath();
            if (mypath != null)
            {
                tb_edlaunch_path.Text = mypath;
            }
        }
        // launch the apps!
        private void Button1_Click(object sender, EventArgs e)
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
                        Updatestatus("Launching EdDiscovery..");
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
                        Updatestatus("Launching EdEngineer..");

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
                        Updatestatus("Launching EDMC..");
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
                        Updatestatus("Launching Elite Mats Helper..");
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
                        Updatestatus("Launching Voice Attack..");

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
                        Updatestatus("Launching Target..");

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
                        Updatestatus("Launching Elite..");
                        //woohoo! lets launch it
                        Process.Start(procname);
                        System.Threading.Thread.Sleep(2000);
                    }
                    else
                    {
                        Updatestatus("Elite exe not found!" + procname);
                    }
                }
                else
                {
                    Updatestatus("Elite path not found!" + tb_edlaunch_path.Text);
                }
            }
            System.Threading.Thread.Sleep(2000);
            Updatestatus("Ready");
            // for ref how to open a webpage in default browser
            //Process.Start("https://www.google.com/");
            //Console.ReadLine();
        }
        //try to detect paths for the applications
        private void Btn_autodetect_Click(object sender, EventArgs e)
        {
            string pathtocheck;
            Updatestatus("This may take a while.. Searching for EDMC");
            // lets check the default path
            // 
            pathtocheck = @"C:\Program Files (x86)\EDMarketConnector";
            if (Directory.Exists(pathtocheck))
            {
                // found it!
                tb_edmc.Text = pathtocheck;
                cb_EDMarketConnector.Checked = true;
            }
            else
            {
                Updatestatus("EDMC Not found");
                System.Threading.Thread.Sleep(2000);
            }
            System.Threading.Thread.Sleep(2000);
            Updatestatus("This may take a while.. Searching for Ed Engineer");

             string Foldertosearch = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\apps";
            string[] result;
           // Console.WriteLine(Foldertosearch);
           result = Directory.GetFiles(Foldertosearch, "EDEngineer.exe", SearchOption.AllDirectories);
           result.ToList().ForEach(i => Console.WriteLine(i.ToString()));  //spit it out to the console for debugging
            //ok so we have a list of possible candidates, lets get the last one..

            if (File.Exists(result.Last()))
            {
                // found it!
                string edeng = result.Last();
                edeng = edeng.Replace(@"\EDEngineer.exe", "");
                tb_edengineer.Text = edeng;
                tb_edengineer.Refresh();
                cb_edengineer.Checked = true;
            }
            else
            {
                Updatestatus("Ed Engineer Not found");
                System.Threading.Thread.Sleep(2000);
            }
            System.Threading.Thread.Sleep(2000);



            Updatestatus("This may take a while.. Searching for Voice Attack");

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
                Updatestatus("Voice Attack Not found");

            }
            System.Threading.Thread.Sleep(2000);
            Updatestatus("This may take a while.. Searching for ED Discovery");
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
                Updatestatus("ED Discovery Not found");

            }
            System.Threading.Thread.Sleep(2000);
            Updatestatus("This may take a while.. Searching for ED Odyysey Materials Helper");

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
                Updatestatus(" ED Odyysey Materials Helper not found");
            }
            System.Threading.Thread.Sleep(2000);

            Updatestatus("This may take a while.. Searching for T.A.R.G.E.T");
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
                Updatestatus(" ED Odyysey Materials Helper not found");
            }
            System.Threading.Thread.Sleep(2000);

            Updatestatus("This may take a while.. Searching for Elite Dangerous");

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
                Updatestatus("Elite launcher not found");
            }
            System.Threading.Thread.Sleep(2000);
            Updatestatus("Ready");
        }

        private void Btn_install_EdEngineer_Click(object sender, EventArgs e)
        {
            Updatestatus("Installing Ed Engineer");
            DownloadFileAndExecute("https://raw.githubusercontent.com/msarilar/EDEngineer/master/EDEngineer/releases/setup.exe");
            Updatestatus("Ready");
        }

        private void Btn_install_edmc_Click(object sender, EventArgs e)
        {
            Updatestatus("Installing EDMC");
            DownloadFileAndExecute("https://github.com/EDCD/EDMarketConnector/releases/download/Release%2F5.5.0/EDMarketConnector_win_5.5.0.msi");
            Updatestatus("Ready");
        }

        private void Btn_install_EDDiscovery_Click(object sender, EventArgs e)
        {
            Updatestatus("Installing ED Discovery");
            DownloadFileAndExecute("https://github.com/EDDiscovery/EDDiscovery/releases/download/Release_15.1.4/EDDiscovery-15.1.4.exe");
            Updatestatus("Ready");
        }

        private void Btn_install_edomhl_Click(object sender, EventArgs e)
        {
            Updatestatus("Installing ED Odyysesy Materials Helper");
            DownloadFileAndExecute("https://github.com/jixxed/ed-odyssey-materials-helper/releases/download/1.100/Elite.Dangerous.Odyssey.Materials.Helper-1.100.msi");
            Updatestatus("Ready");
        }

       
    }
}

