using OpenTools_V2._0.ToolgruppenElemente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenTools_V2._0.AddDialoge
{
    public partial class frmAddInternetseite : Form
    {
        public frmAddInternetseite()
        {
            InitializeComponent();
        }

        public string URL { get; set; }

        private void bFertig_Click(object sender, EventArgs e)
        {

          
            if(textBox1.Text != null)
            {
                if(textBox1.Text.StartsWith("http://") | textBox1.Text.StartsWith("https://"))
                {
                    URL = textBox1.Text;
                }
                else
                {
                    MessageBox.Show("Die Url muss mit http:// oder https:// beginnen!", "OpenTools V2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.None;

                    textBox1.Select();

                }

                Close();
            }

        }
    }
}
