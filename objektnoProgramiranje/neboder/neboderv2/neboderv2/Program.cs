using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace neboderv2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Želite li sami unijeti visinu nebodera i broj katova? (Y/N)");
            string ans = Console.ReadLine();
            if (ans == "Y")
            {
                neb Neboder = new neb();
                Console.Write("Visina: ");
                Neboder.Visina = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Broj katova: ");
                Neboder.BrKat = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Neboder.ToString());
            }
            if (ans == "N")
            {
                neb Neboder = new neb(200, 100);
                Neboder.Visina += 10;
                Neboder.BrKat += 1;
                Console.WriteLine(Neboder.ToString());
            }
            Console.ReadKey();
        }
    }
}
