using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond2
{
    class Program
    {
        private static int i;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n == 1 || n == 2)
            {
                Console.Write(new string('*', n));
            }
            else if (n % 2 == 0 && n != 2)
            {
                int firstLastTiresCounter = (n - 2) / 2;
                int middleTiresCounter = 0;
                int starsCounter = 1;
                for (int row = 1; row <= n / 2; row++)
                {
                    Console.WriteLine("{0}{1}{2}{1}{0}", new string('-', firstLastTiresCounter), new string('*', starsCounter), new string('-', middleTiresCounter));
                    firstLastTiresCounter -= 1;
                    middleTiresCounter += 2;
                }
                int firstLastTiresCounter2 = 1;
                int middleTiresCounter2 = n - 4;
                for (int i = n / 2 + 1; i < n; i++)
                {
                    Console.WriteLine("{0}{1}{2}{1}{0}", new string('-', firstLastTiresCounter2), new string('*', starsCounter), new string('-', middleTiresCounter2));
                    firstLastTiresCounter2 += 1;
                    middleTiresCounter2 = middleTiresCounter2 - 2;
                }
            }
            else if (n % 2 == 1 && n != 1)
            {
                int firstLastTiresCounterRow1 = (n - 1) / 2;
                int firstLastTiresCounter = (n - 1) / 2 -1;
                int middleTiresCounter = 1;
                int starsCounter = 1;
                for (int i = 1; i <= Math.Ceiling(n * 1.0 / 2); i++)
                {
                    if (i == 1)
                    {
                        Console.WriteLine("{0}{1}{0}", new string('-', firstLastTiresCounterRow1), new string('*', starsCounter));
                    }
                    else
                    {
                        Console.WriteLine("{0}{1}{2}{1}{0}", new string('-', firstLastTiresCounter), new string('*', starsCounter), new string('-', middleTiresCounter));
                        firstLastTiresCounter -= 1;
                        middleTiresCounter += 2;
                    }
                }
                int firstLastTiresCounter2 = 1;
                int middleTiresCounter2 = n - 4;
                for (int i = ((n + 1) / 2) + 1; i <= n; i++)
                {
                    if (i == n)
                    {
                        Console.WriteLine("{0}{1}{0}", new string('-', firstLastTiresCounterRow1), new string('*', starsCounter));
                    }
                    else
                    {
                        Console.WriteLine("{0}{1}{2}{1}{0}", new string('-', firstLastTiresCounter2), new string('*', starsCounter), new string('-', middleTiresCounter2));
                        firstLastTiresCounter2 += 1;
                        middleTiresCounter2 -= 2;
                    }
                }

            }

        }
    }
}
