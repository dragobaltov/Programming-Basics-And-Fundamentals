using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Магнолии – 3.25 лева
            //•	Зюмбюли – 4 лева
            //•	Рози – 3.50 лева
            //•	Кактуси – 8 лева
            int magnoliiQuantity = int.Parse(Console.ReadLine());
            int zumbiuliQuantity = int.Parse(Console.ReadLine());
            int rosesQuantity = int.Parse(Console.ReadLine());
            int cactusesQuantity = int.Parse(Console.ReadLine());
            double presentPrice = double.Parse(Console.ReadLine());
            double profit = (magnoliiQuantity * 3.25 + zumbiuliQuantity * 4 + rosesQuantity * 3.5 + cactusesQuantity * 8) * 0.95;

            if (profit >= presentPrice)
            {
                Console.WriteLine($"She is left with {Math.Floor(profit - presentPrice)} leva.");
            }
            else
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(presentPrice - profit)} leva.");
            }
        }
    }
}
