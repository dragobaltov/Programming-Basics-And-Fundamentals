using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftAndRightSum2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double rightSum = 0.0;
            double leftSum = 0.0;

            for (int i = 0; i < 2 * n; i++)
            {
                double number = double.Parse(Console.ReadLine());
                rightSum += number;
            }
            for (int i = 0; i < 2 * n; i++)
            {
                double number = double.Parse(Console.ReadLine());
                leftSum += number;
            }
            if (rightSum == leftSum)
            {
                Console.WriteLine($"Yes, sum = {rightSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(leftSum - rightSum)}");
            }
        }
    }
}
