using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCamp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string typeGroup = Console.ReadLine();
            int students = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            double price = students * nights;
            string sport = null;

            if (season == "Winter")
            {
                if (typeGroup == "boys")
                {
                    sport = "Judo";
                    if (students >= 50)
                    {
                        price *= 9.6 * 0.5;
                    }
                    else if (students >= 20)
                    {
                        price *= 9.6 * 0.85;
                    }
                    else if (students >= 10)
                    {
                        price *= 9.6 * 0.95;
                    }
                    else
                    {
                        price *= 9.6;
                    }
                }
                else if (typeGroup == "girls")
                {
                    sport = "Gymnastics";
                    if (students >= 50)
                    {
                        price *= 9.6 * 0.5;
                    }
                    else if (students >= 20)
                    {
                        price *= 9.6 * 0.85;
                    }
                    else if (students >= 10)
                    {
                        price *= 9.6 * 0.95;
                    }
                    else
                    {
                        price *= 9.6;
                    }
                }
                else if (typeGroup == "mixed")
                {
                    sport = "Ski";
                    if (students >= 50)
                    {
                        price *= 10 * 0.5;
                    }
                    else if (students >= 20)
                    {
                        price *= 10 * 0.85;
                    }
                    else if (students >= 10)
                    {
                        price *= 10 * 0.95;
                    }
                    else
                    {
                        price *= 10;
                    }
                }
            }
            else if (season == "Spring")
            {
                if (typeGroup == "boys")
                {
                    sport = "Tennis";
                    if (students >= 50)
                    {
                        price *= 7.2 * 0.5;
                    }
                    else if (students >= 20)
                    {
                        price *= 7.2 * 0.85;
                    }
                    else if (students >= 10)
                    {
                        price *= 7.2 * 0.95;
                    }
                    else
                    {
                        price *= 7.2;
                    }
                }
                else if (typeGroup == "girls")
                {
                    sport = "Athletics";
                    if (students >= 50)
                    {
                        price *= 7.2 * 0.5;
                    }
                    else if (students >= 20)
                    {
                        price *= 7.2 * 0.85;
                    }
                    else if (students >= 10)
                    {
                        price *= 7.2 * 0.95;
                    }
                    else
                    {
                        price *= 7.2;
                    }
                }
                else if (typeGroup == "mixed")
                {
                    sport = "Cycling";
                    if (students >= 50)
                    {
                        price *= 9.5 * 0.5;
                    }
                    else if (students >= 20)
                    {
                        price *= 9.5 * 0.85;
                    }
                    else if (students >= 10)
                    {
                        price *= 9.5 * 0.95;
                    }
                    else
                    {
                        price *= 9.5;
                    }
                }
            }
            else if (season == "Summer")
            {
                if (typeGroup == "boys")
                {
                    sport = "Football";
                    if (students >= 50)
                    {
                        price *= 15 * 0.5;
                    }
                    else if (students >= 20)
                    {
                        price *= 15 * 0.85;
                    }
                    else if (students >= 10)
                    {
                        price *= 15 * 0.95;
                    }
                    else
                    {
                        price *= 15;
                    }
                }
                else if (typeGroup == "girls")
                {
                    sport = "Volleyball";
                    if (students >= 50)
                    {
                        price *= 15 * 0.5;
                    }
                    else if (students >= 20)
                    {
                        price *= 15 * 0.85;
                    }
                    else if (students >= 10)
                    {
                        price *= 15 * 0.95;
                    }
                    else
                    {
                        price *= 15;
                    }
                }
                else if (typeGroup == "mixed")
                {
                    sport = "Swimming";
                    if (students >= 50)
                    {
                        price *= 20 * 0.5;
                    }
                    else if (students >= 20)
                    {
                        price *= 20 * 0.85;
                    }
                    else if (students >= 10)
                    {
                        price *= 20 * 0.95;
                    }
                    else
                    {
                        price *= 20;
                    }
                }
            }

            Console.WriteLine($"{sport} {price:F2} lv.");
        }
    }
}
