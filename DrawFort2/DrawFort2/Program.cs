using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawFort2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n <= 4)
            {
                Console.WriteLine("{0}{1}{2}{0}{1}{2}", new string('/', 1), new string('^', n - 2), new string('\\', 1));
                for (int i = 2; i <= n - 1; i++)
                {
                    Console.WriteLine("{0}{1}{0}", new string('|', 1), new string(' ', 2 * n - 2));
                }
                Console.WriteLine("{0}{1}{2}{0}{1}{2}", new string('\\', 1), new string('_', n - 2), new string('/', 1));
            }
            else
            {
                Console.WriteLine("{0}{1}{2}{3}{0}{1}{2}", new string('/', 1), new string('^', n / 2), new string('\\', 1), new string('_', 2 * n - 4 - 2 * (n / 2)));
                for (int i = 2; i <= n - 1; i++)
                {
                    if (i == n - 1)
                    {
                        Console.WriteLine("{0}{1}{2}{1}{0}", new string('|', 1), new string(' ', n / 2 + 1), new string('_', 2 * n - 4 - 2 * (n / 2)));
                    }
                    else
                    {
                        Console.WriteLine("{0}{1}{0}", new string('|', 1), new string(' ', 2 * n - 2));
                    }
                }
                Console.WriteLine("{0}{1}{2}{3}{0}{1}{2}", new string('\\', 1), new string('_', n / 2), new string('/', 1), new string(' ', 2 * n - 4 - 2 * (n / 2)));
            }
        }
    }
}
