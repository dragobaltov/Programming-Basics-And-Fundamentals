using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplinterTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            double wholeDistance = double.Parse(Console.ReadLine());
            double capacity = double.Parse(Console.ReadLine());
            double distanceInHeavyWinds = double.Parse(Console.ReadLine());
            double distanceInNonHeavyWinds = wholeDistance - distanceInHeavyWinds;
            double fuelConsumed = (distanceInNonHeavyWinds * 25 + distanceInHeavyWinds * 25 * 1.5) * 1.05;

            Console.WriteLine("Fuel needed: {0:F2}L", fuelConsumed);

            if (fuelConsumed <= capacity)
            {
                Console.WriteLine($"Enough with {capacity - fuelConsumed:F2}L to spare!");
            }
            else
            {
                Console.WriteLine($"We need {fuelConsumed - capacity:F2}L more fuel.");
            }
        }
    }
}
