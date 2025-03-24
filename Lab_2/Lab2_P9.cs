using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Lab2_P9
    {
        public void Lab2_p9()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            string longestWord = FindLongestWord(input);

            Console.WriteLine("The longest word is: " + longestWord);
        }
        string FindLongestWord(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return string.Empty;
            }

            string[] words = input.Split(new char[] { ' ', '\t', '\n', '\r', '.', ',', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            string longestWord = string.Empty;
            int maxLength = 0;

            foreach (string word in words)
            {
                if (word.Length > maxLength)
                {
                    maxLength = word.Length;
                    longestWord = word;
                }
            }

            return longestWord;
        }
    }
}
