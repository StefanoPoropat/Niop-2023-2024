using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dot
{
    internal class Zrakoplov
    {
        private String naziv;
        private int snagaMotora;
        private double dosegLeta;
        private double brzina;
        //private dotclass dot;
        dotclass dot = new dotclass();
        dotclass dot1 = new dotclass();

        public Zrakoplov(string naziv="", int snagaMotora=0, double dosegLeta=0, double odrediste_x=0, double odrediste_y = 0)
        {
            this.naziv = naziv;
            this.snagaMotora = snagaMotora;
            this.dosegLeta = dosegLeta;
            dot1 = new dotclass(odrediste_x, odrediste_y);
            this.brzina = snagaMotora * 0.4;
        }
        public double plan_leta()
        {
            double ans= (dot.udaljenost(dot1))/ (this.brzina);
            return ans;
        }
        public override string ToString()
        {
            String str = "\nNaziv: " + this.naziv + "\nSnaga motora: " + this.snagaMotora + "\nDoseg leta: " + this.dosegLeta + "\nBrzina: "+ this.brzina +
                "\nTrajanje leta: " + plan_leta() + "h";
            return str;
        }

    }
}