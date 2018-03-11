using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?<day>\d{2})(?<sep>[.\-\/])(?<month>[A-Z][a-z]{2})\k<sep>(?<year>\d{4})\b";
            string input = Console.ReadLine();
            var dates = Regex.Matches(input, pattern);

            foreach (Match item in dates)
            {
                string day = item.Groups["day"].Value;
                string month = item.Groups["month"].Value;
                string year = item.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
