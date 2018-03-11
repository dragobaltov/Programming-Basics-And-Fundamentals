using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniLogo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int dsCounter = 1;
            int pointCounter = 6 * n - 3;

            for (int i = 1; i <= 2 * n; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', pointCounter), new string('#', dsCounter));
                dsCounter += 6;
                pointCounter -= 3;
            }
            pointCounter += 6;
            dsCounter -= 12;
            for (int i = 2 * n + 1; i <= 3 * n - 2; i++)
            {
                Console.WriteLine("{0}{1}{2}{3}", new string('|', 1), new string('.', pointCounter - 1), new string('#', dsCounter), new string('.', pointCounter));
                pointCounter += 3;
                dsCounter -= 6;
            }
            for (int i = 3 * n - 1; i <= 4 * n - 2; i++)
            {
                if (i == 4 * n - 2)
                {
                    Console.WriteLine("{0}{1}{2}{3}", new string('@', 1), new string('.', pointCounter - 1), new string('#', dsCounter), new string('.', pointCounter));
                }
                else
                {
                    Console.WriteLine("{0}{1}{2}{3}", new string('|', 1), new string('.', pointCounter - 1), new string('#', dsCounter), new string('.', pointCounter));
                }
            }
        }
    }
}
