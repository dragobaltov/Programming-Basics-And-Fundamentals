using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace GroceryShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var productsData = new Dictionary<string, double>();
            string pattern = @"^(?<name>[A-Z][a-z]+):(?<price>\d+\.\d{2})$";

            while (input != "bill")
            {
                if (Regex.IsMatch(input, pattern))
                {
                    Match match = Regex.Match(input, pattern);
                    string name = match.Groups["name"].Value;
                    double price = double.Parse(match.Groups["price"].Value);

                    if (!productsData.Keys.Contains(name))
                        productsData.Add(name, price);

                    productsData[name] = price;
                }

                input = Console.ReadLine();
            }

            foreach (var item in productsData.OrderByDescending(p => p.Value))
            {
                Console.WriteLine($"{item.Key} costs {item.Value:F2}");
            }
        }
    }
}
