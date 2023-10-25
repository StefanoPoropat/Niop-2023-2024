using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasaString_vjezbe4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            start: Console.Write("Unesite rečenicu sa barem dvije riječi: ");
            string str = Console.ReadLine();
            string[] strSplit = str.Split((new char[] { ' ' }));
            int br = strSplit.Length;
            if (br < 2)
            {
                Console.WriteLine("");
                Console.WriteLine("Rečenica je prekratka.\nPokušajte ponovno\n");
                Console.WriteLine("");
                goto start;
            }
            //Console.WriteLine(br);
            Console.WriteLine(strSplit[0] + " " + strSplit[br-1]);
            Console.ReadKey();
        }
    }
}
