using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProcessListDemo
{
    [Serializable]
    public class Window
    {
        public string winTitle { get; set; }        //Titel des Fensters
        public IntPtr winHandle { get; set; }       //Das Handle des Fensters
        public bool winVisible { get; set; }        //Gibt an, ob das Fenster sichtbar ist
        public ProcessListDemo.Declarations.Point winSize { get; set; } //Größe des Fenster
        public ProcessListDemo.Declarations.Point winPos { get; set; }  //Position des Fensters
        public string winClass { get; set; }        //Klasse des Fensters
        public WinType winType { get; set; }        //Bitte ignorieren, spielt für die Demo keine Rolle

        /// <summary>
        /// Gibt an, Welcher Art das Fenster ist da je nach Typ verschiedene Regeln gelten
        /// </summary>
        public enum WinType
        {
            Normal = 0,
            Explorer = 1
        }


        /// <summary>
        /// Erstellt eine neue Instanz der Klasse mit den angegebenen Paramrtern
        /// </summary>
        /// <param name="title">Der Titel des Fensters</param>
        /// <param name="handle">Das Fensterhandle des Fensters</param>
        /// <param name="classe">Die Klasse/Art des Fensters</param>
        /// <param name="isVisible">True wenn der Fenster minimiert ist</param>
        /// <param name="pos">Die Position des Fensters auf dem Bildschirm</param>
        /// <param name="size">Die Größe des Fensters</param>
        public Window(string title, IntPtr handle, string classe, bool isVisible, 
            ProcessListDemo.Declarations.Point pos, ProcessListDemo.Declarations.Point size, WinType type)
        {
            this.winTitle = title;
            this.winHandle = handle;
            this.winClass = classe;
            this.winVisible = isVisible;
            this.winPos = pos;
            this.winSize = size;
            this.winType = type;
        }
    }        
}
