using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainersSalary
{
    class Program
    {
        static void Main(string[] args)
        {
            int lections = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double payment = budget / lections;
            double jelevSalary = 0.0;
            double royalSalary = 0.0;
            double roliSalary = 0.0;
            double trofonSalary = 0.0;
            double sinoSalary = 0.0;
            double othersSalary = 0.0;

            for (int i = 1; i <= lections; i++)
            {
                string trainerName = Console.ReadLine();
                if (trainerName == "Jelev")
                {
                    jelevSalary += payment;
                }
                else if (trainerName == "RoYaL")
                {
                    royalSalary += payment;
                }
                else if (trainerName == "Roli")
                {
                    roliSalary += payment;
                }
                else if (trainerName == "Trofon")
                {
                    trofonSalary += payment;
                }
                else if (trainerName == "Sino")
                {
                    sinoSalary += payment;
                }
                else
                {
                    othersSalary += payment;
                }
            }

            Console.WriteLine($"Jelev salary: {jelevSalary:F2} lv");
            Console.WriteLine($"RoYaL salary: {royalSalary:F2} lv");
            Console.WriteLine($"Roli salary: {roliSalary:F2} lv");
            Console.WriteLine($"Trofon salary: {trofonSalary:F2} lv");
            Console.WriteLine($"Sino salary: {sinoSalary:F2} lv");
            Console.WriteLine($"Others salary: {othersSalary:F2} lv");
        }
    }
}
