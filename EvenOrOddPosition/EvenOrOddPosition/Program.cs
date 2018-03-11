using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOrOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double oddSum = 0.0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            double evenSum = 0.0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;

            for (int i = 1; i < n; i++)
            {
                double number = double.Parse(Console.ReadLine());

                if(i % 2 == 1)
                {
                    oddSum += number;
                    if(oddMin > number)
                    {
                        oddMin = number;
                    }
                    if(oddMax < number)
                    {
                        oddMax = number;
                    }
                }
                else
                {
                    evenSum += number;
                    if (evenMin > number)
                    {
                        evenMin = number;
                    }
                    if (evenMax < number)
                    {
                        evenMax = number;
                    }
                }
            }

            Console.WriteLine($"OddSum={oddSum}");
            
        }
    }
}
