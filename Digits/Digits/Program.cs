using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int firstDigit = n / 100;
            int secondDigit = (n / 10) % 10;
            int thirdDigit = n % 10;

            for (int row = 1; row <= firstDigit + secondDigit; row++)
            {
                for (int col = 1; col <= firstDigit + thirdDigit; col++)
                {
                    if (n % 5 == 0)
                    {
                        n -= firstDigit;
                        Console.Write($"{n} ");
                    }
                    else if (n % 3 == 0)
                    {
                        n -= secondDigit;
                        Console.Write($"{n} ");
                    }
                    else
                    {
                        n += thirdDigit;
                        Console.Write($"{n} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
