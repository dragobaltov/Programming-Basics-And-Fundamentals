using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batteries
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] capacities = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double[] copyArray = CopyArray(capacities);
            double[] usagesPerHour = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            List<int> h = new List<int>();
            int hours = int.Parse(Console.ReadLine());

            for (int i = 0; i < capacities.Length; i++)
            {
                for (int hour = 0; hour < hours; hour++)
                {
                    capacities[i] -= usagesPerHour[i];
                    if (capacities[i] <= 0)
                    {
                        h.Add(hour + 1);
                        break;
                    }
                }
            }

            int counter = 0;

            for (int i = 0; i < capacities.Length; i++)
            {
                if (capacities[i] > 0)
                {
                    Console.WriteLine($"Battery {i + 1}: {capacities[i]:F2} mAh ({(capacities[i] / copyArray[i]) * 100:F2})%");
                }
                else
                {
                    Console.WriteLine($"Battery {i + 1}: dead (lasted {h[counter]} hours)");
                    counter++;
                }
            }
        }

        static double[] CopyArray(double[] c)
        {
            double[] copyArray = new double[c.Length];
            for (int i = 0; i < c.Length; i++)
            {
                copyArray[i] = c[i];
            }

            return copyArray;
        }
    }
}
