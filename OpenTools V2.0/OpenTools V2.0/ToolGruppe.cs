﻿using OpenTools_V2._0.ToolgruppenElemente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace OpenTools_V2._0
{
    [Serializable]
    class ToolGruppe
    {
        public string name { get; set; }

        public List<Datei> Dateien = new List<Datei>();
        public List<Ordner> Ordner = new List<Ordner>();
        public List<Internetseite> Internetseiten = new List<Internetseite>();

        /// <summary>
        /// Speichert die Toolgruppe.
        /// </summary>
        /// <param name="path"></param>
        public void save(string path)
        {

            System.IO.FileStream FS = new System.IO.FileStream(path, System.IO.FileMode.Create);
            BinaryFormatter BF = new BinaryFormatter();

            BF.Serialize(FS, this);

            FS.Dispose();


        }

        /// <summary>
        /// Lädt eine Toolgruppe und gibt diese zurück.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public ToolGruppe load(string path)
        {

            ToolGruppe t = new ToolGruppe();

            System.IO.FileStream FS = new System.IO.FileStream(path, System.IO.FileMode.Open);
            BinaryFormatter BF = new BinaryFormatter();

            t = (ToolGruppe)BF.Deserialize(FS);

            FS.Dispose();

            return t;

        }

    }
}
