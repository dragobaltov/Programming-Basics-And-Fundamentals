using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySymetry2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ');
            int counter = 0;

            for (int i = 0; i <= (array.Length - 1) / 2; i++)
            {
                if(array[i] != array[(array.Length - 1) - i])
                {
                    counter++;
                }
            }

            if (counter == 0)
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
