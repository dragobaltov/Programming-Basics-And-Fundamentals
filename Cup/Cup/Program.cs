using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cup
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int pointCounter = n;
            int dsCounter = 3 * n;

            for (int i = 1; i <= n / 2; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', pointCounter), new string('#', dsCounter));
                pointCounter++;
                dsCounter -= 2;
            }
            for (int i = n / 2 + 1; i <= n + 1; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', pointCounter), new string('#', 1), new string('.', dsCounter - 2));
                pointCounter++;
                dsCounter -= 2;
            }
            pointCounter--;
            dsCounter += 2;
            Console.WriteLine("{0}{1}{0}", new string('.', pointCounter), new string('#', dsCounter));
            pointCounter -= 2;
            dsCounter += 4;
            for (int i = n + 3; i <= 2 * n + 4; i++)
            {
                if (i == n + n / 2 + 3)
                {
                    Console.WriteLine("{0}D^A^N^C^E^{0}", new string('.', (5 * n - 10) / 2));
                }
                else
                {
                    Console.WriteLine("{0}{1}{0}", new string('.', pointCounter), new string('#', dsCounter));
                }
            }
        }
    }
}
