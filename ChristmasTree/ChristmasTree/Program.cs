using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int row = 0; row <= n; row++)
            {
                for (int i = 0; i < n - row; i++)
                {
                    Console.Write(" ");
                }
                for (int col = 0; col < row; col++)
                {
                    Console.Write("*");
                }
                Console.Write(" | ");
                for (int col = 0; col < row; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
