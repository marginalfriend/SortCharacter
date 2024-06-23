using System;
using System.Collections.Generic;
using System.Text;

namespace SortCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input one line of words (S): ");
            string input = Console.ReadLine();

            string vowels = "aeiou";
            StringBuilder vowelCharacters = new StringBuilder();
            StringBuilder consonantCharacters = new StringBuilder();

            foreach (char c in input.ToLower())
            {
                if (char.IsWhiteSpace(c)) continue;

                if (vowels.Contains(c))
                {
                    vowelCharacters.Append(c);
                }
                else if (char.IsLetter(c))
                {
                    consonantCharacters.Append(c);
                }
            }

            Console.WriteLine("Vowel Characters: " + vowelCharacters.ToString());
            Console.WriteLine("Consonant Characters: " + consonantCharacters.ToString());
        }
    }
}
