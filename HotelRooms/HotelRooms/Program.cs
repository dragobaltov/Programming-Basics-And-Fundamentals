using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRooms
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            if (month == "May" || month == "October")
            {
                if (nights > 7 && nights < 14)
                {
                    Console.WriteLine($"Apartment: {nights * 65:F2} lv.");
                    Console.WriteLine($"Studio: {(nights * 50) * 0.95:F2} lv.");
                }
                else if (nights > 14)
                {
                    Console.WriteLine($"Apartment: {nights * 65 * 0.9:F2} lv.");
                    Console.WriteLine($"Studio: {nights * 50 * 0.7:F2} lv.");
                }
                else
                {
                    Console.WriteLine($"Apartment: {nights * 65:F2} lv.");
                    Console.WriteLine($"Studio: {nights * 50:F2} lv.");
                }
            }
            else if (month == "June" || month == "September")
            {
                if (nights > 14)
                {
                    Console.WriteLine($"Apartment: {(nights * 68.7) * 0.9:F2} lv.");
                    Console.WriteLine($"Studio: {(nights * 75.2) * 0.8:F2} lv.");
                }
                else
                {
                    Console.WriteLine($"Apartment: {nights * 68.7:F2} lv.");
                    Console.WriteLine($"Studio: {nights * 75.2:F2} lv.");
                }
            }
            else if (month == "July" || month == "August")
            {
                if (nights > 14)
                {
                    Console.WriteLine($"Apartment: {(nights * 77) * 0.9:F2} lv.");
                    Console.WriteLine($"Studio: {nights * 76:F2} lv.");
                }
                else
                {
                    Console.WriteLine($"Apartment: {nights * 77:F2} lv.");
                    Console.WriteLine($"Studio: {nights * 76:F2} lv.");
                }
            }
        }
    }
}
