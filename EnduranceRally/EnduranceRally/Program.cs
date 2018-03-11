using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnduranceRally
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries);
            double[] zones = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            int[] checkpoints = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for (int i = 0; i < names.Length; i++)
            {
                string name = names[i];
                double fuel = name[0];
                bool failed = false;

                for (int j = 0; j < zones.Length; j++)
                {
                    if (checkpoints.Contains(j))
                    {
                        fuel += zones[j];
                    }
                    else
                    {
                        fuel -= zones[j];
                        if (fuel <= 0)
                        {
                            Console.WriteLine($"{name} - reached {j}");
                            failed = true;
                            break;
                        }
                    }
                }

                if (failed == false)
                {
                    Console.WriteLine($"{name} - fuel left {fuel:F2}");
                }
            }
        }
    }
}
