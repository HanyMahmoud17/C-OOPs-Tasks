using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {


        Console.WriteLine("enter any text :");
        string text =Console.ReadLine();

        int numChars = text.Length;
        int numVowels = 0;
        int numConsonants = 0;
        int numNewlines = 0;

        foreach (char c in text)
        {
            if (Char.IsLetter(c))
            {
                if ("AEIOUaeiou".IndexOf(c) != -1)
                {
                    numVowels++;
                }
                else
                {
                    numConsonants++;
                }
            }
            else if (c == '\n')
            {
                numNewlines++;
            }
        }

        Console.WriteLine("Total number of characters: " + numChars);
        Console.WriteLine("Number of vowels: " + numVowels);
        Console.WriteLine("Number of consonants: " + numConsonants);
        Console.WriteLine("Number of newlines: " + numNewlines);
    }
}







