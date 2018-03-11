using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayElementsEqualToTheirIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] textArr = Console.ReadLine().Split(' ');
            int[] array = new int[textArr.Length];
            string equalElements = String.Empty;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(textArr[i]);

                if (array[i] == i)
                {
                    equalElements += i + " ";
                }
            }

            Console.WriteLine(equalElements);
        }
    }
}
