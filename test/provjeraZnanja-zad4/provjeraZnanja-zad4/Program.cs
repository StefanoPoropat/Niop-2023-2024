using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provjeraZnanja_zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            start: Console.WriteLine("Unesite vrijednost stranica trokuta (a b c), odvojene razmakom: ");
            try
            {
                string str = Console.ReadLine();
                string[] temp = str.Split(' ');
                double a = Convert.ToDouble(temp[0]);
                double b = Convert.ToDouble(temp[1]);
                double c = Convert.ToDouble(temp[2]);
                if (a > 0 && b > 0 && c > 0)
                {
                    if (Math.Pow(c, 2) == (Math.Pow(a, 2) + Math.Pow(b, 2)))
                    {
                        Console.WriteLine("Trkokut je pravkokutan.");
                    }
                    if (Math.Pow(c, 2) != (Math.Pow(a, 2) + Math.Pow(b, 2)))
                    {
                        Console.WriteLine("\nTrkokut nije pravkokutan.");
                    }
                }
                if (a <= 0 && b >= 0 && c >= 0)
                {
                    Console.WriteLine("\nUneseni brojevi nisu mogući.\nPokušajte ponovno.\n");
                    goto start;
                }
            }
            catch(System.FormatException e)
             {
                 Console.WriteLine("Niste unjeli broj.\nPokušajte ponovno.\n");
                goto start;
             }
            catch(System.IndexOutOfRangeException e)
            {
                Console.WriteLine("Kliknuo si enter, nisi li?\n");
                goto start;
            }
            Console.ReadKey();
        }
    }
}
