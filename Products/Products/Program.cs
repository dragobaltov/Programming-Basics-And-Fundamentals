using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Products
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string input = Console.ReadLine();
            List<Product> activeProducts = new List<Product>();
            List<Product> stockedProducts = new List<Product>();
            string[] alreadyStockedProducts = File.ReadAllLines("StockedProducts.txt");

            for (int i = 0; i < alreadyStockedProducts.Length; i++)
            {
                string[] tokens = alreadyStockedProducts[i].Split(' ');
                Product product = Product.ReadProduct(tokens);
                stockedProducts.Add(product);
            }

            while (input != "exit")
            {
                if (input == "stock")
                {
                    for (int i = 0; i < activeProducts.Count; i++)
                    {
                        if (!stockedProducts.Contains(activeProducts[i]))
                        {
                            string text = activeProducts[i].Name + " " + activeProducts[i].Type + " " +
                                activeProducts[i].Price + " " + activeProducts[i].Quantity;
                            File.AppendAllText("StockedProducts.txt", text + Environment.NewLine);

                            stockedProducts.Add(activeProducts[i]);
                        }
                    }
                }
                else if (input == "analyze")
                {
                    if (stockedProducts.Count == 0)
                    {
                        Console.WriteLine("No products stocked");
                    }
                    else
                    {
                        foreach (var item in stockedProducts)
                        {
                            Console.WriteLine($"{item.Type}, Product: {item.Name}");
                            Console.WriteLine($"Price: ${item.Price:F2}, Amount Left: {item.Quantity}");
                        }
                    }
                }
                else if (input == "sales")
                {
                    var incomes = new Dictionary<string, decimal>();

                    foreach (var item in activeProducts)
                    {
                        if (!incomes.ContainsKey(item.Type))
                        {
                            incomes.Add(item.Type, 0);
                        }
                        incomes[item.Type] += item.Income;
                    }

                    foreach (var item in incomes.OrderByDescending(i => i.Value))
                    {
                        Console.WriteLine($"{item.Key}: ${item.Value:F2}");
                    }
                }
                else
                {
                    string[] tokens = input.Split(' ');
                    Product product = Product.ReadProduct(tokens);

                    if (activeProducts.Select(p => p.Name).Contains(product.Name) && 
                        activeProducts.Where(p => p.Name == product.Name).Select(p => p.Type).Contains(product.Type))
                    {
                        activeProducts.Where(p => p.Name == product.Name).Select(p => p.Price = product.Price);
                        activeProducts.Where(p => p.Name == product.Name).Select(p => p.Quantity = product.Quantity);
                    }
                    else
                    {
                        activeProducts.Add(product);
                    }
                }

                input = Console.ReadLine();
            }
        }
    }

    class Product
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public decimal Income
        {
            get
            {
                return Price * Quantity;
            }
        }

        public static Product ReadProduct(string[] tokens)
        {
            return new Product
            {
                Name = tokens[0],
                Type = tokens[1],
                Price = decimal.Parse(tokens[2]),
                Quantity = int.Parse(tokens[3])
            };
        }
    }
}
