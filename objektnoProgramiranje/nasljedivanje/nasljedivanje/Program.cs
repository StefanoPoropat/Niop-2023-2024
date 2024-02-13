using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljedjivanje
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            Osoba osoba = new Osoba();
            Ucenik ucenik = new Ucenik();

            osoba.ime = "Ivano";
            osoba.prezime = "Ivanic";
            ucenik.ime = "Matko";
            ucenik.prezime = "Peric";
            ucenik.razred = "3.d";

            osoba.ispis();
            ucenik.ispis();
            Console.ReadLine();
        }
    }
}