using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityMarathon2
{
    class Program
    {
        static void Main(string[] args)
        {
            long days = long.Parse(Console.ReadLine());
            long runners = long.Parse(Console.ReadLine());
            long lapsMadeByOneRunner = long.Parse(Console.ReadLine());
            long lengthOfTrack = long.Parse(Console.ReadLine());
            long capacityOfTrack = long.Parse(Console.ReadLine());
            decimal moneyPerKm = decimal.Parse(Console.ReadLine());

            if (runners > capacityOfTrack * days)
                runners = capacityOfTrack * days;

            decimal totalKms = (runners * lapsMadeByOneRunner * lengthOfTrack) / 1000;
            decimal moneyRaised = totalKms * moneyPerKm;

            Console.WriteLine($"Money raised: {moneyRaised:F2}");
        }
    }
}
