using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravellingAtLightSpeed
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal ly = decimal.Parse(Console.ReadLine());
            decimal lyToKm = ly * 9450000000000m;
            decimal timeInSec = lyToKm / 300000m;
            decimal weekInSec = 7m * 24 * 60 * 60;
            decimal weeks = Math.Floor(timeInSec / weekInSec);
            decimal dayInSec = 24m * 60 * 60;
            timeInSec -= weeks * weekInSec;
            decimal days = Math.Floor(timeInSec / dayInSec);
            timeInSec -= days * dayInSec;
            decimal hourInSec = 60 * 60;
            decimal hours = Math.Floor(timeInSec / hourInSec);
            timeInSec -= hours * hourInSec;
            decimal minuteInSec = 60;
            decimal minutes = Math.Floor(timeInSec / minuteInSec);
            timeInSec -= minutes * minuteInSec;
            decimal seconds = Math.Floor(timeInSec);

            Console.WriteLine($"{weeks} weeks");
            Console.WriteLine($"{days} days");
            Console.WriteLine($"{hours} hours");
            Console.WriteLine($"{minutes} minutes");
            Console.WriteLine($"{seconds} seconds");
        }
    }
}
