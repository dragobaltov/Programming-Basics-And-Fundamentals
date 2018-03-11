using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyShop2
{
    class Program
    {
        static void Main(string[] args)
        {
            double holidayPrice = double.Parse(Console.ReadLine());
            int puzzelsQuantity = int.Parse(Console.ReadLine());
            int dollsQuantity = int.Parse(Console.ReadLine());
            int bearsQuantity = int.Parse(Console.ReadLine());
            int minionsQuantity = int.Parse(Console.ReadLine());
            int trucksQuantity = int.Parse(Console.ReadLine());
            double allQuantity = puzzelsQuantity + dollsQuantity + bearsQuantity + minionsQuantity + trucksQuantity;
            double puzzelsPrice = puzzelsQuantity * 2.6;
            double dollsPrice = dollsQuantity * 3;
            double bearsPrice = bearsQuantity * 4.1;
            double minionsPrice = minionsQuantity * 8.2;
            double trucksPrice = trucksQuantity * 2;

            if (allQuantity < 50)
            {
                double moneyMade = (puzzelsPrice + dollsPrice + bearsPrice + minionsPrice + trucksPrice) * 0.9;
                if (moneyMade >= holidayPrice)
                {
                    Console.WriteLine($"Yes! {moneyMade - holidayPrice:F2} lv left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! {holidayPrice - moneyMade:F2} lv needed.");
                }
            }
            else
            {
                double moneyMade = (puzzelsPrice + dollsPrice + bearsPrice + minionsPrice + trucksPrice) * 0.75 * 0.9;
                if (moneyMade >= holidayPrice)
                {
                    Console.WriteLine($"Yes! {moneyMade - holidayPrice:F2} lv left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! {holidayPrice - moneyMade:F2} lv needed.");
                }
            }
        }
    }
}
