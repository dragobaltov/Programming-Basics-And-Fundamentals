using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string typeGroup = Console.ReadLine();
            int quantityStudents = int.Parse(Console.ReadLine());
            int quantityNights = int.Parse(Console.ReadLine());

            if (season == "Winter" && quantityStudents >= 50)
            {
                if (typeGroup == "boys")
                {
                    Console.WriteLine($"Judo {quantityStudents * 9.6 * 0.5 * quantityNights:F2} lv.");
                }
                else if (typeGroup == "girls")
                {
                    Console.WriteLine($"Gymnastics {quantityStudents * 9.6 * 0.5 * quantityNights:F2} lv.");
                }
                else if (typeGroup == "mixed")
                {
                    Console.WriteLine($"Ski {quantityStudents * 10 * 0.5 * quantityNights:F2} lv.");
                }
            }
            else if (season == "Winter" && quantityStudents >= 20 && quantityStudents < 50)
            {
                if (typeGroup == "boys")
                {
                    Console.WriteLine($"Judo {quantityStudents * 9.6 * 0.85 * quantityNights:F2} lv.");
                }
                else if (typeGroup == "girls")
                {
                    Console.WriteLine($"Gymnastics {quantityStudents * 9.6 * 0.85 * quantityNights:F2} lv.");
                }
                else if (typeGroup == "mixed")
                {
                    Console.WriteLine($"Ski {quantityStudents * 10 * 0.85 * quantityNights:F2} lv.");
                }
            }
            else if (season == "Winter" && quantityStudents >= 10 && quantityStudents < 20)
            {
                if (typeGroup == "boys")
                {
                    Console.WriteLine($"Judo {quantityStudents * 9.6 * 0.95 * quantityNights:F2} lv.");
                }
                else if (typeGroup == "girls")
                {
                    Console.WriteLine($"Gymnastics {quantityStudents * 9.6 * 0.95 * quantityNights:F2} lv.");
                }
                else if (typeGroup == "mixed") 
                {
                    Console.WriteLine($"Ski {quantityStudents * 10 * 0.95 * quantityNights:F2} lv.");
                }
            }
            else if(season == "Winter" && quantityStudents <10)
            {
                if (typeGroup == "boys")
                {
                    Console.WriteLine($"Judo {quantityStudents * 9.6 * quantityNights:F2} lv.");
                }
                else if (typeGroup == "girls")
                {
                    Console.WriteLine($"Gymnastics {quantityStudents * 9.6 * quantityNights:F2} lv.");
                }
                else if (typeGroup == "mixed")
                {
                    Console.WriteLine($"Ski {quantityStudents * 10 * quantityNights:F2} lv.");
                }
            }


            if (season == "Spring" && quantityStudents >= 50)
            {
                if (typeGroup == "boys")
                {
                    Console.WriteLine($"Tennis {quantityStudents * 7.2 * 0.5 * quantityNights:F2} lv.");
                }
                else if (typeGroup == "girls")
                {
                    Console.WriteLine($"Athletics {quantityStudents * 7.2 * 0.5 * quantityNights:F2} lv.");
                }
                else if (typeGroup == "mixed")
                {
                    Console.WriteLine($"Cycling {quantityStudents * 9.5 * 0.5 * quantityNights:F2} lv.");
                }
            }
            else if (season == "Spring" && quantityStudents >= 20 && quantityStudents < 50)
            {
                if (typeGroup == "boys")
                {
                    Console.WriteLine($"Tennis {quantityStudents * 7.2 * 0.85 * quantityNights:F2} lv.");
                }
                else if (typeGroup == "girls")
                {
                    Console.WriteLine($"Athletics {quantityStudents * 7.2 * 0.85 * quantityNights:F2} lv.");
                }
                else if (typeGroup == "mixed")
                {
                    Console.WriteLine($"Cycling {quantityStudents * 9.5 * 0.85 * quantityNights:F2} lv.");
                }
            }
            else if (season == "Spring" && quantityStudents >= 10 && quantityStudents < 20)
            {
                if (typeGroup == "boys")
                {
                    Console.WriteLine($"Tennis {quantityStudents * 7.2 * 0.95 * quantityNights:F2} lv.");
                }
                else if (typeGroup == "girls")
                {
                    Console.WriteLine($"Athletics {quantityStudents * 7.2 * 0.95 * quantityNights:F2} lv.");
                }
                else if (typeGroup == "mixed")
                {
                    Console.WriteLine($"Cycling {quantityStudents * 9.5 * 0.95 * quantityNights:F2} lv.");
                }
            }
            else if(season == "Spring" && quantityStudents < 10)
            {
                if (typeGroup == "boys")
                {
                    Console.WriteLine($"Tennis {quantityStudents * 7.2 * quantityNights:F2} lv.");
                }
                else if (typeGroup == "girls")
                {
                    Console.WriteLine($"Athletics {quantityStudents * 7.2 * quantityNights:F2} lv.");
                }
                else if (typeGroup == "mixed")
                {
                    Console.WriteLine($"Cycling {quantityStudents * 9.5 * quantityNights:F2} lv.");
                }
            }


            if (season == "Summer" && quantityStudents >= 50)
            {
                if (typeGroup == "boys")
                {
                    Console.WriteLine($"Football {quantityStudents * 15 * 0.5 * quantityNights:F2} lv.");
                }
                else if (typeGroup == "girls")
                {
                    Console.WriteLine($"Volleyball {quantityStudents * 15 * 0.5 * quantityNights:F2} lv.");
                }
                else if (typeGroup == "mixed")
                {
                    Console.WriteLine($"Swimming {quantityStudents * 20 * 0.5 * quantityNights:F2} lv.");
                }
            }
            else if (season == "Summer" && quantityStudents >= 20 && quantityStudents < 50)
            {
                if (typeGroup == "boys")
                {
                    Console.WriteLine($"Football {quantityStudents * 15 * 0.85 * quantityNights:F2} lv.");
                }
                else if (typeGroup == "girls")
                {
                    Console.WriteLine($"Volleyball {quantityStudents * 15 * 0.85 * quantityNights:F2} lv.");
                }
                else if (typeGroup == "mixed")
                {
                    Console.WriteLine($"Swimming {quantityStudents * 20 * 0.85 * quantityNights:F2} lv.");
                }
            }
            else if (season == "Summer" && quantityStudents >= 10 && quantityStudents < 20)
            {
                if (typeGroup == "boys")
                {
                    Console.WriteLine($"Football {quantityStudents * 15 * 0.95 * quantityNights:F2} lv.");
                }
                else if (typeGroup == "girls")
                {
                    Console.WriteLine($"Volleyball {quantityStudents * 15 * 0.95 * quantityNights:F2} lv.");
                }
                else if (typeGroup == "mixed")
                {
                    Console.WriteLine($"Swimming {quantityStudents * 20 * 0.95 * quantityNights:F2} lv.");
                }
            }
            else if(season == "Summer" && quantityStudents < 10)
            {
                if (typeGroup == "boys")
                {
                    Console.WriteLine($"Football {quantityStudents * 15 * quantityNights:F2} lv.");
                }
                else if (typeGroup == "girls")
                {
                    Console.WriteLine($"Volleyball {quantityStudents * 15 * quantityNights:F2} lv.");
                }
                else if (typeGroup == "mixed")
                {
                    Console.WriteLine($"Swimming {quantityStudents * 20 * quantityNights:F2} lv.");
                }
            }
        }
    }
}
