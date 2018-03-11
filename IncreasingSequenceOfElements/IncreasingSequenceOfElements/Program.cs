using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreasingSequenceOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] textArr = Console.ReadLine().Split(' ');
            int[] array = new int[textArr.Length];
            bool sequence = true;
            int previousElement = int.MinValue;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(textArr[i]);

                if (array[i] < previousElement)
                {
                    sequence = false;
                }

                previousElement = array[i];
            }

            if (sequence == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
