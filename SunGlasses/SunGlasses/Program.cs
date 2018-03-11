using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunGlasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string stars = new string('*', 2 * n);
            string glass = new string('/', 2 * n - 2);
            string frame = new string('|', n);
            string space = new string(' ', n);

            for (int row = 1; row <= n; row++)
            {
                if (row == 1 || row == n)
                {
                    Console.Write(stars);
                    Console.Write(space);
                    Console.Write(stars);
                }
                else
                {
                    Console.Write("*");
                    Console.Write(glass);
                    Console.Write("*");
                    if (row == (n + 1) / 2)
                    {
                        Console.Write(frame);
                    }
                    else
                    {
                        Console.Write(space);
                    }
                    Console.Write("*");
                    Console.Write(glass);
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
