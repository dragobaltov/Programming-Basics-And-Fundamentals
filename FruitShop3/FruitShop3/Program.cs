using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitShop3
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine().ToLower();
            string day = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());

            if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday")
            {
                if (fruit == "banana")
                {
                    Console.WriteLine($"{quantity * 2.5:F2}");
                }
                else if (fruit == "apple")
                {
                    Console.WriteLine($"{quantity * 1.2:F2}");
                }
                else if (fruit == "orange")
                {
                    Console.WriteLine($"{quantity * 0.85:F2}");
                }
                else if (fruit == "grapefruit")
                {
                    Console.WriteLine($"{quantity * 1.45:F2}");
                }
                else if (fruit == "kiwi")
                {
                    Console.WriteLine($"{quantity * 2.7:F2}");
                }
                else if (fruit == "pineapple")
                {
                    Console.WriteLine($"{quantity * 5.5:F2}");
                }
                else if (fruit == "grapes")
                {
                    Console.WriteLine($"{quantity * 3.85:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (day == "saturday" || day == "sunday")
            {
                if (fruit == "banana")
                {
                    Console.WriteLine($"{quantity * 2.7:F2}");
                }
                else if (fruit == "apple")
                {
                    Console.WriteLine($"{quantity * 1.25:F2}");
                }
                else if (fruit == "orange")
                {
                    Console.WriteLine($"{quantity * 0.9:F2}");
                }
                else if (fruit == "grapefruit")
                {
                    Console.WriteLine($"{quantity * 1.60:F2}");
                }
                else if (fruit == "kiwi")
                {
                    Console.WriteLine($"{quantity * 3:F2}");
                }
                else if (fruit == "pineapple")
                {
                    Console.WriteLine($"{quantity * 5.6:F2}");
                }
                else if (fruit == "grapes")
                {
                    Console.WriteLine($"{quantity * 4.2:F2}");
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
