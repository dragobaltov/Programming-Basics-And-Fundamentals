using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSumAfterExtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> list2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < list1.Count; i++)
            {
                RemoveElementsFromList2(list1, list2, i);
            }

            if (SumLists(list1) == SumLists(list2))
            {
                Console.WriteLine($"Yes. Sum: {SumLists(list1)}");
            }
            else
            {
                Console.WriteLine($"No. Diff: {Math.Abs(SumLists(list1) - SumLists(list2))}");
            }
        }

        static void RemoveElementsFromList2(List<int> list1, List<int> list2, int i)
        {
            for (int j = 0; j < list2.Count; j++)
            {
                if (list1[i] == list2[j])
                    list2.RemoveAt(j);
            }
        }

        static int SumLists(List<int> list)
        {
            int sum = 0;

            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }

            return sum;
        }

    }
}
