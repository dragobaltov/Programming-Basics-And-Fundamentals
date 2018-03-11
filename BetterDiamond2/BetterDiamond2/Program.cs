using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterDiamond2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int endPointCounter = n - 1;
            int midPointCounter = 3 * n;

            Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', 3 * n));
            for (int i = 2; i <= n; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', endPointCounter), new string('*', 1), new string('.', midPointCounter));
                endPointCounter--;
                midPointCounter += 2;
            }
            Console.WriteLine("{0}", new string('*', 5 * n));
            endPointCounter = 1;
            midPointCounter = 5 * n - 4;
            for (int i = n + 2; i <= 3 * n + 2; i++)
            {
                if (i == 3 * n + 2)
                {
                    Console.WriteLine("{0}{1}{0}", new string('.', 2 * n + 1), new string('*', n - 2));
                }
                else
                {
                    Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', endPointCounter), new string('*', 1), new string('.', midPointCounter));
                }
                endPointCounter++;
                midPointCounter -= 2;
            }
        }
    }
}
