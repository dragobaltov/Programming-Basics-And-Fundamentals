using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spyfer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNum = numbers[i];
                int sumOfNeghbours;

                if (i == 0 && numbers.Count > 1)
                {
                    sumOfNeghbours = numbers[1];

                    if (currentNum == sumOfNeghbours)
                    {
                        numbers.RemoveAt(1);
                        i = 0;
                    }
                }
                else if (i == numbers.Count - 1 && numbers.Count > 1)
                {
                    sumOfNeghbours = numbers[i - 1];

                    if (currentNum == sumOfNeghbours)
                    {
                        numbers.RemoveAt(i - 1);
                        i = 0;
                    }
                }
                else
                {
                    sumOfNeghbours = numbers[i - 1] + numbers[i + 1];

                    if (currentNum == sumOfNeghbours)
                    {
                        numbers.RemoveAt(i - 1);
                        numbers.RemoveAt(i);
                        i = 0;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
