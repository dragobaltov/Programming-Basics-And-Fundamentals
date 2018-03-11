using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entertrain
{
    class Program
    {
        static void Main(string[] args)
        {
            int locomotivePower = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            var wagons = new List<int>();
            int weightOfAllWagons = 0;

            while (!input.Equals("All ofboard!"))
            {
                int currentWagonWeight = int.Parse(input);

                wagons.Add(currentWagonWeight);
                weightOfAllWagons += currentWagonWeight;

                if (weightOfAllWagons > locomotivePower)
                {
                    int averageWeight = weightOfAllWagons / wagons.Count;
                    int index = 0;
                    int minDifference = int.MaxValue;

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        int wagonWeight = wagons[i];
                        int difference = Math.Abs(averageWeight - wagonWeight);

                        if (difference < minDifference)
                        {
                            minDifference = difference;
                            index = i;
                        }
                    }

                    weightOfAllWagons -= wagons[index];
                    wagons.RemoveAt(index);
                }

                input = Console.ReadLine();
            }

            wagons.Reverse();
            wagons.Add(locomotivePower);

            Console.WriteLine(string.Join(" ", wagons));
        }

        static int IndexOfWagonWithClosestValue(List<int> wagons, int averageWeight)
        {
            int index = 0;
            int minDifference = int.MaxValue;

            for (int i = 0; i < wagons.Count; i++)
            {
                int currentWagonWeight = wagons[i];
                int difference = Math.Abs(averageWeight - currentWagonWeight);

                if (difference < minDifference)
                {
                    minDifference = difference;
                    index = i;
                }
            }

            return index;
        }
    }
}
