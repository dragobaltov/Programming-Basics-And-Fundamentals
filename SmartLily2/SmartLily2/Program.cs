using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLily2
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceWashingMashine = double.Parse(Console.ReadLine());
            int priceToy = int.Parse(Console.ReadLine());
            int toysCounter = 0;
            double money = 0.0;
            int gift = 10;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 1)
                {
                    toysCounter++;
                }
                else
                {
                    money += gift;
                    gift += 10;
                }
            }

            double allMoney = money + toysCounter * priceToy - age / 2;

            if (allMoney >= priceWashingMashine)
            {
                Console.WriteLine($"Yes! {allMoney - priceWashingMashine:F2}");
            }
            else
            {
                Console.WriteLine($"No! {priceWashingMashine - allMoney:F2}");
            }
        }
    }
}
