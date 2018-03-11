using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WordEncounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string filter = Console.ReadLine();
            char symbol = filter[0];
            int occurences = int.Parse(filter[1].ToString());
            string input = Console.ReadLine();
            List<string> validElements = new List<string>();
            string pattern = @"\w+";

            while (input != "end")
            {
                if ((input[0] >= 'A' && input[0] <= 'Z') &&
                    (input[input.Length - 1] == '.' || input[input.Length - 1] == '!'
                    || input[input.Length - 1] == '?'))
                {
                    MatchCollection matches = Regex.Matches(input, pattern);

                    foreach (Match item in matches)
                    {
                        if (ContainsNeededSymbols(item.Value, symbol, occurences))
                        {
                            string word = item.Value.Trim(' ');
                            validElements.Add(word);
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", validElements));
        }

        static bool ContainsNeededSymbols(string word, char symbol, int occurences)
        {
            int counter = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == symbol)
                {
                    counter++;
                }
            }

            return (counter >= occurences);
        }
    }
}
