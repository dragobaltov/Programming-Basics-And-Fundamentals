using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousePainting2
{
    class Program
    {
        static void Main(string[] args)
        {
            double houseHeight = double.Parse(Console.ReadLine());
            double lengthSideWall = double.Parse(Console.ReadLine());
            double triangleHeight = double.Parse(Console.ReadLine());
            double backWall = houseHeight * houseHeight;
            double frontWall = backWall - 2 * 1.2;
            double sideWalls = 2 * (houseHeight * lengthSideWall - 1.5 * 1.5);
            double roofRectangles = 2 * (houseHeight * lengthSideWall);
            double roofTriangles = 2 * (houseHeight * triangleHeight / 2);
            double baseArea = backWall + frontWall + sideWalls;
            double roofArea = roofRectangles + roofTriangles;
            double greenPaint = baseArea / 3.4;
            double redPaint = roofArea / 4.3;

            Console.WriteLine($"{greenPaint:F2}");
            Console.WriteLine($"{redPaint:F2}");
        }
    }
}
