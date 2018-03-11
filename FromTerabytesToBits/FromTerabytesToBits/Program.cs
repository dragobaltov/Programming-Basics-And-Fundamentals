using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace FromTerabytesToBits
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal terabytes = decimal.Parse(Console.ReadLine());
            decimal tbToB = 1024m * 1024 * 1024 * 1024 * 8;
            decimal result = terabytes * tbToB;

            Console.WriteLine(Math.Round(result));
        }
    }
}
