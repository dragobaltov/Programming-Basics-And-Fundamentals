using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace SinoTheWalker2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime timeOfLeaving = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture);
            long steps = long.Parse(Console.ReadLine());
            long secondsForAStep = long.Parse(Console.ReadLine());

            long secondsTravelling = steps * secondsForAStep;
            long timeOfLeavingInSeconds = timeOfLeaving.Hour * 3600 + timeOfLeaving.Minute * 60 + timeOfLeaving.Second;
            long timeOfArrivingInSeconds = timeOfLeavingInSeconds + secondsTravelling;

            long hours = timeOfArrivingInSeconds / 3600;
            timeOfArrivingInSeconds -= hours * 3600;
            long minutes = timeOfArrivingInSeconds / 60;
            timeOfArrivingInSeconds -= minutes * 60;
            long seconds = timeOfArrivingInSeconds;

            if (hours >= 24)
                hours %= 24;

            Console.WriteLine($"Time Arrival: {hours:D2}:{minutes:D2}:{seconds:D2}");
        }
    }
}
