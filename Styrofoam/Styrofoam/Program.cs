using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Styrofoam
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double areaHouse = double.Parse(Console.ReadLine());
            int windowses = int.Parse(Console.ReadLine());
            double m2InPacket = double.Parse(Console.ReadLine());
            double pricePacket = double.Parse(Console.ReadLine());
            double areaWithoutWindowses = (areaHouse - windowses * 2.4) * 1.1;
            double packetsNeeded = Math.Ceiling(areaWithoutWindowses / m2InPacket);
            double moneyNeeded = packetsNeeded * pricePacket;

            if (budget > moneyNeeded)
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
