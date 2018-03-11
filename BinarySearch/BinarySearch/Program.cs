using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static int[] integers;
        static int searchedElement;

        static void Main(string[] args)
        {
            integers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            searchedElement = int.Parse(Console.ReadLine());

            FindingElement();

            int linearIterations = Linear();
            int binaryIterations = Binary();

            Console.WriteLine($"Linear search made {linearIterations} iterations");
            Console.WriteLine($"Binary search made {binaryIterations} iterations");
        }

        static void FindingElement()
        {
            bool searching = false;

            for (int i = 0; i < integers.Length; i++)
            {
                if (integers[i] == searchedElement)
                {
                    searching = true;
                    break;
                }
            }

            if (searching)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        static int Linear()
        {
            int iterations = 0;
            for (int i = 0; i < integers.Length; i++)
            {
                iterations++;
                if (integers[i] == searchedElement)
                    break;
            }

            return iterations;
        }

        static int Binary()
        {
            bool change = false;
            do
            {
                change = false;
                for (int i = 0; i < integers.Length - 1; i++)
                {
                    if (integers[i] > integers[i + 1])
                    {
                        int help = integers[i];
                        integers[i] = integers[i + 1];
                        integers[i + 1] = help;
                        change = true;
                    }
                }
            } while (change);


            int iterations = 1;

            int lowerBound = 0;
            int upperBound = integers.Length - 1;

            while (true)
            {

                if (lowerBound >= upperBound)
                {
                    break;
                }

                int midBound = lowerBound + (upperBound - lowerBound) / 2;

                if (integers[midBound] < searchedElement)
                {
                    lowerBound = midBound + 1;
                }
                else if(integers[midBound] > searchedElement)
                {
                    upperBound = midBound - 1;
                }
                else
                {
                    break;
                }
                iterations++;
            }

            return iterations;
        }
    }
}
