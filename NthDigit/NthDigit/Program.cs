using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NthDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            byte index = byte.Parse(Console.ReadLine());

            Console.WriteLine(GetNthDigit(number, index));
        }

        static int GetNthDigit(long number, byte index)
        {
            long currentDigit = 0;
            byte count = 0;

            while (number != 0)
            {
                currentDigit = number % 10;
                number /= 10;
                count++;
                if (count == index)
                    break;
            }

            return (int)currentDigit;
        }
    }
}
