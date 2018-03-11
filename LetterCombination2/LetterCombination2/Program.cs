using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterCombination2
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char letterForMissing = char.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = firstLetter; i <= secondLetter; i++)
            {
                for (int j = firstLetter; j <= secondLetter; j++)
                {
                    for (int k = firstLetter; k <= secondLetter; k++)
                    {
                        if (i != letterForMissing && j != letterForMissing && k != letterForMissing)
                        {
                            counter++;
                            Console.Write($"{Convert.ToChar(i)}{Convert.ToChar(j)}{Convert.ToChar(k)} ");
                        }
                    }
                }
            }
            Console.Write(counter);
        }
    }
}
