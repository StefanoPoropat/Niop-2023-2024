using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UvodnaVjezba02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a = 0;
        int b = 0;
        double c = 0;
        double d = 0;
        double result = 0;
       /* private void varA_TextChanged(object sender, EventArgs e)
        {
            a = (int)Convert.ToSingle(varA.Text);
            b = (int)Convert.ToSingle(varB.Text);
            c = (int)Convert.ToSingle(varC.Text);
            d = (int)Convert.ToSingle(varD.Text);
            result = (a + b+ c + d) /4 ;
            lblResult.Text = "" + result;
        }
        private void varB_TextChanged(object sender, EventArgs e)
        {
            a = (int)Convert.ToSingle(varA.Text);
            b = (int)Convert.ToSingle(varB.Text);
            c = (int)Convert.ToSingle(varC.Text);
            d = (int)Convert.ToSingle(varD.Text);
            result = (a + b + c + d) / 4;
            lblResult.Text = "" + result;
        }

        private void varD_TextChanged(object sender, EventArgs e)
        {
            a = (int)Convert.ToSingle(varA.Text);
            b = (int)Convert.ToSingle(varB.Text);
            c = (int)Convert.ToSingle(varC.Text);
            d = (int)Convert.ToSingle(varD.Text);
            result = (a + b + c + d) / 4;
            lblResult.Text = "" + result;
        }

        private void varC_TextChanged(object sender, EventArgs e)
        {
            a = (int)Convert.ToSingle(varA.Text);
            b = (int)Convert.ToSingle(varB.Text);
            c = (int)Convert.ToSingle(varC.Text);
            d = (int)Convert.ToSingle(varD.Text);
            result = (a + b + c + d) / 4;
            lblResult.Text = "" + result;
        }*/

        private void btnCalc_Clicked(object sender, EventArgs e)
        {
            result = 0;
            a = (int)Convert.ToSingle(varA.Text);
            b = (int)Convert.ToSingle(varB.Text);
            c = (int)Convert.ToSingle(varC.Text);
            d = (int)Convert.ToSingle(varD.Text);
            result = (a + b + c + d) / 4;
            lblResult.Text = "" + result;
        }
    }
}
