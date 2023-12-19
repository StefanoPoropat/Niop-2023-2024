using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace neboder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Neb Tower = new Neb(200, 100);

            Console.WriteLine(Tower.ToString());
            Console.ReadKey();
        }
    }
}
