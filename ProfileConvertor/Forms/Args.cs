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

namespace AHD.Forms
{
    /// <summary>
    /// Args used for "find" or "find and replace" events
    /// </summary>
    public class FindAndReplaceArgs : EventArgs
    {
        string findWhat = "";
        string replaceWith = "";
        bool matchCase = false;
        bool matchWholeWord = false;
        bool all = false;
        /// <summary>
        /// Args used for "find" or "find and replace" events 
        /// </summary>
        /// <param name="findWhat">The find word</param>
        /// <param name="replaceWith">The word that should replace the dind one, set to null if you want to find only</param>
        /// <param name="matchCase">Is match case option is set</param>
        /// <param name="matchWholeWord">Is match whole word option is set</param>
        /// <param name="all">If set, search all (or replace all)</param>
        public FindAndReplaceArgs(string findWhat, string replaceWith, bool matchCase, bool matchWholeWord, bool all)
        {
            this.findWhat = findWhat;
            this.replaceWith = replaceWith;
            this.matchCase = matchCase;
            this.matchWholeWord = matchWholeWord;
            this.all = all;
        }
        /// <summary>
        /// Find what string
        /// </summary>
        public string FindWhat
        { get { return findWhat; } set { findWhat = value; } }
        /// <summary>
        /// The replace word, will be null if Find only
        /// </summary>
        public string ReplaceWith
        { get { return replaceWith; } set { replaceWith = value; } }
        /// <summary>
        /// Get if match case option is set
        /// </summary>
        public bool MatchCase
        { get { return matchCase; } set { matchCase = value; } }
        /// <summary>
        /// Get if match whole word option is set
        /// </summary>
        public bool MatchWholeWord
        { get { return matchWholeWord; } set { matchWholeWord = value; } }
        /// <summary>
        /// If set, search all (or replace all)
        /// </summary>
        public bool All
        { get { return all; } }
    }
    public class EnterNameFormOkPressedArgs : EventArgs
    {
        bool cancel;
        string nameEntered = "";
        public EnterNameFormOkPressedArgs(string nameEntered)
        { this.nameEntered = nameEntered; }
        public bool Cancel
        { get { return cancel; } set { cancel = value; } }
        public string NameEntered
        { get { return nameEntered; } }
    }
}
