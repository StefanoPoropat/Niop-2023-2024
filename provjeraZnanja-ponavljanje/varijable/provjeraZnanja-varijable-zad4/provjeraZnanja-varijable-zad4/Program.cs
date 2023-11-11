using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provjeraZnanja_varijable_zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite prvo jedan cijeli broj, a zatim (razmakom odvojeno) jedan decimalni broj");
            string str=Console.ReadLine();
            string[] str1=str.Split(' ');
            try
            {
                int x = Convert.ToInt32(str1[0]);
                double y = Convert.ToDouble(str1[1]);
                Console.WriteLine("x = " + x);
                Console.WriteLine("y = " + y);
                Console.ReadKey();
            }
            catch (Exception e) {
                double y = Convert.ToDouble(str1[0]);
                int x = Convert.ToInt32(str1[1]);
                Console.WriteLine("x = " + x);
                Console.WriteLine("y = " + y);
                Console.ReadKey();
            }
        }
    }
}
