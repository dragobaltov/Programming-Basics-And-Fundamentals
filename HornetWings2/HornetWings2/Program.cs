using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetWings2
{
    class Program
    {
        static void Main(string[] args)
        {
            int wingFlaps = int.Parse(Console.ReadLine());
            decimal distanceFor1000Flaps = decimal.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());

            decimal distanceTravelled = ((decimal)wingFlaps / 1000) * distanceFor1000Flaps;
            int seconds = (wingFlaps / 100) + (wingFlaps / endurance) * 5;

            Console.WriteLine($"{distanceTravelled:F2} m.");
            Console.WriteLine($"{seconds} s.");
        }
    }
}
