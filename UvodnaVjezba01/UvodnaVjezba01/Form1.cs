using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UvodnaVjezba01
{
    public partial class Form1 : Form
    {
        int a = 0;
        int b = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            a = (int)Convert.ToSingle(varA.Text);
            b = (int)Convert.ToSingle(varB.Text);
            lblRez.Text = "" + a / b;
            lblOstatak.Text = "" + a % b;
            lblText.Text = a + "" + " dijeljeno s " + b + " je " + a / b + " i ostatak " + a % b;
        }
    }
}
