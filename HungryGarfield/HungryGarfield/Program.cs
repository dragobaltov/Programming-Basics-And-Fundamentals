using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungryGarfield
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            decimal rate = decimal.Parse(Console.ReadLine());
            decimal pizzaPrice = decimal.Parse(Console.ReadLine());
            decimal lasagnaPrice = decimal.Parse(Console.ReadLine());
            decimal sandwichPrice = decimal.Parse(Console.ReadLine());
            uint pizzaQuantity = uint.Parse(Console.ReadLine());
            uint lasagnaQuantity = uint.Parse(Console.ReadLine());
            uint sandwichQuantity = uint.Parse(Console.ReadLine());
            decimal pizzaInDollars = pizzaPrice / rate;
            decimal lasagnaInDollars = lasagnaPrice / rate;
            decimal sandwichInDollars = sandwichPrice / rate;
            decimal moneyNeeded = pizzaInDollars * pizzaQuantity + lasagnaInDollars * lasagnaQuantity + sandwichInDollars * sandwichQuantity;

            if (moneyNeeded <= money)
            {
                Console.WriteLine($"Garfield is well fed, John is awesome. Money left: ${money - moneyNeeded:F2}.");
            }
            else
            {
                Console.WriteLine($"Garfield is hungry. John is a badass. Money needed: ${moneyNeeded - money:F2}.");
            }
        }
    }
}
