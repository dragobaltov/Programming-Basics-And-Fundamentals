using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0, c1 = 0;
            double p2 = 0, c2 = 0;
            double p3 = 0, c3 = 0;
            double p4 = 0, c4 = 0;
            double p5 = 0, c5 = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if(number < 200)
                {
                    c1++;
                }
                else if(number <= 399)
                {
                    c2++;
                }
                else if(number <= 599)
                {
                    c3++;
                }
                else if (number <= 799)
                {
                    c4++;
                }
                else
                {
                    c5++;
                }
            }
            p1 = (c1 / n) * 100;
            p2 = (c2 / n) * 100;
            p3 = (c3 / n) * 100;
            p4 = (c4 / n) * 100;
            p5 = (c5 / n) * 100;

            Console.WriteLine($"{p1:F2} %");
            Console.WriteLine($"{p2:F2} %");
            Console.WriteLine($"{p3:F2} %");
            Console.WriteLine($"{p4:F2} %");
            Console.WriteLine($"{p5:F2} %");
        }
    }
}
