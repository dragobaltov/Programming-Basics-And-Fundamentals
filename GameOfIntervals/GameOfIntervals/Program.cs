using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfIntervals
{
    class Program
    {
        static void Main(string[] args)
        {
            int moves = int.Parse(Console.ReadLine());
            double result = 0.0;
            double counter0 = 0.0;
            double counter1 = 0.0;
            double counter2 = 0.0;
            double counter3 = 0.0;
            double counter4 = 0.0;
            double counterInvalid = 0.0;

            for (int i = 1; i <= moves; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num >= 0 && num <= 9)
                {
                    result += 0.2 * num;
                    counter0++;
                }
                else if (num > 9 && num <= 19)
                {
                    result += 0.3 * num;
                    counter1++;
                }
                else if (num > 19 && num <= 29)
                {
                    result += 0.4 * num;
                    counter2++;
                }
                else if (num > 29 && num <= 39)
                {
                    result += 50;
                    counter3++;
                }
                else if (num > 39 && num <= 50)
                {
                    result += 100;
                    counter4++;
                }
                else
                {
                    result /= 2;
                    counterInvalid++;
                }
            }

            Console.WriteLine($"{result:F2}");
            Console.WriteLine($"From 0 to 9: {counter0 / moves * 100:F2}%");
            Console.WriteLine($"From 10 to 19: {counter1 / moves * 100:F2}%");
            Console.WriteLine($"From 20 to 29: {counter2 / moves * 100:F2}%");
            Console.WriteLine($"From 30 to 39: {counter3 / moves * 100:F2}%");
            Console.WriteLine($"From 40 to 50: {counter4 / moves * 100:F2}%");
            Console.WriteLine($"Invalid numbers: {counterInvalid / moves * 100:F2}%");
        }
    }
}
