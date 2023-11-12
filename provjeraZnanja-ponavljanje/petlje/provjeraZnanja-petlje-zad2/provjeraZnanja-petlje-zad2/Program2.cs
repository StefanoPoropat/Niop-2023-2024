using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();

        // Convert the sentence to lowercase to make the counting case-insensitive
        sentence = sentence.ToLower();

        // Dictionary to store letter frequencies
        Dictionary<char, int> letterFrequencies = new Dictionary<char, int>();

        // Count letter frequencies
        foreach (char letter in sentence)
        {
            if (char.IsLetter(letter))
            {
                if (letterFrequencies.ContainsKey(letter))
                {
                    letterFrequencies[letter]++;
                }
                else
                {
                    letterFrequencies[letter] = 1;
                }
            }
        }

        // Find the most frequent letter
        char mostFrequentLetter = ' ';
        int maxFrequency = 0;

        foreach (var kvp in letterFrequencies)
        {
            if (kvp.Value > maxFrequency)
            {
                maxFrequency = kvp.Value;
                mostFrequentLetter = kvp.Key;
            }
        }

        // Display the result
        Console.WriteLine($"The most frequent letter is '{mostFrequentLetter}' with a frequency of {maxFrequency}.");
    }
}
