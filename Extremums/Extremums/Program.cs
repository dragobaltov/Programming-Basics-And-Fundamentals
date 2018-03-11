using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extremums
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            
            string command = Console.ReadLine();

            if (command == "Max")
            {
                GetMaxSum(numbers);
            }
            else
            {
                GetMinSum(numbers);
            }
        }

        static void GetMaxSum(List<int> numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                int initialNumber = numbers[i];
                List<char> list = numbers[i].ToString().ToList();
                for (int digit = 0; digit < list.Count; digit++)
                {
                    char first = list[0];
                    list.RemoveAt(0);
                    list.Add(first);

                    double multiplier = Math.Pow(10, (list.Count - 1));
                    double number = 0;
                    for (int j = 0; j < list.Count; j++)
                    {
                        double num = (list[j] - 48) * multiplier;
                        number += num;
                        multiplier /= 10;
                    }

                    if (number > initialNumber)
                    {
                        initialNumber = (int)number;
                    }
                }
                if (i != numbers.Count - 1)
                {
                    Console.Write($"{initialNumber}, ");
                }
                else
                {
                    Console.Write(initialNumber);
                }
                sum += initialNumber;
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }

        static void GetMinSum(List<int> numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                int initialNumber = numbers[i];
                List<char> list = numbers[i].ToString().ToList();
                for (int digit = 0; digit < list.Count; digit++)
                {
                    char first = list[0];
                    list.RemoveAt(0);
                    list.Add(first);

                    double multiplier = Math.Pow(10, (list.Count - 1));
                    double number = 0;
                    for (int j = 0; j < list.Count; j++)
                    {
                        double num = (list[j] - 48) * multiplier;
                        number += num;
                        multiplier /= 10;
                    }

                    if (number < initialNumber)
                    {
                        initialNumber = (int)number;
                    }
                }
                if (i != numbers.Count - 1)
                {
                    Console.Write($"{initialNumber}, ");
                }
                else
                {
                    Console.Write(initialNumber);
                }
                sum += initialNumber;
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
