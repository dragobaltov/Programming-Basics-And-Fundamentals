using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance2
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstSpeed = int.Parse(Console.ReadLine());
            int firstTimeMin = int.Parse(Console.ReadLine());
            int secondTimeMin = int.Parse(Console.ReadLine());
            int thirdTimeMin = int.Parse(Console.ReadLine());
            double firstTimeH = firstTimeMin * 1.0 / 60;
            double secondTimeH = secondTimeMin * 1.0 / 60;
            double thirdTimeH = thirdTimeMin * 1.0 / 60;
            double secondSpeed = firstSpeed * 1.1;
            double thirdSpeed = secondSpeed * 0.95;
            double firstDistance = firstSpeed * firstTimeH;
            double secondDistance = secondSpeed * secondTimeH;
            double thirdDistance = thirdSpeed * thirdTimeH;

            Console.WriteLine($"{firstDistance + secondDistance + thirdDistance:F2}");

        }
    }
}
