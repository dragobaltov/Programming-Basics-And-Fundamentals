using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double priceLightsaber = double.Parse(Console.ReadLine());
            double priceRobe = double.Parse(Console.ReadLine());
            double priceBelt = double.Parse(Console.ReadLine());

            double priceOfLightsabers = Math.Ceiling(students * 1.1) * priceLightsaber;
            double priceOfBelts = (students * priceBelt) - ((students / 6) * priceBelt);
            double priceOfRobes = students * priceRobe;
            double moneyNeeded = priceOfLightsabers + priceOfBelts + priceOfRobes;

            if (moneyNeeded <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {moneyNeeded:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {moneyNeeded - money:F2}lv more.");
            }
        }
    }
}
