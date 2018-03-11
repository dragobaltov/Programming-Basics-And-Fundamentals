using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRace
{
    class Program
    {
        static void Main(string[] args)
        {
            // Група trail   cross - country   downhill            road
            //juniors 5.50       8                12.25              20
            //seniors 7         9.50              13.75              21.50
            int juniorCyclists = int.Parse(Console.ReadLine());
            int seniorsCyclists = int.Parse(Console.ReadLine());
            string typeTrace = Console.ReadLine();

            if (typeTrace == "trail")
            {
                Console.WriteLine($"{(juniorCyclists * 5.5 + seniorsCyclists * 7) * 0.95:F2}");
            }
            else if (typeTrace == "cross-country")
            {
                if ((juniorCyclists + seniorsCyclists) >= 50)
                {
                    Console.WriteLine($"{(juniorCyclists * 8 * 0.75 + seniorsCyclists * 9.5 * 0.75) * 0.95:F2}");
                }
                else
                {
                    Console.WriteLine($"{(juniorCyclists * 8 + seniorsCyclists * 9.5) * 0.95:F2}");
                }
            }
            else if (typeTrace == "downhill")
            {
                Console.WriteLine($"{(juniorCyclists * 12.25 + seniorsCyclists * 13.75) * 0.95:F2}");
            }
            else if (typeTrace == "road")
            {
                Console.WriteLine($"{(juniorCyclists * 20 + seniorsCyclists * 21.5) * 0.95:F2}");
            }
        }
    }
}
