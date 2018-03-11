using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOfGivenElementInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] textArr = Console.ReadLine().Split(' ');
            int givenElement = int.Parse(Console.ReadLine());
            int[] array = new int[textArr.Length];
            int counter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(textArr[i]);

                if (array[i] == givenElement)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
