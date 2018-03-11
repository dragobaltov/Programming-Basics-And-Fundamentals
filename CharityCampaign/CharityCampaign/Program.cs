using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int quantityCakes = int.Parse(Console.ReadLine());
            int quantityGoffrets = int.Parse(Console.ReadLine());
            int quantityPancakes = int.Parse(Console.ReadLine());
            double moneyCakes = quantityCakes * 45;
            double moneyGoffrets = quantityGoffrets * 5.8;
            double moneyPancakes = quantityPancakes * 3.2;
            double moneyOneDay = (moneyCakes + moneyGoffrets + moneyPancakes) * workers;
            double money = moneyOneDay * days;
            Console.WriteLine($"{money * 7 / 8:F2}");

        }
    }
}
