using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArrayUsingInsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            InsertionSort(array);

            Console.WriteLine(string.Join(" ", array));
        }

        static void InsertionSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (array[j] < array[j - 1])
                    {
                        int help = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = help;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}
