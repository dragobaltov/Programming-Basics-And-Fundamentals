using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_Airline
{
    class Program
    {
        static void Main(string[] args)
        {
            int flights = int.Parse(Console.ReadLine());
            decimal overallProfit = 0m;

            for (int i = 0; i < flights; i++)
            {
                int adultPassangersCount = int.Parse(Console.ReadLine());
                decimal adultTicketPrice = decimal.Parse(Console.ReadLine());
                int youthPassangersCount = int.Parse(Console.ReadLine());
                decimal youthTicketPrice = decimal.Parse(Console.ReadLine());
                
                decimal fuelPricePerHour = decimal.Parse(Console.ReadLine());
                decimal fuelConsumptionPerHour = decimal.Parse(Console.ReadLine());
                short flightDuration = short.Parse(Console.ReadLine());

                decimal income = adultPassangersCount * adultTicketPrice + youthPassangersCount * youthTicketPrice;
                decimal expenses = fuelPricePerHour * fuelConsumptionPerHour * flightDuration;
                decimal profit = income - expenses;
                overallProfit += profit;

                if (profit >= 0)
                {
                    Console.WriteLine("You are ahead with {0:F3}$.", profit);
                }
                else
                {
                    Console.WriteLine("We've got to sell more tickets! We've lost {0:F3}$.", profit);
                }
            }

            decimal averageProfit = overallProfit / flights;

            Console.WriteLine("Overall profit -> {0:F3}$.", overallProfit);
            Console.WriteLine("Average profit -> {0:F3}$.", averageProfit);
        }
    }
}
