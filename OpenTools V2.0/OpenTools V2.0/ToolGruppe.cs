using OpenTools_V2._0.ToolgruppenElemente;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        /// <summary>
        /// Startet die Toolgruppe.
        /// </summary>
        public void run()
        {
            #region Dateien

            foreach (Datei d in Dateien)
            {
                try {
                    //Startet die Datei
                    Process p = new Process();
                    p.StartInfo = new ProcessStartInfo(d.path);
                    p.Start();

                    WindowManager wm = new WindowManager();

                    Thread.Sleep(150);


                    //Schiebt das Fenster an die passende Position
                    try {
                        wm.moveWindow(p.MainWindowHandle, d.WindowSettings.winPos.x, d.WindowSettings.winPos.y, d.WindowSettings.winSize.x, d.WindowSettings.winSize.y);
                    }
                    catch { }

                }catch{

                    MessageBox.Show("Die Datei " + d.path + " konnte nicht gestartet werden!", "OpenTools V2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

            #endregion

            #region Ordner
            foreach (Ordner o in Ordner)
            {
                try {
                    //Startet den Ordner
                    WindowManager wm = new WindowManager();
                    Process p = new Process();
                    p.StartInfo = new ProcessStartInfo(o.path);
                    p.Start();

                    Thread.Sleep(150);


                    IntPtr Handle = wm.getFolderHandle(o.path); //Handler des Explorerfensteres mit dem passenen Ordner

                    //Schiebt das Fenster an die passende Position
                    wm.moveWindow(Handle, o.WindowSettings.winPos.x, o.WindowSettings.winPos.y, o.WindowSettings.winSize.x, o.WindowSettings.winSize.y);

                }
                catch
                {

                    MessageBox.Show("Der Ordner " + o.path + " konnte nicht geöffnet werden!", "OpenTools V2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
            }

            #endregion

            #region Inernetseite
            foreach (Internetseite i in Internetseiten)
            {
                try {
                    Process.Start(i.url);
                }
                catch
                {
                    MessageBox.Show("Die Internetseite " + i.url + " konnte nicht gestartet werden!", "OpenTools V2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            #endregion
        }

    }
}
