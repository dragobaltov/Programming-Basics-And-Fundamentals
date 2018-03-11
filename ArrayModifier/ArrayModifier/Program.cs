using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayModifier
{
    class Program
    {
        public static long[] array;

        static void Main(string[] args)
        {
            array = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            string input = Console.ReadLine();

            while (!input.Equals("end"))
            {
                string[] tokens = input.Split(' ');
                string command = tokens[0];

                if (command == "swap")
                {
                    int index1 = int.Parse(tokens[1]);
                    int index2 = int.Parse(tokens[2]);

                    Swap(index1, index2);
                }
                else if (command == "multiply")
                {
                    int index1 = int.Parse(tokens[1]);
                    int index2 = int.Parse(tokens[2]);

                    Multiply(index1, index2);
                }
                else
                {
                    Decrease();
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", array));
        }
       
        static void Swap(int index1, int index2)
        {
            if (index1 >= 0 && index1 < array.Length && index2 >= 0 && index2 < array.Length)
            {
                long copyOfFirstElement = array[index1];
                array[index1] = array[index2];
                array[index2] = copyOfFirstElement;
            }
        }

        static void Multiply(int index1, int index2)
        {
            if (index1 >= 0 && index1 < array.Length && index2 >= 0 && index2 < array.Length)
            {
                array[index1] *= array[index2];
            }
        }

        private static void Decrease()
        {
            array = array.Select(x => x - 1).ToArray();
        }
    }
}
