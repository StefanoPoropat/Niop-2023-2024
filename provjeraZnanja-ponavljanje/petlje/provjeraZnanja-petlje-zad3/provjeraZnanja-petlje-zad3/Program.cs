using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provjeraZnanja_petlje_zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter the first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int largestCommonDivisor = FindLargestCommonDivisor(number1, number2);
            Console.WriteLine("The largest number by which both " + number1 + " and " + number2 + " are divisible is: " + largestCommonDivisor +".");
            Console.ReadKey(); 
        }
        static int FindLargestCommonDivisor(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b != 0)
            {
                int temp = b; Console.WriteLine("temp=b: " + temp);
                b = a % b; Console.WriteLine("b=a%b: " + b);
                a = temp; Console.WriteLine("a=temp: " + a+"\n");
            }
            return a;
        }
        }
    }

