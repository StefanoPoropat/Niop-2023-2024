using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provjeraZnanja_nizovi_zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many numbers do you want to input in each array?: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int br = 0;
            int[] niz1 = new int[x];
            int[] niz2 = new int[x];
            int call = 0;
            Console.WriteLine("\nArray 1.");
            for (int i = 0; i<x; i++)
            {
            start1: try
                {
                    Console.Write((i + 1) + ". ");
                    niz1[i] = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    goto start1;
                }
            }
            Console.WriteLine("\nArray 2.");
            for (int i = 0; i < x ; i++)
            {
                start2:  try
                {
                    Console.Write((i + 1) + ". ");
                    niz2[i] = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    goto start2;
                }
            }
            for (int i = 0; i < x; i++)
            {
                {
                    if (niz1[i] == niz2[i])
                    {
                        br++;
                    }
                }
            }
            if (call <= 0)
            {
                Console.WriteLine("\n" + br + " inputs match.");
            }
            Console.ReadKey();
        }
    }
}
