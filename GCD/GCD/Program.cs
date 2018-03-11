using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCD
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int gcd = 0;

            if (a > b)
            {
                for (int i = 1; i <= b; i++)
                {
                    if (a % i == 0 && b % i == 0)
                    {
                        gcd = i;
                    }
                }
            }
            else
            {
                for (int i = 1; i <= a; i++)
                {
                    if (a % i == 0 && b % i == 0)
                    {
                        gcd = i;
                    }
                }
            }
            Console.WriteLine(gcd);
        }
    }
}
