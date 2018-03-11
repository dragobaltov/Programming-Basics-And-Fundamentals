using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncrementVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = int.Parse(Console.ReadLine());

            if (num <= byte.MaxValue)
            {
                Console.WriteLine(num);
            }
            else
            {
                Console.WriteLine($"{num - (256 * (num / 256))}");
                Console.WriteLine($"Overflowed {num / 256} times");
            }
        }
    }
}
