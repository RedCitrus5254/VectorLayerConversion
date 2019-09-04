using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Windows.Forms;

namespace Cataloguer
{
    public class FolderBrowser
    {
        public static string ChooseFolder(IWin32Window owner)
        {
            if (Environment.OSVersion.Version.Major <= 5)
            {
                using (var folderBrowser = new FolderBrowserDialog())
                {
                    if (folderBrowser.ShowDialog(owner) == DialogResult.OK)
                    {
                        return folderBrowser.SelectedPath;
                    }
                }
            }
            else
            {
                using (CommonOpenFileDialog dialog = new CommonOpenFileDialog())
                {
                    dialog.IsFolderPicker = true;
                    if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                    {
                        return dialog.FileName;
                    }
                }
            }
            return null;
        }
    }
}
