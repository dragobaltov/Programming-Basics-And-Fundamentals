using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int balls = int.Parse(Console.ReadLine());
            BigInteger highestValue = -1;
            int maxSnow = 0;
            int maxTime = 0;
            int maxQuality = 0;

            for (int i = 0; i < balls; i++)
            {
                int snow = int.Parse(Console.ReadLine());
                int time = int.Parse(Console.ReadLine());
                int quality = int.Parse(Console.ReadLine());
                BigInteger value = 1;

                for (int j = 0; j < quality; j++)
                {
                    value *= (snow / time);
                }

                if (value > highestValue)
                {
                    highestValue = value;
                    maxSnow = snow;
                    maxTime = time;
                    maxQuality = quality;
                }
            }

            Console.WriteLine($"{maxSnow} : {maxTime} = {highestValue} ({maxQuality})");
        }
    }
}
