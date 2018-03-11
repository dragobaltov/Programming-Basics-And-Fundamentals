using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestNElements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> array = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());
            int[] resultArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                int maxElement = int.MinValue;
                for (int j = 0; j < array.Count; j++)
                {
                    if (array[j] > maxElement)
                    {
                        maxElement = array[j];
                    }
                }
                resultArray[i] = maxElement;
                RemovingElements(array, maxElement);
            }

            Console.WriteLine(string.Join(" ", resultArray));
        }

        static void RemovingElements(List<int> array, int maxElement)
        {
            for (int i = 0; i < array.Count; i++)
            {
                if (array[i] == maxElement)
                {
                    array.RemoveAt(i);
                }
            }
        }
    }
}
