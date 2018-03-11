using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                Box box = Box.ReadBox(input);

                Console.WriteLine($"Box: {box.Width}, {box.Height}");
                Console.WriteLine($"Perimeter: {Box.CalculatePerimeter(box.Width, box.Height)}");
                Console.WriteLine($"Area: {Box.CalculateArea(box.Width, box.Height)}");

                input = Console.ReadLine();
            }
        }

        class Point
        {
            public int X { get; set; }
            public int Y { get; set; }
            
            public static Point ReadPoint(string input)
            {
                string[] tokens = input.Split(':');
                int x = int.Parse(tokens[0]);
                int y = int.Parse(tokens[1]);

                return new Point
                {
                    X = x,
                    Y = y
                };
            }

            public static double CalculateDistance(Point p1, Point p2)
            {
                int sideA = p1.X - p2.X;
                int sideB = p1.Y - p2.Y;
                double distance = Math.Sqrt(sideA * sideA + sideB * sideB);

                return distance;
            }
        }

        class Box
        {
            public Point UpperLeft { get; set; }
            public Point UpperRight { get; set; }
            public Point BottomLeft { get; set; }
            public Point BottomRight { get; set; }

            public int Width
            {
                get
                {
                    return Math.Abs(BottomRight.X - BottomLeft.X);
                }
            }

            public int Height
            {
                get
                {
                    return Math.Abs(UpperLeft.Y - BottomLeft.Y);
                }
            }

            public static Box ReadBox(string input)
            {
                string[] tokens = input.Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);

                return new Box
                {
                    UpperLeft = Point.ReadPoint(tokens[0]),
                    UpperRight = Point.ReadPoint(tokens[1]),
                    BottomLeft = Point.ReadPoint(tokens[2]),
                    BottomRight = Point.ReadPoint(tokens[3])
                };
            }

            public static int CalculatePerimeter(int width, int height)
            {
                return (2 * width + 2 * height);
            }

            public static int CalculateArea(int width, int height)
            {
                return width * height;
            }
        }
    }
}
