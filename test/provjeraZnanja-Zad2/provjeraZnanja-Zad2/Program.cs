using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provjeraZnanja_Zad2
{
    internal class Program
    {
        /*public static string sortString(string inputString)
        {
            char[] tempArray = inputString.ToCharArray();
            Array.Sort(tempArray);
            return new string(tempArray);
        }*/
        static void Main(string[] args)
        {
            Console.Write("Unesite prvi string: ");
            string str1 = Console.ReadLine();
            Console.Write("Unesite drugi string: ");
            string str2 = Console.ReadLine();
            int a = str1.Length + str2.Length;
            int br1 = 0, br2 = 0;
            /*char[] str11 = str1.ToCharArray();
            char[] str22 = str2.ToCharArray();*/
            //Console.WriteLine("String 1: "+ sortString(str1));
            //Console.WriteLine("String 1: " + sortString(str2));
            for (int i=0; i < a; i++)
            {
                if (str1[i+1] < str2[i+1])
                {
                    br1++;
                }
                if (str1[i] > str2[i])
                {
                    br2++;
                }
            }
            if (br1 > br2)
            {
                Console.WriteLine("\n" + str1);
                Console.WriteLine("\n" + str2);
            }
            if (br1 < br2)
            {
                Console.WriteLine("\n" + str2);
                Console.WriteLine("\n" + str1);
            }
            Console.ReadKey();
        }
       
    }
}
