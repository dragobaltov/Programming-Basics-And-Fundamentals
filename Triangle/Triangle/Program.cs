using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int pointCounter = 1;
            int spaceCounter = 1;
            int dsCounter = 2 * n - 1;

            Console.WriteLine("{0}", new string('#', 4 * n + 1));
            for (int i = 2; i <= n + 1; i++)
            {
                if (i == n / 2 + 2)
                {
                    Console.WriteLine("{0}{1}{2}{3}{4}{5}{2}{1}{0}", new string('.', pointCounter), new string('#', dsCounter), new string(' ', (spaceCounter - 3) / 2), new string('(', 1), new string('@', 1), new string(')', 1));
                }
                else
                {
                    Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', pointCounter), new string('#', dsCounter), new string(' ', spaceCounter));
                }
                pointCounter++;
                spaceCounter += 2;
                dsCounter -= 2;
            }
            dsCounter = 2 * n - 1;
            for (int i = n + 2; i <= 2 * n + 1; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', pointCounter), new string('#', dsCounter));
                pointCounter++;
                dsCounter -= 2;
            }
        }
    }
}
