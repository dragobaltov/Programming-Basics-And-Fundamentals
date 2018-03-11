using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxCombinations2
{
    class Program
    {
        static void Main(string[] args)
        {
            int beginning = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int maxCombinations = int.Parse(Console.ReadLine());
            int counterCombinations = 0;

            for (int i = beginning; i <= end; i++)
            {
                for (int j = beginning; j <= end; j++)
                {
                    counterCombinations++;
                    if (counterCombinations > maxCombinations)
                        break;
                    Console.Write($"<{i}-{j}>");
                }
            }
        }
    }
}
