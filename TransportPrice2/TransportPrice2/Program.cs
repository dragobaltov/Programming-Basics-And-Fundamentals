using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportPrice2
{
    class Program
    {
        static void Main(string[] args)
        {
            int km = int.Parse(Console.ReadLine());
            string timeOfTheDay = Console.ReadLine();

            if (km < 20)
            {
                if (timeOfTheDay == "day")
                {
                    Console.WriteLine($"{0.7 + 0.79 * km}");
                }
                else if (timeOfTheDay == "night")
                {
                    Console.WriteLine($"{0.7 + 0.9 * km}");
                }
            }
            else if (km >= 20 && km < 100)
            {
                Console.WriteLine($"{0.09 * km}");
            }
            else
            {
                Console.WriteLine($"{0.06 * km}");
            }
        }
    }
}
