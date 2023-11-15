using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provjeraZnanja_zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite rečenicu: ");
            string str = Console.ReadLine();
            str = str.Replace(" ", "-");
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
