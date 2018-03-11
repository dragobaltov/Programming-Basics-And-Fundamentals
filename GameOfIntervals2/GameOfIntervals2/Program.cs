using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfIntervals2
{
    class Program
    {
        static void Main(string[] args)
        {
            int moves = int.Parse(Console.ReadLine());
            double result = 0.0;
            int counter0 = 0;
            int counter1 = 0;
            int counter2 = 0;
            int counter3 = 0;
            int counter4 = 0;
            int counterInvalid = 0;

            for (int i = 1; i <= moves; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num >= 0 && num <= 9)
                {
                    counter0++;
                    result += 0.2 * num;
                }
                else if (num >= 10 && num <= 19)
                {
                    counter1++;
                    result += 0.3 * num;
                }
                else if (num >= 20 && num <= 29)
                {
                    counter2++;
                    result += 0.4 * num;
                }
                else if (num >= 30 && num <= 39)
                {
                    counter3++;
                    result += 50;
                }
                else if (num >= 40 && num <= 50)
                {
                    counter4++;
                    result += 100;
                }
                else
                {
                    counterInvalid++;
                    result /= 2;
                }
            }

            Console.WriteLine($"{result:F2}");
            Console.WriteLine($"From 0 to 9: {counter0 * 1.0 / moves * 100:F2}%");
            Console.WriteLine($"From 10 to 19: {counter1 * 1.0 / moves * 100:F2}%");
            Console.WriteLine($"From 20 to 29: {counter2 * 1.0 / moves * 100:F2}%");
            Console.WriteLine($"From 30 to 39: {counter3 * 1.0 / moves * 100:F2}%");
            Console.WriteLine($"From 40 to 50: {counter4 * 1.0 / moves * 100:F2}%");
            Console.WriteLine($"Invalid numbers: {counterInvalid * 1.0 / moves * 100:F2}%");
        }
    }
}
