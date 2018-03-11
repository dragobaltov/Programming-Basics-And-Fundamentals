using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop2
{
    class Program
    {
        static void Main(string[] args)
        {
            int magnoliiQuantity = int.Parse(Console.ReadLine());
            int ziumbiuliQuantity = int.Parse(Console.ReadLine());
            int rosesQuantity = int.Parse(Console.ReadLine());
            int cactusesQuantity = int.Parse(Console.ReadLine());
            double presentPrice = double.Parse(Console.ReadLine());
            double magnoliiPrice = magnoliiQuantity * 3.25;
            double ziumbiuliPrice = ziumbiuliQuantity * 4;
            double rosesPrice = rosesQuantity * 3.5;
            double cactusesPrice = cactusesQuantity * 8;
            double profit = (magnoliiPrice + ziumbiuliPrice + rosesPrice + cactusesPrice) * 0.95;

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
