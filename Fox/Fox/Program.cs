using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fox
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int starCounter = 1;
            int linesCounter = 2 * n - 1;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}{1}{2}{3}{0}", new string('*', starCounter), new string('\\', 1), new string('-', linesCounter), new string('/', 1));
                starCounter++;
                linesCounter -= 2;
            }
            int endStarCounter = n / 2;
            int midStarCounterOdd = n;
            int midStarCounterEven = n - 1;
            for (int i = n + 1; i <= n + n / 3; i++)
            {
                if (n % 2 == 1)
                {
                    Console.WriteLine("{0}{1}{2}{3}{4}{1}{0}", new string('|', 1), new string('*', endStarCounter), new string('\\', 1), new string('*', midStarCounterOdd), new string('/', 1));
                    endStarCounter++;
                    midStarCounterOdd -= 2;
                }
                else
                {
                    Console.WriteLine("{0}{1}{2}{3}{4}{1}{0}", new string('|', 1), new string('*', endStarCounter), new string('\\', 1), new string('*', midStarCounterEven), new string('/', 1));
                    endStarCounter++;
                    midStarCounterEven -= 2;
                }
            }
            int linesCounter2 = 1;
            int starCounter2 = 2 * n - 1;
            for (int i = n + n / 3 + 1; i <= 2 * n + n / 3; i++)
            {
                Console.WriteLine("{0}{1}{2}{3}{0}", new string('-', linesCounter2), new string('\\', 1), new string('*', starCounter2), new string('/', 1));
                starCounter2 -= 2;
                linesCounter2++;
            }
        }   
    }
}
