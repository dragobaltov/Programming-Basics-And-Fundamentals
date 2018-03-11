using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regexmon2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Regex bojomonPattern = new Regex(@"[A-Za-z]+-[A-Za-z]+");
            Regex didimonPattern = new Regex(@"[^A-Za-z-]+");

            while (true)
            {
                if (didimonPattern.IsMatch(text))
                {
                    Match match = didimonPattern.Match(text);
                    Console.WriteLine(match.Value);

                    int startIndex = text.IndexOf(match.Value.ToString());
                    text = text.Remove(0, startIndex + match.Value.ToString().Length);
                }
                else
                {
                    break;
                }

                if (bojomonPattern.IsMatch(text))
                {
                    Match match = bojomonPattern.Match(text);
                    Console.WriteLine(match.Value);

                    int startIndex = text.IndexOf(match.Value.ToString());
                    text = text.Remove(0, startIndex + match.Value.ToString().Length);
                }
                else
                {
                    break;
                }
            }
        }
    }
}
