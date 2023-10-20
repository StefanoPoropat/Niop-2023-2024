using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace radioButtonKontrola08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnRezerviraj_Click(object sender, EventArgs e)
        {
            if(radioButtonAutobus.Checked)
            {
                lbl1.Text = "Odabrali ste prijevoz autobusom.";
            }
            if (radioButtonAvion.Checked)
            {
                lbl1.Text = "Odabrali ste prijevoz avionom.";
            }
            if (radioButtonVlastiti.Checked)
            {
                lbl1.Text = "Odabrali ste vlastiti prijevoz.";
            }
        }
    }
}
