using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClosestTwoPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Point[] allPoints = new Point[n];

            for (int i = 0; i < n; i++)
            {
                Point p = Point.ReadPoint(Console.ReadLine());
                allPoints[i] = p;
            }

            double closestDistance = double.MaxValue;
            Point firstLastPoint = new Point();
            Point secondtLastPoint = new Point();

            for (int i = 0; i < allPoints.Length; i++)
            {
                for (int j = i + 1; j < allPoints.Length; j++)
                {
                    double distnace = CalculatingDistance(allPoints[i], allPoints[j]);

                    if (distnace < closestDistance)
                    {
                        closestDistance = distnace;
                        firstLastPoint = allPoints[i];
                        secondtLastPoint = allPoints[j];
                    }
                }
            }

            Console.WriteLine("{0:F3}", closestDistance);
            Console.WriteLine($"({firstLastPoint.X}, {firstLastPoint.Y})");
            Console.WriteLine($"({secondtLastPoint.X}, {secondtLastPoint.Y})");
        }

        public static double CalculatingDistance(Point p1, Point p2)
        {
            int sideA = p1.X - p2.X;
            int sideB = p1.Y - p2.Y;
            double c = Math.Sqrt(sideA * sideA + sideB * sideB);

            return c;
        }
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public static Point ReadPoint(string input)
        {
            int[] inputTokens = input.Split(' ').Select(int.Parse).ToArray();

            Point point = new Point { X = inputTokens[0], Y = inputTokens[1] };

            return point;
        }
    }
}
