using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeTiles2
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneySaved = double.Parse(Console.ReadLine());
            double widthFloor = double.Parse(Console.ReadLine());
            double lengthFloor = double.Parse(Console.ReadLine());
            double sideTrinagle = double.Parse(Console.ReadLine());
            double heightTrinagle = double.Parse(Console.ReadLine());
            double priceOneTile = double.Parse(Console.ReadLine());
            double priceWorker = double.Parse(Console.ReadLine());
            double floorArea = widthFloor * lengthFloor;
            double tileArea = sideTrinagle * heightTrinagle / 2;
            double tilesNeeded = Math.Ceiling(floorArea / tileArea) + 5;
            double moneyNeeded = tilesNeeded * priceOneTile + priceWorker;

            if (moneySaved >= moneyNeeded)
            {
                Console.WriteLine($"{moneySaved - moneyNeeded:F2} lv left.");
            }
            else
            {
                Console.WriteLine($"You'll need {moneyNeeded - moneySaved:F2} lv more.");
            }
        }
    }
}
