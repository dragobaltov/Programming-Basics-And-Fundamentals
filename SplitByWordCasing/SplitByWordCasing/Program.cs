using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitByWordCasing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine().Split(new char[] { '\'',' ' , ',', ';', ':', '.', '!', '(', ')', '"', '\\', '/', '[', ']'}, 
                StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> lowerCaseList = new List<string>();
            List<string> upperCaseList = new List<string>();
            List<string> mixedCaseList = new List<string>();

            for (int i = 0; i < text.Count; i++)
            {
                int lowerLetterCounter = 0;
                int upperLetterCounter = 0;

                foreach (char letter in text[i])
                {
                    if (letter >= 'a' && letter <= 'z')
                    {
                        lowerLetterCounter++;
                    }
                    else if (letter >= 'A' && letter <= 'Z')
                    {
                        upperLetterCounter++;
                    }
                }

                if (lowerLetterCounter == text[i].Length)
                {
                    lowerCaseList.Add(text[i]);
                }
                else if(upperLetterCounter == text[i].Length)
                {
                    upperCaseList.Add(text[i]);
                }
                else
                {
                    mixedCaseList.Add(text[i]);
                }
            }

            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCaseList));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedCaseList));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCaseList));

        }
    }
}
