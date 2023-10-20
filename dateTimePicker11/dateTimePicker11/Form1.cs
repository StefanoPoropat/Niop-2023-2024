using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dateTimePicker11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRez_Click(object sender, EventArgs e)
        {
            rTxt.Clear();
            DateTime dt1 = date1.Value;
            DateTime dt2 = time1.Value;
            StringBuilder sb1 = new StringBuilder();
            sb1.AppendLine("Vas datum leta je: \n");
            sb1.AppendLine(dt1.ToLongDateString() + "\n");
            sb1.AppendLine("Vase vrijeme polaska je: \n");
            sb1.AppendLine(dt2.ToLongTimeString() + "\n");
            rTxt.Text = sb1.ToString();
        }
    }
}
