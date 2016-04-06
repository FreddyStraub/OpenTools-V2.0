using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Runtime.InteropServices;
using ProcessListDemo;


namespace ProcessListDemo
{
    public class Windows
    {
        /// <summary>
        /// Beinhaltet alle zur Zeit geöffneten und Minimierten Fenster
        /// </summary>
        public LinkedList<Window> lstWindows { get; set; }

        /// <summary>
        /// Erstellt eine neue Windows-Klasse und ließt die Informationen
        /// über alle verfügbaren Fenster aus
        /// </summary>
        public Windows()
        {
            lstWindows = new LinkedList<Window>();

            getWindows();
        }

        /// <summary>
        /// Delegate Funktion für EnumWindows (Siehe Declarations)
        /// Gibt die Werte an EnumWindowCallBack weiter
        /// </summary>
        /// <param name="hwnd">Fensterhandle</param>
        /// <param name="lParam">Nicht benutzt bitte 0 angeben</param>
        /// <returns>Bei Erfolg True</returns>
        public delegate bool WinCallBack(int hwnd, int lParam);

        private void getWindows()
        {
            //Liste mit Fenstern befüllen
            ProcessListDemo.Declarations.EnumWindows(new WinCallBack(EnumWindowCallBack), 0);
           
        }

        /// <summary>
        /// Gibt die Anzahl gefundener Fenster zurück
        /// </summary>
        /// <returns>Integer mit der Anahl der Fenster</returns>
        public int winCount()
        {
            return lstWindows.Count();
        }

        /// <summary>
        /// Diese Funktion wird durch die Delegate Funktion WinCallBack aufgerufen
        /// und iteriert durch alle zur Zeit geöffneten Fenster
        /// </summary>
        /// <param name="hwnd">Erhält den Fensterhandle</param>
        /// <param name="lParam">Diese Variable ist ungenutzt!</param>
        /// <returns>Bei Erfolg gibt diese Funktion True zurück</returns>
        private bool EnumWindowCallBack(int hwnd, int lParam)
        {
            IntPtr windowHandle = (IntPtr)hwnd;

            StringBuilder sb = new StringBuilder(1024);
            StringBuilder sbc = new StringBuilder(256);

            ProcessListDemo.Declarations.GetClassName(hwnd, sbc, sbc.Capacity);
            ProcessListDemo.Declarations.GetWindowText((int)windowHandle, sb, sb.Capacity);

            //Nur Prozesse mit einer Beschreibung, also einem Fenster bearbeiten
            if (sb.Length > 0)
            {
                ProcessListDemo.Declarations.RECT r = new ProcessListDemo.Declarations.RECT(); //Fensterposition & Größe bestimmen:
                ProcessListDemo.Declarations.GetWindowRect(windowHandle,ref r);
              

                Window w = new Window(  sb + "",
                                        windowHandle,
                                        sbc + "",
                                        ProcessListDemo.Declarations.IsWindowVisible(windowHandle),
                                        new ProcessListDemo.Declarations.Point(r.Left, r.Top),
                                        new ProcessListDemo.Declarations.Point(r.Right - r.Left, r.Bottom - r.Top),
                                        Window.WinType.Normal);
                this.lstWindows.AddLast(w);
            }
            return true;
        }
    }
}
