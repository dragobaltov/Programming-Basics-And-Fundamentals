using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateTriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideLength = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine(TriangleArea(sideLength, height));
        }

        static double TriangleArea(double length, double height)
        {
            return length * height / 2;
        }
    }
}
