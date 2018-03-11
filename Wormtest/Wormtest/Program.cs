using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wormtest
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthInMeters = int.Parse(Console.ReadLine());
            decimal widthInCm = decimal.Parse(Console.ReadLine());
            int lengthInCm = lengthInMeters * 100;

            if (widthInCm == 0) 
            {
                Console.WriteLine($"{lengthInCm * widthInCm:F2}");
            }
            else if (lengthInCm % widthInCm == 0)
            {
                Console.WriteLine($"{lengthInCm * widthInCm:F2}");
            }
            else
            {
                Console.WriteLine($"{lengthInCm / widthInCm * 100:F2}%");
            }
        }
    }
}
