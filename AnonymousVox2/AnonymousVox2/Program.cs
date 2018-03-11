using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AnonymousVox2
{
    class Program
    {
        static void Main(string[] args)
        {
            string encodedText = Console.ReadLine();
            string[] placeholders = Console.ReadLine().Split(new char[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries);
            Regex pattern = new Regex(@"(?<start>[A-Za-z]+)(.+)(\k<start>)");
            char[] array = encodedText.ToCharArray();

            MatchCollection matches = pattern.Matches(encodedText);
            int index = 0;

            foreach (Match match in matches)
            {
                if (index < placeholders.Length)
                {
                    string start = match.Groups["start"].Value.ToString();
                    string currentValue = match.Value.ToString();
                    string newValue = start + placeholders[index] + start;

                    encodedText = encodedText.Replace(currentValue, newValue);
                    index++;
                }
            }

            Console.WriteLine(encodedText);
        }
    }
}
