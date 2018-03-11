using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int yearsInThePast = year - 1799;
            double moneyForEvenYears = 0.0;
            double moneyForOddYears = 0.0;
            for (int i = 1800; i <= year; i++)
            {
                if (i % 2 == 0)
                {
                    moneyForEvenYears += 12000;
                }
                else
                {
                    moneyForOddYears += 12000 + 50 * (18 + i - 1800);
                }
            }
            if ((moneyForEvenYears + moneyForOddYears) <= money)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {money - (moneyForEvenYears + moneyForOddYears):F2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {(moneyForEvenYears + moneyForOddYears) - money:F2} dollars to survive.");
            }
        }
    }
}
