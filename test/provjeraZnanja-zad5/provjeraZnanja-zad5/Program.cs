using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provjeraZnanja_zad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite broj brojeva koje želite unjeti u niz: ");
            int maxNumber = Convert.ToInt32(Console.ReadLine());
            double[] str = new double[maxNumber];
            double rez = 0;
            for(int i=0; i<maxNumber; i++)
            {
                Console.WriteLine("Unesite "+(i+1)+". broj: ");
                str[i] = Convert.ToDouble(Console.ReadLine());
                rez = rez + str[i];
            }
            rez = (rez/maxNumber);
            double temp = 0, temp2 = 0, finalrez=0;
            for (int i=0; i<maxNumber; i++)
            {
                temp = Math.Abs((str[i])-rez);
                if (temp2 < temp)
                {
                    temp2 = temp;
                    finalrez = str[i+1];
                }
                Console.WriteLine("Temp: " + temp);
            }
            Console.WriteLine("Temp2: " + temp2);
            Console.WriteLine("Najmanje odstupanje od strednje vrijednosti (" + rez + ") ima broj: " + finalrez);
            Console.ReadKey();
        }
    }
}
