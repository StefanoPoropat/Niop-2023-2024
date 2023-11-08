using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provjeraZnanja_zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startGod = 1900, endGod = 2100;
            for (int i = startGod - 1; i <= endGod + 1; i++)
            {
                //Console.WriteLine("god");
                if (i % 400 == 0 || (i % 4 == 0 && i % 100 != 0))
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
