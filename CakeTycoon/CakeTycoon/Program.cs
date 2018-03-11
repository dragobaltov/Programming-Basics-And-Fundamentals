using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeTycoon
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong cakesWanted = ulong.Parse(Console.ReadLine());
            decimal kgFlourNeededForACake = decimal.Parse(Console.ReadLine());
            uint kgFlourAvailable = uint.Parse(Console.ReadLine());
            ulong truffelsAvailable = ulong.Parse(Console.ReadLine());
            ulong priceTruffel = ulong.Parse(Console.ReadLine());
            decimal cakesMade = Math.Floor(kgFlourAvailable / kgFlourNeededForACake);
            decimal cakesMade2 = kgFlourAvailable / kgFlourNeededForACake;
            ulong costTruffels = truffelsAvailable * priceTruffel;
            double cakePrice = (costTruffels / cakesWanted) * 1.25;
            decimal flourNeeded = cakesWanted * kgFlourNeededForACake;
            decimal flourUsed = cakesMade2 * kgFlourNeededForACake;

            if (cakesMade >= cakesWanted)
            {
                Console.WriteLine($"All products available, price of a cake: {cakePrice:F2}");
            }
            else
            {
                Console.WriteLine($"Can make only {cakesMade} cakes, need {flourNeeded - flourUsed:F2} kg more flour");
            }

        }
    }
}
