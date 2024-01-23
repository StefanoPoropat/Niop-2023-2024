using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klase
{
    internal class Sport
    {
        private String naziv;
        private Boolean igraLiSeLoptom;
        private byte brojIgraca;
        public Sport(string naziv="", bool igraLiSeLoptom=true, byte brojIgraca=0)
        {
            this.naziv = naziv;
            this.igraLiSeLoptom = igraLiSeLoptom;
            this.brojIgraca = brojIgraca;
        }
        public override string ToString()
        {
            String str = "\nNaziv: " + naziv + "\nIgra li se loptopm? " + igraLiSeLoptom + "\nBroj igrača: " + brojIgraca;
            return str;
        }
    }
}
