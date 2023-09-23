using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uvodnaVjezba03
{
    internal class Program
    {
        static void Main(string[] args)
        {
           start: int x = 0, y = 0, z = 0;
            string anser;
            strA:Console.Write("Unesite a stranicu pravokutnog trokuta: ");
             x = Convert.ToInt32(Console.ReadLine());
            if(x <= 0){
                Console.WriteLine("Stranica a je manja ili jednaka nula.");
                Console.WriteLine("Pokušajte ponovo.");
                goto strA;
            }
            Console.WriteLine("");
            strB:Console.Write("Unesite b stranicu pravokutnog trokuta: ");
             y = Convert.ToInt32(Console.ReadLine());
            if (y <= 0){
                Console.WriteLine("Stranica b je manja ili jednaka nula.");
                Console.WriteLine("Pokušajte ponovo.");
                goto strB;
            }
            Console.WriteLine("");
            strC:Console.Write("Unesite c stranicu pravokutnog trokuta: ");
             z = Convert.ToInt32(Console.ReadLine());
            if(z <= 0){
                Console.WriteLine("Stranica c je manja ili jednaka nula.");
                Console.WriteLine("Pokušajte ponovo.");
                goto strC;
            }
            if (Math.Pow(z, 2) == (Math.Pow(x, 2) + Math.Pow(y, 2)))
            {
                Console.WriteLine("");
                Console.WriteLine("Ovo je pravokutni trokut.");
            }
            else
            {
                Console.WriteLine("Ovo nije pravokutni trokut.");
                Console.WriteLine("Stranica c iznosi: " + Math.Sqrt((Math.Pow(x, 2) + Math.Pow(y, 2))));
                Console.WriteLine("Želite li pokušati ponovno? Y/N");
                anser = Console.ReadLine(); 
                if (anser == "Y" || anser == "y")
                {
                    goto start;
                }
            }
            Console.ReadKey();
        }
    }
}
