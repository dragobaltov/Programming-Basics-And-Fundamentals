using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousePaint
{
    class Program
    {
        static void Main(string[] args)
        {
            double houseHeight = double.Parse(Console.ReadLine());
            double sideWallLength = double.Parse(Console.ReadLine());
            double triangleHeight = double.Parse(Console.ReadLine());
            double backWall = houseHeight * houseHeight;
            double entrance = 2 * 1.2;
            double frontWall = backWall - entrance;
            double windows = 1.5 * 1.5;
            double sideWalls = 2 * (houseHeight * sideWallLength) - 2 * windows;
            double roofRectangles = 2 * (houseHeight * sideWallLength);
            double roofTriangles = 2 * (houseHeight * triangleHeight / 2);
            double greenPaint = (backWall + frontWall + sideWalls) / 3.4;
            double redPaint = (roofTriangles + roofRectangles) / 4.3;

            Console.WriteLine($"{greenPaint:F2}");
            Console.WriteLine($"{redPaint:F2}");
        }
    }
}
