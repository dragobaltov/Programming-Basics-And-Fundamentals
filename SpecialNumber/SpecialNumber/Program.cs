using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int num = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"{i} -> ");
                num = i;
                while (num != 0)
                {
                    sum += num % 10;
                    num /= 10;
                }
            
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.Write("True");
                }
                else
                {
                    Console.Write("False");
                }
                Console.WriteLine();
                sum = 0;
            }

        }
    }
}
