using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace example_GeoBody
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double rez = 0;
            Circle c = new Circle("What", 5);
            c.write();
            Triangle t = new Triangle("Who", 4, 5);
            t.write();
            geoBody[] polje = {c, t};
            for (int i = 0; i < polje.Length; i++)
            {
                rez += polje[i].surface();
            }
            Console.WriteLine("Sum: " + rez);
            Console.ReadKey();
        }
    }
}
