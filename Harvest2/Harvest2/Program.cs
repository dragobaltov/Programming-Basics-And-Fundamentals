using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest2
{
    class Program
    {
        static void Main(string[] args)
        {
            int area = int.Parse(Console.ReadLine());
            double grapeM2 = double.Parse(Console.ReadLine());
            int wineNeeded = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            double grape = area * grapeM2;
            double grapeForWine = grape * 0.4;
            double wineMade = grapeForWine / 2.5;

            if (wineMade >= wineNeeded)
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wineMade)} liters.");
                Console.WriteLine($"{Math.Ceiling(wineMade - wineNeeded)} liters left -> {Math.Ceiling((wineMade - wineNeeded) / workers)} liters per person.");
            }
            else
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(wineNeeded - wineMade)} liters wine needed.");
            }
        }
    }
}
