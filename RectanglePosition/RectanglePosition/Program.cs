using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectanglePosition
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle firstRectangle = Rectangle.ParseRectangle(Console.ReadLine());
            Rectangle secondRectangle = Rectangle.ParseRectangle(Console.ReadLine());

            if (Rectangle.IsInside(firstRectangle, secondRectangle))
                Console.WriteLine("Inside");
            else
                Console.WriteLine("Not inside");
        }
    }

    class Rectangle
    {
        public int Left { get; set; }
        public int Top { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public int Bottom
        {
            get
            {
                return Top + Height;
            }
        }

        public int Right
        {
            get
            {
                return Left + Width;
            }
        }

        public static Rectangle ParseRectangle(string input)
        {
            int[] inputTokens = input.Split(' ').Select(int.Parse).ToArray();

            return new Rectangle
            {
                Left = inputTokens[0],
                Top = inputTokens[1],
                Width = inputTokens[2],
                Height = inputTokens[3]
            };
        }

        public static bool IsInside(Rectangle first, Rectangle second)
        {
            return (first.Top >= second.Top && first.Bottom <= second.Bottom &&
                     first.Left >= second.Left && first.Right <= second.Right);
        }
    }
}
