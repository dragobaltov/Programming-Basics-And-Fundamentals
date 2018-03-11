using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectAddingMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 1; i < array.Length; i++)
            {
                int currentNumber = array[i];
                int index = i;

                while (index > 0 && array[index - 1] >= currentNumber)
                {
                    array[index] = array[index - 1];
                    index--;
                }
                array[index] = currentNumber;
            }

            Console.WriteLine(string.Join(" ", array));
        }
    }
}
