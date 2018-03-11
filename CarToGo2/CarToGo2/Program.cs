using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarToGo2
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            if (budget <= 100)
            {
                Console.WriteLine("Economy class");
                if (season == "Summer")
                {
                    Console.WriteLine($"Cabrio - {budget * 0.35:F2}");
                }
                else if (season == "Winter")
                {
                    Console.WriteLine($"Jeep - {budget * 0.65:F2}");
                }
            }
            else if (budget > 100 && budget <= 500)
            {
                Console.WriteLine("Compact class");
                if (season == "Summer")
                {
                    Console.WriteLine($"Cabrio - {budget * 0.45:F2}");
                }
                else if (season == "Winter")
                {
                    Console.WriteLine($"Jeep - {budget * 0.8:F2}");
                }
            }
            else
            {
                Console.WriteLine("Luxury class");
                Console.WriteLine($"Jeep - {budget * 0.9:F2}");
            }
        }
    }
}
