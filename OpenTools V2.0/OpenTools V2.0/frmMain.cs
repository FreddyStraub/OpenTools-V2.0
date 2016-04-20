using Microsoft.Win32;
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
    public partial class frmMain : Form
    {


        public frmMain()
        {
            InitializeComponent();
        }

        public frmMain(string toolgruppePath)
        {
            InitializeComponent();
            
            ToolGruppe t = new ToolGruppe();
            t = t.load(toolgruppePath);
            t.run();

        }

        Einstellungen einstellungen = new Einstellungen();

        private void llbWolf066LP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://youtube.de/Wolf066LP");
        }
        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {



            einstellungen = einstellungen.load();

            OrdnerVerwaltung();

            loadToolgruppen();


        }

        /// <summary>
        /// Kuümmert sich um das erstellen der Ordner
        /// </summary>
        private void OrdnerVerwaltung()
        {

            if (!System.IO.Directory.Exists(einstellungen.path + "\\OpenTools V2.0"))
            {

                System.IO.Directory.CreateDirectory(einstellungen.path + "\\OpenTools V2.0");

            }

        }

        /// <summary>
        /// Lädt die gespeicherten Toolgruppen in die Listbox.
        /// </summary>
        private void loadToolgruppen()
        {

            listToolgruppen.Items.Clear();

            foreach(string file in System.IO.Directory.GetFiles(einstellungen.path + "\\OpenTools V2.0\\"))
            {

                listToolgruppen.Items.Add(System.IO.Path.GetFileNameWithoutExtension(file));

            }

        }

        private void einstellungenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEinstellungen frmEinstellungen = new frmEinstellungen();
            frmEinstellungen.ShowDialog();
        }

        private void neuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmToolgruppeErstellen frmToolgruppeErstellen = new frmToolgruppeErstellen();
            frmToolgruppeErstellen.ShowDialog();

            loadToolgruppen();
        }

        private void listToolgruppen_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            if(listToolgruppen.SelectedItems.Count != 0)
            {

                ToolGruppe t = new ToolGruppe();
                t = t.load(einstellungen.path + "\\OpenTools V2.0\\" + listToolgruppen.SelectedItem + ".tg");
                t.run();

            }

        }

        private void löschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(listToolgruppen.SelectedItems.Count != 0)
            {

                if(System.IO.File.Exists(einstellungen.path + "OpenTools V2.0\\" + listToolgruppen.SelectedItem + ".tg"))
                {
                    System.IO.File.Delete(einstellungen.path + "OpenTools V2.0\\" + listToolgruppen.SelectedItem + ".tg");

                }

            }

            loadToolgruppen();
        }
    }
}
