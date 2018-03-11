using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double studioPrice = 0.0;
            double doublePrice = 0.0;
            double suitePrice = 0.0;

            if (month == "May" || month == "October")
            {
                if (nights <= 7)
                {
                    studioPrice = nights * 50;
                }
                else
                {
                    studioPrice = nights * 50 * 0.95;
                }
                doublePrice = nights * 65;
                suitePrice = nights * 75;
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = nights * 60;
                if (nights <= 14)
                {
                    doublePrice = nights * 72;
                }
                else
                {
                    doublePrice = nights * 72 * 0.9;
                }
                suitePrice = nights * 82;
            }
            else if (month == "July" || month == "August" || month == "December")
            {
                studioPrice = nights * 68;
                doublePrice = nights * 77;
                if (nights <= 14)
                {
                    suitePrice = nights * 89;
                }
                else
                {
                    suitePrice = nights * 89 * 0.85;
                }
            }

            if (month == "October" && nights > 7)
            {
                studioPrice -= 50 * 0.95;
            }
            else if (month == "September" && nights > 7)
            {
                studioPrice -= 60;
            }

            Console.WriteLine($"Studio: {studioPrice:F2} lv.");
            Console.WriteLine($"Double: {doublePrice:F2} lv.");
            Console.WriteLine($"Suite: {suitePrice:F2} lv.");
           
        }
    }
}