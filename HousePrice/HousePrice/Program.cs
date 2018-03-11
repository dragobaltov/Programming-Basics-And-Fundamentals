using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousePrice
{
    class Program
    {
        static void Main(string[] args)
        {
            double areaSmallestRoom = double.Parse(Console.ReadLine());
            double areaKitchen = double.Parse(Console.ReadLine());
            double priceM2 = double.Parse(Console.ReadLine());
            double areaBathroom = areaSmallestRoom / 2;
            double secondBiggestRoom = areaSmallestRoom * 1.1;
            double thirdBiggestRoom = secondBiggestRoom * 1.1;
            double wholeArea = (areaSmallestRoom + areaKitchen + areaBathroom + secondBiggestRoom + thirdBiggestRoom) * 1.05;
            Console.WriteLine($"{priceM2 * wholeArea:F2}");
        }
    }
}
