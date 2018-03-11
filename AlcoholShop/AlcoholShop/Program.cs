using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlcoholShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceWhiskey = double.Parse(Console.ReadLine());
            double priceRakija = priceWhiskey / 2;
            double priceWine = 0.6 * priceRakija;
            double priceBeer = 0.2 * priceRakija;
            double quantityBeer = double.Parse(Console.ReadLine());
            double quantityWine = double.Parse(Console.ReadLine());
            double quantityRakija = double.Parse(Console.ReadLine());
            double quantityWhiskey = double.Parse(Console.ReadLine());

            Console.WriteLine($"{priceWhiskey * quantityWhiskey + priceRakija * quantityRakija + priceWine * quantityWine + priceBeer * quantityBeer:F2}");
        }
    }
}
