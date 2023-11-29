using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klaseIObjekti
{
    internal class Zrakoplov
    {
        string naziv;
        double snagaMotora;
        int dosegLeta;
        public Zrakoplov(string naziv, double snagaMotora, int dosegLeta)
        {
            this.naziv = naziv;
            this.snagaMotora = snagaMotora;
            this.dosegLeta = dosegLeta;
        }
        public override string ToString()
        {
            string ispis = "Naziv: " + this.naziv + "\nSnaga motora: " + this.snagaMotora + "\n"
                + "Doseg leta: " + this.dosegLeta + "\n";
            return ispis;
        }

    }
}
