using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleverLili
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMashinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            double moneyFromOneBirthday = 0.0;
            double moneyGift = 0.0;
            double moneyFromToys = 0.0;
            double moneyLeft = 0.0;
            for (int i = 2; i <= age; i+=2)
            {
                moneyFromOneBirthday += 10.0;
                moneyGift += moneyFromOneBirthday;
            }
            if (age % 2 == 0)
            {
                moneyFromToys = (age / 2) * toyPrice;
                moneyLeft = moneyGift - (age / 2);
            }
            else
            {
                moneyFromToys = Math.Ceiling(age * 1.0 / 2) * toyPrice;
                moneyLeft = moneyGift - Math.Floor(age * 1.0 / 2);
            }
            if ((moneyLeft + moneyFromToys) >= washingMashinePrice)
            {
                Console.WriteLine($"Yes! {(moneyLeft + moneyFromToys) - washingMashinePrice:F2}");
            }
            else
            {
                Console.WriteLine($"No! {washingMashinePrice - (moneyLeft + moneyFromToys):F2}");
            }
        }
    }
}
