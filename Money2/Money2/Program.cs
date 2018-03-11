using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money2
{
    class Program
    {
        static void Main(string[] args)
        {
            //• 1 биткойн = 1168 лева.
            //• 1 китайски юан = 0.15 долара.
            //• 1 долар = 1.76 лева.
            //• 1 евро = 1.95 лева.
            int bitcoins = int.Parse(Console.ReadLine());
            double chineseMoney = double.Parse(Console.ReadLine());
            double commission = double.Parse(Console.ReadLine());
            int bitcoinsInLV = bitcoins * 1168;
            double chineseMoneyInLV = chineseMoney * 0.15 * 1.76;
            double moneyEUR = (bitcoinsInLV + chineseMoneyInLV) / 1.95;
            double money = moneyEUR - commission / 100 * moneyEUR;

            Console.WriteLine($"{money:F2}");

        }
    }
}
