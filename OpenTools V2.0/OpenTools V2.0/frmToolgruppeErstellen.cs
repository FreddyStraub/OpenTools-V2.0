using OpenTools_V2._0.ToolgruppenElemente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenTools_V2._0
{
    public partial class frmToolgruppeErstellen : Form
    {
        Einstellungen einstellungen = new Einstellungen();


        ToolGruppe toolgruppe = new ToolGruppe();

        public List<Datei> Dateien = new List<Datei>();
        public List<Ordner> Ordner = new List<Ordner>();

        public frmToolgruppeErstellen()
        {
            InitializeComponent();
        }

        private void bAbbrechen_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmToolgruppeErstellen_Load(object sender, EventArgs e)
        {
            einstellungen = einstellungen.load();
        }
        private void bFertig_Click(object sender, EventArgs e)
        {

            toolgruppe.Dateien = Dateien;
            toolgruppe.Ordner = Ordner;


            toolgruppe.save(einstellungen.path + "\\OpenTools V2.0\\" + textBox1.Text + ".tg");

        }

        #region Datei
        Process processDateien;
        /// <summary>
        /// Fügt eine Datei zur Toolgruppe hinzu.
        /// </summary>
        /// <param name="path"></param>
        private void dateiHinzufügen(string path)
        {
            processDateien = new Process();
            processDateien.StartInfo = new ProcessStartInfo(path);
            processDateien.EnableRaisingEvents = true;

            processDateien.Start();

            if (MessageBox.Show("Fenster positioniert?", "OpenTools V2.0", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
            {
                ProcessListDemo.Windows win = new ProcessListDemo.Windows();

                //Neue Datei erstellen und Pfad mitgeben 
                Datei d = new Datei(ofdDatei.FileName);

                Dateien.Add(d);
                listDateien.Items.Add(d.name);


                //Window settings hinzufügen;
                foreach (ProcessListDemo.Window w in win.lstWindows)
                {
                    if (w.winHandle == processDateien.MainWindowHandle)
                    {
                        //Fenstereigenschaften werden an Datei übergeben
                        d.WindowSettings = w;
                    }
                }

            }

            processDateien.CloseMainWindow();


        }
        /// <summary>
        /// Ausgewählte Dateien löschen.
        /// </summary>
        private void dateienLöschen()
        {

            if (listDateien.SelectedItems.Count != 0)
            {

                foreach (string s in listDateien.SelectedItems)
                {

                    Dateien.Remove(Dateien[listDateien.Items.IndexOf(s)]);
                    listDateien.Items.Remove(s);

                }

            }

        }

        //Hinzufügen
        private void bDateiHinzufügen_Click(object sender, EventArgs e)
        {
            if (ofdDatei.ShowDialog() == DialogResult.OK)
                dateiHinzufügen(ofdDatei.FileName);

        }
        private void hinzufügenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofdDatei.ShowDialog() == DialogResult.OK)
                dateiHinzufügen(ofdDatei.FileName);

        }

        //Löschen
        private void bDateiEntfernen_Click(object sender, EventArgs e)
        {
            dateienLöschen();
        }
        private void entfernenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dateienLöschen();
        }

        #endregion
        #region Ordner


        /// <summary>
        /// Fügt einen Ordner hinzu.
        /// </summary>
        /// <param name="path"></param>
        private void ordnerHinzufügen(string path)
        {
            IntPtr Handle = new IntPtr();
            WindowManager wm = new WindowManager();
            Handle = wm.OpenFolderGetHandle(path);

            if (MessageBox.Show("Fenster positioniert?", "OpenTools V2.0", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
            {
                ProcessListDemo.Windows win = new ProcessListDemo.Windows();

                //Neuen Ordner erstellen und Pfad mitgeben 
                Ordner o = new Ordner(path);

                
                //Window settings hinzufügen;
           
                //    string xs = "";

                foreach (ProcessListDemo.Window w in win.lstWindows)
                {

       
                   // xs += "\n" + w.winTitle + "\n" + w.winHandle;

                    if (w.winHandle == Handle)
                    {
                        //Fenstereigenschaften werden an Ordner übergeben
                        o.WindowSettings = w;


                    }
                }
                Ordner.Add(o);
                listOrdner.Items.Add(o.name);

          // MessageBox.Show(xs);

            }

        }

        /// <summary>
        /// Löscht die ausgewählten Ordner
        /// </summary>
        private void ordnerLöschen()
        {

            if (listOrdner.SelectedItems.Count != 0)
            {

                foreach (string s in listOrdner.SelectedItems)
                {
                    Ordner.Remove(Ordner[listOrdner.Items.IndexOf(s)]);
                    listOrdner.Items.Remove(s);

                }

            }

        }

        //Löschen
        private void bOrdnerLöschen_Click(object sender, EventArgs e)
        {
            ordnerLöschen();
        }
        private void entfernenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ordnerLöschen();
        }

        //Hinzufügen

        private void bOrdnerHinzufügen_Click(object sender, EventArgs e)
        {
            if(fbdOrdner.ShowDialog() == DialogResult.OK)
            {
                ordnerHinzufügen(fbdOrdner.SelectedPath);
            }
        }
        private void hinzufügenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (fbdOrdner.ShowDialog() == DialogResult.OK)
            {
                ordnerHinzufügen(fbdOrdner.SelectedPath);
            }

        }

        #endregion
    }
}
