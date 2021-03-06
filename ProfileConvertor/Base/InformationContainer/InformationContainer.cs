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

namespace AHD.EO.Base
{
    [Serializable()]
    public abstract class InformationContainer
    {
        public InformationContainer()
        { }
        public InformationContainer(string name)
        {
            Name = name;
        }

        string name = "";
        string id = "";
        InformationContainerLocation location = InformationContainerLocation.TopLeft;

        /// <summary>
        /// Get or set the name of this container
        /// </summary>
        public virtual string Name
        { get { return name; } set { name = value; id = name.ToLower(); } }
        /// <summary>
        /// Get or set the id of this container
        /// </summary>
        public virtual string ID
        { get { return id; } set { id = value; } }
        /// <summary>
        /// Get or set the tab location of this container
        /// </summary>
        public virtual InformationContainerLocation Location
        { get { return location; } set { location = value; } }
    }
}
