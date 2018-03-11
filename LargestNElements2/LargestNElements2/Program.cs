using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestNElements2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());
            List<int> resultList = LargestNElements(list, n);

            Console.WriteLine(string.Join(" ", resultList));
        }

        static List<int> LargestNElements(List<int> list, int n)
        {
            List<int> resultList = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int maxElement = int.MinValue;
                int helpJ = 0;
                for (int j = 0; j < list.Count; j++)
                {
                    if (list[j] > maxElement)
                    {
                        maxElement = list[j];
                        helpJ = j;
                    }
                }
                resultList.Add(list[helpJ]);
                list[helpJ] = int.MinValue;
            }

            return resultList;
        }
    }
}
