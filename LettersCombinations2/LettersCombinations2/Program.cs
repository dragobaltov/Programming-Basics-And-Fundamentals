using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersCombinations2
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter1 = char.Parse(Console.ReadLine());
            char letter2 = char.Parse(Console.ReadLine());
            char letterMissing = char.Parse(Console.ReadLine());
            int counter = 0;

            for (char i = letter1; i <= letter2; i++)
            {
                if (i != letterMissing)
                {
                    for (char j = letter1; j <= letter2; j++)
                    {
                        if (j != letterMissing)
                        {
                            for (char k = letter1; k <= letter2; k++)
                            {
                                if (k != letterMissing)
                                {
                                    counter++;
                                    Console.Write($"{i}{j}{k} ");
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
