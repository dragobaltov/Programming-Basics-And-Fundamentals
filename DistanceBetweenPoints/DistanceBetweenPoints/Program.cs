using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceBetweenPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstTwoPoints = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondTwoPoints = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Point fTP = new Point() { A = firstTwoPoints[0], B = firstTwoPoints[1] };
            Point sTP = new Point() { A = secondTwoPoints[0], B = secondTwoPoints[1] };

            int a = CalculatingDistance(fTP.A, sTP.A);
            int b = CalculatingDistance(fTP.B, sTP.B);
            double c = Math.Sqrt(a * a + b * b);
            Console.WriteLine("{0:F3}", c);
        }

        static int CalculatingDistance(int p1, int p2)
        {
            int distance = Math.Abs(p1 - p2);
            return distance;
        }
    }

    class Point
    {
        public int A { get; set; }
        public int B { get; set; }
    }
}
