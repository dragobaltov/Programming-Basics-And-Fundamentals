using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawFort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (n > 4)
                {
                    if (i == 1)
                    {
                        Console.WriteLine("{0}{1}{2}{3}{0}{1}{2}", new string('/', 1), new string('^', n / 2), new string('\\', 1), new string('_', 2 * n - (2 * (n / 2)) - 4));
                    }
                    else if (i == n - 1)
                    {
                        Console.WriteLine("{0}{1}{2}{1}{0}", new string('|', 1), new string(' ', n / 2 + 1), new string('_', 2 * n - (2 * (n / 2)) - 4));
                    }
                    else if (i == n)
                    {
                        Console.WriteLine("{0}{1}{2}{3}{0}{1}{2}", new string('\\', 1), new string('_', n / 2), new string('/', 1), new string(' ', 2 * n - (2 * (n / 2)) - 4));
                    }
                    else
                    {
                        Console.WriteLine("{0}{1}{0}", new string('|', 1), new string(' ', 2 * n - 2));
                    }
                }
                else
                {
                    if (i == 1)
                    {
                        Console.WriteLine("{0}{1}{2}{0}{1}{2}", new string('/', 1), new string('^', n / 2), new string('\\', 1));
                    }
                    else if (i == n)
                    {
                        Console.WriteLine("{0}{1}{2}{0}{1}{2}", new string('\\', 1), new string('_', n / 2), new string('/', 1));
                    }
                    else
                    {
                        Console.WriteLine("{0}{1}{0}", new string('|', 1), new string(' ', 2 * n - 2));
                    }
                }
            }
        }
    }
}
