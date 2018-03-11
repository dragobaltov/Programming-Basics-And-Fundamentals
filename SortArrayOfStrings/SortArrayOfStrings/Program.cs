using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ').ToArray();

            BubbleSort(array);

            Console.WriteLine(string.Join(" ", array));
        }

        static void BubbleSort(string[] array)
        {
            bool change = false;
            do
            {
                change = false;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i].CompareTo(array[i + 1]) > 0)
                    {
                        string helpElement = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = helpElement;
                        change = true;
                    }
                }
            } while (change);
            
        }
    }
}
