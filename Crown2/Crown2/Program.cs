using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crown2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int endPointCounter = 1;
            int midPointCounter = 1;
            int spaceCounter = n - 5;

            Console.WriteLine("{0}{1}{0}{1}{0}", new string('@', 1), new string(' ', n - 2));
            Console.WriteLine("{0}{1}{2}{1}{0}", new string('*', 2), new string(' ', n - 3), new string('*', 1));
            for (int i = 3; i <= n / 2 + 1; i++)
            {
                if (i == n / 2 + 1)
                {
                    if (n % 2 == 1)
                    {
                        Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", new string('*', 1), new string('.', endPointCounter + 1), new string('.', midPointCounter));
                    }
                    else
                    {
                        Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", new string('*', 1), new string('.', endPointCounter), new string('.', midPointCounter));
                    }
                }
                else
                {
                    Console.WriteLine("{0}{1}{0}{2}{0}{3}{0}{2}{0}{1}{0}", new string('*', 1), new string('.', endPointCounter), new string(' ', spaceCounter), new string('.', midPointCounter));
                }
                midPointCounter += 2;
                endPointCounter++;
                spaceCounter -= 2;
            }
            int starCounter = (2 * n - 4 - 2 * endPointCounter) / 2;
            if (n % 2 == 0)
            {
                Console.WriteLine("{0}{1}{2}{3}{2}{1}{0}", new string('*', 1), new string('.', endPointCounter), new string('*', starCounter), new string('.', 1));
            }
            else
            {
                Console.WriteLine("{0}{1}{2}{3}{2}{1}{0}", new string('*', 1), new string('.', endPointCounter), new string('*', starCounter), new string('.', 1));
            }
            Console.WriteLine("{0}", new string('*', 2 * n - 1));
            Console.WriteLine("{0}", new string('*', 2 * n - 1));
        }
    }
}
