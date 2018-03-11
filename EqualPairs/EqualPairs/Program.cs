using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            double firstPair = n1 + n2;
            double secondPair = 0.0;
            double maxDiff = 0.0;
            double diff = 0.0;

            for (int i =2; i < 2 * n; i++)
            {
                double number = double.Parse(Console.ReadLine());
                secondPair += number;
                if (i % 2 == 1)
                {
                    if(firstPair != secondPair)
                    {
                        diff = Math.Abs(firstPair - secondPair);
                        if(diff > maxDiff)
                        {
                            maxDiff = diff;
                        }
                        firstPair = secondPair;
                    }
                }
            }

            if (maxDiff == 0)
            {
                Console.WriteLine($"")
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}
