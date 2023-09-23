using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uvodnaVjezba04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0, rezEnd = 0;
            Console.Write("Unesite željeni broj Fibonaccijevog niza: ");
            n = Convert.ToInt32(Console.ReadLine());
            List <int> rezTemp = new List <int>();
            rezTemp.Add(0);
            rezTemp.Add(1);
            for (int i = 0; i < n; i++)
            {
                rezEnd = rezEnd + rezTemp[i];
                rezTemp.Add(rezEnd);
                //Console.WriteLine(rezEnd);                    //Provjera koraka
            }
            Console.WriteLine("");
            Console.WriteLine(n + ". broj Fibonaccijevog niza je " + rezEnd);
            Console.ReadKey();
        }
    }
}
