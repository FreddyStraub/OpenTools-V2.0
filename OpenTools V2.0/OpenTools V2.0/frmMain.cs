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

            WindowState = FormWindowState.Minimized;

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

            registerHotkey();

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

                einstellungen = einstellungen.load();

                loadToolgruppen();
            
                //Hotkey reloaden
                UnregisterHotKey(this.Handle, 1);
                registerHotkey();
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
        //Toolgruppe löschen:
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

        private void bearbeiToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (listToolgruppen.SelectedItems.Count != 0)
            {
                ToolGruppe t = new ToolGruppe();
                t = t.load(einstellungen.path + "\\OpenTools V2.0\\" +
                    listToolgruppen.SelectedItem + ".tg");


                frmToolgruppeBearbeiten frmToolgruppeBearbeiten = new frmToolgruppeBearbeiten(t);
                frmToolgruppeBearbeiten.ShowDialog();

            }
        }

        private void desktopverknüpfungErstellenToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if(listToolgruppen.SelectedItems.Count != 0)
            {

                Verknüpfung.DesktopverknüpfungErstellen(einstellungen.path + "\\" + listToolgruppen.SelectedItem + ".tg");

            }

        }

        private void einstellungenToolStripMenuItem_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Process.Start(einstellungen.path + "\\OpenTools V2.0");
            }

        }

        private void registerHotkey()
        {
            RegisterHotKey(this.Handle, 1, getDinger(), (int)einstellungen.key);

        }

        //Hotkey:

        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);
        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);


        const int MOD_CONTROL = 0x0002;
        const int MOD_ALT = 0x0001;
        const int MOD_SHIFT = 0x0004;
        const int WM_HOTKEY = 0x0312;

        private int getDinger()
        {
            int vor = 0;


            if (einstellungen.alt == true)
            {
                vor += MOD_ALT;
            }
            if (einstellungen.shift == true)
            {
                vor += MOD_SHIFT;
            }
            if (einstellungen.steuerung == true)
            {
                vor += MOD_CONTROL;
            }
            return vor;

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnregisterHotKey(this.Handle, 1);

        }
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_HOTKEY && (int)m.WParam == 1)
                WindowState = FormWindowState.Normal;
                
                base.WndProc(ref m);
        }

        }

    }
