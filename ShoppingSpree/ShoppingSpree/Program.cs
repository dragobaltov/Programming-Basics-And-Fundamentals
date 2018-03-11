using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');
            Dictionary<string, double> productsData = new Dictionary<string, double>();

            while (input[0] != "end")
            {
                string productName = input[0];
                double price = double.Parse(input[1]);

                if (!productsData.ContainsKey(productName))
                {
                    productsData.Add(productName, price);
                }
                else
                {
                    if (price < productsData[productName])
                        productsData[productName] = price;
                }

                input = Console.ReadLine().Split(' ');
            }

            double neededSum = productsData.Values.Sum();

            if (neededSum > budget)
            {
                Console.WriteLine("Need more money... Just buy banichka");
            }
            else
            {
                foreach (var item in productsData.OrderByDescending(x => x.Value).ThenBy(x => x.Key.Length))
                {
                    Console.WriteLine($"{item.Key} costs {item.Value:F2}");
                }
            }
        }
    }
}
