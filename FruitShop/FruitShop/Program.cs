using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine().ToLower();
            string day = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());

            if (day == "monday" || day == "tuesday" || day == "wednesday"
                || day == "thursday" || day == "friday")
            {
                if(fruit == "banana")
                {
                    Console.WriteLine($"{2.5 * quantity:F2}");
                }
                else if(fruit == "apple")
                {
                    Console.WriteLine($"{1.2 * quantity:F2}");
                }
                else if (fruit == "orange")
                {
                    Console.WriteLine($"{0.85 * quantity:F2}");
                }
                else if (fruit == "grapefruit")
                {
                    Console.WriteLine($"{1.45 * quantity:F2}");
                }
                else if (fruit == "kiwi")
                {
                    Console.WriteLine($"{2.7 * quantity:F2}");
                }
                else if (fruit == "pineapple")
                {
                    Console.WriteLine($"{5.5 * quantity:F2}");
                }
                else if (fruit == "grapes")
                {
                    Console.WriteLine($"{3.85 * quantity:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if(day == "saturday" || day == "sunday")
            {
                if (fruit == "banana")
                {
                    Console.WriteLine($"{2.7 * quantity:F2}");
                }
                else if (fruit == "apple")
                {
                    Console.WriteLine($"{1.25 * quantity:F2}");
                }
                else if (fruit == "orange")
                {
                    Console.WriteLine($"{0.9 * quantity:F2}");
                }
                else if (fruit == "grapefruit")
                {
                    Console.WriteLine($"{1.6 * quantity:F2}");
                }
                else if (fruit == "kiwi")
                {
                    Console.WriteLine($"{3 * quantity:F2}");
                }
                else if (fruit == "pineapple")
                {
                    Console.WriteLine($"{5.6 * quantity:F2}");
                }
                else if (fruit == "grapes")
                {
                    Console.WriteLine($"{4.2 * quantity:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
