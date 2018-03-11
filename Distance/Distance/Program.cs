using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstSpeed = int.Parse(Console.ReadLine());
            int firstTimeMinutes = int.Parse(Console.ReadLine());
            int secondTimeMinutes = int.Parse(Console.ReadLine());
            int thirdTimeMinutes = int.Parse(Console.ReadLine());

            double firstDistance = firstSpeed * (firstTimeMinutes * 1.0 / 60);
            double secondDistance = (firstSpeed * 1.1) * (secondTimeMinutes * 1.0 / 60);
            double thirdDistance = ((firstSpeed * 1.1) * 0.95) * (thirdTimeMinutes * 1.0 / 60);
            Console.WriteLine($"{firstDistance + secondDistance + thirdDistance:F2}");
        }
    }
}
