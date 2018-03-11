using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            double lengthSide = double.Parse(Console.ReadLine());
            double heightHouse = double.Parse(Console.ReadLine());
            //зелената боя е 1 литър за 3 м2
            //червената – 1 литър за 5 м2
            double leftRightWall = 2 * (lengthSide * lengthSide / 2);
            double backWall = (lengthSide / 2 * lengthSide / 2) + (lengthSide / 2 * ((heightHouse - lengthSide / 2) / 2));
            double entrance = lengthSide / 5 * lengthSide / 5;
            double frontWall = backWall - entrance;
            double roof = 2 * (lengthSide * lengthSide / 2);
            double greenPaintNeeded = (leftRightWall + backWall + frontWall) / 3;
            double redPaintNeeded = roof / 5;

            Console.WriteLine($"{greenPaintNeeded:F2}");
            Console.WriteLine($"{redPaintNeeded:F2}");
        }
    }
}
