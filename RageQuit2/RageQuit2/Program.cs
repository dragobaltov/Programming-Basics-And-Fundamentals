using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RageQuit2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex pattern = new Regex(@"(?<text>[^0-9]+)(?<number>[0-9]+)");
            MatchCollection matches = pattern.Matches(input);
            StringBuilder result = new StringBuilder();

            foreach (Match match in matches)
            {
                string value = match.Value.ToString();
                string textPart = match.Groups["text"].Value.ToString();
                int number = int.Parse(match.Groups["number"].Value.ToString());
                textPart = textPart.ToUpper();

                for (int i = 0; i < number; i++)
                {
                    result.Append(textPart);
                }
            }

            Console.WriteLine($"Unique symbols used: {result.ToString().Distinct().Count()}");
            Console.WriteLine(result.ToString());
        }
    }
}
