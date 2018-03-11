using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceOfTheStars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal lyToKm = 9450000000000m;
            decimal toNearestStar = lyToKm * 4.22m;
            decimal toTheCenter = lyToKm * 26000m;
            decimal diameterMilkyWay = lyToKm * 100000m;
            decimal toUniverse = lyToKm * 46500000000m;

            Console.WriteLine($"{toNearestStar:e2}");
            Console.WriteLine($"{toTheCenter:e2}");
            Console.WriteLine($"{diameterMilkyWay:e2}");
            Console.WriteLine($"{toUniverse:e2}");
        }
    }
}
