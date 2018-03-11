using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniWaterSupplies
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal totalWater = decimal.Parse(Console.ReadLine());
            decimal[] bottles = Console.ReadLine().Split(new char[] { ' ' },
                               StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).ToArray();
            long capacityOfABottle = long.Parse(Console.ReadLine());
            bool allBottlesAreFilled = true;
            decimal copyOfTotalWater = totalWater;

            if (totalWater % 2 == 0)
            {
                for (int i = 0; i < bottles.Length; i++)
                {
                    decimal neededWaterForCurrentBottle = capacityOfABottle - bottles[i];

                    if (totalWater >= neededWaterForCurrentBottle)
                    {
                        bottles[i] = capacityOfABottle;
                        totalWater -= neededWaterForCurrentBottle;
                    }
                    else
                    {
                        allBottlesAreFilled = false;
                    }
                }               
            }
            else
            {
                for (int i = bottles.Length - 1; i >= 0; i--)
                {
                    decimal neededWaterForCurrentBottle = capacityOfABottle - bottles[i];

                    if (totalWater >= neededWaterForCurrentBottle)
                    {
                        bottles[i] = capacityOfABottle;
                        totalWater -= neededWaterForCurrentBottle;
                    }
                    else
                    {
                        allBottlesAreFilled = false;
                    }
                }              
            }

            if (allBottlesAreFilled)
            {
                Console.WriteLine("Enough water!");
                Console.WriteLine("Water left: {0}l.", totalWater);
            }
            else
            {
                Console.WriteLine("We need more water!");
                Console.WriteLine("Bottles left: {0}", bottles.Where(b => b != capacityOfABottle).ToArray().Length);

                var unfilledBottles = new Dictionary<long, decimal>();

                if (copyOfTotalWater % 2 == 0)
                {
                    for (int i = 0; i < bottles.Length; i++)
                    {
                        if (bottles[i] != capacityOfABottle)
                        {
                            unfilledBottles.Add(i, bottles[i]);
                        }
                    }
                }
                else
                {
                    for (int i = bottles.Length - 1; i >= 0; i--)
                    {
                        if (bottles[i] != capacityOfABottle)
                        {
                            unfilledBottles.Add(i, bottles[i]);
                        }
                    }
                }

                Console.WriteLine("With indexes: {0}", string.Join(", ", unfilledBottles.Keys));

                decimal neededWater = unfilledBottles.Count * capacityOfABottle - unfilledBottles.Values.Sum() - totalWater;

                Console.WriteLine("We need {0} more liters!", neededWater);
            }
        }
    }
}

