using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 0; row < n; row++)
            {
                for (int col = 1; col <= n ; col++)
                {
                    int sum = row + col;

                    if (sum > n)
                    {
                        sum = n - (sum % n);
                    }
                    Console.Write($"{sum} ");
                }
                Console.WriteLine();
            }
        }
    }
}
