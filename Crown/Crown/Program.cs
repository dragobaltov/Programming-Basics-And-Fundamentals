using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crown
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}{0}{1}{0}", new string('@', 1), new string(' ', n - 2));
            Console.WriteLine("{0}{1}{2}{1}{0}", new string('*', 2), new string(' ', n - 3), new string('*', 1));
            int pointEndsCounter = 1;
            int pointMidCounter = 1;
            int spaceCounter = n - 5;
            for (int i = 3; i <= n / 2; i++)
            {
                Console.WriteLine("{0}{1}{0}{2}{0}{3}{0}{2}{0}{1}{0}", new string('*', 1), new string('.', pointEndsCounter), new string(' ', spaceCounter), new string('.', pointMidCounter));
                pointEndsCounter++;
                pointMidCounter += 2;
                spaceCounter -= 2;
            }
            if (n % 2 == 0)
            {
                Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", new string('*', 1), new string('.', n / 2 - 1), new string('.', n - 3));
                Console.WriteLine("{0}{1}{2}{3}{2}{1}{0}", new string('*', 1), new string('.', n / 2), new string('*', n / 2 - 2), new string('.', 1));
            }
            else
            {
                Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", new string('*', 1), new string('.', n / 2 - 1), new string('.', n - 2));
                Console.WriteLine("{0}{1}{2}{3}{2}{1}{0}", new string('*', 1), new string('.', n / 2), new string('*', n / 2 - 1), new string('.', 1));
            }
            Console.WriteLine(new string('*', 2 * n - 1));
            Console.WriteLine(new string('*', 2 * n - 1));
        }
    }
}
