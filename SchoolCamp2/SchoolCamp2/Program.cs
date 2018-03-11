using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCamp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string typeGroup = Console.ReadLine();
            int students = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());

            if (season == "Winter")
            {
                if (typeGroup == "boys")
                {
                    double price = nights * students * 9.6;
                    Console.WriteLine($"Judo {price:F2} lv.");
                }
                else if (typeGroup == "girls")
                {
                    double price = nights * students * 9.6;
                    Console.WriteLine($"Gymnastics {price:F2} lv.");
                }
                else if (typeGroup == "mixed")
                {
                    double price = nights * students * 10;
                    Console.WriteLine($"Ski {price:F2} lv.");
                }
            }
            else if (season == "Spring")
            {
                if (typeGroup == "boys")
                {
                    double price = nights * students * 7.2;
                    Console.WriteLine($"Tennis {price:F2} lv.");
                }
                else if (typeGroup == "girls")
                {
                    double price = nights * students * 7.2;
                    Console.WriteLine($"Athletics {price:F2} lv.");
                }
                else if (typeGroup == "mixed")
                {
                    double price = nights * students * 9.5;
                    Console.WriteLine($"Cycling {price:F2} lv.");
                }
            }
            else if (season == "Summer")
            {
                if (typeGroup == "boys")
                {
                    double price = nights * students * 15;
                    Console.WriteLine($"Football {price:F2} lv.");
                }
                else if (typeGroup == "girls")
                {
                    double price = nights * students * 15;
                    Console.WriteLine($"Volleyball {price:F2} lv.");
                }
                else if (typeGroup == "mixed")
                {
                    double price = nights * students * 20;
                    Console.WriteLine($"Swimming {price:F2} lv.");
                }
            }
        }
    }
}
