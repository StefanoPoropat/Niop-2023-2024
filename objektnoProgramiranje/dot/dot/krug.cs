using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dot
{
    internal class krug
    {
        double radius;
        int circCount;

        public krug(double radius)
        {
            this.radius = radius;
        }
        public krug()
        {
            this.radius = radius;
        }

        public krug(int circCount)
        {
            this.circCount = circCount;
        }

        public double Radius { get => radius; set => radius = value; }
        public int CircCount { get => circCount; set => circCount = value; }

        public double intercept(krug circ, dotclass dot, krug circ1, dotclass dot1){
            if ((dot.udaljenost(dot1))<=(circ.radius + circ1.radius))
            {
                circCount = 1;
                return circCount;
            }
            if (dot.udaljenost(dot1) > (circ.radius + circ1.radius))
            {
                circCount = 0;
                return circCount;
            }
            else
            {
                return 100;
            }
        }
        public override string ToString()
        {
            String str="";
            if (circCount == 1) { str = "Preklapaju se"; }
            if (circCount == 0) { str = "Ne preklapaju se"; }
            return str;
        }
    }
}
