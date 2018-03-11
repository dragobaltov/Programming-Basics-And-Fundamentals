using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetDessert2
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

            int sets = guests / 6;

            if (guests % 6 != 0)
                sets++;

            decimal moneyNeeded = sets * (2 * priceOneBanana + 4 * priceOneEgg + 0.2m * priceOneKiloBerries);

            if (money >= moneyNeeded)
            {
                Console.WriteLine("Ivancho has enough money - it would cost {0:F2}lv.", moneyNeeded);
            }
            else
            {
                Console.WriteLine("Ivancho will have to withdraw money - he will need {0:F2}lv more.", moneyNeeded - money);
            }
        }
    }
}
