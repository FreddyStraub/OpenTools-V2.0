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
    public partial class frmToolgruppeBearbeiten : Form
    {

        Einstellungen einstellungen = new Einstellungen();

        ToolGruppe toolgruppe = new ToolGruppe();

        public List<Datei> Dateien = new List<Datei>();
        public List<Ordner> Ordner = new List<Ordner>();
        public List<Internetseite> Internetseiten = new List<Internetseite>();
        
        public frmToolgruppeBearbeiten(ToolGruppe toolgruppe)
        {
            InitializeComponent();

            einstellungen = einstellungen.load();

            this.toolgruppe = toolgruppe;

            textBox1.Text = toolgruppe.name;

            loadDateien();
            loadOrdner();
            loadInternetseiten();
            
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

            try
            {

                processDateien.Start();

                if (MessageBox.Show("Fenster positioniert?", "OpenTools V2.0", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    ProcessListDemo.Windows win = new ProcessListDemo.Windows();

                    //Neue Datei erstellen und Pfad mitgeben 
                    Datei d = new Datei(path);


                    //Window settings hinzufügen;
                    foreach (ProcessListDemo.Window w in win.lstWindows)
                    {

                        try
                        {

                            if (w.winHandle == processDateien.MainWindowHandle)
                            {
                                //Fenstereigenschaften werden an Datei übergeben
                                d.WindowSettings = w;

                            }
                        }
                        catch
                        {
                            //TODO: Vielleicht gibts ja ne Lösung für die Fensterpositionen xD


                        }
                    }

                    Dateien.Add(d);
                    listDateien.Items.Add(d.name);

                }

            }
            catch
            {

                MessageBox.Show(System.IO.Path.GetFileNameWithoutExtension(path) +
                    System.IO.Path.GetExtension(path) +
                    " konnte nicht geöffnet werden! Überprüfe den Pfad oder das Programm mit dem die Datei geöffnet wird!",
                    "Datei nicht kompatibel!", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }


        }
        /// <summary>
        /// Ausgewählte Dateien löschen.
        /// </summary>
        private void dateienLöschen()
        {

            if (listDateien.SelectedItems.Count != 0)
            {

                int n = 0;
                while (listDateien.SelectedItems.Count != 0)
                {

                    string s = listDateien.SelectedItems[n].ToString();
                    Dateien.Remove((Dateien[listDateien.Items.IndexOf(s)]));
                    listDateien.Items.Remove(s);


                    n++;

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

                //o.WindowTitel = wm.DireWindowName;

                //Window settings hinzufügen;


                foreach (ProcessListDemo.Window w in win.lstWindows)
                {



                    if (w.winHandle == Handle)
                    {
                        //Fenstereigenschaften werden an Ordner übergeben
                        o.WindowSettings = w;


                    }
                }
                Ordner.Add(o);
                listOrdner.Items.Add(o.name);


            }

        }

        /// <summary>
        /// Löscht die ausgewählten Ordner
        /// </summary>
        private void ordnerLöschen()
        {

            if (listOrdner.SelectedItems.Count != 0)
            {
                int n = 0;
                while (listOrdner.SelectedItems.Count != 0)
                {

                    string s = listOrdner.SelectedItems[n].ToString();
                    Ordner.Remove((Ordner[listOrdner.Items.IndexOf(s)]));
                    listOrdner.Items.Remove(s);

                    n++;

                }

            }




        }

        //Hinzufügen
        private void bOrdnerHinzufügen_Click(object sender, EventArgs e)
        {
            if (fbdOrdner.ShowDialog() == DialogResult.OK)
                ordnerHinzufügen(fbdOrdner.SelectedPath);
        }
        private void hinzufügenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (fbdOrdner.ShowDialog() == DialogResult.OK)
                ordnerHinzufügen(fbdOrdner.SelectedPath);

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


        #endregion

        #region Internetseite

        /// <summary>
        /// Löscht die ausgewählten Internetseiten.
        /// </summary>
        private void internetseiteLöschen()
        {

            int n = 0;
            while (listOrdner.SelectedItems.Count != 0)
            {

                foreach (string s in listInternetseiten.SelectedItems)
                {

                    Internetseiten.Remove(Internetseiten[listInternetseiten.Items.IndexOf(s)]);
                    listInternetseiten.Items.Remove(s);
                    n++;

                }

            }


        }
        
        /// <summary>
        /// Fügt eine Internetseite hinzu.
        /// </summary>
        private void internetseiteHinzufügen()
        {
            AddDialoge.frmAddInternetseite frmAddInternetseite = new AddDialoge.frmAddInternetseite();
            frmAddInternetseite.ShowDialog();

            if (frmAddInternetseite.URL != null)
            {
                Internetseite i = new Internetseite();
                i.url = frmAddInternetseite.URL;

                Internetseiten.Add(i);
                listInternetseiten.Items.Add(i.url);

            }

        }

        //Löschen
        private void bInternetseiteLöschen_Click(object sender, EventArgs e)
        {
            internetseiteLöschen();
        }
        private void entfernenToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            internetseiteLöschen();
        }

        #endregion

        /// <summary>
        /// Lädt die Dateien der zu bearbeitenden Toolgruppe
        /// </summary>
        private void loadDateien()
        {

            foreach(Datei d in toolgruppe.Dateien)
            {
                Dateien.Add(d);
                listDateien.Items.Add(d.name);
            }

        }

        /// <summary>
        /// Lädt die Ordner der zu bearbeitenden Toolgruppe
        /// </summary>
        private void loadOrdner()
        {
            foreach (Ordner o in toolgruppe.Ordner)
            {
                Ordner.Add(o);
                listOrdner.Items.Add(o.name);
            }

        }

        /// <summary>
        /// Lädt die Internetseiten der zu bearbeitenden Toolgruppe
        /// </summary>
        private void loadInternetseiten()
        {
            foreach (Internetseite i in toolgruppe.Internetseiten)
            {
                Internetseiten.Add(i);
                listInternetseiten.Items.Add(i.url);
            }

        }

        private void bFertig_Click(object sender, EventArgs e)
        {
            System.IO.File.Delete(einstellungen.path + "OpenTools V2.0\\" + toolgruppe.name + ".tg");

            if (textBox1.Text != String.Empty)
            {

                if (IS.creatable(textBox1.Text) == true)
                {

                    if (!System.IO.File.Exists(einstellungen.path + "OpenTools V2.0\\" + textBox1.Text + ".tg"))
                    {
                                                                        
                        ToolGruppe t = new ToolGruppe();

                        t.Dateien = Dateien;
                        t.Ordner = Ordner;
                        t.Internetseiten = Internetseiten;

                        t.name = textBox1.Text;

                        t.save(einstellungen.path + "OpenTools V2.0\\" + textBox1.Text + ".tg");

                        //Wenn Grppe = Autostartgruppe --> dann auch umbennen
                        if(einstellungen.AutostartGruppe == toolgruppe.name)
                        {
                            einstellungen.AutostartGruppe = t.name;
                            einstellungen.save();
                        }

                    }
                    else
                    {
                        //Toolgruppe bereits vorhanden:

                        MessageBox.Show("Toolgruppe bereits vorhanden!", "Bereits vorhanden", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.DialogResult = DialogResult.None;
                        textBox1.Select();
                        textBox1.SelectionStart = 0;
                        textBox1.SelectionLength = textBox1.Text.Length;

                    }

                }
                else
                {
                    MessageBox.Show("Die Zeichen \\ / ? : * \" < > | dürfen nicht verwendet werden!", "FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.None;
                    textBox1.Select();
                    textBox1.SelectionStart = 0;
                    textBox1.SelectionLength = textBox1.Text.Length;

                }
            }
            else
            {
                MessageBox.Show("Bitte gib deiner Toolgruppe einen Namen! Sie ist sonst traurig", "Name --> Toolgruppe traurig", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.None;
                textBox1.Select();
                textBox1.SelectionStart = 0;
                textBox1.SelectionLength = textBox1.Text.Length;

            }
        }

        private void bInternetseiteHinzufügen_Click(object sender, EventArgs e)
        {
            internetseiteHinzufügen();
        }

        private void hinzufügenToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            internetseiteHinzufügen();
        }

        private void frmToolgruppeBearbeiten_KeyDown(object sender, KeyEventArgs e)
        {
            //Datei hinzufügen
            if (e.Control)
            {
                if (e.KeyCode == Keys.D)
                {
                    bDateiHinzufügen.PerformClick();
                }
            }

            //Ordner hinzufügen
            if (e.Control)
            {
                if (e.KeyCode == Keys.O)
                {
                    bOrdnerHinzufügen.PerformClick();
                }
            }

            //INternetseite Hinzufügen
            if (e.Control)
            {
                if (e.KeyCode == Keys.I)
                {
                    bInternetseiteHinzufügen.PerformClick();
                }
            }

            //LÖschen

            if (e.KeyCode == Keys.Delete)
            {
                if (listDateien.Focused == true)
                    bDateiEntfernen.PerformClick();

                if (listOrdner.Focused == true)
                    bOrdnerLöschen.PerformClick();

                if (listInternetseiten.Focused == true)
                    bInternetseiteLöschen.PerformClick();
            }

        }

        private void frmToolgruppeBearbeiten_Load(object sender, EventArgs e)
        {

        }
    }
}
