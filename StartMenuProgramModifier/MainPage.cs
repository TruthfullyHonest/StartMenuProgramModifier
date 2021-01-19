using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace StartMenuProgramModifier
{
    public partial class FRM_SMPM : Form
    {
        // Represents the index we selected in out ListView
        int SearchIndex = -1;

        // Default drive for Windows devices always is C (Local Disk), we can go into the AppData and get the programs there
        string StartMenuDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Microsoft", "Windows", "Start Menu", "Programs");

        // Holds all the shortcut information for each shortcut we received
        List<MenuProgram> Programs = new List<MenuProgram>();

        public FRM_SMPM()
        {
            InitializeComponent();
        }

        private void FRM_SMPM_Load(object sender, EventArgs e)
        {
            LoadShortcuts(StartMenuDir);
        }

        private void LoadShortcuts(string directory)
        {
            // A foreach loop to iterate through every shortcut seen in the Start Menu location
            // Right now it only does the first level of traversal but not any subfolders within it
            foreach (string s in Directory.GetFiles(directory).Where(dir => !dir.Contains("desktop.ini")))
            {
                // Create a name that will be used as information
                string Name = s.Substring(s.LastIndexOf("\\") + 1);

                // Create a unique name specifically for the list view image keys
                string UniqName = Name + Properties.Settings.Default.CurrentProgramIndex++;

                // Add the information we obtained from each entry into our List
                // Arguments is empty for right now as I look more into this
                Programs.Add(new MenuProgram(Name, s, string.Empty));

                // Get the icon from the file at this location and add it into the list view and image list
                // Same with the name and unique name
                Icon ProgIcon = Icon.ExtractAssociatedIcon(s);
                IMGLST_Images.Images.Add(UniqName, ProgIcon);
                LSTVW_Shortcuts.Items.Add(Name, UniqName);
            }
        }

        private void BTN_LoadShortcut_Click(object sender, EventArgs e)
        {
            // We can select a program from our List data structure to load
            // Based on the index which we selected
            MenuProgram NewProg = Programs[SearchIndex];

            // We use the information from the MenuProgram object as information for the Process
            // Then put it into the process
            ProcessStartInfo ProStrt = new ProcessStartInfo(NewProg.GetLocation(), NewProg.GetArguments());
            Process NewProc = new Process();
            NewProc.StartInfo = ProStrt;

            // We start the process when everything is set up
            NewProc.Start();
        }

        private void LSTVW_Shortcuts_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            // This is used to represent the index which we selected, as ListViews do not have a property representing so
            SearchIndex = e.ItemIndex;
        }
    }
}
