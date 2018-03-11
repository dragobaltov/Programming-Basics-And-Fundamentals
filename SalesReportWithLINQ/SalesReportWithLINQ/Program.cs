using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesReportWithLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Sale> sales = new List<Sale>();

            for (int i = 0; i < n; i++)
            {
                Sale sale = Sale.ReadSale(Console.ReadLine());
                sales.Add(sale);
            }

            List<string> towns = sales.Select(s => s.Town).Distinct().OrderBy(t => t).ToList();

            foreach (string town in towns)
            {
                double totalSum = sales.Where(s => s.Town == town).Select(s => s.TotalPrice).Sum();

                Console.WriteLine($"{town} -> {totalSum:F2}");
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

            public static Sale ReadSale(string input)
            {
                string[] tokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                return new Sale
                {
                    Town = tokens[0],
                    Product = tokens[1],
                    Price = double.Parse(tokens[2]),
                    Quantity = double.Parse(tokens[3])
                };
            }
        }
    }


}
