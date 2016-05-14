using Associations;
using Microsoft.Win32;
using Org.Mentalis.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenTools_V2._0
{

    public class Program
    {

        public static bool LaunchedViaStartup { get; set; }

        [DllImport("Shell32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern void SHChangeNotify(uint wEventId, uint uFlags, IntPtr dwItem1, IntPtr dwItem2);

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        public static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Offenes OpenTools schließen.
            foreach (Process p in Process.GetProcessesByName("OpenTools V2.0"))
            {
                p.CloseMainWindow();
            }

            //TODO: Evtl. Fenster position des alten Fenster dem neuen geben


            Program.LaunchedViaStartup = args != null && args.Any(arg => arg.Equals("startup", StringComparison.CurrentCultureIgnoreCase));

            SetAssociation(".tg", "Toolgruppe", Application.ExecutablePath, "OpenTools V2.0 - Toolgruppe", Application.StartupPath + "\\ToolgruppeIcon.ico");

            if (args.Length == 0)
                {
                    Application.Run(new frmMain());

            }
            else{
                if(args[0] == "startup")
                {
                    Application.Run(new frmMain());

                }
                else {
                    Application.Run(new frmMain(args[0] + " " + args[1]));

                }


            }
           
        }
        public static void SetAssociation(string Extension, string KeyName, string OpenWith, string FileDescription, string iconpath)
        {
            RegistryKey BaseKey;
            RegistryKey OpenMethod;
            RegistryKey Shell;
            RegistryKey CurrentUser;

            BaseKey = Registry.ClassesRoot.CreateSubKey(Extension);
            BaseKey.SetValue("", KeyName);

            OpenMethod = Registry.ClassesRoot.CreateSubKey(KeyName);
            OpenMethod.SetValue("", FileDescription);
            OpenMethod.CreateSubKey("DefaultIcon").SetValue("", "\"" + iconpath + "\",0");
            Shell = OpenMethod.CreateSubKey("Shell");
            Shell.CreateSubKey("edit").CreateSubKey("command").SetValue("", "\"" + OpenWith + "\"" + " \"%1\"");
            Shell.CreateSubKey("open").CreateSubKey("command").SetValue("", "\"" + OpenWith + "\"" + " \"%1\"");
            BaseKey.Close();
            OpenMethod.Close();
            Shell.Close();

            //CurrentUser = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FileExts\\.arrr", true);
            //CurrentUser.DeleteSubKey("UserChoice", false);
            //CurrentUser.Close();

            // Tell explorer the file association has been changed
            SHChangeNotify(0x08000000, 0x0000, IntPtr.Zero, IntPtr.Zero);
        }
    }


    }

