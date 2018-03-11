using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupName
{
    class Program
    {
        static void Main(string[] args)
        {
            char upperLetter = char.Parse(Console.ReadLine());
            char smallLetter1 = char.Parse(Console.ReadLine());
            char smallLetter2 = char.Parse(Console.ReadLine());
            char smallLetter3 = char.Parse(Console.ReadLine());
            int digit = int.Parse(Console.ReadLine());
            int counterSuggestions = 0;

            for (char i = 'A'; i <= upperLetter; i++)
            {
                for (char j = 'a'; j <= smallLetter1; j++)
                {
                    for (char k = 'a'; k <= smallLetter2; k++)
                    {
                        for (char l = 'a'; l <= smallLetter3; l++)
                        {
                            for (int g = 0; g <= digit; g++)
                            {
                                counterSuggestions++;
                            }
                        }
                    }
                }
            }

            Console.WriteLine(counterSuggestions - 1);
        }
    }
}
