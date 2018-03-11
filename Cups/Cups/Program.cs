using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cups
{
    class Program
    {
        static void Main(string[] args)
        {
            int quntityCupsNeeded = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int workDays = int.Parse(Console.ReadLine());
            int cupsMade = (workDays * 8 * workers) / 5;
            double moneyNeeded = quntityCupsNeeded * 4.2;
            double moneyMade = cupsMade * 4.2;

            if (cupsMade >= quntityCupsNeeded)
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
