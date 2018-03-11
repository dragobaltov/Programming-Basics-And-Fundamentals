using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battles2
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokemonsPlayer1 = int.Parse(Console.ReadLine());
            int pokemonsPlayer2 = int.Parse(Console.ReadLine());
            int maxBattles = int.Parse(Console.ReadLine());
            int counterBattles = 0;

            for (int i = 1; i <= pokemonsPlayer1; i++)
            {
                for (int j = 1; j <= pokemonsPlayer2; j++)
                {
                    counterBattles++;
                    if (counterBattles > maxBattles)
                        break;
                    Console.Write($"({i} <-> {j}) ");
                }
            }
        }
    }
}
