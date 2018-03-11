using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratingRectangles2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int minArea = int.Parse(Console.ReadLine());

            for (int left = -n; left <= n; left++)
            {
                for (int top = -n; top <= n; top++)
                {
                    for (int right = -n; right <= n; right++)
                    {
                        for (int bottom = -n; top <= n; top++)
                        {
                            if (left < right && top < bottom)
                            {
                              int area = (Math.Abs(left) + right) * (Math.Abs(top) + bottom);
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
    }
}
