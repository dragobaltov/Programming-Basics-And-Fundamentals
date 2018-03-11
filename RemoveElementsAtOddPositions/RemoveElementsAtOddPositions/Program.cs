using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveElementsAtOddPositions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(' ').ToList();
            List<string> newList = new List<string>();

            for (int i = 0; i < list.Count; i++)
            {
                if (i % 2 == 1)
                {
                    newList.Add(list[i]);
                }
            }

            Console.WriteLine(string.Join("", newList));
        }
    }
}
