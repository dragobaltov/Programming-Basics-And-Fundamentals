using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AnonymousVox
{
    class Program
    {
        static void Main(string[] args)
        {
            string encodedText = Console.ReadLine();
            string[] placeholders = Console.ReadLine().Split(new char[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries);
            string pattern = @"(?<start>[A-Za-z]+)(?<content>.+)\k<start>";
            int counter = 0;

            MatchCollection matches = Regex.Matches(encodedText, pattern);

            foreach (Match match in matches)
            {
                string start = match.Groups["start"].Value;
                string content = placeholders[counter];
                string result = start + content + start;

                encodedText = encodedText.Replace(match.Value, result);

                counter++;
            }

            Console.WriteLine(encodedText);
        }
    }
}
