using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (i == 1 || i == n)
                {
                    Console.WriteLine("{0}{1}{0}", new string('*', 2 * n), new string(' ', n));
                }
                else if (i == Math.Ceiling(n * 1.0 / 2))
                {
                    Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", new string('*', 1), new string('/', 2 * n - 2), new string('|', n));
                }
                else
                {
                    Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", new string('*', 1), new string('/', 2 * n - 2), new string(' ', n));
                }
            }
        }
    }
}
