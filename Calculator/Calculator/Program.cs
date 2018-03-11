using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            char sign = char.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            switch (sign)
            {
                case '+':
                    Console.WriteLine($"{num1} {sign} {num2} = {num1 + num2}");
                    break;
                case '-':
                    Console.WriteLine($"{num1} {sign} {num2} = {num1 - num2}");
                    break;
                case '*':
                    Console.WriteLine($"{num1} {sign} {num2} = {num1 * num2}");
                    break;
                case '/':
                    Console.WriteLine($"{num1} {sign} {num2} = {num1 / num2}");
                    break;
                default:
                    break;
            }
        }
    }
}
