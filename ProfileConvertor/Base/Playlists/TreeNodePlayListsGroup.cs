/* This file is part of Emulators Organizer
   A program that can organize roms and emulators

   Copyright © Ali Hadid and Ala Hadid 2009 - 2013

   This program is free software: you can redistribute it and/or modify
   it under the terms of the GNU General Public License as published by
   the Free Software Foundation, either version 3 of the License, or
   (at your option) any later version.

   This program is distributed in the hope that it will be useful,
   but WITHOUT ANY WARRANTY; without even the implied warranty of
   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
   GNU General Public License for more details.

   You should have received a copy of the GNU General Public License
   along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AHD.EO.Base
{
    public class TreeNodePlayListsGroup : EOTreeNode
    {
        PlaylistsGroup gr;

        public PlaylistsGroup PlaylistsGroup
        { get { return gr; } set { gr = value; RefreshText(); } }

        public override void RefreshText()
        {
            this.Text = gr.Name;
        }

        public override void RefreshNodes()
        {
            this.Nodes.Clear();
            foreach (Playlist pl in gr.PlayLists)
            {
                TreeNodePlayList tr = new TreeNodePlayList();
                tr.Playlist = pl;
                this.Nodes.Add(tr);
            }
        }
    }
}
