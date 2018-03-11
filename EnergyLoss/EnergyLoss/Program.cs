using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyLoss
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int dancers = int.Parse(Console.ReadLine());
            double energyDancers = 100 * days * dancers;

            for (int i = 1; i <= days; i++)
            {
                int hours = int.Parse(Console.ReadLine());

                if (i % 2 == 0 && hours % 2 == 0)
                {
                    energyDancers -= dancers * 68;
                }
                else if (i % 2 == 1 && hours % 2 == 0)
                {
                    energyDancers -= 49 * dancers;
                }
                else if (i % 2 == 0 && hours % 2 == 1)
                {
                    energyDancers -= 65 * dancers;
                }
                else if (i % 2 == 1 && hours % 2 == 1)
                {
                    energyDancers -= 30 * dancers;
                }
            }

            double energyDancerDay = (energyDancers / dancers) / days;

            if (energyDancerDay >= 50)
            {
                Console.WriteLine($"They feel good! Energy left: {energyDancerDay:F2}");
            }
            else
            {
                Console.WriteLine($"They are wasted! Energy left: {energyDancerDay:F2}");
            }
        }
    }
}
