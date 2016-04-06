using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

            Einstellungen s = new Einstellungen();
            s.path = textBox1.Text;
            
            s.save();
            

        }
    }
}
