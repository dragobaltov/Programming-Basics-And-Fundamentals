using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayModifier2
{
    class Program
    {
        public static List<long> numbers;

        static void Main(string[] args)
        {
            numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            string input = Console.ReadLine();

            while (!input.Equals("end"))
            {
                string[] tokens = input.Split(' ');
                string command = tokens[0];

                if (command == "swap")
                {
                    int firstIndex = int.Parse(tokens[1]);
                    int secondIndex = int.Parse(tokens[2]);

                    Swap(firstIndex, secondIndex);
                }
                else if(command == "multiply")
                {
                    int firstIndex = int.Parse(tokens[1]);
                    int secondIndex = int.Parse(tokens[2]);

                    Multiply(firstIndex, secondIndex);
                }
                else
                {
                    Decrease();
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", numbers));
        }

        static void Swap(int firstIndex, int secondIndex)
        {
            long copyOfFirstElement = numbers[firstIndex];
            numbers[firstIndex] = numbers[secondIndex];
            numbers[secondIndex] = copyOfFirstElement;
        }

        static void Multiply(int firstIndex, int secondIndex)
        {
            numbers[firstIndex] *= numbers[secondIndex];
        }

        static void Decrease()
        {
            numbers = numbers.Select(n => n - 1).ToList();
        }
    }
}
