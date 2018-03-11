using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOccurrencesOfLargerNumberInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] textArr = Console.ReadLine().Split(' ');
            double p = double.Parse(Console.ReadLine());
            double[] array = new double[textArr.Length];
            int counter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = double.Parse(textArr[i]);

                if (array[i] > p)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
