using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repair
{
    class Program
    {
        static void Main(string[] args)
        {
            double playgroundLength = double.Parse(Console.ReadLine());
            double plateWidth = double.Parse(Console.ReadLine());
            double plateLength = double.Parse(Console.ReadLine());
            double benchWidth = double.Parse(Console.ReadLine());
            double benchLength = double.Parse(Console.ReadLine());

            double areaPlayground = playgroundLength * playgroundLength;
            double areaPlate = plateWidth * plateLength;
            double areaBench = benchWidth * benchLength;

            Console.WriteLine($"{(areaPlayground - areaBench) / areaPlate:F2}");
            Console.WriteLine($"{((areaPlayground - areaBench) / areaPlate) * 0.2:F2}");
        }
    }
}
