using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestElementInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string elements = Console.ReadLine();
            string[] separated = elements.Split(' ');
            int[] array = new int[separated.Length];
            int minNumber = int.MaxValue;

            MinElement(elements, separated, array, minNumber);
        }

        static void MinElement(string element, string[] separated, int[] array, int minNumber)
        {
            minNumber = int.MaxValue;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(separated[i]);
                if (array[i] < minNumber)
                {
                    minNumber = array[i];
                }
            }

            Console.WriteLine(minNumber);
        }
    }
}
