using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetDessert
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            int guests = int.Parse(Console.ReadLine());
            decimal priceOneBanana = decimal.Parse(Console.ReadLine());
            decimal priceOneEgg = decimal.Parse(Console.ReadLine());
            decimal priceOneKiloBerries = decimal.Parse(Console.ReadLine());
            int portions = (int)Math.Ceiling(guests / 6.0);
            decimal neededMoney = portions * (2 * priceOneBanana + 4 * priceOneEgg + 0.2m * priceOneKiloBerries);

            if (money >= neededMoney)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {neededMoney:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {(neededMoney - money):F2}lv more.");
            }
        }
    }
}
