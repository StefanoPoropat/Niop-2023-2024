using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provjeraZnanja_petlje_zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
        start: Console.Write("Inster a postitve, one digit number: ");
            try
            {
                int numberUno = Convert.ToInt32(Console.ReadLine());
                if (numberUno <= 0)
                {
                    Console.WriteLine("Inputed number is not inside of stated aparmeters.\nTry again.\n\n");
                    goto start;
                }
                string str="";
                for (int i = 1; i <=numberUno-1; i++)
                {
                    str = str + i;
                    Console.WriteLine(str);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Inputed number is not inside of stated aparmeters.\nTry again.\n\n");
                goto start;
            }
            Console.ReadKey();
        }
    }
}
