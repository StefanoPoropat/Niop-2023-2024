using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasaString_vjezbe2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite niz znakova: ");
            string str = Console.ReadLine();
            str = str.Replace(" ", "_");
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
