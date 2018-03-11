using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualPairs3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int lastSum = 0;
            int diff = 0;
            int maxDiff = 0;

            for (int i = 1; i <= n; i++)
            {
                int firstNum = int.Parse(Console.ReadLine());
                int secondNum = int.Parse(Console.ReadLine());
                lastSum = sum;
                sum = firstNum + secondNum;
                if (i > 1)
                {
                    diff = Math.Abs(lastSum - sum);
                    if (diff > maxDiff)
                    {
                        maxDiff = diff;
                    }
                }
            }

            if (maxDiff == 0)
            {
                Console.WriteLine($"Yes, value={sum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={maxDiff}");
            }
        }
    }
}
