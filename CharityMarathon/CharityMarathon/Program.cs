using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityMarathon
{
    class Program
    {
        static void Main(string[] args)
        {
            long days = long.Parse(Console.ReadLine());
            long runners = long.Parse(Console.ReadLine());
            long lapsPerRunner = long.Parse(Console.ReadLine());
            long lengthOfTheTrack = long.Parse(Console.ReadLine());
            long capacityOfTheTrack = long.Parse(Console.ReadLine());
            decimal moneyPerKM = decimal.Parse(Console.ReadLine());

            long runnersAllowed = days * capacityOfTheTrack;
            if (runners > runnersAllowed)
                runners = runnersAllowed;
            long metersRunned = runners * lapsPerRunner * lengthOfTheTrack;
            decimal kmRunned = metersRunned / 1000.0m;
            decimal moneyRaised = kmRunned * moneyPerKM;

            Console.WriteLine($"Money raised: {moneyRaised:F2}");
        }
    }
}
