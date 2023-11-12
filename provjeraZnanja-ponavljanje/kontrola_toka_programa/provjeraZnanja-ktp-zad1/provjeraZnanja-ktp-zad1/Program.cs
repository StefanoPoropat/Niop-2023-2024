using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provjeraZnanja_ktp_zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite niz znakova: ");
            string str = Console.ReadLine();
            int a = str.Length;
            if (a <=5)
            {
                Console.WriteLine(str);
            }
            else
            {
                Console.WriteLine(str.Substring(2, (a-4)));
            }
            Console.ReadKey();
        }
    }
}
