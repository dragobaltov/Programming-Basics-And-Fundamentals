using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kmForMonth = double.Parse(Console.ReadLine());
            // 4 months, 10 %

            if (kmForMonth <= 5000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    Console.WriteLine($"{(4 * kmForMonth * 0.75) * 0.9:F2}");
                }
                else if (season == "Summer")
                {
                    Console.WriteLine($"{(4 * kmForMonth * 0.9) * 0.9:F2}");
                }
                else if (season == "Winter")
                {
                    Console.WriteLine($"{(4 * kmForMonth * 1.05) * 0.9:F2}");
                }
            }
            else if (kmForMonth > 5000 && kmForMonth <= 10000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    Console.WriteLine($"{(4 * kmForMonth * 0.95) * 0.9:F2}");
                }
                else if (season == "Summer")
                {
                    Console.WriteLine($"{(4 * kmForMonth * 1.1) * 0.9:F2}");
                }
                else if (season == "Winter")
                {
                    Console.WriteLine($"{(4 * kmForMonth * 1.25) * 0.9:F2}");
                }
            }
            else if (kmForMonth > 10000 && kmForMonth <= 20000)
            {
                Console.WriteLine($"{(4 * kmForMonth * 1.45) * 0.9:F2}");
            }
        }
    }
}
