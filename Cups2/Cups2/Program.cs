﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cups2
{
    class Program
    {
        static void Main(string[] args)
        {
            int cupsNeeded = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int workDays = int.Parse(Console.ReadLine());
            double moneyNeeded = cupsNeeded * 4.2;
            double hoursNeeded = cupsNeeded * 5;
            double hoursMade = workDays * workers * 8;
            double cupsMade = Math.Floor(hoursMade / 5);
            double moneyMade = cupsMade * 4.2;

            if (moneyMade >= moneyNeeded)
            {
                Console.WriteLine($"{moneyMade - moneyNeeded:F2} extra money");
            }
            else
            {
                Console.WriteLine($"Losses: {moneyNeeded - moneyMade:F2}");
            }
        }
    }
}
