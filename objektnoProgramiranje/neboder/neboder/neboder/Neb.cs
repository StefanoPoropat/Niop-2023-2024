using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace neboder
{
    internal class Neb
    {
        double visina = 0;
        int brKatova = 0;

        public Neb(double visina, int brKatova)
        {
            this.Visina = visina;
            this.BrKatova = brKatova;
        }
        public Neb()
        {
            this.Visina = visina;
            this.BrKatova = brKatova;
        }

        public double Visina { get => visina; set => visina = value; }
        public int BrKatova { get => brKatova; set => brKatova = value; }

        public override string ToString()
        {
            visina += 10;
            brKatova += 1;
            double avgKat = visina / brKatova;
            string str = "Visina: " + visina + "\nBroj katova: " + brKatova + "\nAvg visina kata: " + avgKat + " metara";
            return str;
        }
    }
}
