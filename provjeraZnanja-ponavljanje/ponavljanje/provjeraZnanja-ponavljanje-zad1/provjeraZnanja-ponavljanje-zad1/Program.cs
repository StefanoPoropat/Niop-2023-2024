using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace provjeraZnanja_ponavljanje_zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
          start:  int x = 0, y = 0, z = 0;
            strX:
            Console.Write("Unesite stranicu a: ");
            x = Convert.ToInt16(Console.ReadLine());
            if (x <= 0)
            {
                Console.WriteLine("");
                Console.WriteLine("Uneseni broj nije moguć.");
                Console.WriteLine("Pokušajte ponovno.");
                Console.WriteLine("");
                goto strX;
            }
            strY: Console.Write("Unesite stranicu b: ");
            y = Convert.ToInt16(Console.ReadLine());
            if (y <= 0)
            {
                Console.WriteLine("");
                Console.WriteLine("Uneseni broj nije moguć.");
                Console.WriteLine("Pokušajte ponovno.");
                Console.WriteLine("");
                goto strY;
            }
            strZ: Console.Write("Unesite stranicu c: ");
            z = Convert.ToInt16(Console.ReadLine());
            if (z <= 0)
            {
                Console.WriteLine("");
                Console.WriteLine("Uneseni broj nije moguć.");
                Console.WriteLine("Pokušajte ponovno.");
                Console.WriteLine("");
                goto strZ;
            }
            if(z<=x || z <= y)
            {
                Console.WriteLine("");
                Console.WriteLine("Stranica c nije hipotenuza.");
                Console.WriteLine("Pokušajte ponovno.");
                Console.WriteLine("");
                goto start;
            }
            if(Math.Pow(z, 2) == (Math.Pow(x, 2) + Math.Pow(y, 2)))
            {
                Console.Write("To su stranice pravkoutnog trokuta.");
            }
            if (Math.Pow(z, 2) != (Math.Pow(x, 2) + Math.Pow(y, 2)))
            {
                Console.Write("To nisu stranice pravkoutnog trokuta.");
            }
            Console.ReadKey();
        }
    }
}
