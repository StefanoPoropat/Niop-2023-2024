using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provjeraZnanja_varijable_zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Hrvatska ima more";
            string s2 = "Italija je prvak svijeta";
            string s3 = "";

            s3 = s1.Substring(0,8) + s2.Substring(7);
            Console.WriteLine(s3);
            Console.ReadKey();
        }
    }
}
