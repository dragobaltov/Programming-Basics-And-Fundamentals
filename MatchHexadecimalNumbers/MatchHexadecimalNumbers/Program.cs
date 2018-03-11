using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MatchHexadecimalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(0x)?[A-F0-9]+\b";
            string input = Console.ReadLine();
            List<Match> matches = Regex.Matches(input, pattern).Cast<Match>().ToList();

            Console.WriteLine(string.Join(" ", matches));
        }
    }
}
