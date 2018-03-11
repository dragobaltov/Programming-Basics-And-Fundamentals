using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefractorSpecialNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int num = 0;
            bool result = false;

            for (int currentNum = 1; currentNum <= number; currentNum++)
            {
                num = currentNum;
                while (num > 0 )
                {
                    sum += num % 10;
                    num /= 10;
                }

                result = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{currentNum} -> {result}");
                sum = 0;
            }
        }
    }
}
