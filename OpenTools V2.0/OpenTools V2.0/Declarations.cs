using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace ProcessListDemo
{
    [Serializable]
    public class Declarations
    {
        [DllImport("user32.dll")] //Die Position und Größe eines Fensters bestimmen
        public static extern long GetWindowRect(IntPtr hwnd, ref RECT lpRect);

        [DllImport("user32.dll")] //Prüfen, ob ein Fenster Sichtbar ist
        public static extern bool IsWindowVisible(IntPtr hWnd);

        [DllImport("user32.Dll")] //Alle offenen Fenster abrufen
        public static extern int EnumWindows(ProcessListDemo.Windows.WinCallBack x, int y);

        [DllImport("User32.Dll")] //Titel eines Fensters auslesen
        public static extern void GetWindowText(int h, StringBuilder s, int nMaxCount);

        [DllImport("User32.Dll")] //Die Klasse des Fensters besimmen
        public static extern void GetClassName(int h, StringBuilder s, int nMaxCount);


        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;

        }

        [Serializable]
        public struct Point
        {
            public int x;
            public int y;

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
    }
}
