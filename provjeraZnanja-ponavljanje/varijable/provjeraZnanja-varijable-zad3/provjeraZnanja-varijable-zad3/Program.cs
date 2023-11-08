using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provjeraZnanja_varijable_zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite rečenicu: ");
            string str=Console.ReadLine();
            string[] str1 = str.Split(' ');
            int a = str1.Length;
            Console.WriteLine(str1[0]);
            Console.WriteLine(str1[a-1]);
            Console.ReadKey();
        }
    }
}
