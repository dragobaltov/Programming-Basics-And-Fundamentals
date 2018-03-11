using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetAssault
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> beehives = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            List<long> hornets = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            long power = hornets.Sum();
            List<long> survivedBees = new List<long>();

            for (int i = 0; i < beehives.Count; i++)
            {
                if (power > beehives[i])
                {
                    beehives.RemoveAt(i);
                    i--;
                }
                else if(power == beehives[i])
                {
                    beehives.RemoveAt(i);
                    i--;
                    hornets.RemoveAt(0);
                    if (hornets.Count == 0)
                        break;

                    power = hornets.Sum();
                }
                else
                {
                    beehives[i] -= power;
                    hornets.RemoveAt(0);
                    if (hornets.Count == 0)
                        break;

                    power = hornets.Sum();
                }
            }

            if (beehives.Count > 0)
            {
                Console.WriteLine(string.Join(" ", beehives));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
        }
    }
}
