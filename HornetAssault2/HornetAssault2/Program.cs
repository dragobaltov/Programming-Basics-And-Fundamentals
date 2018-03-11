using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetAssault2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> beehevies = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            List<long> hornets = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            long powerOfHornets = hornets.Sum();

            for (int i = 0; i < beehevies.Count; i++)
            {
                beehevies[i] -= powerOfHornets;
                
                if(beehevies[i] >= 0 && hornets.Count > 0)
                {
                    hornets.RemoveAt(0);
                    powerOfHornets = hornets.Sum();
                }

            }

            beehevies = beehevies.Where(b => b > 0).ToList();

            if (beehevies.Count > 0)
            {
                Console.WriteLine(string.Join(" ", beehevies));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
        }
    }
}
