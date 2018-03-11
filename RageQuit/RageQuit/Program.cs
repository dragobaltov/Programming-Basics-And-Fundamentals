using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RageQuit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(?<text>[^0-9]+)(?<number>\d+)";
            MatchCollection matches = Regex.Matches(input, pattern);
            StringBuilder result = new StringBuilder();

            foreach (Match match in matches)
            {
                string text = match.Groups["text"].Value.ToUpper();
                int number = int.Parse(match.Groups["number"].Value);

                for (int i = 0; i < number; i++)
                {
                    result.Append(text);
                }
            }

            int uniqueSymbols = result.ToString().Distinct().ToArray().Length;

            Console.WriteLine("Unique symbols used: {0}", uniqueSymbols);
            Console.WriteLine(result.ToString());
        }
    }
}
