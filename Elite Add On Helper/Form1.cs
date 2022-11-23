//using Elite_Add_On_Helper.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Management;
using System.Threading;
using System.IO;
using System.Linq;
using System.Net;
//using System.Text; 
//using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Xml.Linq;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.ComponentModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Xml.XPath;
using System.Xml;

namespace Elite_Add_On_Helper
{

    public partial class Form1 : Form
    {
        static string directory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

        static string settingsFilePath = directory + "/Elite Add On Helper";

        public Form1()
        {
            InitializeComponent();

            System.IO.Directory.CreateDirectory(settingsFilePath);
            Application.DoEvents();

            Load_prefs();


        }

        //load our preferences..
        public void Load_prefs()
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
        #region Read Data From XML
        /// <summary>
        /// Reads the data of specified node provided in the parameter
        /// </summary>
        /// <param name="pstrValueToRead">Node to be read</param>
        /// <returns>string containing the value</returns>
        private static string ReadValueFromXML(string pstrValueToRead)
        {
            try
            {
                //settingsFilePath is a string variable storing the path of the settings file 
                XPathDocument doc = new XPathDocument(settingsFilePath);
                XPathNavigator nav = doc.CreateNavigator();
                // Compile a standard XPath expression
                XPathExpression expr;
                expr = nav.Compile(@"/settings/" + pstrValueToRead);
                XPathNodeIterator iterator = nav.Select(expr);
                // Iterate on the node set
                while (iterator.MoveNext())
                {
                    return iterator.Current.Value;
                }
                return string.Empty;
            }
            catch
            {
                //do some error logging here. Leaving for you to do 
                return string.Empty;
            }
        }
        /// <summary>
        /// Writes the updated value to XML
        /// </summary>
        /// <param name="pstrValueToRead">Node of XML to read</param>
        /// <param name="pstrValueToWrite">Value to write to that node</param>
        /// <returns></returns>
        private static bool WriteValueTOXML(string pstrValueToRead, string pstrValueToWrite)
        {
            try
            {
                //settingsFilePath is a string variable storing the path of the settings file 
                XmlTextReader reader = new XmlTextReader(settingsFilePath);
                XmlDocument doc = new XmlDocument();
                doc.Load(reader);
                //we have loaded the XML, so it's time to close the reader.
                reader.Close();
                XmlNode oldNode;
                XmlElement root = doc.DocumentElement;
                oldNode = root.SelectSingleNode("/settings/" + pstrValueToRead);
                oldNode.InnerText = pstrValueToWrite;
                doc.Save(settingsFilePath);
                return true;
            }
            catch
            {
                //properly you need to log the exception here. But as this is just an
                //example, I am not doing that. 
                return false;
            }
        }
        #endregion

        //end test region

        // My Functions
        #region functions

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
        #endregion
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
        #region browse for paths
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
        #endregion
        // launch the apps!
        private void Button1_Click(object sender, EventArgs e)
        {
            string procname;
            //ooooh lets remember to set up the progress bar...
            // Display the ProgressBar control.
            progressBar1.Visible = true;
            // Set Minimum to 1 to represent the first file being copied.
            progressBar1.Minimum = 1;
            // Set Maximum to the total number of files to copy.
            int Totalchecked = nonvr_profile.Controls.OfType<System.Windows.Forms.CheckBox>().Where(c => c.Checked).Count();
            progressBar1.Maximum = Totalchecked;
            // Set the initial value of the ProgressBar.
            progressBar1.Value = 1;
            // Set the Step property to a value of 1 to represent each file being copied.
            progressBar1.Step = 1;
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

                        progressBar1.PerformStep();
                        progressBar1.Refresh();
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
                        progressBar1.PerformStep();
                        progressBar1.Refresh();
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
                        progressBar1.PerformStep();
                        progressBar1.Refresh();
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
                        progressBar1.PerformStep();
                        progressBar1.Refresh();
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
                        progressBar1.PerformStep();
                        progressBar1.Refresh();
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
                        progressBar1.PerformStep();
                        progressBar1.Refresh();
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
                        progressBar1.PerformStep();
                        progressBar1.Refresh();
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
            progressBar1.Value= 1;
            progressBar1.Refresh();
            // for ref how to open a webpage in default browser
            //Process.Start("https://www.google.com/");
            ;
        }

        //try to detect paths for the applications
        // TODO get path and exe names to make launching a simple loop operation.
        private void Btn_autodetect_Click(object sender, EventArgs e)
        {
            // Display the ProgressBar control.
            progressBar1.Visible = true;
            // Set Minimum to 1 to represent the first file being copied.
            progressBar1.Minimum = 1;
            // Set Maximum to the total number of files to copy.
            int Totalchecked = nonvr_profile.Controls.OfType<System.Windows.Forms.CheckBox>().Count();
            progressBar1.Maximum = Totalchecked;
            Console.WriteLine(Totalchecked);
            // Set the initial value of the ProgressBar.
            progressBar1.Value = 1;
            // Set the Step property to a value of 1 to represent each file being copied.
            progressBar1.Step = 1;
            List<String> Driveletter = new List<string>();                                  //who has more than 10 local drives???
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo d in allDrives)
            {
                if (d.IsReady && d.DriveType == DriveType.Fixed)
                {
                    // Store Drives in list..
                    // Drives;

                    Driveletter.Add(d.ToString());

                }
            }
            string pathtocheck;
            Updatestatus("This may take a while.. Searching for EDMC");
            // lets check the default path
            // 
            progressBar1.PerformStep();
            progressBar1.Refresh();
            pathtocheck = @"C:\Program Files (x86)\EDMarketConnector";
            if (Directory.Exists(pathtocheck))
            {
                // found it!
                tb_edmc.Text = pathtocheck;
                tb_edmc.Refresh();
                cb_EDMarketConnector.Checked = true;
            }
            else
            {
                Updatestatus("EDMC Not found");

            }
            progressBar1.PerformStep();
            progressBar1.Refresh();
            Updatestatus("This may take a while.. Searching for Ed Engineer");
            // lets get the users appdata/local folder...
            string Foldertosearch = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\apps";
            //now we need an array to hold the search result (Edengineer leases stuff behind when it updates resulting in mulitple copies)
            string[] result;
            // now lets search app data for EdEngineer..           
            result = Directory.GetFiles(Foldertosearch, "EDEngineer.exe", SearchOption.AllDirectories);

            //ok so we have a list of possible candidates, lets get the last one..

            if (File.Exists(result.Last()))
            {
                // found it!
                string edeng = result.Last();                       //get the last (usually most recent, meh) version of the file.
                edeng = edeng.Replace(@"\EDEngineer.exe", "");      //take of the exe name so we jjust have the path
                tb_edengineer.Text = edeng;                         //update the textbox
                tb_edengineer.Refresh();                            // refresh the textbox
                cb_edengineer.Checked = true;                       // enable the app by checking the checkbox
            }
            else
            {
                Updatestatus("Ed Engineer Not found");
            }
            Updatestatus("This may take a while.. Searching for Voice Attack");
            progressBar1.PerformStep();
            progressBar1.Refresh();
            // lets check the default path
            // lets also search well known locations on all local fixed drives
            pathtocheck = @"C:\Program Files (x86)\Steam\steamapps\commonVoiceAttack";
            if (Directory.Exists(pathtocheck))
            {
                // found it!
                tb_voiceattack.Text = pathtocheck;
                tb_voiceattack.Refresh();
                cb_voiceattack.Checked = true;
            }
            else                                    // not found in default? lets search all local drives for steam apps
            {
                foreach (string d in Driveletter)
                {
                    pathtocheck = d + @"SteamLibrary\steamapps\common\VoiceAttack";

                    if (Directory.Exists(pathtocheck))
                    {
                        // found it!
                        tb_voiceattack.Text = pathtocheck;
                        tb_voiceattack.Refresh();
                        cb_voiceattack.Checked = true;
                    }
                    else
                    {
                        Updatestatus("Voice Attack Not found");

                    }
                }
            }
            progressBar1.PerformStep();
            progressBar1.Refresh();
            Updatestatus("This may take a while.. Searching for ED Discovery");
            // lets check the default path
            // 
            pathtocheck = @"C:\Program Files\EDDiscovery";
            if (Directory.Exists(pathtocheck))
            {
                // found it!
                tb_eddisco.Text = pathtocheck;
                tb_eddisco.Refresh();
                cb_EDDiscovery.Checked = true;
            }
            else
            {
                Updatestatus("ED Discovery Not found");

            }
            progressBar1.PerformStep();
            progressBar1.Refresh();
            Updatestatus("This may take a while.. Searching for ED Odyysey Materials Helper");

            // lets check the default path
            // 

            pathtocheck = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Elite Dangerous Odyssey Materials Helper Launcher";

            if (Directory.Exists(pathtocheck))
            {
                // found it!
                tb_edomhl.Text = pathtocheck;
                tb_edomhl.Refresh();
                cb_edomhl.Checked = true;
            }
            else
            {
                Updatestatus(" ED Odyysey Materials Helper not found");
            }

            progressBar1.PerformStep();
            progressBar1.Refresh();
            Updatestatus("This may take a while.. Searching for T.A.R.G.E.T");
            // lets check the default path
            // 
            pathtocheck = @"c:\program files (x86)\Thrustmaster\TARGET\x64";
            if (Directory.Exists(pathtocheck))
            {
                // found it!
                tb_warthog.Text = pathtocheck;
                tb_warthog.Refresh();
                cb_warthog.Checked = true;
            }
            else
            {
                Updatestatus(" ED Odyysey Materials Helper not found");
            }

            progressBar1.PerformStep();
            progressBar1.Refresh();
            Updatestatus("This may take a while.. Searching for Elite Dangerous");

            // lets check the default path
            // 
            pathtocheck = @"C:\Program Files (x86)\Steam\steamapps\common\Elite Dangerous\";

            if (Directory.Exists(pathtocheck))
            {
                // found it!
                tb_edlaunch_path.Text = pathtocheck;
                tb_edlaunch_path.Refresh();
                cb_edlaunch.Checked = true;
            }
            else                                    // not found in default? lets search all local drives for steam apps
            {
                foreach (string d in Driveletter)
                {


                    pathtocheck = d + @"SteamLibrary\steamapps\common\Elite Dangerous";

                    if (Directory.Exists(pathtocheck))
                    {
                        // found it!
                        tb_edlaunch_path.Text = pathtocheck;
                        tb_edlaunch_path.Refresh();
                        cb_edlaunch.Checked = true;
                    }
                }
            }
            if (tb_edlaunch_path.Text == null)
            {
                Updatestatus("Elite launcher not found");
            }
            System.Threading.Thread.Sleep(2000);
            progressBar1.Value= 1;
            progressBar1.Refresh();
            Updatestatus("Ready");
        }
        # region installs
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

        #endregion installs      

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tb_edengineer_TextChanged(object sender, EventArgs e)
        {
            // do we have an object for this field?

        }
    }
}

