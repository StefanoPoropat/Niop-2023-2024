using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klaseIObjekti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zrakoplov x380 = new Zrakoplov("Airbus", 2000, 6000);
            Zrakoplov C162 = new Zrakoplov("Cessna Skycatcher", 75, 870);
            Zrakoplov PC21 = new Zrakoplov("Pilatus", 1200, 1333);

            Console.WriteLine("\n"+ x380);
            Console.WriteLine(C162);
            Console.WriteLine(PC21);

            Console.ReadKey();
        }
    }
}
