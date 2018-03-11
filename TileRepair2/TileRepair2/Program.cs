using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TileRepair2
{
    class Program
    {
        static void Main(string[] args)
        {
            double playgroundSide = double.Parse(Console.ReadLine());
            double tileWidth = double.Parse(Console.ReadLine());
            double tileLength = double.Parse(Console.ReadLine());
            double benchWidth = double.Parse(Console.ReadLine());
            double benchLength = double.Parse(Console.ReadLine());
            double playgroundArea = playgroundSide * playgroundSide - benchLength * benchWidth;
            double tileArea = tileLength * tileWidth;
            double tilesNeeded = playgroundArea / tileArea;
            double timeNeeded = tilesNeeded * 0.2;

            Console.WriteLine($"{tilesNeeded:F2}");
            Console.WriteLine($"{timeNeeded:F2}");
        }
    }
}
