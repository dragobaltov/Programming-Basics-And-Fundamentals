using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace SoftUniCoffeeOrders3
{
    class Program
    {
        static void Main(string[] args)
        {
            int orders = int.Parse(Console.ReadLine());
            decimal totalPrice = 0.0m;

            for (int i = 0; i < orders; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                DateTime dateOfOrder = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy",
                                       CultureInfo.InvariantCulture);
                long countCapsules = long.Parse(Console.ReadLine());
                int daysInCurrentMonth = DateTime.DaysInMonth(dateOfOrder.Year, dateOfOrder.Month);

                decimal orderPrice = daysInCurrentMonth * countCapsules * pricePerCapsule;
                totalPrice += orderPrice;

                Console.WriteLine("The price for the coffee is: ${0:F2}", orderPrice);
            }

            Console.WriteLine("Total: ${0:F2}", totalPrice);
        }
    }
}
