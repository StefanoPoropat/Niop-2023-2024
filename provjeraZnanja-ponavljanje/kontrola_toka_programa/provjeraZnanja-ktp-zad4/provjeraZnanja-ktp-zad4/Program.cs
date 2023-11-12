using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provjeraZnanja_ktp_zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert the 1st price: ");
            double priceUno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert the 2nd price: ");
            double priceDos = Convert.ToInt32(Console.ReadLine());
            if (priceUno > priceDos)
            {
                Console.WriteLine("PDV is equal to " + (((priceUno/priceDos)-1)*100) + "%.");
            }
            if (priceUno < priceDos)
            {
                Console.WriteLine("PDV is equal to " + (((priceDos / priceUno) -1) *100) + "%.");
            }
            Console.ReadKey();
        }
    }
}
