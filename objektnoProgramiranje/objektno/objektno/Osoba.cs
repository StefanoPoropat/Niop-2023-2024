using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objektno
{
    internal class Osoba
    {
        string ime, prezime;
        int godRodj;
        double visina, tezina;
        char spol;



        public void setIme(string ime)
        {
            this.ime = ime;
        }
        public string getIme()
        {
            return ime;
        }
        public void setPrezime(string prezime)
        {
            this.prezime= prezime;
        }
        public string getPrezime()
        {
            return prezime;
        }
        public void setGodRodj(int godRodj)
        {
            this.godRodj = godRodj;
        }
        public int getGodRodj()
        {
            return godRodj;
        }
        public void setVisina(double visina)
        {
            this.visina = visina;
        }
        public double getVisina()
        {
            return visina;
        }
        public void setTezina(double tezina)
        {
            this.tezina = tezina;
        }
        public double getTezina()
        {
            return tezina;
        }
        public void setVisina(char spol)
        {
            this.spol = spol;
        }
        public char getSpol()
        {
            return spol;
        }
        public override string ToString()
        {
            string ispis = "Ime i prezime: " + this.getIme()
                + " " + this.getPrezime() + "\n"
                + "Godina rođenja: " + this.getGodRodj() + "\n"
                + "Visina: " + this.getVisina() + "cm\n"
                + "Težina: " + this.getTezina() + "kg\n"
                + "Spol: " + this.getSpol();
            return ispis;
        }
        public Osoba()
        {

        }
        public Osoba(string ime, string prezime, int godRodj, double visina, double tezina, char spol)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.godRodj = godRodj;
            this.visina = visina;
            this.tezina = tezina;
            this.spol = spol;
        }

        public Osoba(string ime, string prezime)
        {
            this.ime = ime;
            this.prezime = prezime;
        }
    }
}
