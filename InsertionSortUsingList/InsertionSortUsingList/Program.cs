using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSortUsingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> resultList = InsertionSort(list);

            Console.WriteLine(string.Join(" ", resultList));
        }

        static List<int> InsertionSort(List<int> list)
        {
            List<int> resultList = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                bool isInserted = false;
                for (int j = 0; j < resultList.Count; j++)
                {
                    if (resultList[j] > list[i])
                    {
                        resultList.Insert(j, list[i]);
                        isInserted = true;
                        break;
                    }
                }

                if (!isInserted)
                {
                    resultList.Add(list[i]);
                }
            }

            return resultList;
        }
    }
}
