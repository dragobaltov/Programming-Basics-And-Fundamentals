using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlcoholMarket2
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceWhiskey = double.Parse(Console.ReadLine());
            double beerQuantity = double.Parse(Console.ReadLine());
            double wineQuantity = double.Parse(Console.ReadLine());
            double rakijaQuantity = double.Parse(Console.ReadLine());
            double whiskeyQuantity = double.Parse(Console.ReadLine());
            double priceRakija = priceWhiskey / 2;
            double priceWine = priceRakija * 0.6;
            double priceBeer = priceRakija * 0.2;
            double all = priceWhiskey * whiskeyQuantity + priceRakija * rakijaQuantity + priceWine * wineQuantity + priceBeer * beerQuantity;

            Console.WriteLine($"{all:F2}");
        }
    }
}
