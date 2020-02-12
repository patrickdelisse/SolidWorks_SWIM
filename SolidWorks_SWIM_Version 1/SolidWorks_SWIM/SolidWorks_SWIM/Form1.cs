using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using Microsoft.Win32;
using System.Reflection;


[assembly: AssemblyVersionAttribute("1.0.1")]

/// <summary>
/// Program reads a XML file and filles two listboxes with NX version and CustomGroup
/// If settings in registry are availible, then these values are highlighted in the listboxes if they occur there
/// When user made a selection and chooses Save, the selected values are stored in the registry
/// The startup script for NX in teamcenter environment pickes these values from the registry
/// </summary>
namespace TC_NX_Launch
{
    public partial class Form1 : Form
    {
        #region Define and Set Variables

        const string XML_File = "SolidWorks_SWIM_settings.xml";
        const string Help_File = "SolidWorks_SWIM.pdf";
        public string SW_desktop_shortcut = null;
        public string SW_AppName = null;
        public string TC_Server = null;
        public string TC_BatFile = null;
        public string SW_para_portal = null;
        public string TC_FIXED_SWVer = null; //Fixed SW version for Teamcenter Produktion Database
        public string _defver = null;



        public string Editor = null;

        public int ListAppSelected = 0;
        public int ListGroupSelected = 0;

        public bool TC_FIXED_SW = false; //Fixed NX version for Teamcenter Produktion Database
        public bool Splash = false;
        const string userRoot = "HKEY_CURRENT_USER";
        const string subkey = "Software\\KMWE\\SW_Select\\Defaults";
        const string keyName = userRoot + "\\" + subkey;
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CancelButton = Cancel;
            logo.Image = global::SolidWorks_SWIM.Properties.Resources.logo;

            RegistryRead();
            ArangeWindow_Normal();
            SelectionHide();
            ReadSettings();


            if (!(File.Exists(TC_Server + "\\" + TC_BatFile))) //If batfile does not exist
            {
                MessageBox.Show("Cannot find the startup script.\n\n" + TC_Server + "\\" + TC_BatFile + "\n\nCheck network connections.", "Startup Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Afsluiten();
            }
                
            // Check if needed and copy native NX shortcut to desktop
            SW_desktop_shortcut = "KMWE - SolidWorks SWIM.lnk";
            string source_shrtct = Path.GetDirectoryName(Application.ExecutablePath) + "\\..\\" + SW_desktop_shortcut;
            string destin_shrtct = Environment.GetEnvironmentVariable("USERPROFILE") + "\\Desktop\\" + SW_desktop_shortcut;
            if (!(File.Exists(destin_shrtct)))
            {
                try
                {
                    File.Copy(source_shrtct, destin_shrtct, true);
                }
                catch { }
            }

        }

        // Closing Application
        private void Afsluiten()
        {
            Cancel_Click("Afsluiten", null);
        }

        /// <summary>
        /// Arange the window as the regular interface
        /// </summary>
        private void ArangeWindow_Normal()
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            panelselect.Location = paneloverview.Location;
            Foldup.Location = Folddown.Location;
            this.Height = paneloverview.Top + paneloverview.Height + 75;
            
            Splash = false;

            // Get the version of the current assembly.
            Assembly assem = typeof(Form1).Assembly;
            AssemblyName assemName = assem.GetName();
            Version ver = assemName.Version;

            LBL_AppVersion.Text = assemName.Name + " - version: " + ver.ToString();
        }

        // Button Cancel
        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// If no NX version was selected or read from the registry, disable the launch button
        /// </summary>
        private void Check_NX()
        {
            if (ListAppSelected == 0) 
            {
                LAUNCH_NX.Enabled = false;
                LAUNCH_NX.Image = global::SolidWorks_SWIM.Properties.Resources.swimdim;
            }
            else
            {
                LAUNCH_NX.Enabled = true;
                LAUNCH_NX.Image = global::SolidWorks_SWIM.Properties.Resources.swim1;
            }
            
            if (TC_FIXED_SW)
            {
                if (!(SW_AppName == TC_FIXED_SWVer))
                {
                    LAUNCH_NX.Enabled = false;
                    label4.Visible = false;
                    LBL_TC_Server.Visible = false;
                    LAUNCH_NX.Image = global::SolidWorks_SWIM.Properties.Resources.swimdim;
                    LBL_Fixed_NX.Visible = true;
                    LBL_Fixed_NX.Text = "Only SW " + TC_FIXED_SWVer + " allowed";
                }
                else
                {
                    LBL_Fixed_NX.Visible = false;
                    label4.Visible = true;
                    LBL_TC_Server.Visible = true;

                }
            }
        }

        /// <summary>
        /// Execute specified process
        /// </summary>
        private void ExecuteIt(string arg, string process, string name)
        {
                Process compiler = new Process();
                compiler.StartInfo.FileName = TC_Server + "\\" + TC_BatFile;
                compiler.StartInfo.Arguments = arg;
                compiler.StartInfo.UseShellExecute = false;
                compiler.StartInfo.RedirectStandardOutput = false;
                compiler.Start();
                compiler.WaitForExit();
        }

        /// <summary>
        /// Button folddown
        /// </summary>
        private void Folddown_Click(object sender, EventArgs e)
        {
            SelectionShow(); // Show NX App and Group selection window
        }

        /// <summary>
        /// Button foldup
        /// </summary>
        private void Foldup_Click(object sender, EventArgs e)
        {
            SelectionHide(); // Hide NX App and Group selection window
        }

        /// <summary>
        /// When selection is made in App list
        /// </summary>
        private void ListApp_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListAppSelected = ListApp.SelectedIndex + 1;
            SW_AppName = ListApp.SelectedItem.ToString();
            Lbl_NX_versie.Text = SW_AppName;
            SelectionHide();
        }

        // Set Focus to and highlight Launch
        private void LAUNCH_NX_MouseEnter(object sender, EventArgs e)
        {
            LAUNCH_NX.FlatAppearance.BorderSize = 1;
            LAUNCH_NX.BackColor = Color.FromArgb(40, 40, 40);
            LAUNCH_NX.Focus();
            LAUNCH_NX.Select();
        }

        /// <summary>
        /// Save Settings, Launch SW and close
        /// </summary>
        private void LAUNCH_NX_Click(object sender, EventArgs e)
        {
            RegistrySave();
            ExecuteIt(SW_para_portal, "SWIM", "SolidWorks");

            Afsluiten();
        }

        /// <summary>
        /// Show or hide settings
        /// </summary>
        private void NXbar_Click(object sender, EventArgs e)
        {
            if (Folddown.Visible)
            {
                Folddown_Click("NXBar", null);
            }
            else
            {
                Foldup_Click("NXBar", null);
            }
        }

        /// <summary>
        /// Read in all settings from XML file and build selection lists
        /// </summary>
        private void ReadSettings()
        {
            int indx = 0;
            string Regel = null;
            ListApp.Items.Clear();

            try
            {
                using (StreamReader FStream = new StreamReader(Path.GetDirectoryName(Application.ExecutablePath) + "\\" + XML_File))
                {
                    while (FStream.Peek() >= 0)
                    {
                        Regel = FStream.ReadLine();
                        if (!(Regel.IndexOf("<SW_AppName>") == -1)) //NX application, add to list, if installed
                        {
                            SW_AppName = Regel.Replace("<SW_AppName>", "").Replace("</SW_AppName>", "").Trim();
                            ListApp.Items.Add(SW_AppName);
                            indx = ListApp.Items.Count - 1;
                            if (_defver == SW_AppName)
                            {
                                ListAppSelected = indx + 1;
                            }
                        }
                        if (!(Regel.IndexOf("<TC_server>") == -1)) //Teamcenter server
                        {
                            TC_Server = Regel.Replace("<TC_server>", "").Replace("</TC_server>", "").Trim();
                            LBL_TC_Server.Text = TC_Server.Replace("\\", "");
                        }
                        if (!(Regel.IndexOf("<TC_bat>") == -1)) //Teamcenter startup batch-file
                        {
                            TC_BatFile = Regel.Replace("<TC_bat>", "").Replace("</TC_bat>", "").Trim();
                        }
                        if (!(Regel.IndexOf("<SW_portal>") == -1)) //Startup argument for batch-file
                        {
                            SW_para_portal = Regel.Replace("<SW_portal>", "").Replace("</SW_portal>", "").Trim();
                        }
                        if (!(Regel.IndexOf("<TC_FixedSW>") == -1)) //Startup argument for batch-file
                        {
                            if (Regel.Replace("<TC_FixedSW>", "").Replace("</TC_FixedSW>", "").Trim() == "yes")
                            {
                                TC_FIXED_SW = true;
                            }
                        }
                        if (!(Regel.IndexOf("<TC_FixedSWver>") == -1)) //Startup argument for batch-file
                        {
                            TC_FIXED_SWVer = Regel.Replace("<TC_FixedSWver>", "").Replace("</TC_FixedSWver>", "").Trim();
                        }

                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "File not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Afsluiten();
            }

            if (!(ListAppSelected == 0)) //If a default version -last saved- was found, highlight it
            {
                ListApp.SetSelected(ListAppSelected - 1, true);
            }
            Check_NX();
        }

        /// <summary>
        /// Settings from registry 'Computer\HKEY_CURRENT_USER\Software\KMWE\NX_Select\Defaults'
        /// </summary>
        public void RegistryRead()
        {
            try
            {
                _defver = (string)Registry.GetValue(keyName, "SWversion", "");
            }
            catch
            {
            }
        }

        /// <summary>
        /// Save NX App and Group to registry 'Computer\HKEY_CURRENT_USER\Software\KMWE\NX_Select\Defaults'
        /// </summary>
        private void RegistrySave()
        {
            if (!(ListAppSelected == 0)) //Only save if a SW version is selected
            {
                 try
                {
                    Registry.SetValue(keyName, "SWversion", SW_AppName);
                }
                catch {}
            }
        }

        /// <summary>
        /// Hide the NX app and custopmgroup selection window
        /// </summary>
        private void SelectionHide()
        {
            panelselect.Visible = false;
            paneloverview.Visible = true;
            Foldup.Visible = false;
            Folddown.Visible = true;
            LBL_TC_Server.Visible = true;
            Check_NX();
        }

        /// <summary>
        /// Hide the NX app and custopmgroup selection window
        /// </summary>
        private void SelectionShow()
        {
            panelselect.Visible = true;
            paneloverview.Visible = false;
            Foldup.Visible = true;
            Folddown.Visible = false;
            LBL_TC_Server.Visible = false;
        }

        /// <summary>
        /// Open the settings file in an editor
        /// </summary>
        private void SettingsEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Be carefull when editing settings. This will have impact on every SolidWorks user", "Be carefull", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            string Editor = null;
            string editor = "c:\\windows\\notepad.exe";
            if (File.Exists(editor))
            {
                Editor = editor;
            }
            editor = "C:\\Program Files (x86)\\Notepad++\\notepad++.exe";
            if (File.Exists(editor))
            {
                Editor = editor;
            }
            editor = "C:\\Program Files\\Notepad++\\notepad++.exe";
            if (File.Exists(editor))
            {
                Editor = editor;
            }

            if (!(Editor == null))
            {
                Process myProcess = new Process();
                ProcessStartInfo myProcessStartInfo = new ProcessStartInfo(Editor, Path.GetDirectoryName(Application.ExecutablePath) + "\\" + XML_File)
                {
                    UseShellExecute = false,
                    RedirectStandardError = true
                };
                myProcess.StartInfo = myProcessStartInfo;
                myProcess.Start();
                string error = myProcess.StandardError.ReadToEnd();
                myProcess.WaitForExit();

                ReadSettings();
            }
        }


        /// <summary>
        /// Show of Hide most controls
        /// </summary>
        /// <param name="state"></param>
        private void ShowHide_others(bool state)
        {
            panel2.Visible = state;
            paneloverview.Visible = state;
            NXbar.Visible = state;
            label3.Visible = state;
            LBL_TC_Server.Visible = state;
            Foldup.Visible = state;
            Folddown.Visible = state;
        }

        private void LBL_AppVersion_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(Path.GetDirectoryName(Application.ExecutablePath) + "\\" + Help_File);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message + "\n" + Help_File, "File not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
