using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butterfly2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n - 2; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine("{0}{1}{2}{3}{0}", new string('*', n - 2), new string('\\', 1), new string(' ', 1), new string('/', 1));
                }
                else
                {
                    Console.WriteLine("{0}{1}{2}{3}{0}", new string('-', n - 2), new string('\\', 1), new string(' ', 1), new string('/', 1));
                }
            }
            Console.WriteLine("{0}{1}{0}", new string(' ', n - 1), new string('@', 1));
            for (int i = n; i <= 2 * (n - 2) + 1; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine("{0}{1}{2}{3}{0}", new string('*', n - 2), new string('/', 1), new string(' ', 1), new string('\\', 1));
                }
                else
                {
                    Console.WriteLine("{0}{1}{2}{3}{0}", new string('-', n - 2), new string('/', 1), new string(' ', 1), new string('\\', 1));
                }
            }
        }
    }
}
