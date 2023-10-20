using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contextMenuStrip10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lijevoNaDesnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtD.Text = txtL.Text; 
        }

        private void desnoNaLijevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtL.Text = txtD.Text;
        }
    }
}
