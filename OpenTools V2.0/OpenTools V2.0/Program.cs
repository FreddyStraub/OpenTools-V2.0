using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenTools_V2._0
{

    public class Program
    {

        [DllImport("Shell32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern void SHChangeNotify(uint wEventId, uint uFlags, IntPtr dwItem1, IntPtr dwItem2);


        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        public static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if(!isAsssociated())
                Associate();

            if (args.Length == 0)
            {
                Application.Run(new frmMain());

            }
            else
            {
                Application.Run(new frmMain(args[0] + " " + args[1]));

            }

        }

        public static bool isAsssociated()
        {
            return (Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FileExts\\.tg", false) == null);
        }

        static RegistryKey fileReg = Registry.CurrentUser.CreateSubKey("Software\\Classes\\.tg");
        static RegistryKey appReg = Registry.CurrentUser.CreateSubKey("Software\\Classes\\Applications\\OpenTools V2.0.exe\\Explorer\\.tg");
        static RegistryKey appAsoc = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FileExts\\.tg");

        public static void Associate()
        {


            fileReg.CreateSubKey("DefaultIcon").SetValue("", Application.StartupPath + "\\ToolgruppeIcon.ico");
            fileReg.CreateSubKey("PreceivedType").SetValue("", "Toolgrupe");

            appReg.CreateSubKey("shell\\open\\command").SetValue("", "\"" + Application.ExecutablePath + "\" %1");
            appReg.CreateSubKey("shell\\edit\\command").SetValue("", "\"" + Application.ExecutablePath + "\" %1");
            appReg.CreateSubKey("DefaultIcon").SetValue("", Application.StartupPath + "\\ToolgruppeIcon.ico");

            appAsoc.CreateSubKey("UserChoice").SetValue("Progid", "Applications\\OpenTools V2.0.exe");
            SHChangeNotify(0x08000000, 0x0000, IntPtr.Zero, IntPtr.Zero);


        }


    }
}
