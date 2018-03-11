using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Styrofoam2
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double houseArea = double.Parse(Console.ReadLine());
            int windowses = int.Parse(Console.ReadLine());
            double m2StyrofoamInPacket = double.Parse(Console.ReadLine());
            double pricePacket = double.Parse(Console.ReadLine());
            double styrofoamNeeded = (houseArea - windowses * 2.4) * 1.1;
            double packetsNeeded = Math.Ceiling(styrofoamNeeded / m2StyrofoamInPacket);
            double moneyNeeded = packetsNeeded * pricePacket;

            if (budget >= moneyNeeded)
            {
                Console.WriteLine($"Spent: {moneyNeeded:F2}");
                Console.WriteLine($"Left: {budget - moneyNeeded:F2}");
            }
            else
            {
                Console.WriteLine($"Need more: {moneyNeeded - budget:F2}");
            }
        }
    }
}
