using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int beginning = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int counterCombinations = 0;
            bool equal = false;

            for (int i = beginning; i <= end; i++)
            {
                for (int j = beginning; j <= end; j++)
                {
                    counterCombinations++;
                    if ((i + j) == magicNum)
                    {
                        equal = true;
                        Console.Write($"Combination N:{counterCombinations} ");
                        if (i <= j)
                        {
                          Console.Write($"({i} + {j} = {magicNum})");
                        }
                        else
                        {
                            Console.Write($"({j} + {i} = {magicNum})");
                        }
                    }
                    if (equal == true)
                        break;
                }
                if (equal == true)
                    break;
            }
            if (equal == false)
            {
                Console.WriteLine($"{counterCombinations} combinations - neither equals {magicNum}");
            }
        }
    }
}
