using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeTiles
{
    class Program
    {
        static void Main(string[] args)
        {
            double savings = double.Parse(Console.ReadLine());
            double widthFloor = double.Parse(Console.ReadLine());
            double lengthFloor = double.Parse(Console.ReadLine());
            double sideTriangle = double.Parse(Console.ReadLine());
            double heightTriangle = double.Parse(Console.ReadLine());
            double priceOneTile = double.Parse(Console.ReadLine());
            double priceWorker = double.Parse(Console.ReadLine());

            double areaFloor = widthFloor * lengthFloor;
            double areaOneTile = sideTriangle * heightTriangle / 2;
            double tilesNeeded = Math.Ceiling(areaFloor / areaOneTile) + 5;
            double moneyNeeded = priceWorker + priceOneTile * tilesNeeded;

            if (savings >= moneyNeeded)
            {
                Console.WriteLine($"{savings - moneyNeeded:F2} lv left.");
            }
            else
            {
                Console.WriteLine($"You'll need {moneyNeeded - savings:F2} lv more.");
            }
        }
    }
}
