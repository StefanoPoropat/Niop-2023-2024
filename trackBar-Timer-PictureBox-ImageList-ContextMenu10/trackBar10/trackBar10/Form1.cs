using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trackBar10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbl1.Text = "Postavljena vrijednost iznosi: " + bar1.Value.ToString();
        }

        private void bar1_Scroll(object sender, EventArgs e)
        {
            lbl1.Text = "Postavljena vrijednost iznosi: " + bar1.Value.ToString();
        }
    }
}
