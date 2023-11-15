using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provjeraZnanja_zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite n-ti broj Fibonaccijevog niza: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int rez = 0;
            int[] temp = new int[x+1];
            temp[0] = 1;
            for(int i=1; i<x; i++)
            {
                Console.WriteLine(i + ". član niza: " + rez);
                temp[i] = rez;
                rez = rez + temp[i-1];
                
            }
            Console.ReadKey();
        }
    }
}
