using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provjeraZnanja_nizovi_zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n = 10;
            int[] numberDivTwo=new int[n];
            int[] numberNotDivTwo = new int[n];
            int temporary = 0;
            Console.WriteLine("Insert max 10 even and 10 odd numbers. ");
            int i = 0, divTwo=0, notDivTwo=0;

            while ((temporary != 0 || divTwo < 10 || notDivTwo < 10) && i<20)
            {
            start: try
                {
                    Console.Write((i + 1) + ". ");
                    temporary = Convert.ToInt32(Console.ReadLine());
                    if (temporary % 2 == 0)
                    {
                        numberDivTwo[divTwo] = temporary;
                        i++;
                        divTwo++;
                    }
                    if (temporary % 2 == 1)
                    {
                        numberNotDivTwo[notDivTwo] = temporary;
                        i++;
                        notDivTwo++;
                    }
                    if (temporary == 0)
                    {
                        goto end;
                    }
                }
                catch (System.FormatException e)
                {
                    Console.WriteLine("Inputed number does not fit set paramaters.\nTryAgain\n"); ;
                    goto start;
                }
                catch (System.IndexOutOfRangeException e)
                {
                    goto end;
                }
            }
            end: Console.Write("\nEven numbers: ");
            foreach (int number in numberDivTwo)
            {
                Console.Write(number + ", ");
            }
            Console.Write("\nOdd numbers: ");
            foreach (int number in numberNotDivTwo)
            {
                Console.Write(number + ", ");
            }
            Console.ReadKey();
        }
    }
}
