using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetWings
{
    class Program
    {
        static void Main(string[] args)
        {
            int wingFlaps = int.Parse(Console.ReadLine());
            double distanceFor1000Flaps = double.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());
            double distance = (wingFlaps / 1000.0) * distanceFor1000Flaps;
            int timeFlying = wingFlaps / 100;
            int timeResting = (wingFlaps  / endurance) * 5;
            int wholeTime = timeFlying + timeResting;

            Console.WriteLine($"{distance:F2} m.");
            Console.WriteLine($"{wholeTime} s.");
        }
    }
}
