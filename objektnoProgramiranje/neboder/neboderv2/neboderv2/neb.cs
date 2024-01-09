using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace neboderv2
{
    internal class neb
    {
        decimal visina;
        int brKat;

        public neb(decimal visina, int brKat)
        {
            this.visina = visina;
            this.brKat = brKat;
        }
        public neb()
        {
            this.visina = visina;
            this.brKat = brKat;
        }

        public decimal Visina { get => visina; set => visina = value; }
        public int BrKat { get => brKat; set => brKat = value; }
        
        public override string ToString()
        {
            String str = "\nVisina nebodera: " + (Visina) + "\nBroj katova: " + (BrKat) + "\nAvg visina kata: " + (Visina) / (BrKat);
            return str;
        }
    }
}
