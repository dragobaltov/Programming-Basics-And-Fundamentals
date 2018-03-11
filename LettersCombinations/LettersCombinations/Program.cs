using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersCombinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char letterForBeginning = char.Parse(Console.ReadLine());
            char letterForEnding = char.Parse(Console.ReadLine());
            char letterForMissing = char.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = Convert.ToInt16(letterForBeginning); i <= Convert.ToInt16(letterForEnding); i++)
            {
                if (i != Convert.ToInt16(letterForMissing))
                {
                    for (int j = Convert.ToInt16(letterForBeginning); j <= Convert.ToInt16(letterForEnding); j++)
                    {
                        if (j != Convert.ToInt16(letterForMissing))
                        {
                            for (int k = Convert.ToInt16(letterForBeginning); k <= Convert.ToInt16(letterForEnding); k++)
                            {
                                if (k != Convert.ToInt16(letterForMissing))
                                {
                                    counter++;
                                    Console.Write($"{Convert.ToChar(i)}{Convert.ToChar(j)}{Convert.ToChar(k)} ");
                                }
                            }
                        }
                    }
                }
            }
            Console.Write(counter);
        }
    }
}
