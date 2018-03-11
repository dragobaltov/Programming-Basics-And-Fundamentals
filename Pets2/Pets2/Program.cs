using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets2
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int foodLeftKG = int.Parse(Console.ReadLine());
            double dogFoodKgDay = double.Parse(Console.ReadLine());
            double catFoodKgDay = double.Parse(Console.ReadLine());
            double turtleFoodGrDay = double.Parse(Console.ReadLine());
            double turtleFoodKGDay = turtleFoodGrDay / 1000;
            double foodNeeded = (dogFoodKgDay + catFoodKgDay + turtleFoodKGDay) * days;

            if (foodLeftKG >= foodNeeded)
            {
                Console.WriteLine($"{Math.Floor(foodLeftKG - foodNeeded)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(foodNeeded - foodLeftKG)} more kilos of food are needed.");
            }
        }
    }
}
