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
using System.Windows.Forms;

namespace EmulatorsOrganizer.GUI
{
    public partial class Form_ApplyNames : Form
    {
        public Form_ApplyNames()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }
        public bool RenameRelatedFiles
        { get { return checkBox_renameRelatedFiles.Checked; } }
        public Form_RenameRoms.RenameingMethod RenameingMethodChosen
        {
            get { return (Form_RenameRoms.RenameingMethod)comboBox1.SelectedIndex; }
        }
        private void checkBox_renameRelatedFiles_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = checkBox_renameRelatedFiles.Checked;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        // Ok
        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }
    }
}
