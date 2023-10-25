using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasaString_vjezba1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Hrvatska ima more";
            string s2 = "Italija je prvak svijeta";
            string s3 = " ";

            for(int i=0; i<=7; i++)
            {
                s3 += s1[i];
            }
            for (int i = 7; i < s2.Length; i++)
            {
                s3 += s2[i];
            }

            Console.WriteLine(s3);
            Console.ReadKey();
        }

    }
}
