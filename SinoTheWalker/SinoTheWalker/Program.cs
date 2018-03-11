using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace SinoTheWalker
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(':').Select(int.Parse).ToArray();
            long steps = long.Parse(Console.ReadLine());
            int secForStep = int.Parse(Console.ReadLine());

            int hourSettingOff = input[0];
            int minutesSettingOff = input[1];
            int secondsSettingOff = input[2];
            long timeInSecSettingOff = hourSettingOff * 3600 + minutesSettingOff * 60 + secondsSettingOff;

            long neededTimeInSec = steps * secForStep;
            long timeInSecArriving = timeInSecSettingOff + neededTimeInSec;

            long hourArriving = timeInSecArriving / 3600;
            timeInSecArriving -= hourArriving * 3600;
            if (hourArriving > 23)
            {
                hourArriving -= ((hourArriving / 24) * 24);
            }
            long minutesArriving = timeInSecArriving / 60;
            timeInSecArriving -= minutesArriving * 60;
            long secondsArriving = timeInSecArriving;

            Console.WriteLine($"Time Arrival: {hourArriving:D2}:{minutesArriving:D2}:{secondsArriving:D2}");
        }
    }
}
