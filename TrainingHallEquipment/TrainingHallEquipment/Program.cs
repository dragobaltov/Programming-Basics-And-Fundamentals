using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingHallEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numberItems = int.Parse(Console.ReadLine());
            string itemName = null;
            double itemPrice = 0.0;
            int quantity = 0;
            double subtotal = 0.0;

            for (int i = 0; i < numberItems; i++)
            {
                itemName = Console.ReadLine();
                itemPrice = double.Parse(Console.ReadLine());
                quantity = int.Parse(Console.ReadLine());
                subtotal += itemPrice * quantity;

                if (quantity == 1)
                {
                    Console.WriteLine($"Adding 1 {itemName} to cart.");
                }
                else
                {
                    Console.WriteLine($"Adding {quantity} {itemName}s to cart.");
                }
            }

            Console.WriteLine($"Subtotal: ${subtotal:F2}");
            if (subtotal > budget)
            {
                Console.WriteLine($"Not enough. We need ${subtotal - budget:F2} more.");
            }
            else
            {
                Console.WriteLine($"Money left: ${budget - subtotal:F2}");
            }
        }
    }
}
