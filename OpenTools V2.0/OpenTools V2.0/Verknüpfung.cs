using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IWshRuntimeLibrary;
using System.Windows.Forms;

namespace OpenTools_V2._0
{
    public static class Verknüpfung
    {
        /// <summary>
        /// Erstellt eine Desktopverknüpfung
        /// </summary>
        /// <param name="filepath"></param>
        public static void DesktopverknüpfungErstellen(string filepath)
        {
            string deskDir = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

            WshShell shell = new WshShell();
            IWshShortcut link = (IWshShortcut)shell.CreateShortcut(deskDir + "\\"+ System.IO.Path.GetFileNameWithoutExtension(filepath)+" - Toolgruppe" +".lnk");
            link.IconLocation = Application.StartupPath + "\\ToolgruppeIcon.ico";
            link.TargetPath = filepath;
            link.Save();
        }

        public static void VerknüpfungErstellen(string filepath, string path, string iconpath, string target)
        {
            
            WshShell shell = new WshShell();
            IWshShortcut link = (IWshShortcut)shell.CreateShortcut(path + "\\" + System.IO.Path.GetFileNameWithoutExtension(filepath) + ".lnk");
            link.IconLocation = iconpath;
            link.TargetPath = filepath;
            link.Arguments = target;
            link.Save();
        }
    }
}
