using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyProfit2
{
    class Program
    {
        static void Main(string[] args)
        {
            int workDaysMonth = int.Parse(Console.ReadLine());
            double dailyProfitUSD = double.Parse(Console.ReadLine());
            double dollarRate = double.Parse(Console.ReadLine());
            double monthProfitUSD = workDaysMonth * dailyProfitUSD;
            double yearProfitUSD = (12 * monthProfitUSD + 2.5 * monthProfitUSD) * 0.75;
            double yearProfitBGN = yearProfitUSD * dollarRate;
            double avarageProfit = yearProfitBGN / 365;

            Console.WriteLine($"{avarageProfit:F2}");
        }
    }
}
