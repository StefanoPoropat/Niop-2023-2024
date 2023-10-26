using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace monthCalendarKontrola12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            mC1.MaxSelectionCount = 999999999;
        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            TimeSpan ts = mC1.SelectionEnd - mC1.SelectionStart;
            if (ts.Days < 1)
            {
                MessageBox.Show("Korištenjem tipke SHIFT odaberite opseg datuma.\nIli koristite drugi gumb za odabir rezervacije u trajanju od jednog dana. ");
                return;
            }
            if(ts.Days >= 1)
            {
                MessageBox.Show("Rezervirali ste usluge u trajanju od "+ (ts.Days + 1).ToString() + " dana.", "Rezervacija");
                MessageBox.Show("Vaša rezervacija počinje dana " + mC1.SelectionStart.ToShortDateString() + ", a završava dana " + mC1.SelectionEnd.ToShortDateString());
            }
        }

        private void btn1Day_Click(object sender, EventArgs e)
        {
            TimeSpan ts = mC1.SelectionEnd - mC1.SelectionStart;
            if (ts.Days == 0)
            {
                MessageBox.Show("Vaša rezervacija počinje dana " + mC1.SelectionStart.ToShortDateString() + " te završava istoga.");
            }
            else
            {
                MessageBox.Show("Za odabir više dana, koristite drugi gumb.");
            }
        }
    }
}
