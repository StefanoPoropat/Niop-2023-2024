using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace klasaProcess14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIE_Click(object sender, EventArgs e)
        {
            string message = "Internet Explorer is no more. This is his legacy.";
            string caption = "Title No.1";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Information;
            MessageBox.Show(message, caption, buttons, icon);
            Process.Start("msedge.exe");
        }

        private void btnExc_Click(object sender, EventArgs e)
        {
            Process.Start("Excel.exe");
        }

        private void btnWo_Click(object sender, EventArgs e)
        {
            Process.Start("WINWORD.exe");
        }

        private void btnSI_Click(object sender, EventArgs e)
        {
            string message = "Internet Explorer is no more. This is his legacy.";
            string caption = "Title No.2";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Information;
            MessageBox.Show(message, caption, buttons, icon);
            ProcessStartInfo startInfo = new ProcessStartInfo("msedge.exe")
            {
                WindowStyle = ProcessWindowStyle.Normal,
                Arguments = "www.sser.hr"
            };
            Process.Start(startInfo);
        }
    }
}
