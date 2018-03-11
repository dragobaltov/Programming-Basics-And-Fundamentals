using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= (n + 1) / 2; row++)
            {
                Console.WriteLine(new string('-', n / 2 - row));
                if (row == 1)
                {
                    if (n % 2 == 0)
                    {
                        Console.WriteLine("**");
                    }
                    else
                    {
                        Console.WriteLine("");
                    }
                }

            }
        }
    }
}
