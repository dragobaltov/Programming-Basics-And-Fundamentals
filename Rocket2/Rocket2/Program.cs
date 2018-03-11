using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocket2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int spaceCounter = 0;
            int pointCounter = (3 * n - 2) / 2;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}{1}{2}{3}{0}", new string('.', pointCounter), new string('/', 1), new string(' ', spaceCounter), new string('\\', 1));
                pointCounter--;
                spaceCounter += 2;
            }
            Console.WriteLine("{0}{1}{0}", new string('.', n / 2), new string('*', 2 * n));
            for (int i = n + 2; i <= 3 * n + 1; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', n / 2), new string('|', 1), new string('\\', 2 * n - 2));
            }
            int pointCounter2 = n / 2;
            int starCounter = 2 * n - 2;
            for (int i = 3 * n + 2; i <= 3 * n + n / 2 + 1; i++)
            {
                Console.WriteLine("{0}{1}{2}{3}{0}", new string('.', pointCounter2), new string('/', 1), new string('*', starCounter), new string('\\', 1));
                pointCounter2--;
                starCounter += 2;
            }
        }
    }
}
