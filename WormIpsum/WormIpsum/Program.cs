using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WormIpsum
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex patternForSentence = new Regex(@"^[A-Z][^\.]*\.$");
            Regex patternForWord = new Regex(@"[A-Za-z]+");

            while (!input.Equals("Worm Ipsum"))
            {
                if (patternForSentence.IsMatch(input))
                {
                    MatchCollection words = patternForWord.Matches(input);

                    foreach (Match match in words)
                    {
                        string currentWord = match.Value.ToString();
                        string newWord = NewWord(currentWord);

                        if (input.Contains(currentWord))
                            input = input.Replace(currentWord, newWord);
                    }

                    Console.WriteLine(input);
                }

                input = Console.ReadLine();
            }
        }

        static string NewWord(string word)
        {
            int maxCount = 1;
            char mostOccured = word[0];

            for (int i = 0; i < word.Length; i++)
            {
                char currentSymbol = word[i];
                int count = 0;

                for (int j = 0; j < word.Length; j++)
                {
                    if (word[j] == currentSymbol)
                    {
                        count++;
                    }
                }

                if (count > maxCount)
                {
                    maxCount = count;
                    mostOccured = currentSymbol;
                }
            }

            if (maxCount > 1)
                return new string(mostOccured, word.Length);

            return word;
        }
    }
}
