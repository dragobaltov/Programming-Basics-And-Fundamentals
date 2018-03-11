using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 9; i++)
            {
                if (n % i == 0)
                {
                    for (int j = 1; j <= 9; j++)
                    {
                        if (n % j == 0)
                        {
                            for (int k = 1; k <= 9; k++)
                            {
                                if (n % k == 0)
                                {
                                    for (int l = 1; l <= 9; l++)
                                    {
                                        if (n % l == 0)
                                        {
                                            Console.Write($"{i}{j}{k}{l} ");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
