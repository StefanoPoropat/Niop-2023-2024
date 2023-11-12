using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provjeraZnanja_petlje_zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1900-1; i<=2100; i++)
            {
                if(i%400==0 || (i%4==0 && i % 100 != 0))
                {
                    Console.WriteLine("Prijestupna godina: "+i);
                }
            }
            Console.ReadKey();
        }
    }
}
