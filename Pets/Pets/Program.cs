using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int foodLeft = int.Parse(Console.ReadLine());
            double dogFood = double.Parse(Console.ReadLine());
            double catFood = double.Parse(Console.ReadLine());
            double turtleFood = double.Parse(Console.ReadLine());
            double foodNeeded = (dogFood + catFood + (turtleFood / 1000)) * days;
            if (foodNeeded > foodLeft)
            {
                Console.WriteLine($"{Math.Ceiling(foodNeeded - foodLeft)} more kilos of food are needed.");
            }
            else
            {
                Console.WriteLine($"{Math.Floor(foodLeft - foodNeeded)} kilos of food left.");
            }
        }
    }
}
