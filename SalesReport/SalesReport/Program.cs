using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesReport
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Sale> allSales = new List<Sale>();
            var salesData = new SortedDictionary<string, double>();

            for (int i = 0; i < n; i++)
            {
                Sale sale = Sale.ParseSale(Console.ReadLine());
                allSales.Add(sale);
            }


            for (int i = 0; i < n; i++)
            {
                Sale currentSale = allSales[i];

                if (!salesData.ContainsKey(currentSale.Town))
                    salesData.Add(currentSale.Town, 0);

                salesData[currentSale.Town] += currentSale.TotalPrice;
            }

            foreach (var item in salesData)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:F2}");
            }
        }
    }

    class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }

        public double TotalPrice
        {
            get
            {
                return Price * Quantity;
            }
        }

        public static Sale ParseSale(string input)
        {
            string[] inputTokens = input.Split(' ');

            return new Sale
            {
                Town = inputTokens[0],
                Product = inputTokens[1],
                Price = double.Parse(inputTokens[2]),
                Quantity = double.Parse(inputTokens[3])
            };
        }
    }
}
