using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}{0}", new string('.', n / 2), new string('#', n));
            for (int i = 2; i <= n - 1; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', n / 2), new string('#', 1), new string('.', n - 2));
            }
            Console.WriteLine("{0}{1}{0}", new string('#', n / 2 + 1), new string('.', n - 2));
            int endPointCounter = 1;
            int midPointCounter = n + n / 2 + n / 2 - 4;
            for (int i = n + 1; i <= 2 * n - 1; i++)
            {
                if (n % 2 == 1)
                {
                    if (i == 2 * n - 1)
                    {
                        Console.WriteLine("{0}{1}{0}", new string('.', (n + n / 2 + n / 2 - 1) / 2), new string('#', 1));
                    }
                    else
                    {
                        Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', endPointCounter), new string('#', 1), new string('.', midPointCounter));
                    }
                }
                else
                {
                    Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', endPointCounter), new string('#', 1), new string('.', midPointCounter));
                }
                endPointCounter++;
                midPointCounter -= 2;
            }
        }
    }
}
