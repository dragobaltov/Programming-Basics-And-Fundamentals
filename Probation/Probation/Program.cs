using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace SinoTheWalker2
{
    class Program
    {
        static void Main(string[] args)
        {
            int carsToPass = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            var queue = new Queue<string>();
            int passedCars = 0;

            while (!input.Equals("end"))
            {
                if (input == "green")
                {
                    int min = Math.Min(queue.Count, carsToPass);
                    passedCars += min;

                    for (int i = 0; i < min; i++)
                    {
                        Console.WriteLine(queue.Dequeue() + " passed!");
                    }
                }
                else
                {
                    queue.Enqueue(input);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"{passedCars} cars passed the road.");
        }
    }
}
