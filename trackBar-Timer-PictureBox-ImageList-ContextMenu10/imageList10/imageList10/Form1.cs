using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imageList10
{
    public partial class Form1 : Form
    {
        public int br = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            
            if (br == 0)
            {
                pB1.Image = imageList1.Images[0];
                pB1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (br == 1)
            {
                pB1.Image = imageList1.Images[1];
                pB1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (br == 2)
            {
                br = 0;
                pB1.Image = imageList1.Images[0];
                pB1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            br++;
        }
    }
}
