using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipListSides
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> copyList = new List<int>();
            int j = list.Count - 1;

            CreatingCopyList(list, copyList);

            for (int i = 0; i < list.Count; i++)
            {
                if (i != 0 && i != list.Count - 1)
                {
                    list[i] = copyList[Math.Abs(j)];
                }
                j--;
            }
            
            Console.WriteLine(string.Join(" ", list));
        }

        static void CreatingCopyList(List<int> list, List<int> copyList)
        {
            for (int i = 0; i < list.Count; i++)
            {
                copyList.Add(list[i]);
            }
        }
    }
}
