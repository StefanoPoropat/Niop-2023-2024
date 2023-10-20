using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace richTextBoxKontrola09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            lbl1.LoadFile(@"C:Tempproba.rtf");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            lbl1.SaveFile(@"C:Tempproba.rtf");
            MessageBox.Show("Tekst spremljen");
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            lbl1.Clear();
        }
    }
}
