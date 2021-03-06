﻿#region License Information (GPL v3)

/*
    ShareX - A program that allows you to take screenshots and share any file type
    Copyright (C) 2007-2014 ShareX Developers

    This program is free software; you can redistribute it and/or
    modify it under the terms of the GNU General Public License
    as published by the Free Software Foundation; either version 2
    of the License, or (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program; if not, write to the Free Software
    Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.

    Optionally you can also view the license at <http://www.gnu.org/licenses/>.
*/

#endregion License Information (GPL v3)

using HelpersLib;
using System;
using System.Windows.Forms;

namespace ShareX
{
    public partial class ClipboardFormatForm : Form
    {
        public ClipboardFormat ClipboardFormat { get; private set; }

        public ClipboardFormatForm()
            : this(new ClipboardFormat())
        {
        }

        public ClipboardFormatForm(ClipboardFormat cbf)
        {
            InitializeComponent();
            ClipboardFormat = cbf;
            txtDescription.Text = cbf.Description ?? "";
            txtFormat.Text = cbf.Format ?? "";
            CodeMenu.Create<ReplCodeMenuEntry>(txtFormat);
            lblExample.Text = "Supported variables: $result, $url, $shorturl, $thumbnailurl, $deletionurl, $filepath, $filename, $filenamenoext, $thumbnailfilename, $thumbnailfilenamenoext, $folderpath, $foldername, $uploadtime and other variables such as %y-%mo-%d etc.";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ClipboardFormat.Description = txtDescription.Text;
            ClipboardFormat.Format = txtFormat.Text;
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}