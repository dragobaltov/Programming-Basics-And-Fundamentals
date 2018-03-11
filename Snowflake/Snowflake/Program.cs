using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Snowflake
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstSurface = Console.ReadLine();
            string firstMantle = Console.ReadLine();
            string coreLine = Console.ReadLine();
            string secondMantle = Console.ReadLine();
            string secondSurface = Console.ReadLine();

            Regex surfacePattern = new Regex(@"^[^A-Za-z0-9]*$");
            Regex mantlePattern = new Regex(@"^[0-9_]*$");
            Regex coreLinePattern = new Regex(@"^([^A-Za-z0-9]*)([0-9_]*)(?<core>[A-Za-z]*)([0-9_]*)([^A-Za-z0-9]*)$");

            if (surfacePattern.IsMatch(firstSurface) && surfacePattern.IsMatch(secondSurface) &&
                mantlePattern.IsMatch(firstMantle) && mantlePattern.IsMatch(secondMantle)
                && coreLinePattern.IsMatch(coreLine))
            {
                Match match = coreLinePattern.Match(coreLine);
                int length = match.Groups["core"].Value.ToString().Length;

                Console.WriteLine("Valid");
                Console.WriteLine(length);
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
