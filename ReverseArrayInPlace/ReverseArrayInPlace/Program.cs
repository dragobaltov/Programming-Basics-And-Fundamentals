using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArrayInPlace
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rightIndex = array.Length - 1;

            for (int leftIndex = 0; leftIndex < array.Length / 2; leftIndex++)
            {
                int help = array[leftIndex];
                array[leftIndex] = array[rightIndex];
                array[rightIndex] = help;
                rightIndex--;
            }

            Console.WriteLine(string.Join(" ", array));
        }
    }
}
