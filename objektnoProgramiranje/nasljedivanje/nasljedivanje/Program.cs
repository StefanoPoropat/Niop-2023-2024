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
            Osoba osoba = new Osoba("Ivano","Ivanic");
            Ucenik ucenik = new Ucenik("Matko", "Peric", "3.d");

            osoba.ispis();
            ucenik.ispis();
            Console.ReadLine();
        }
    }
}