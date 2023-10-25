using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasaString_vjezbe3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           start: Console.Write("Unesite niz od barem 11 znakova: ");
            string str = Console.ReadLine();
            string sVelika=str.ToUpper(), sMala = str.ToLower(), sPrvaTri = "", sZadnjihPet = "", s8_11 = "";
            int br = str.Length;
            if (br < 11)
            {
                Console.WriteLine("");
                Console.WriteLine("Uneseni niz nije duži od 11 znakova. \nMolimo unesite duži niz.\n");
                Console.WriteLine("");
                goto start;
            }
            for (int i = 0; i < 3; i++)
            {
                sPrvaTri += str[i];
            }
            for (int i = br-5; i <br; i++)
            {
                sZadnjihPet += str[i];
            }
            for (int i = 7; i <= 10; i++)
            {
                s8_11 += str[i];
            }
            Console.WriteLine("sVelika: " + sVelika);
            Console.WriteLine("sMala: " + sMala);
            Console.WriteLine("sPrvaTri: " + sPrvaTri);
            Console.WriteLine("sZadnjihPet: " + sZadnjihPet);
            Console.WriteLine("s8_11: " + s8_11);
            Console.ReadKey();
        }
    }
}
