using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());

            if (operation == '+')
            {
                if ((num1 + num2) % 2 == 0)
                {
                    Console.WriteLine($"{num1} + {num2} = {num1 + num2} - even");
                }
                else
                {
                    Console.WriteLine($"{num1} + {num2} = {num1 + num2} - odd");
                }
            }
            else if (operation == '-')
            {
                if ((num1 - num2) % 2 == 0)
                {
                    Console.WriteLine($"{num1} - {num2} = {num1 - num2} - even");
                }
                else
                {
                    Console.WriteLine($"{num1} - {num2} = {num1 - num2} - odd");
                }
            }
            else if (operation == '*')
            {
                if ((num1 * num2) % 2 == 0)
                {
                    Console.WriteLine($"{num1} * {num2} = {num1 * num2} - even");
                }
                else
                {
                    Console.WriteLine($"{num1} * {num2} = {num1 * num2} - odd");
                }
            }
            else if (operation == '/')
            {
                if (num2 == 0)
                {
                    Console.WriteLine($"Cannot divide {num1} by zero");
                }
                else
                {
                    Console.WriteLine($"{num1} / {num2} = {num1 * 1.0 / num2:F2}");
                }
            }
            else if (operation == '%')
            {
                if (num2 == 0)
                {
                    Console.WriteLine($"Cannot divide {num1} by zero");
                }
                else
                {
                    Console.WriteLine($"{num1} % {num2} = {num1 % num2}");
                }
            }
        }
    }
}
