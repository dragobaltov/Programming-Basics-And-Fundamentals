using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSequenceOfElementsInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] textArr = Console.ReadLine().Split(' ');
            int[] array = new int[textArr.Length];
            bool equality = true;
            int previousElement = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(textArr[i]);

                if (array[i] != previousElement && i != 0)
                {
                    equality = false;
                }

                previousElement = array[i];
            }

            if (equality == true)
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
