using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace checkBoxKontrola06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            txtBox.Clear();
            txtBox.Text = "Odabrali ste: " + "\r\n";
            txtBox.AppendText("\r\n");
            if (chkBreakfast.Checked == true)
            {
                txtBox.AppendText("Doručak " + "\r\n");
            }
            if (chkLunch.Checked == true)
            {
                txtBox.AppendText("Ručak" + "\r\n");
            }
            if (chkDinner.Checked == true)
            {
                txtBox.AppendText("Večera" + "\r\n");
            }
        }
        private void chkOrder_CheckedChanged(object sender, EventArgs e)
        {
            if(chkOrder.Checked == true) {
                txtBox.Visible = false;
            }
            if (chkOrder.Checked == false)
            {
                txtBox.Visible = true;
            }
        }
    }
}
