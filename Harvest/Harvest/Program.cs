using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int area = int.Parse(Console.ReadLine());
            double grape = double.Parse(Console.ReadLine());
            int wineNeeded = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            double areaForWine = area * 0.4;
            double grapeProduction = grape * areaForWine;
            double wineProduction = grapeProduction / 2.5;

            if(wineProduction < wineNeeded)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Truncate(wineNeeded - wineProduction)} liters wine needed.");
            }
            else 
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Truncate(wineProduction)} liters.");
                Console.WriteLine($"{Math.Ceiling(wineProduction - wineNeeded)} liters left -> " +
                    $"{Math.Ceiling((wineProduction - wineNeeded) / workers)} liters per person.");
            }
        }
    }
}
