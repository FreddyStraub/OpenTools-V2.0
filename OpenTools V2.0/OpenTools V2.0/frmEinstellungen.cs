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
            
            if(fbdEinstellungen.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = fbdEinstellungen.SelectedPath;
            }

        }

        private void frmEinstellungen_Load(object sender, EventArgs e)
        {
            Einstellungen s = new Einstellungen();
            s.path = textBox1.Text;


        }

        private void ordnerÖffnenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(textBox1.Text);
        }

        private void bSpeichern_Click(object sender, EventArgs e)
        {
            Einstellungen ein = new Einstellungen();
            ein.path = textBox1.Text;

            ein.save();

        }
    }
}
