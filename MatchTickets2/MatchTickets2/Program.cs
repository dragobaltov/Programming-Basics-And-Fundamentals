using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchTickets2
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());

            if (people >= 1 && people <= 4)
            {
                budget -= budget * 0.75;
            }
            else if (people <= 9)
            {
                budget -= budget * 0.6;
            }
            else if (people <= 24)
            {
                budget -= budget * 0.5;
            }
            else if (people <= 49)
            {
                budget -= budget * 0.4;
            }
            else
            {
                budget -= budget * 0.25;
            }

            if (category == "VIP")
            {
                double price = people * 499.99;
                if (price <= budget)
                {
                    Console.WriteLine($"Yes! You have {budget - price:F2} leva left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! You need {price - budget:F2} leva.");
                }
            }
            else if (category == "Normal")
            {
                double price = people * 249.99;
                if (price <= budget)
                {
                    Console.WriteLine($"Yes! You have {budget - price:F2} leva left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! You need {price - budget:F2} leva.");
                }
            }
        }
    }
}
