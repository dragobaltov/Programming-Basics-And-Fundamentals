using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckDriver2
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kmMonth = double.Parse(Console.ReadLine());
            double moneyMade = 4;

            if (kmMonth <= 5000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    moneyMade *= kmMonth * 0.75;
                }
                else if (season == "Summer")
                {
                    moneyMade *= kmMonth * 0.9;
                }
                else
                {
                    moneyMade *= kmMonth * 1.05;
                }
            }
            else if (kmMonth <= 10000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    moneyMade *= kmMonth * 0.95;
                }
                else if (season == "Summer")
                {
                    moneyMade *= kmMonth * 1.1;
                }
                else
                {
                    moneyMade *= kmMonth * 1.25;
                }
            }
            else if (kmMonth <= 20000)
            {
                    moneyMade *= kmMonth * 1.45;
            }

            Console.WriteLine($"{moneyMade * 0.9:F2}");
        }
    }
}
