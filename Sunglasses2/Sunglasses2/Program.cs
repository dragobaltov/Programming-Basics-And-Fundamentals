using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++)
            {
                if (n % 2 == 0)
                {
                    if (row == 1 || row == n)
                    {
                        Console.Write(new string('*', 2 * n));
                        Console.Write(new string(' ', n));
                        Console.Write(new string('*', 2 * n));
                        Console.WriteLine();
                    }
                    else if (row == n / 2)
                    {
                        Console.Write("*");
                        Console.Write(new string('/', 2 * n - 2));
                        Console.Write("*");
                        Console.Write(new string('|', n));
                        Console.Write("*");
                        Console.Write(new string('/', 2 * n - 2));
                        Console.Write("*");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Write("*");
                        Console.Write(new string('/', 2 * n - 2));
                        Console.Write("*");
                        Console.Write(new string(' ', n));
                        Console.Write("*");
                        Console.Write(new string('/', 2 * n - 2));
                        Console.Write("*");
                        Console.WriteLine();
                    }
                }
                else
                {
                    if (row == 1 || row == n)
                    {
                        Console.Write(new string('*', 2 * n));
                        Console.Write(new string(' ', n));
                        Console.Write(new string('*', 2 * n));
                        Console.WriteLine();
                    }
                    else if (row == n / 2 + 1)
                    {
                        Console.Write("*");
                        Console.Write(new string('/', 2 * n - 2));
                        Console.Write("*");
                        Console.Write(new string('|', n));
                        Console.Write("*");
                        Console.Write(new string('/', 2 * n - 2));
                        Console.Write("*");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Write("*");
                        Console.Write(new string('/', 2 * n - 2));
                        Console.Write("*");
                        Console.Write(new string(' ', n));
                        Console.Write("*");
                        Console.Write(new string('/', 2 * n - 2));
                        Console.Write("*");
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
