using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistinctList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> newList = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                if (!newList.Contains(list[i]))
                {
                    newList.Add(list[i]);
                }
            }

            Console.WriteLine(string.Join(" ", newList));
        }
    }
}
