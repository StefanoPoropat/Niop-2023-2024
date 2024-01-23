using dot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sport ili zrakoplov? (S/Z)");
            String ans = Console.ReadLine();
            if (ans == "S")
            {
                Sport Nogomet = new Sport("Nogomet");
                Sport Vaterpolo = new Sport("Vaterpolo", true);
                Sport Curling = new Sport("Curling", false, 8);
                Console.WriteLine(Nogomet.ToString());
                Console.WriteLine(Vaterpolo.ToString());
                Console.WriteLine(Curling.ToString());
            }
            if (ans=="Z")
            {
                Zrakoplov x380 = new Zrakoplov("Airbus", 2000, 6000, 0, 200);
                Console.WriteLine(x380.ToString());
            }
            Console.ReadKey();
        }
    }
}
