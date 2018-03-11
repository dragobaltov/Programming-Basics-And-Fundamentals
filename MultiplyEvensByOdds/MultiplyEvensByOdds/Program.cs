using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(OddSum(number) * EvenSum(number));
        }

        static int OddSum(int number)
        {
            int oddSum = 0;
            int currentNum = 0;

            while (number != 0)
            {
                currentNum = number % 10;

                if (currentNum % 2 == 1 || currentNum % 2 == -1)
                {
                    oddSum += currentNum;
                }

                number /= 10;
            }

            return oddSum;
        }

        static int EvenSum(int number)
        {
            int evenSum = 0;
            int currentNum = 0;

            while (number != 0)
            {
                currentNum = number % 10;

                if (currentNum % 2 == 0)
                {
                    evenSum += currentNum;
                }

                number /= 10;
            }

            return evenSum;
        }
    }
}
