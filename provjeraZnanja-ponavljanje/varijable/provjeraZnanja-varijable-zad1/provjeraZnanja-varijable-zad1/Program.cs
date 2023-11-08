using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provjeraZnanja_varijable_zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a= 7548, b= 4494, c= 5791, d= 5819;
            double x = (Math.Pow(a, 2) + Math.Pow(b, 2) + Math.Pow(c, 2) + Math.Pow(d, 2))/(Math.Pow((a+b), 2) + Math.Pow((c + d),2));
            Console.WriteLine("x = " + x);
            Console.ReadKey();
        }
    }
}
