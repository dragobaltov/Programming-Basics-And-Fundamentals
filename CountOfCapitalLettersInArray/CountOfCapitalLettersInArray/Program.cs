using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOfCapitalLettersInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ');
            int counter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length == 1 && Convert.ToChar(array[i]) >= 65 && Convert.ToChar(array[i]) <= 90)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
