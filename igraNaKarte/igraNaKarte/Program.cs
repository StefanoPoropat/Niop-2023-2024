using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace igraNaKarte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float unos = 0, zbroj = 0;
            start:  do
            {
                Console.Write("Unesi broj u rasponu od 1 do 13: ");
                unos = (float) Convert.ToDouble(Console.ReadLine());    
                if (unos >= 1 && unos <= 13) {
                    zbroj += unos;
                }
                else
                {
                    Console.WriteLine("Broj nije u rasponu, pokušajte ponovno");
                    Console.WriteLine("");
                    goto start;
                }
               
            }while (zbroj < 31);
            if (zbroj == 31)
            {
                Console.WriteLine("");
                Console.WriteLine("Pobijedili ste!");
                Console.WriteLine("Ukupna vrijednost karata je 31");
            }
           if(zbroj > 31)
            {
                Console.WriteLine("");
                Console.WriteLine("Izgubili ste");
                Console.WriteLine("Ukupna vrijednost karata je veća od 31 (" + zbroj + ")");
            }
            Console.ReadKey();
        }
        
    }
}
