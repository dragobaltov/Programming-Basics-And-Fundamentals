﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeMon2
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int originalPokePower = pokePower;
            int count = 0;

            while (pokePower - distance >= 0)
            {
                pokePower -= distance;
                count++;

                if (pokePower * 2 == originalPokePower)
                    if (exhaustionFactor != 0)
                        pokePower /= exhaustionFactor;
            }

            Console.WriteLine(pokePower);
            Console.WriteLine(count);
        }
    }
}
