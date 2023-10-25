using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace klasaString_vjezbe5
{
    internal class Program
    {
        static void Main(string[] args)
        {
        start: //Console.WriteLine(NumberFormatInfo.CurrentInfo.NumberDecimalSeparator);
            Console.Write("Unesite jedan cijeli i jedan decimalni broj (odvojene razmakom): ");
            string str = Console.ReadLine();
            string[] strSplit = str.Split((new char[] { ' ' }));
            if (strSplit[0].Contains("."))
            {
                try
                {
                    double x = Convert.ToDouble(strSplit[0], CultureInfo.InvariantCulture);
                    //Console.WriteLine(x);
                    //Console.WriteLine(strSplit[0]);
                    int y = Convert.ToInt32(strSplit[1], CultureInfo.InvariantCulture);
                    //Console.WriteLine(y);
                    //Console.WriteLine(strSplit[1]);
                    Console.WriteLine("");
                    Console.WriteLine("Cijeli broj y iznosi " + y + ", a decimalni broj x iznosi " + x);
                }
                catch (Exception e)
                {
                    Console.WriteLine("");
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Molimo, unesite samo dva broja.");
                    Console.WriteLine("");
                    goto start;
                }
            }
            if (!strSplit[0].Contains("."))
            {
                try
                {
                    double x = Convert.ToDouble(strSplit[1], CultureInfo.InvariantCulture);
                    //Console.WriteLine(x);
                    //Console.WriteLine(strSplit[1]);
                    int y = Convert.ToInt32(strSplit[0], CultureInfo.InvariantCulture);
                    //Console.WriteLine(y);
                    //Console.WriteLine(strSplit[0]);
                    Console.WriteLine("");
                    Console.WriteLine("Cijeli broj y iznosi " + y + ", a decimalni broj x iznosi " + x);
                }
                catch (Exception e)
                {
                    Console.WriteLine("");
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Molimo, unesite samo dva broja.");
                    Console.WriteLine("");
                    goto start;

                }
            }
            Console.ReadKey();
        }
    }
}
