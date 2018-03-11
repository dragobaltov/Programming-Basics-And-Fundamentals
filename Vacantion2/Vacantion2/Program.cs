using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacantion2
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            if (budget <= 1000)
            {
                if (season == "Summer")
                {
                    Console.WriteLine($"Alaska - Camp - {budget * 0.65:F2}");
                }
                else if (season == "Winter")
                {
                    Console.WriteLine($"Morocco - Camp - {budget * 0.45:F2}");
                }
            }
            else if (budget > 1000 && budget <= 3000)
            {
                if (season == "Summer")
                {
                    Console.WriteLine($"Alaska - Hut - {budget * 0.8:F2}");
                }
                else if (season == "Winter")
                {
                    Console.WriteLine($"Morocco - Hut - {budget * 0.6:F2}");
                }
            }
            else
            {
                if (season == "Summer")
                {
                    Console.WriteLine($"Alaska - Hotel - {budget * 0.9:F2}");
                }
                else if (season == "Winter")
                {
                    Console.WriteLine($"Morocco - Hotel - {budget * 0.9:F2}");
                }
            }
        }
    }
}
