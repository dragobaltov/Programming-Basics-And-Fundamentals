using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalCompetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int dancers = int.Parse(Console.ReadLine());
            double points = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string place = Console.ReadLine();
            double moneyReceived = 0;

            if (place == "Bulgaria")
            {
                moneyReceived = dancers * points;
                if (season == "summer")
                {
                    moneyReceived *= 0.95;
                }
                else if (season == "winter")
                {
                    moneyReceived *= 0.92;
                }
            }
            else if (place == "Abroad")
            {
                moneyReceived = dancers * points * 1.5;
                if (season == "summer")
                {
                    moneyReceived *= 0.9;
                }
                else if (season == "winter")
                {
                    moneyReceived *= 0.85;
                }
            }

            double moneyCharity = moneyReceived * 0.75;
            moneyReceived *= 0.25;
            double moneyForADancer = moneyReceived / dancers;

            Console.WriteLine($"Charity - {moneyCharity:F2}");
            Console.WriteLine($"Money per dancer - {moneyForADancer:F2}");
        }
    }
}
