// This file is part of Emulators Organizer
// A program that can organize roms and emulators
// 
// Copyright © Alaa Ibrahim Hadid 2009 - 2021
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program.If not, see<http://www.gnu.org/licenses/>.
// 
// Author email: mailto:alaahadidfreeware@gmail.com
//
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using EmulatorsOrganizer.Services;
using EmulatorsOrganizer.Core;
using MMB;
namespace EmulatorsOrganizer.GUI
{
    public partial class PlaylistProperties : Form
    {
        public PlaylistProperties(string playlistID)
        {
            InitializeComponent();
            this.playlistID = playlistID;
            Trace.WriteLine("Loading property controls ...", "Playlist properties");
            Type[] types = Assembly.GetExecutingAssembly().GetTypes();
            foreach (Type tp in types)
            {
                if (tp.IsSubclassOf(typeof(IPlaylistPropertiesControl)))
                {
                    controls.Add(Activator.CreateInstance(tp) as IPlaylistPropertiesControl);
                }
            }
            controls.Sort(new PlaylistPropertiesControlComparer(true));
            foreach (IPlaylistPropertiesControl control in controls)
            {
                control.PlaylistID = playlistID;
                control.LoadSettings();
                listBox1.Items.Add(control.ToString());
            }
            listBox1.SelectedIndex = 0;
            Trace.WriteLine("Playlist property controls loaded successfully.", "Playlist properties");
        }
        private string playlistID;
        private List<IPlaylistPropertiesControl> controls = new List<IPlaylistPropertiesControl>();
        private ProfileManager profileManager = (ProfileManager)ServicesManager.GetService("Profile Manager");
        private LanguageResourcesService ls = (LanguageResourcesService)ServicesManager.GetService("EO Language Resources");

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            IPlaylistPropertiesControl control = controls[listBox1.SelectedIndex];
            control.Location = new Point(0, 0);
            string test = control.ToString();
            panel1.Controls.Add(control);

            label_desc.Text = control.Description;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        // OK
        private void button1_Click(object sender, EventArgs e)
        {
            Trace.WriteLine("Saving playlist properties ...", "Playlist properties");
            int index = 0;
            foreach (IPlaylistPropertiesControl control in controls)
            {
                if (control.CanSaveSettings)
                    control.SaveSettings();
                else
                {
                    Trace.TraceWarning("Unable to save properties !");
                    listBox1.SelectedIndex = index;
                    return;
                }
                index++;
            }
            profileManager.Profile.OnPlaylistPropertiesChanged(profileManager.Profile.Playlists[playlistID].Name);
            Trace.WriteLine("Playlist properties saved successfully.", "Playlist properties");
            Close();
        }
        // Defaults all
        private void button4_Click(object sender, EventArgs e)
        {
            foreach (IPlaylistPropertiesControl control in controls)
                control.DefaultSettings();
            Trace.WriteLine("All playlist properties reset to default.", "Playlist properties");
        }
        // Defaults
        private void button3_Click(object sender, EventArgs e)
        {
            controls[listBox1.SelectedIndex].DefaultSettings();
            Trace.WriteLine(controls[listBox1.SelectedIndex].ToString() + " properties reset to default.", "Playlist properties");
        }
    }
}
