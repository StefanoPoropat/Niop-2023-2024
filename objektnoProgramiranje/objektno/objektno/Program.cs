using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objektno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba = new Osoba();
            osoba.setIme(Console.ReadLine());
            osoba.setPrezime(Console.ReadLine());
            osoba.setVisina(150);
            Console.WriteLine("Ime: " + osoba.getIme());
            Console.WriteLine("Prezime: " + osoba.getPrezime());
            Console.WriteLine("Visina: " + osoba.getVisina()+"\n");

            Osoba osoba2 = new Osoba("Vladimir", "Nazor", 168, 85, 1895, 'M');
            Console.WriteLine("\n"+osoba2);
            Console.ReadKey();
        }
    }
}
