using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniCoffeeSupplies
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] delimeters = Console.ReadLine().Split(' ');
            string firstDelimeter = delimeters[0];
            string secondDelimeter = delimeters[1];
            var nameAndCoffeeType = new Dictionary<string, string>();
            var coffeeTypeAndQuantity = new Dictionary<string, int>();


            string firstInput = Console.ReadLine();

            while (firstInput != "end of info")
            {
                if (firstInput.Contains(firstDelimeter))
                {
                    string[] tokens = firstInput.Split(new string[] { firstDelimeter }, StringSplitOptions.RemoveEmptyEntries);
                    string personName = tokens[0];
                    string coffeeType = tokens[1];

                    if (!nameAndCoffeeType.ContainsKey(personName))
                        nameAndCoffeeType.Add(personName, coffeeType);
                    else
                        nameAndCoffeeType[personName] = coffeeType;

                    if (!coffeeTypeAndQuantity.ContainsKey(coffeeType))
                    {
                        coffeeTypeAndQuantity.Add(coffeeType, 0);
                    }
                }
                else if (firstInput.Contains(secondDelimeter))
                {
                    string[] tokens = firstInput.Split(new string[] { secondDelimeter }, StringSplitOptions.RemoveEmptyEntries);
                    string coffeeType = tokens[0];
                    int quantity = int.Parse(tokens[1]);

                    if (!coffeeTypeAndQuantity.ContainsKey(coffeeType))
                    {
                        coffeeTypeAndQuantity.Add(coffeeType, 0);
                    }

                    coffeeTypeAndQuantity[coffeeType] += quantity;
                }

                firstInput = Console.ReadLine();
            }

            foreach (var item in coffeeTypeAndQuantity)
            {
                if (item.Value == 0)
                {
                    Console.WriteLine("Out of {0}", item.Key);
                }
            }

            string secondInput = Console.ReadLine();

            while (secondInput != "end of week")
            {
                string[] tokens = secondInput.Split(' ');
                string personName = tokens[0];
                int quantity = int.Parse(tokens[1]);
                string neededCoffeeType = nameAndCoffeeType[personName];

                if (coffeeTypeAndQuantity.ContainsKey(neededCoffeeType))
                {
                    coffeeTypeAndQuantity[neededCoffeeType] -= quantity;

                    if(coffeeTypeAndQuantity[neededCoffeeType] <= 0)
                        Console.WriteLine("Out of {0}", neededCoffeeType);
                }
                else
                {
                    Console.WriteLine("Out of {0}", neededCoffeeType);
                }

                secondInput = Console.ReadLine();
            }

            Console.WriteLine("Coffee Left:");

            foreach (var kvp in coffeeTypeAndQuantity.Where(c => c.Value > 0).OrderByDescending(c => c.Value))
            {
                Console.WriteLine($"{kvp.Key} {kvp.Value}");
            }

            Console.WriteLine("For:");

            foreach (var kvp in coffeeTypeAndQuantity.Where(c => c.Value > 0)
                                .OrderBy(c => c.Key))
            {
                string coffeeType = kvp.Key;
                int quantity = kvp.Value;

                foreach (var item in nameAndCoffeeType.Where(x => x.Value == coffeeType).OrderByDescending(x => x.Key))
                {
                    Console.WriteLine(item.Key + " " + item.Value);
                }
            }
        }
    }
}
