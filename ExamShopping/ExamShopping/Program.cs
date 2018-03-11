using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamShopping
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stock = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> inventory = new Dictionary<string, int>();

            while (stock[0] == "stock")
            {
                string product = stock[1];
                int quantity = int.Parse(stock[2]);

                if (inventory.ContainsKey(product))
                {
                    inventory[product] += quantity;
                }
                else
                {
                    inventory.Add(product, quantity);
                }

                stock = Console.ReadLine().Split(' ');
            }

            string[] purchases = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            while (purchases[0] == "buy")
            {
                string product = purchases[1];
                int quantity = int.Parse(purchases[2]);

                if (!inventory.ContainsKey(product))
                {
                    Console.WriteLine($"{product} doesn't exist");
                }
                else
                {
                    if (inventory[product] == 0)
                    {
                        Console.WriteLine($"{product} out of stock");
                    }
                    else
                    {
                        if (quantity >= inventory[product])
                        {
                            inventory[product] = 0;
                        }
                        else
                        {
                            inventory[product] -= quantity;
                        }
                    }
                }

                purchases = Console.ReadLine().Split(' ');
            }

            foreach (KeyValuePair<string, int> item in inventory)
            {
                if (item.Value > 0)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value}");
                }
            }
        }
    }
}
