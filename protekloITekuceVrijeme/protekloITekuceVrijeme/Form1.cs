using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace protekloITekuceVrijeme
{
    
    public partial class Form1 : Form
    
    {
        DateTime pocetno = DateTime.Now;
        public Form1()
        {
            InitializeComponent();
        }

        private void T_Tick(object sender, EventArgs e)
        {
            lblCurrent.Text = "Trenutno: " + DateTime.Now.ToLongTimeString();
            TimeSpan proteklo = new TimeSpan();
            proteklo = DateTime.Now - pocetno;
            lblPased.Text = "Proteklo: " + proteklo.Hours.ToString() + ":" + proteklo.Minutes.ToString() + ":" + proteklo.Seconds.ToString();
        }
    }
}
