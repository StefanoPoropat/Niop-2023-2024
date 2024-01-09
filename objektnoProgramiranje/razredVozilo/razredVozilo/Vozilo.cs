using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace razredVozilo
{
    internal class Vozilo
    {
        String vrsta;
        double maxBrzina;
        int brKot;

        public Vozilo(string vrsta, double maxBrzina, int brKot)
        {
            this.vrsta = vrsta;
            this.maxBrzina = maxBrzina;
            this.brKot = brKot;
        }
        public Vozilo()
        {
            this.vrsta = vrsta;
            this.maxBrzina = maxBrzina;
            this.brKot = brKot;
        }

        public string Vrsta { get => vrsta; set => vrsta = value; }
        public void setMaxBrzina(double maxBrzina)
        {
            this.maxBrzina = maxBrzina;
            if (this.Vrsta == "Automobil")
            {
               this.maxBrzina = (this.maxBrzina * 0.3) + maxBrzina;
            }
        }
        public double getMaxBrzina()
        {
            return maxBrzina;
        }

        public int BrKot { get => brKot; set => brKot = value; }

        public override string ToString()
        {
            string str = "\nVrsta: " + Vrsta + "\nBroj Kotača: " + brKot + "\nMax brzina: " + maxBrzina + "\n";
            return str;
        }
    }
}
