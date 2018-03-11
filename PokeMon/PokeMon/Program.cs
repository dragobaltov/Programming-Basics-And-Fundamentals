using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int originalPower = pokePower;
            int distance = int.Parse(Console.ReadLine());
            int exhaustion = int.Parse(Console.ReadLine());
            int countPokes = 0;
            int extracted = 0;

            while (pokePower >= distance)
            {
                pokePower -= distance;
                extracted += distance;
                countPokes += 1;

                if (pokePower == extracted)
                {
                    if (pokePower >= exhaustion)
                    {
                        try
                        {
                            pokePower /= exhaustion;
                        }
                        catch (Exception)
                        {

                        }
                    }
                }
            }

            Console.WriteLine(pokePower);
            Console.WriteLine(countPokes);
        }
    }
}
