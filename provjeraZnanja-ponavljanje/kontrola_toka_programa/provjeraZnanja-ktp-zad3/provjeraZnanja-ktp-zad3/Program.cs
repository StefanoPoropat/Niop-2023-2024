using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provjeraZnanja_ktp_zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inout a number, any number: ");
            double number = Convert.ToInt32(Console.ReadLine());
            if(number % 4 == 0 && number % 6 != 0)
            {
                Console.WriteLine("Number can be devided by 4 to get a whole number.");
            }
            if (number % 6 == 0 && number % 4 != 0)
            {
                Console.WriteLine("Number can be devided by 6 to get a whole number.");
            }
            if (number % 6 == 0 && number % 4 == 0)
            {
                Console.WriteLine("Number can be devided by 4 and 6 to get a whole number.");
            }
            if (number % 4 != 0 && number % 6 != 0)
            {
                Console.WriteLine("Number can't be devided by 4 and 6 to get a whole number.");
            }
            Console.ReadKey();
        }
    }
}
