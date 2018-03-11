using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterDiamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int pointLeftRightCounter = n - 1;
            int pointMidCounter = 3 * n;

            for (int i = 1; i <= n; i++)
            {
                if (i == 1)
                {
                    Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', 3 * n));
                }
                else
                {
                    Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', pointLeftRightCounter), new string('*', 1), new string('.', pointMidCounter));
                    pointLeftRightCounter -= 1;
                    pointMidCounter += 2;
                }
            }
            Console.WriteLine(new string('*', 5 * n));
            int pointLeftRightCounter2 = 1;
            int pointMidCounter2 = 5 * n - 4;
            for (int i = n + 2; i <= 3 * n + 2; i++)
            {
                if (i == 3 * n + 2)
                {
                    Console.WriteLine("{0}{1}{0}", new string('.', 2 * n + 1), new string('*', n - 2));
                }
                else
                {
                    Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', pointLeftRightCounter2), new string('*', 1), new string('.', pointMidCounter2));
                    pointLeftRightCounter2++;
                    pointMidCounter2 -= 2;
                }
            }
        }
    }
}
