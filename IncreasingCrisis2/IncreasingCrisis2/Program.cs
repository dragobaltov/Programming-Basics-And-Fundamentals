using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreasingCrisis2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> sequence = new List<int>();

            for (int i = 0; i < n; i++)
            {
                InsertNumbers(sequence);
                RemoveNumbers(sequence);
            }

            Console.WriteLine(string.Join(" ", sequence));
        }

        static void RemoveNumbers(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    for (int removed = i + 1; removed < numbers.Count; removed++)
                    {
                        numbers.RemoveAt(removed);
                        removed--;
                    }
                }
            }
        }

        static void InsertNumbers(List<int> numbers)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            bool empty = numbers.Count == 0 || numbers[numbers.Count - 1] <= input[0];

            if (empty)
            {
                foreach (int item in input)
                {
                    numbers.Add(item);
                }
            }
            else
            {
                int start = Position(numbers, input);
                int end = start + input.Count;
                int index = 0;

                for (int position = start; position < end; position++)
                {
                    numbers.Insert(position, input[index]);
                    index++;

                    if (numbers[position] > numbers[position + 1])
                    {
                        break;
                    }
                }
            }
        }

        static int Position(List<int> numbers, List<int> input)
        {
            int start = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > input[0])
                {
                    start = i;
                    break;
                }
            }

            return start;
        }
    }
}
