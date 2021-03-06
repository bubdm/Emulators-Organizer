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
namespace EmulatorsOrganizer.Core
{
    /// <summary>
    /// Arguments for emulators refresh event
    /// </summary>
    public class RefreshEmulatorsArgs : EventArgs
    {
        /// <summary>
        /// Arguments for emulators refresh event
        /// </summary>
        /// <param name="emulatorIDs">The emulators to refresh (ids of emulators)</param>
        public RefreshEmulatorsArgs(string[] emulatorIDs)
        { this.emulatorIDs = emulatorIDs; }

        private string[] emulatorIDs;

        /// <summary>
        /// Get the emulators to refresh (ids of emulators) 
        /// </summary>
        public string[] EmulatorIDs
        { get { return emulatorIDs; } set { emulatorIDs = value; } }
    }
}
