using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousePrice2
{
    class Program
    {
        static void Main(string[] args)
        {
            double areaSmallestRoom = double.Parse(Console.ReadLine());
            double areaKitchen = double.Parse(Console.ReadLine());
            double priceM2 = double.Parse(Console.ReadLine());
            double areaMiddleRoom = areaSmallestRoom * 1.1;
            double areaBiggestRoom = areaMiddleRoom * 1.1;
            double areaBathroom = areaSmallestRoom / 2;
            double area = (areaSmallestRoom + areaMiddleRoom + areaBiggestRoom + areaKitchen + areaBathroom) * 1.05;

            Console.WriteLine($"{area * priceM2:F2}");
        }
    }
}
