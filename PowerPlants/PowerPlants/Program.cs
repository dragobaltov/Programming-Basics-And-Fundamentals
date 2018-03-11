using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerPlants
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] powerOfPlants = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int daysInASeason = powerOfPlants.Length;
            int days = 0;
            int seasons = 0;

            while (IsAlive(powerOfPlants))
            {
                for (int plant = 0; plant < powerOfPlants.Length; plant++)
                {
                    if (powerOfPlants[plant] != 0)
                    {
                        if (plant != days - (daysInASeason * seasons))
                        {
                            powerOfPlants[plant] -= 1;
                        }
                    }
                }
                days++;

                if (days % daysInASeason == 0)
                {
                    for (int i = 0; i < powerOfPlants.Length; i++)
                    {
                        if (powerOfPlants[i] > 0)
                        {
                            powerOfPlants[i] += 1;
                        }
                    }
                    seasons++;
                }
            }

            int seasons2 = (days - 1) / daysInASeason;

            string seasonFormat = null;
            if (seasons == 1)
            {
                seasonFormat = "season";
            }
            else
            {
                seasonFormat = "seasons";
            }

            Console.WriteLine($"survived {days} days ({seasons2} {seasonFormat})");
        }

        static bool IsAlive(int[] powerOfPlants)
        {
            for (int i = 0; i < powerOfPlants.Length; i++)
            {
                if (powerOfPlants[i] > 0)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
