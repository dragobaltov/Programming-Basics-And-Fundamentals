using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            MatchCollection names = Regex.Matches(input, pattern);

            foreach (var name in names)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine();
        }
    }
}
