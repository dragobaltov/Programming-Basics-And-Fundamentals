using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocket
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int pointCounter = (3 * n - 2) / 2;
            int spaceCounter = 0;
            for (int row = 1; row <= n; row++)
            {
                Console.WriteLine("{0}{1}{2}{3}{0}", new string('.', pointCounter), new string('/', 1), new string(' ', spaceCounter), new string('\\', 1));
                pointCounter -= 1;
                spaceCounter += 2;
            }
            Console.WriteLine("{0}{1}{0}", new string('.', n / 2), new string('*', 2 * n));
            for (int i = n + 2; i <= 3 * n + 1; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', n / 2), new string('|', 1), new string('\\', 2 * n - 2));
            }
            int pointCounter2 = n / 2;
            int starsCounter = 2 * n - 2;
            for (int i = 3 * n + 2; i <= 3 * n + 1 + n / 2; i++)
            {
                Console.WriteLine("{0}{1}{2}{3}{0}", new string('.', pointCounter2), new string('/', 1), new string('*', starsCounter), new string('\\', 1));
                pointCounter2 -= 1;
                starsCounter += 2;
            }
        }
    }
}
