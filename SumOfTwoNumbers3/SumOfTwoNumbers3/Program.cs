using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfTwoNumbers3
{
    class Program
    {
        static void Main(string[] args)
        {
            int beginning = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int counterCombinations = 0;
            bool equal = false;

            for (int i = beginning; i <= end; i++)
            {
                for (int j = beginning; j <= end; j++)
                {
                    counterCombinations++;
                    if (i + j == magicNumber)
                    {
                        equal = true;
                        Console.WriteLine($"Combination N:{counterCombinations} ({i} + {j} = {magicNumber})");
                        break;
                    }
                    //if (equal == true)
                        break;
                }
                if (equal == true)
                    break;
            }

            if (equal == false)
            {
                Console.WriteLine($"{counterCombinations} combinations - neither equals {magicNumber}");
            }
        }
    }
}
