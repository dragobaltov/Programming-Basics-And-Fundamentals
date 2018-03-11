using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOfOddNumbersInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] textArray = text.Split(' ');
            int[] array = new int[textArray.Length];
            int oddCounter = 0;

            CountOfOddNumbers(array, textArray, oddCounter);
        }

        static void CountOfOddNumbers(int[] array,string[] textArray ,int oddCounter)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(textArray[i]);

                if (array[i] % 2 == 1 || array[i] % 2 == -1)
                {
                    oddCounter++;
                }
            }

            Console.WriteLine(oddCounter);
        }
    }
}
