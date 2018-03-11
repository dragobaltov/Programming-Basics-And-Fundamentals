using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(^|(?<=[SHDC]))([2-9]|10|[JQKA])[SHDC]";
            MatchCollection matches = Regex.Matches(input, pattern);
            string result = "";

            for (int i = 0; i < matches.Count; i++)
            {
                if (i == matches.Count - 1)
                    result += matches[i].Value;
                else
                    result += matches[i].Value + ", ";
            }

            Console.WriteLine(result);
        }
    }
}
