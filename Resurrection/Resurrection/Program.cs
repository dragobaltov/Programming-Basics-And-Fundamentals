using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resurrection
{
    class Program
    {
        static void Main(string[] args)
        {
            int phoenixes = int.Parse(Console.ReadLine());

            for (int i = 0; i < phoenixes; i++)
            {
                long totalLength = long.Parse(Console.ReadLine());
                decimal totalWidth = decimal.Parse(Console.ReadLine());
                long wingLength = long.Parse(Console.ReadLine());
                decimal totalYears = totalLength * totalLength * (totalWidth + 2 * wingLength);
                Console.WriteLine(totalYears);
            }
        }
    }
}
