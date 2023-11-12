using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provjeraZnanja_petlje_zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert a word/sentence: ");
            string word = Console.ReadLine();
            Dictionary<char, int> letters = new Dictionary<char, int>();
            for (int i = 0; i < word.Length; i++)
            {
                if (letters.ContainsKey(word[i]))
                {
                    letters[word[i]]++;
                }
                else
                {
                    letters[word[i]] = 1;
                }
            }
            int maxLetterFreq = 0;
            char maxLetterKey = ' ';
            int altmaxLetterFreq = 1;
            char altmaxLetterKey = ' ';
            foreach (var c in letters)
            {
                if (maxLetterFreq < c.Value)
                {
                    maxLetterFreq = c.Value;
                    maxLetterKey = c.Key;
                }
                if (altmaxLetterFreq == c.Value)
                {
                    altmaxLetterFreq = c.Value;
                    altmaxLetterKey = c.Key;
                }
            }
            string str = " ";
            int j = 1;
            if (altmaxLetterFreq == maxLetterFreq)
            {
                Console.WriteLine("There seem to be mulitple letter with the same frequency.\n");
                foreach (var c in letters)
                {
                    if (char.IsLetter(c.Key))
                    {
                        if (j == 1)
                        {
                            str = "1st";
                        }
                        if (j == 2)
                        {
                            str = "2nd";
                        }
                        if (j == 3)
                        {
                            str = "3rd";
                        }
                        if (j > 3)
                        {
                            str = j + "th";
                        }
                        Console.WriteLine("The " + str + " most frequent letter is '" + c.Key + "', with a frequency of " + c.Value + ".\n");
                        j++;
                    }
                }

            }
            j = 1;
            if (altmaxLetterFreq != maxLetterFreq)
            {
                foreach (var c in letters)
                {
                    if (char.IsLetter(c.Key))
                    {
                        if (j == 1)
                        {
                            Console.WriteLine("The most frequent letter is '" + maxLetterKey + "', with a frequency of " + maxLetterFreq + ".");
                            j++;
                        }
                    }

                }

            }
            Console.ReadKey();
        }
    }
}
