using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MatchNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(^|(?<=\s))-?\d+(\.?\d+)?($|(?=\s))";
            string input = Console.ReadLine();
            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (var item in matches)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
