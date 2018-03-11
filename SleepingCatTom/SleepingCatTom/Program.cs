using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepingCatTom
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOff = int.Parse(Console.ReadLine());
            double minutesForPlay = (365 - daysOff) * 63 + daysOff * 127;

            if (minutesForPlay > 30000)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{Math.Truncate((minutesForPlay - 30000) / 60)} hours and {(minutesForPlay - 30000) % 60:F0} minutes more for play");
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{Math.Truncate((30000 - minutesForPlay) / 60)} hours and {(30000 - minutesForPlay) % 60:F0} minutes less for play");
            }
            
        }
    }
}
