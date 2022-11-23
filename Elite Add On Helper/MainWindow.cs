using Elite_Add_On_Helper.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Elite_Add_On_Helper
{

    public partial class MainWindow : Form
    {
        /// <summary>
        /// List of all addons
        /// </summary>
        public Dictionary<string, AddOn> addOns = new Dictionary<string, AddOn>();

        public MainWindow()
        {
            InitializeComponent();
            Application.DoEvents();
            load_prefs();

        }

        private int currentControlRow = 0;

        private void InitialAddonsSetup()
        {
            //Test data below, dictionary key should match friendly name
            addOns.Add("Ed Engineer", new AddOn
            {
                Enabled = false,
                Installable = false,
                ProgramDirectory = "test",
                FriendlyName = "Ed Engineer",
                ExecutableName = "EDEngineer.exe",
                AutoDiscoverPath = "test"
            });

            addOns.Add("Ed Market Connector", new AddOn
            {
                Enabled = false,
                Installable = true,
                ProgramDirectory = "test",
                FriendlyName = "Ed Market Connector",
                ExecutableName = "EDMarketConnector.exe", //didn't check this, possibly wrong
                AutoDiscoverPath = "test"
            });
        }

        private void load_prefs()
        {
            // load all the textboxes with values from settings file
            if (File.Exists("AddOns.json"))
            {
                addOns = DeserializeAddOns();
            }
            else
            {
                InitialAddonsSetup();
            }

            foreach(var addon in addOns.Values)
            {
                CreateControls(addon);
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // My Functions
        private void updatestatus(string status)
        {
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

        // launch the apps!
        private void button1_Click(object sender, EventArgs e)
        {
            foreach(var addOn in addOns.Values)
            {
                if (addOn.Enabled)
                {
                    LaunchAddon(addOn);
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
            
        }

        /// <summary>
        /// Creates all the controls programmatically from the addon class model you provide.
        /// </summary>
        /// <param name="addOn"></param>
        private void CreateControls(AddOn addOn)
        {
            //Sets the y position of the controls based on how many rows (addons) there are
            var yPosition = ((currentControlRow) * 22) + 150;

            //Create checkbox
            CheckBox checkBox = new CheckBox();
            //Set the text to the friendly (human readable) addon name
            checkBox.Text = addOn.FriendlyName;
            //Autosize on
            checkBox.AutoSize = true;
            //Data binding, super useful. If the box is checked, it updates the model, if you update the model in code, the box changes too!
            //this is basically saying "The box being checked on screen is linked to this specific addon object, and more specifically the enabled property"
            checkBox.DataBindings.Add("Checked", addOn, "Enabled");
            //Set the location on screen, this can be a bit trial and error
            checkBox.Location = new System.Drawing.Point(15, yPosition);
            //Add the checkbox to the controls for this form1 form
            Controls.Add(checkBox);

            Button button = new Button();
            button.Text = "Select Path...";
            button.Location = new System.Drawing.Point(277, yPosition);
            button.Size = new System.Drawing.Size(80, 20);
            //To the buttons click method, add this method, and pass it the friendly name (to use as the AddOns dictionary key)
            button.Click += (sender, e) => HandleSelectPath(addOn.FriendlyName); 
            Controls.Add(button);

            TextBox textBox = new TextBox();
            textBox.Name = addOn.FriendlyName;
            textBox.Location = new System.Drawing.Point(360, yPosition);
            textBox.Size = new System.Drawing.Size(230, 22);
            textBox.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            textBox.DataBindings.Add("Text", addOn, "ProgramDirectory");
            textBox.Margin = new System.Windows.Forms.Padding(3,3,3,3);
            Controls.Add(textBox);

            if (addOn.Installable)
            {
                Button installButton = new Button();
                installButton.Text = "Install?";
                installButton.Location = new System.Drawing.Point(600, yPosition);
                installButton.Size = new System.Drawing.Size(80, 20);
                //To the buttons click method, add this method, and pass it the friendly name (to use as the AddOns dictionary key)
                installButton.Click += (sender, e) => HandleInstallButton(addOn.FriendlyName);
                Controls.Add(installButton);
            }
            

            currentControlRow++;
        }

        private void HandleInstallButton(string dictKey)
        {
            //TODO handle install button
        }

        private void HandleSelectPath(string dictKey)
        {
            addOns.TryGetValue(dictKey, out var addOn); //get the AddOn model as "addOn" using the dictionary key

            if(addOn == null)
            {
                return;
            }
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Title = "Select A File";
            openDialog.Filter = "Executable files (*.exe)|*.exe";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                string file = openDialog.FileName;
                addOn.ProgramDirectory = file;
            }

            addOns[dictKey] = addOn; //overwrite the existing addon in the dictionary with the updated model

        }

        private void tb_edmc_TextChanged(object sender, EventArgs e)
        {

        }

        internal static Dictionary<string, AddOn> DeserializeAddOns()
        {
            var Json = File.ReadAllText("AddOns.json");

            return JsonConvert.DeserializeObject<Dictionary<string, AddOn>>(Json,
                new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.Objects,
                    TypeNameAssemblyFormatHandling = TypeNameAssemblyFormatHandling.Simple
                });
        }

        internal static void SerializeAddons(object addOns)
        {
            var Json = JsonConvert.SerializeObject(addOns, Formatting.Indented, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Objects,
                TypeNameAssemblyFormatHandling = TypeNameAssemblyFormatHandling.Simple
            });

            File.WriteAllText("AddOns.json", Json);
        }

        /// <remarks>
        /// this would be better on the addon class, but you need access to updatestatus() etc.
        /// thats not impossible, but for now its here because I didn't have time lol
        /// </remarks>
        /// <param name="addOn"></param>
        private void LaunchAddon(AddOn addOn)
        {
            var path = $"{addOn.ProgramDirectory}/{addOn.ExecutableName}";

            if (File.Exists(path))
            {
                updatestatus($"Launching {addOn.FriendlyName}..");
                Process.Start(path);
            }
            else
            {
                updatestatus($"Unable to launch {addOn.FriendlyName}..");

            }
            System.Threading.Thread.Sleep(2000);

        }
    }
}

