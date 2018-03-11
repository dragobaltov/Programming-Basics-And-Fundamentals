using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wormhole
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] numbers = Console.ReadLine().Split(' ').Select(byte.Parse).ToArray();
            int steps = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 0)
                {
                    steps++;
                }
                else
                {
                    int copy = i;
                    i = numbers[i] - 1;
                    numbers[copy] = 0;
                }
            }

            Console.WriteLine(steps);
        }
    }
}
