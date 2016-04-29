using IWshRuntimeLibrary;
using Microsoft.Win32;
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
    public partial class frmEinstellungen : Form
    {
        public frmEinstellungen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (fbdEinstellungen.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = fbdEinstellungen.SelectedPath;
            }

        }

        private void frmEinstellungen_Load(object sender, EventArgs e)
        {
            Einstellungen s = new Einstellungen();
            s = s.load();

            textBox1.Text = s.path;

            checkAuto.Checked = s.autostart;

            checkSteuerung.Checked = s.steuerung;
            checkShift.Checked = s.shift;
            checkAlt.Checked = s.alt;
            bKey.Text = s.key.ToString();

            ToolTip t = new ToolTip();
            t.SetToolTip(checkAuto, s.AutostartGruppe);



        }

        private void ordnerÖffnenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(textBox1.Text);
        }

        private void bSpeichern_Click(object sender, EventArgs e)
        {
            Einstellungen ein = new Einstellungen();

            ein.path = textBox1.Text;

            ein.alt = checkAlt.Checked;
            ein.shift = checkShift.Checked;
            ein.steuerung = checkSteuerung.Checked;

            ein.key = (Keys)Enum.Parse(typeof(Keys), bKey.Text);

            ein.autostart = checkAuto.Checked;

            RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (ein.autostart)
            {

                Verknüpfung.VerknüpfungErstellen(Application.ExecutablePath, Application.StartupPath, Application.StartupPath + "\\logo.ico", "startup");
                System.IO.File.SetAttributes(Application.StartupPath + "\\OpenTools V2.0.lnk", System.IO.FileAttributes.Hidden);

                rkApp.SetValue(Application.ProductName, Application.StartupPath + "\\OpenTools V2.0.lnk");


            }
            else
            {
                rkApp.DeleteValue(Application.ProductName, false);
                System.IO.File.Delete(Application.StartupPath + "\\OpenTools V2.0.lnk");

            }


            ein.save();

            Close();

        }

        private void bAbbrechen_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Process.Start(textBox1.Text);
        }

        private void bKey_KeyDown(object sender, KeyEventArgs e)
        {
            if (bKey.Text == "Drücke die Taste!")
            {

                switch (e.KeyCode)
                {
                    case Keys.Control:
                        break;
                    case Keys.LControlKey:
                        break;
                    case Keys.RControlKey:
                        break;
                    case Keys.Alt:
                        break;
                    case Keys.Menu:
                        break;
                    case Keys.LShiftKey:
                        break;
                    case Keys.RShiftKey:
                        break;
                    case Keys.Shift:
                        break;
                    case Keys.ShiftKey:
                        break;
                    default:
                        bKey.Text = e.KeyCode.ToString(); break;

                }

            }
        }

        private void bKey_Click(object sender, EventArgs e)
        {
            bKey.Text = "Drücke die Taste!";

        }
    }
}
