using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumbers2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    for (int k = 1; k <= 9; k++)
                    {
                        for (int l = 1; l <= 9; l++)
                        {
                            if (n % i == 0 && n % j == 0 && n % k == 0 && n % l == 0)
                            {
                                Console.Write($"{Convert.ToString(i)}{Convert.ToString(j)}{Convert.ToString(k)}{Convert.ToString(l)} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
