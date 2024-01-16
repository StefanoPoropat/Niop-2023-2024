using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dot
{
    internal class dotclass
    {
        private double n_x;
        private double n_y;

        public double x { get => n_x; set => n_x = value; }
        public double y { get => n_y; set => n_y = value; }
        public dotclass(double n_x, double n_y)
        {
            this.x = n_x;
            this.y = n_y;
        }
        /*public dotclass()
        {
            this.x = n_x;
            this.y = n_y;
        }*/
        public double udaljenost(dotclass dot)
        {
            double rez = Math.Sqrt(((n_x - dot.x)*((n_x - dot.x)) + (n_y-dot.y)*(n_y - dot.y)));
            return rez;
        }
        public override string ToString()
        {
            String str = "x = " + x + "\ny = " + y;
            return str;
        }
    }
}
