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
        public List<Internetseite> Internetseiten = new List<Internetseite>();

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

            //TODO: IF textbox.text leer

            if (textBox1.Text != String.Empty)
            {
                if (IS.creatable(textBox1.Text) == true)
                {

                    if (!System.IO.File.Exists(einstellungen.path + "OpenTools V2.0\\" + textBox1.Text + ".tg"))
                    {

                        //Toolgruppe nicht vorhanden --> Erstellen

                        toolgruppe.Dateien = Dateien;
                        toolgruppe.Ordner = Ordner;
                        toolgruppe.Internetseiten = Internetseiten;

                        toolgruppe.name = textBox1.Text;

                        toolgruppe.save(einstellungen.path + "\\OpenTools V2.0\\" + textBox1.Text + ".tg");

                        //DesktopShortcut erstellen
                        if (checkShortcut.Checked)
                            Verknüpfung.DesktopverknüpfungErstellen(einstellungen.path + "\\OpenTools V2.0\\" + textBox1.Text + ".tg");

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


        //TODO: MultiExtend Delete

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

            try {

                processDateien.Start();

                if (MessageBox.Show("Fenster positioniert?", "OpenTools V2.0", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    ProcessListDemo.Windows win = new ProcessListDemo.Windows();

                    //Neue Datei erstellen und Pfad mitgeben 
                    Datei d = new Datei(path);


                    //Window settings hinzufügen;
                    foreach (ProcessListDemo.Window w in win.lstWindows)
                    {

                        try {

                            if (w.winHandle == processDateien.MainWindowHandle)
                            {
                                //Fenstereigenschaften werden an Datei übergeben
                                d.WindowSettings = w;

                            }
                        } catch
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
                while(listDateien.SelectedItems.Count != 0)
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

                //foreach (string s in listOrdner.SelectedItems)
                //{
                //    Ordner.Remove(Ordner[listOrdner.Items.IndexOf(s)]);
                //    listOrdner.Items.Remove(s);

                //}
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

        #region Internetseite

        private void hinzufügenToolStripMenuItem2_Click(object sender, EventArgs e)
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

        private void entfernenToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            internetseiteLöschen();
        }

        #endregion



        private void listDateien_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listDateien.SelectedItems.Count != 0)
            {
                try {
                    Datei d = Dateien[(listDateien.Items.IndexOf(listDateien.SelectedItem))];
                    Process.Start(d.path);
                }catch (Exception ex)
                {
                    MessageBox.Show("Die Datei konnte nicht geöffnet werden!\n\nFehler:\n " + ex.ToString(), "OpenTools V2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void listOrdner_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listOrdner.SelectedItems.Count != 0)
            {
                try {
                    Ordner o = Ordner[(listOrdner.Items.IndexOf(listOrdner.SelectedItem))];
                    Process.Start(o.path);
                }
                catch (Exception ex) 
                {
                    MessageBox.Show("Der Ordner konnte nich geöffnet werden!\n\nFehler:\n" + ex.ToString(), "OpenTools V2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }

        private void listInternetseiten_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listInternetseiten.SelectedItems.Count != 0)
            {
                try {
                    Internetseite i = Internetseiten[(listInternetseiten.Items.IndexOf(listInternetseiten.SelectedItem))];
                    Process.Start(i.url);
                }catch{

                    MessageBox.Show("URL konnte nicht geöffnet werden!", "OpenTools V2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        #region Drag & Drop

        //Dateien
        private void listDateien_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;


        }

        private void listDateien_DragDrop(object sender, DragEventArgs e)
        {

           string[] files = (string[])(e.Data.GetData(DataFormats.FileDrop));
           foreach(string s in files)
            {
                dateiHinzufügen(s); 
            }

                 

        }

        //Ordner
        private void listOrdner_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;


        }

        private void listOrdner_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])(e.Data.GetData(DataFormats.FileDrop));
            foreach (string s in files)
            {
                ordnerHinzufügen(s);
            }

        }

        #endregion

        private void bInternetseiteHinzufügen_Click(object sender, EventArgs e)
        {
            internetseiteHinzufügen();
        }

    }
}
