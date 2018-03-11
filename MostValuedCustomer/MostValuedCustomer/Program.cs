using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostValuedCustomer
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var shopData = new Dictionary<string, double>();
            var customersData = new Dictionary<string, Dictionary<string, double>>();
            var countData = new Dictionary<string, Dictionary<string, int>>();

            while (input != "Shop is open")
            {
                string[] inputTokens = input.Split(' ');
                string product = inputTokens[0];
                double price = double.Parse(inputTokens[1]);

                shopData.Add(product, price);

                input = Console.ReadLine();
            }

            string command = Console.ReadLine();

            while (command != "Print")
            {
                if (command == "Discount")
                {
                    foreach (var item in shopData.OrderByDescending(x => x.Value).Take(3))
                    {
                        shopData[item.Key] *= 0.9;
                    }
                }
                else
                {
                    string[] commandTokens = command.Split(new string[] { ": " }, StringSplitOptions.RemoveEmptyEntries);
                    string name = commandTokens[0];
                    string[] products = commandTokens[1].Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

                    if (!customersData.ContainsKey(name))
                        customersData.Add(name, new Dictionary<string, double>());
                    if (!countData.ContainsKey(name))
                        countData.Add(name, new Dictionary<string, int>());

                    foreach (var item in products)
                    {
                        if (shopData.ContainsKey(item))
                        {
                            if (!customersData[name].ContainsKey(item))
                                customersData[name].Add(item, 0);
                            if (!countData[name].ContainsKey(item))
                                countData[name].Add(item, 0);

                            customersData[name][item] += shopData[item];
                            countData[name][item] += 1;
                        }
                    }
                }

                command = Console.ReadLine();
            }

            string biggestSpender = "";
            double mostSpended = 0;

            foreach (var item in customersData)
            {
                double spended = item.Value.Values.Sum();
                if (spended > mostSpended)
                {
                    mostSpended = spended;
                    biggestSpender = item.Key;
                }
            }

            var resultDict = new Dictionary<string, double>();
            foreach (var item in customersData[biggestSpender])
            {
                resultDict.Add(item.Key, shopData[item.Key]);
            }

            double sum = 0;
            foreach (var item in resultDict)
            {
                sum += (item.Value * countData[biggestSpender][item.Key]);
            }

            Console.WriteLine($"Biggest spender: {biggestSpender}");
            Console.WriteLine("^Products bought:");
            foreach (var item in resultDict.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"^^^{item.Key}: {item.Value:F2}");
            }
            Console.WriteLine($"Total: {sum:F2}");
        }
    }
}
