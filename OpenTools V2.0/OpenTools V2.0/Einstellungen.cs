﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenTools_V2._0
{
    [Serializable]
    public class Einstellungen
    {
        public string path { get; set; }

        public bool autostart { get; set; }

        public string AutostartGruppe { get; set; }

        //Hotkey

        public bool alt { get; set; }
        public bool shift { get; set; }
        public bool steuerung { get; set; }
        public Keys key { get; set; }


        /// <summary>
        /// Speichert die Einstellungen.
        /// </summary>
        public void save()
        {

            System.IO.FileStream FS = new System.IO.FileStream(Application.StartupPath + "\\Einstellungen.einstellungen", System.IO.FileMode.Create);
            BinaryFormatter BF = new BinaryFormatter();

            BF.Serialize(FS, this);

            FS.Dispose();

        }

        /// <summary>
        /// Lädt die Einstellungen
        /// </summary>
        public Einstellungen load()
        {

            Einstellungen settings = new Einstellungen();

            System.IO.FileStream FS = new System.IO.FileStream(Application.StartupPath + "\\Einstellungen.einstellungen", System.IO.FileMode.Open);
            BinaryFormatter BF = new BinaryFormatter();

            settings = (Einstellungen)BF.Deserialize(FS);

            FS.Dispose();

            return settings;

        }

        public void setStandart()
        {
            path = "C:\\";

            alt = true;
            shift = false;
            steuerung = true;
            key = Keys.RMenu;

            autostart = true;

            save();
        }
    }
}
