using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySymetry
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ');

            if (NormalArray(array) == ReversedArray(array))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        static string NormalArray(string[] array)
        {
            string normalArray = string.Empty;

            for (int i = 0; i < array.Length; i++)
            {
                normalArray += array[i];
            }

            return normalArray;
        }

        static string ReversedArray(string[] array)
        {
            string reversedArray = String.Empty;

            for (int i = array.Length - 1; i >= 0; i--)
            {
                reversedArray += array[i];
            }

            return reversedArray;
        }
    }
}
