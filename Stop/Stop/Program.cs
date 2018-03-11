using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int pointCounter = n;
            int lineCounter = 2 * n - 1;

            for (int i = 1; i <= n + 1; i++)
            {
                if (i == 1)
                {
                    Console.WriteLine("{0}{1}{0}", new string('.', n + 1), new string('_', 2 * n + 1));
                }
                else
                {
                    Console.WriteLine("{0}{1}{2}{3}{0}", new string('.', pointCounter), new string('/', 2), new string('_', lineCounter), new string('\\', 2));
                    pointCounter -= 1;
                    lineCounter += 2;
                }
            }
            Console.WriteLine("{0}{1}STOP!{1}{2}", new string('/', 2), new string('_', 2 * n - 3), new string('\\', 2));
            Console.WriteLine("{0}{1}{2}", new string('\\', 2), new string('_', 4 * n - 1), new string('/', 2));
            int pointCounter2 = 1;
            int lineCounter2 = 4 * n - 3;
            for (int i = n + 4; i <= 2 * n + 2; i++)
            {
                Console.WriteLine("{0}{1}{2}{3}{0}", new string('.', pointCounter2), new string('\\', 2), new string('_', lineCounter2), new string('/', 2));
                pointCounter2++;
                lineCounter2 -= 2;
            }
        }
    }
}
