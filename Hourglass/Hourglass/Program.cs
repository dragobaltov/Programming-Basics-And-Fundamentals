using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hourglass
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int pointCounter = 2;
            int aCounter = 2 * n - 5;

            Console.WriteLine("{0}", new string('*', 2 * n + 1));
            Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', 1), new string('*', 1), new string(' ', 2 * n - 3));
            for (int i = 3; i <= n; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', pointCounter), new string('*', 1), new string('@', aCounter));
                pointCounter++;
                aCounter -= 2;
            }
            Console.WriteLine("{0}{1}{0}", new string('.', pointCounter), new string('*', 1));
            pointCounter--;
            int spaceCounter = 0;
            for (int i = n + 2; i <= 2 * n - 1; i++)
            {
                Console.WriteLine("{0}{1}{2}{3}{2}{1}{0}", new string('.', pointCounter), new string('*', 1), new string(' ', spaceCounter), new string('@', 1));
                pointCounter--;
                spaceCounter++;
            }
            Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', 1), new string('*', 1), new string('@', 2 * n - 3));
            Console.WriteLine("{0}", new string('*', 2 * n + 1));
        }
    }
}
