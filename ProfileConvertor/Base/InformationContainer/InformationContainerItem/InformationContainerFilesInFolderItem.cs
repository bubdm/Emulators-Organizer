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
using System.Xml.Serialization;
namespace AHD.EO.Base
{
    [Serializable()]
    public class InformationContainerFilesInFolderItem : InformationContainerItem
    {
        public InformationContainerFilesInFolderItem()
            : base()
        { }
        public InformationContainerFilesInFolderItem(string id) :
            base(id)
        { }
        List<string> files = new List<string>();

        /// <summary>
        /// Get or set the files collection
        /// </summary>
        public List<string> Files
        { get { return files; } set { files = value; } }
    }
}
