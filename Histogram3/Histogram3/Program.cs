using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num < 200)
                {
                    p1++;
                }
                else if (num >= 200 && num <= 399)
                {
                    p2++;
                }
                else if (num >= 400 && num <= 599)
                {
                    p3++;
                }
                else if (num >= 600 && num <= 799)
                {
                    p4++;
                }
                else
                {
                    p5++;
                }
            }

            Console.WriteLine($"{p1 * 1.0 / n * 100:F2}");
            Console.WriteLine($"{p2 * 1.0 / n * 100:F2}");
            Console.WriteLine($"{p3 * 1.0 / n * 100:F2}");
            Console.WriteLine($"{p4 * 1.0 / n * 100:F2}");
            Console.WriteLine($"{p5 * 1.0 / n * 100:F2}");
        }
    }
}
