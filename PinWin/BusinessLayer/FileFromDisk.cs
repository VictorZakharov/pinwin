using System;
using System.Windows.Forms;

namespace PinWin.BusinessLayer
{
    public class FileFromDisk
    {
        public static string Select(IWin32Window parent)
        {
            var fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = Environment.CurrentDirectory;
            var dialogResult = fileDialog.ShowDialog(parent);
            if (dialogResult != DialogResult.OK)
            {
                return null;
            }

            string selectedAbsolutePath = fileDialog.FileName;
            string selectedRelativePath = RelativePath.Get(Environment.CurrentDirectory, selectedAbsolutePath);
            if (selectedRelativePath.Length < fileDialog.FileName.Length)
            {
                // if relative path is more optimal = fewer characters, use it
                return selectedRelativePath;
            }

            return selectedAbsolutePath;
        }
    }
}
