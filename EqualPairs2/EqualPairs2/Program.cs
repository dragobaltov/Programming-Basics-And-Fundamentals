using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualPairs2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currentSum = 0;
            int previousSum = 0;
            int maxDiff = 0;

            for (int i = 0; i < n; i++)
            {
                previousSum = currentSum;
                currentSum = 0;
                currentSum += int.Parse(Console.ReadLine());
                currentSum += int.Parse(Console.ReadLine());

                if (i != 0)
                {
                    var diff = Math.Abs(currentSum - previousSum);
                    if (diff != 0 && diff > maxDiff)
                    {
                        maxDiff = diff;
                    }
                }

            }

            if (previousSum == currentSum || n == 1)
            {
                Console.WriteLine($"Yes, value={currentSum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={maxDiff}");
            }
        }
    }
}
