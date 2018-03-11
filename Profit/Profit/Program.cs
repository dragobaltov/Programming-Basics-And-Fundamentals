using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int workingDays = int.Parse(Console.ReadLine());
            double moneyForDay = double.Parse(Console.ReadLine());
            double USDtoLeva = double.Parse(Console.ReadLine());
            double monthSalary = workingDays * moneyForDay;
            double profitYear = monthSalary * 12 + monthSalary * 2.5;
            double profitYearInLeva = profitYear * USDtoLeva;

            Console.WriteLine($"{(profitYearInLeva * 0.75) / 365:F2}");
        }
    }
}
