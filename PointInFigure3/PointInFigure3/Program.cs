using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInFigure3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if (x < 0 || x > 3 * n || y < 0 || y > 4 * n)
            {
                Console.WriteLine("outside");
            }
            else if ((x < n || x > 2 * n) && y > n)
            {
                Console.WriteLine("outside");
            }
            else if ((x > 0 && x < 3 * n) && (y > 0 && y < n))
            {
                Console.WriteLine("inside");
            }
            else if ((x > n && x < 2 * n) && (y > 0 && y < 4 * n))
            {
                Console.WriteLine("inside");
            }
            else
            {
                Console.WriteLine("border");
            }
        }
    }
}
