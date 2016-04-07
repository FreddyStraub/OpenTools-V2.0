using OpenTools_V2._0.ToolgruppenElemente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
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

        #region Datei
        Process p;
        /// <summary>
        /// Fügt eine Datei zur Toolgruppe hinzu.
        /// </summary>
        /// <param name="path"></param>
        private void dateiHinzufügen(string path)
        {
                p = new Process();
                p.StartInfo = new ProcessStartInfo(path);
                p.EnableRaisingEvents = true;

                p.Start();

            if(MessageBox.Show("Fenster positioniert?", "OpenTools V2.0", MessageBoxButtons.OK,MessageBoxIcon.Question) == DialogResult.OK)
            {
                ProcessListDemo.Windows win = new ProcessListDemo.Windows();

                //Neue Datei erstellen und Pfad mitgeben 
                Datei d = new Datei(openFileDialog1.FileName);

                Dateien.Add(d);
                listDateien.Items.Add(d.name);


                //Window settings hinzufügen;
                foreach (ProcessListDemo.Window w in win.lstWindows)
                {
                    if (w.winHandle == p.MainWindowHandle)
                    {
                        //Fenstereigenschaften werden an Datei übergeben
                        d.WindowSettings = w;
                    }
                }

            }

            p.CloseMainWindow();


        }
        /// <summary>
        /// Ausgewählte Dateien löschen.
        /// </summary>
        private void dateienLöschen()
        {

            if(listDateien.SelectedItems.Count != 0)
            {

                foreach(string s in listDateien.SelectedItems)
                {

                    Dateien.Remove(Dateien[listDateien.Items.IndexOf(s)]);
                    listDateien.Items.Remove(s);

                }

            }

        }

        private void bDateiHinzufügen_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
                dateiHinzufügen(openFileDialog1.FileName);

        }
        private void hinzufügenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                dateiHinzufügen(openFileDialog1.FileName);

        }

        private void bDateiEntfernen_Click(object sender, EventArgs e)
        {
            dateienLöschen();
        }
        private void bOrdnerLöschen_Click(object sender, EventArgs e)
        {
            dateienLöschen();
        }

        #endregion

        private void bFertig_Click(object sender, EventArgs e)
        {

            toolgruppe.Dateien = Dateien;

            toolgruppe.save(einstellungen.path + "\\OpenTools V2.0\\" + textBox1.Text + ".tg");

        }
    }
}
