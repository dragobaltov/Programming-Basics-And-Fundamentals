using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogHouse2
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideWallLength = double.Parse(Console.ReadLine());
            double houseHeigth = double.Parse(Console.ReadLine());
            double sideWalls = 2 * (sideWallLength * sideWallLength / 2);
            double backWall = (sideWallLength / 2 * sideWallLength / 2) + (sideWallLength / 2 * (houseHeigth - sideWallLength / 2)) / 2;
            double frontWall = backWall - (sideWallLength / 5 * sideWallLength / 5);
            double roof = 2 * (sideWallLength * sideWallLength / 2);
            double greenPaint = (sideWalls + backWall + frontWall) / 3;
            double redPaint = roof / 5;

            Console.WriteLine($"{greenPaint:F2}");
            Console.WriteLine($"{redPaint:F2}");
        }
    }
}
