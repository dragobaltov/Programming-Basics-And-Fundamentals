using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            var number1 = int.Parse(Console.ReadLine());
            Console.Write("Enter another number: ");
            var number2 = int.Parse(Console.ReadLine());

            if(number1 > number2)
            {
                Console.WriteLine($"{number1} is bigger");
            }
            else
            {
                Console.WriteLine($"{number2} is bigger");
            }
        }
    }
}
