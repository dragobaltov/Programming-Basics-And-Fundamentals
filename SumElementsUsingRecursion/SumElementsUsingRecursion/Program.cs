using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumElementsUsingRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(SumElements(array, n - 1));
        }

        public static int SumElements(int[] array, int i)
        {
            if (i == 0)
                return array[0];
            else
                return SumElements(array, i - 1) + array[i];
        }
    }
}
