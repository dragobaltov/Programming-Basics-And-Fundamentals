using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            Console.WriteLine(PowerOfANumber(number, power));
        }

        static double PowerOfANumber(double num, int power)
        {
            double sum = 1;
            for (int i = 0; i < power; i++)
            {
                sum *= num;
            }
            return sum;
        }
    }
}
