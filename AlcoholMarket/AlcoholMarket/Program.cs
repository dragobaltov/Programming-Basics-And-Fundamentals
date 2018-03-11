using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlcoholMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceWhisky = double.Parse(Console.ReadLine());
            double quantityBeer = double.Parse(Console.ReadLine());
            double quantityWine = double.Parse(Console.ReadLine());
            double quantityRakia = double.Parse(Console.ReadLine());
            double quantityWhisky = double.Parse(Console.ReadLine());
            double price = quantityRakia * priceWhisky / 2 + quantityWine * priceWhisky * 0.6 / 2
                + quantityBeer * priceWhisky * 0.2 / 2 + quantityWhisky * priceWhisky;
            Console.WriteLine($"{price:F2}");
        }
    }
}
