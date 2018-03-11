using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                Console.Write(new string(' ', n - row));
                for (int col = 1; col <= row; col++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            for (int row = n - 1; row >= 1; row--)
            {
                Console.Write(new string(' ', n - row));
                for (int i = row ; i >= 1; i--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

        }
    }
}
