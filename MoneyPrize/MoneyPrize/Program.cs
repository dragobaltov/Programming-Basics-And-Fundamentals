using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyPrize
{
    class Program
    {
        static void Main(string[] args)
        {
            int parts = int.Parse(Console.ReadLine());
            double moneyForPoint = double.Parse(Console.ReadLine());
            double prize = 0.0;

            for (int i = 1; i <= parts; i++)
            {
                int points = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    prize += (2 * points * moneyForPoint);
                }
                else
                {
                    prize += (points * moneyForPoint);
                }
            }

            Console.WriteLine($"The project prize was {prize:F2} lv.");
        }
    }
}
