using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniLogo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int pointCounter = 6 * n - 3;
            int dsCounter = 1;

            for (int i = 1; i <= 2 * n; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', pointCounter), new string('#', dsCounter));
                dsCounter += 6;
                pointCounter -= 3;
            }
            int pointLeftCounter = 2;
            int pointRightCounter = 3;
            int dsCounter2 = 12 * n - 11;
            for (int i = 2 * n + 1; i <= 3 * n - 2; i++)
            {
                Console.WriteLine("{0}{1}{2}{3}", new string('|', 1), new string('.', pointLeftCounter), new string('#', dsCounter2), new string('.', pointRightCounter));
                pointLeftCounter += 3;
                pointRightCounter += 3;
                dsCounter2 -= 6;
            }
            for (int i = 3 * n - 1; i <= 4 * n - 2; i++)
            {
                if (i == 4 * n - 2)
                {
                    Console.WriteLine("{0}{1}{2}{3}", new string('@', 1), new string('.', pointLeftCounter), new string('#', dsCounter2), new string('.', pointLeftCounter + 1));
                }
                else
                {
                    Console.WriteLine("{0}{1}{2}{3}", new string('|', 1), new string('.', pointLeftCounter), new string('#', dsCounter2), new string('.', pointLeftCounter + 1));
                }
            }
        }
    }
}
