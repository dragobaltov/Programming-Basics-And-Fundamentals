using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BoomingCannon
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(' ');
            int toSkip = int.Parse(numbers[0]);
            int toDestroy = int.Parse(numbers[1]);
            string input = Console.ReadLine();
            List<string> destroyedElements = new List<string>();

            string pattern = @"(?<=\\<<<).+?(?=\\<<<|$)";
            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match item in matches)
            {
                string text = item.Value;

                if (text.Length > toSkip)
                {
                    string substring = text.Substring(toSkip);

                    if (substring.Length > toDestroy)
                    {
                        substring = substring.Substring(0, toDestroy);
                    }

                    destroyedElements.Add(substring);
                }
            }


            Console.WriteLine(string.Join("/\\", destroyedElements));
        }
    }
}
