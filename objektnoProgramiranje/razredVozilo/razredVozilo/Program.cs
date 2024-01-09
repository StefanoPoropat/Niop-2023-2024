using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace razredVozilo
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Vozilo jedan = new Vozilo();
            Vozilo dva = new Vozilo();
            jedan.Vrsta = "Motocikl";
            jedan.BrKot = 2;
            Console.Write("Koliko iznosi max brzina ovog Motora? ");
            jedan.setMaxBrzina(Convert.ToDouble(Console.ReadLine()));

            dva.Vrsta = "Automobil";
            dva.BrKot = 4;
            dva.setMaxBrzina(jedan.getMaxBrzina());
            Console.WriteLine(jedan.ToString());
            Console.WriteLine(dva.ToString());

            Console.ReadKey();
        }
    }
}
