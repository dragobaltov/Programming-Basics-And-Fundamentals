using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleWithStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 2 * (Math.Ceiling(n * 1.0 / 2)) + 1; i++)
            {
                if (i == 1 || i == 2 * (Math.Ceiling(n * 1.0 / 2)) + 1)
                {
                    Console.WriteLine(new string('%', 2 * n));
                }
                else if (i == Math.Ceiling(n * 1.0 / 2) + 1)
                {
                    Console.WriteLine("{0}{1}{2}{1}{0}", new string('%', 1), new string(' ', n - 2), new string('*', 2));
                }
                else
                {
                    Console.WriteLine("{0}{1}{0}", new string('%', 1), new string(' ', 2 * n - 2));
                }
            }
        }
    }
}
