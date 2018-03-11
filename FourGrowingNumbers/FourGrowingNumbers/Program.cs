using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourGrowingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a + 3 <= b)
            {
                for (int i = a; i <= b - 3; i++)
                {
                    for (int j = a + 1; j <= b - 2; j++)
                    {
                        for (int k = a + 2; k <= b - 1; k++)
                        {
                            for (int l = a + 3; l <= b; l++)
                            {
                                if (i < j && j < k && k < l)
                                {
                                    Console.WriteLine($"{i} {j} {k} {l}");
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("No");
            }
            
        }
    }
}
