using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNumbersAtOddPositions
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] textArray = text.Split(' ');
            int[] array = new int[textArray.Length];

            CountOfOddNUmbers(textArray, array);
        }

        static void CountOfOddNUmbers(string[] textArray, int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(textArray[i]);

                if (i % 2 == 1)
                {
                    if (array[i] % 2 == 1 || array[i] % 2 == -1)
                    {
                        Console.WriteLine($"Index {i} -> {array[i]}");
                    }
                }
            }
        }
    }
}
