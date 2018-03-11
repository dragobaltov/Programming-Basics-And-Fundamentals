using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToThePast2
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyInherited = double.Parse(Console.ReadLine());
            int yearToLive = int.Parse(Console.ReadLine());
            int moneyNeeded = 0;

            for (int i = 1800; i <= yearToLive; i++)
            {
                if (i % 2 == 0)
                {
                    moneyNeeded += 12000;
                }
                else
                {
                    moneyNeeded += 12000 + 50 * (18 + i - 1800);
                }
            }

            if (moneyInherited >= moneyNeeded)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {moneyInherited - moneyNeeded:F2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {moneyNeeded - moneyInherited:F2} dollars to survive.");
            }
        }
    }
}
