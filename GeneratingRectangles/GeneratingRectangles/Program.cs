using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratingRectangles
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int minArea = int.Parse(Console.ReadLine());

            for (int left = -n; left <= n; left++)
            {
                for (int right = left + 1; right <= n; right++)
                {
                    if (left < right)
                    {
                        for (int bottom = -n; bottom <= n; bottom++)
                        {
                            for (int top = bottom + 1; top <= n; top++)
                            {
                                if (bottom < top)
                                {
                                    int area = (Math.Abs(left) + right) * (Math.Abs(bottom) + top);
                                    if (area >= minArea)
                                    {
                                        Console.WriteLine($"({left}, {top}) ({right}, {bottom}) -> {area}");
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (4 * n * n < minArea)
            {
                Console.WriteLine("No");
            }
        }
    }
}
