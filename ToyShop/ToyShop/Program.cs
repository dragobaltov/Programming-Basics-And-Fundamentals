using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyShop
{
    class Program 
    {
        static void Main(string[] args)
        {
            double priceHoliday = double.Parse(Console.ReadLine());
            int quantityPuzzels = int.Parse(Console.ReadLine());
            int quantityDolls = int.Parse(Console.ReadLine());
            int quantityBears = int.Parse(Console.ReadLine());
            int quantityMinions = int.Parse(Console.ReadLine());
            int quantityTrucks = int.Parse(Console.ReadLine());
            double profit = (quantityPuzzels * 2.6 + quantityDolls * 3 + quantityBears * 4.1
                            + quantityMinions * 8.2 + quantityTrucks * 2) * 0.9;

            if (quantityPuzzels + quantityDolls + quantityBears + quantityMinions + quantityTrucks >= 50)
            {
                profit = profit * 0.75;
                if(priceHoliday <= profit)
                {
                    Console.WriteLine($"Yes! {profit - priceHoliday:F2} lv left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! {priceHoliday - profit:F2} lv needed.");
                }
            }
            else
            {
                if(priceHoliday <= profit)
                {
                    Console.WriteLine($"Yes! {profit - priceHoliday:F2} lv left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! {priceHoliday - profit:F2} lv needed.");
                }
            }
            
        }
    }
}
