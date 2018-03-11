using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaporStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string game = null;
            double gamePrice = 0;

            while (budget > 0)
            {
                game = Console.ReadLine();

                if (game == "Game Time")
                    break;

                if (game == "OutFall 4")
                {
                    gamePrice = 39.99;
                }
                else if (game == "CS: OG")
                {
                    gamePrice = 15.99;
                }
                else if (game == "Zplinter Zell")
                {
                    gamePrice = 19.99;
                }
                else if (game == "Honored 2")
                {
                    gamePrice = 59.99;
                }
                else if (game == "RoverWatch")
                {
                    gamePrice = 29.99;
                }
                else if (game == "RoverWatch Origins Edition")
                {
                    gamePrice = 39.99;
                }
                else
                {
                    Console.WriteLine("Not Found");
                }

                if (budget < gamePrice)
                {
                    Console.WriteLine("Too Expensive");
                }
                else if(budget >= gamePrice && gamePrice != 0)
                {
                    budget -= gamePrice;
                    Console.WriteLine($"Bought {game}");
                }
            }
        }
    }
}
