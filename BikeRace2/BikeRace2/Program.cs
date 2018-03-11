using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRace2
{
    class Program
    {
        static void Main(string[] args)
        {
            int juniors = int.Parse(Console.ReadLine());
            int seniors = int.Parse(Console.ReadLine());
            string trace = Console.ReadLine();

            if (trace == "trail")
            {
                Console.WriteLine($"{(juniors * 5.5 + seniors * 7) * 0.95:F2}");
            }
            else if (trace == "cross-country")
            {
                if (juniors + seniors < 50)
                {
                    Console.WriteLine($"{(juniors * 8 + seniors * 9.5) * 0.95:F2}");
                }
                else
                {
                    Console.WriteLine($"{(juniors * 8 * 0.75 + seniors * 9.5 * 0.75) * 0.95:F2}");
                }
            }
            else if (trace == "downhill")
            {
                Console.WriteLine($"{(juniors * 12.25 + seniors * 13.75) * 0.95:F2}");
            }
            else if (trace == "road")
            {
                Console.WriteLine($"{(juniors * 20 + seniors * 21.5) * 0.95:F2}");
            }
        }
    }
}
