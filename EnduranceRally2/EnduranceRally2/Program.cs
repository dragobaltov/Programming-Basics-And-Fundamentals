using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnduranceRally2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> drivers = Console.ReadLine().Split(' ').ToList();
            List<double> zones = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            List<int> checkpoints = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < drivers.Count; i++)
            {
                double fuelOfCurrentDriver = drivers[i][0];
                int index = -1;

                for (int j = 0; j < zones.Count; j++)
                {
                    if (checkpoints.Contains(j))
                    {
                        fuelOfCurrentDriver += zones[j];
                    }
                    else
                    {
                        fuelOfCurrentDriver -= zones[j];

                        if(fuelOfCurrentDriver <= 0)
                        {
                            index = j;
                            break;
                        }
                    }
                }

                if (index == -1)
                {
                    Console.WriteLine($"{drivers[i]} - fuel left {fuelOfCurrentDriver:F2}");
                }
                else
                {
                    Console.WriteLine($"{drivers[i]} - reached {index}");
                }
            }
        }
    }
}
