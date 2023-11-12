using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provjeraZnanja_ktp_zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            start: Console.Write("a: ");
            startA: double a = Convert.ToInt32(Console.ReadLine());
            if (a <= 0)
            {
                Console.WriteLine("");
                Console.WriteLine("Invalid number, try again.");
                Console.WriteLine("");
                goto startA;
            }
            startB: Console.Write("b: "); double b = Convert.ToInt32(Console.ReadLine());
            if (b <= 0)
            {
                Console.WriteLine("");
                Console.WriteLine("Invalid number, try again.");
                Console.WriteLine("");
                goto startB;
            }
           startC: Console.Write("c: "); double c = Convert.ToInt32(Console.ReadLine());
            if (c <= 0)
            {
                Console.WriteLine("");
                Console.WriteLine("Invalid number, try again.");
                Console.WriteLine("");
                goto startC;
            }
            if(c <= a || c <= b)
            {
                Console.WriteLine("");
                Console.WriteLine("The value of the number c is not the highest.\nTry again.");
                Console.WriteLine("");
                goto start;
            }
            if(Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2))
            {
                Console.WriteLine("This is a right triangle");
            }
            if(Math.Pow(c, 2) != Math.Pow(a, 2) + Math.Pow(b, 2))
            {
                Console.WriteLine("This is not a right triangle.");
            }
            Console.ReadKey();
        }
    }
}
