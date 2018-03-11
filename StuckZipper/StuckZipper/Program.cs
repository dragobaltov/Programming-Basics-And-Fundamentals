using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuckZipper
{
    class Program
    {
        static void Main(string[] args)
        {
            //-12 23 - 33 12
            //23 43 123 - 999
            List<int> firstList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int minLength = MinElement(firstList, secondList);
            List<int> firstNewList = new List<int>();
            List<int> secondNewList = new List<int>();

            for (int i = 0; i < firstList.Count; i++)
            {
                if (ElementLength(firstList[i]) == minLength)
                {
                    firstNewList.Add(firstList[i]);
                }
            }

            for (int i = 0; i < secondList.Count; i++)
            {
                if (ElementLength(secondList[i]) == minLength)
                {
                    secondNewList.Add(secondList[i]);
                }
            }

            int count = Math.Max(firstNewList.Count, secondNewList.Count);
            List<int> newList = new List<int>();

            for (int i = 0; i < count; i++)
            {
                if (i < secondNewList.Count)
                {
                    newList.Add(secondNewList[i]);
                }

                if (i < firstNewList.Count)
                {
                    newList.Add(firstNewList[i]);
                }
            }

            Console.WriteLine(string.Join(" ", newList));
        }

        static int MinElement(List<int> firstList, List<int> secondList)
        {
            int minElement = ElementLength(int.MaxValue);

            for (int i = 0; i < firstList.Count; i++)
            {
                if (ElementLength(firstList[i]) < minElement)
                {
                    minElement = ElementLength(firstList[i]);
                }
            }

            for (int i = 0; i < secondList.Count; i++)
            {
                if (ElementLength(secondList[i]) < minElement)
                {
                    minElement = ElementLength(secondList[i]);
                }
            }

            return minElement;
        }

        static int ElementLength(int element)
        {
            element = Math.Abs(element);
            int length = 0;
            while (element > 0)
            {
                length++;
                element /= 10;
            }

            return length;
        }
    }
}
