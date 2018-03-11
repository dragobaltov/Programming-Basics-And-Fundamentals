using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniCoffeeOrders
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal sum = 0.0m;

            for (int i = 0; i < n; i++)
            {
                decimal price = decimal.Parse(Console.ReadLine());
                DateTime date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                long capsules = long.Parse(Console.ReadLine());
                int daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);
                decimal sumOfCurrentOrder = daysInMonth * capsules * price;
                sum += sumOfCurrentOrder;
                Console.WriteLine($"The price for the coffee is: ${sumOfCurrentOrder:F2}");
            }

            Console.WriteLine($"Total: ${sum:F2}");
        }
    }
}
