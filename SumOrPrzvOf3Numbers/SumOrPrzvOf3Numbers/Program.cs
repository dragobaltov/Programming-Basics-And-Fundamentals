using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOrPrzvOf3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int controlNumber = int.Parse(Console.ReadLine());
            bool no = true;

            for (int i = 1; i <= 30; i++)
            {
                for (int j = 1; j <= 30; j++)
                {
                    for (int k = 1; k <= 30; k++)
                    {
                        if (i + j + k == controlNumber)
                        {
                            if (i < j && j < k)
                            {
                                Console.WriteLine($"{i} + {j} + {k} = {controlNumber}");
                                no = false;
                            }
                        }
                        else if (i * j * k == controlNumber)
                        {
                            if (i > j && j > k)
                            {
                                Console.WriteLine($"{i} * {j} * {k} = {controlNumber}");
                                no = false;
                            }
                        }
                    }
                }
            }
            if (no == true)
            {
                Console.WriteLine("No!");
            }
        }
    }
}
