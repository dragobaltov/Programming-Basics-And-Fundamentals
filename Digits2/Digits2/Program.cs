using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digits2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int thirdDigit = n % 10;
            int secondDigit = ((n % 100) - thirdDigit) / 10;
            int firstDigit = (n - (n % 100)) / 100;

            for (int rows = 1; rows <= firstDigit + secondDigit ; rows++)
            {
                for (int cols = 1; cols <= firstDigit + thirdDigit; cols++)
                {
                    if (n % 5 == 0)
                    {
                        n -= firstDigit;
                    }
                    else if (n % 3 == 0)
                    {
                        n -= secondDigit;
                    }
                    else
                    {
                        n += thirdDigit;
                    }
                    Console.Write($"{n} ");
                }
                Console.WriteLine();
            }
        }
    }
}
