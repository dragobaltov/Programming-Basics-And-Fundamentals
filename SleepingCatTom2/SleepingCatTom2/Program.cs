using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepingCatTom2
{
    class Program
    {
        static void Main(string[] args)
        {
            int nonWorkDays = int.Parse(Console.ReadLine());
            int workDays = 365 - nonWorkDays;
            double timeForPlay = nonWorkDays * 127 + workDays * 63;

            if (timeForPlay > 30000)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{Math.Floor((timeForPlay - 30000) / 60)} hours and {(timeForPlay - 30000) % 60} minutes more for play");
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{Math.Floor((30000 - timeForPlay) / 60)} hours and {(30000 - timeForPlay) % 60} minutes less for play");
            }
        }
    }
}
