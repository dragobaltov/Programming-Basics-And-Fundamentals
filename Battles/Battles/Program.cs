using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battles
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityPokemonsPlayer1 = int.Parse(Console.ReadLine());
            int quantityPokemonsPlayer2 = int.Parse(Console.ReadLine());
            int maxBattles = int.Parse(Console.ReadLine());
            int counterFights = 0;

            for (int i = 1; i <= quantityPokemonsPlayer1; i++)
            {
                for (int j = 1; j <= quantityPokemonsPlayer2; j++)
                {
                    counterFights++;
                    if (counterFights > maxBattles)
                        break;
                    Console.Write($"({i} <-> {j}) ");
                }
            }
        }
    }
}
