using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double result = 0.0;

            if (number <= 100)
            {
                result = number + 5;
                if(number % 2 ==0)
                {
                    result += 1;
                    Console.WriteLine(6);
                }
                else if(number % 10 == 5)
                {
                    result += 2;
                    Console.WriteLine(7);
                }
                else
                {
                    Console.WriteLine(5);
                }
            }
            else if (number > 1000)
            {
                result = number * 1.1;
                if (number % 2 == 0)
                {
                    result += 1;
                    Console.WriteLine(1 + number * 0.1);
                }
                else if (number % 10 == 5)
                {
                    result += 2;
                    Console.WriteLine(2 + number * 0.1);
                }
                else
                {
                    Console.WriteLine(number * 0.1);
                }
            }
            else if (number > 100)
            {
                result = number * 1.2;
                if (number % 2 == 0)
                {
                    result += 1;
                    Console.WriteLine(1 + number * 0.2);
                }
                else if (number % 10 == 5)
                {
                    result += 2;
                    Console.WriteLine(2 + number * 0.2);
                }
                else
                {
                    Console.WriteLine(number * 0.2);
                }
            }
            Console.WriteLine(result);
        }
    }
}
