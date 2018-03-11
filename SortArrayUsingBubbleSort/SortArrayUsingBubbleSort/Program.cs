using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArrayUsingBubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            BubbleSort(array);
            Console.WriteLine(string.Join(" ", array));
        }

        static void BubbleSort(int[] array)
        {
            bool thereIsChange = false;

            do
            {
                thereIsChange = false;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int help = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = help;
                        thereIsChange = true;
                    }
                }
            } while (thereIsChange);
        }
    }
}
