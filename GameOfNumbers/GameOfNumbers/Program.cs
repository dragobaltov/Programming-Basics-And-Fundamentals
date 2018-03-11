using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int counter = 0;
            bool equal = false;

            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    counter++;
                    if (i + j == magicNumber)
                    {
                        equal = true;
                        if (i > j)
                        {
                            Console.WriteLine($"Number found! {i} + {j} = {magicNumber}");
                        }
                        else
                        {
                            Console.WriteLine($"Number found! {j} + {i} = {magicNumber}");
                        }
                    }
                    if (equal == true)
                        break;
                }
                if (equal == true)
                    break;
            }

            if (equal == false)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
            }
        }
    }
}
