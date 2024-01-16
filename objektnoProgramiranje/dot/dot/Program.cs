using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            krug circ = new krug(50);
            krug circ1 = new krug(50);
            dotclass dot = new dotclass(10,20);
            dotclass dot1 = new dotclass(0, 0);
            /*Console.WriteLine("Cords 1: (x,y)");
            dot.x=Convert.ToDouble(Console.ReadLine());
            dot.y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Cords 2: (x,y)");
            dot1.x = Convert.ToDouble(Console.ReadLine());
            dot1.y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Radius 1: ");
            circ.Radius = Convert.ToDouble(Console.ReadLine());
            dot.y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Radius 2: ");
            circ1.Radius = Convert.ToDouble(Console.ReadLine());
            /*Console.WriteLine("How many circles do you have? ");
            circ.CircCount = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < circ.CircCount; i++)
            {
                krug circNew = new krug();
                dotclass dot1 = new dotclass();
            }*/
            Console.WriteLine(dot.ToString()+"\n");
            Console.WriteLine(dot1.ToString() + "\n");
            Console.WriteLine(dot.udaljenost(dot1));
            Console.WriteLine(circ.ToString());
            Console.ReadLine();
        }
    }
}
