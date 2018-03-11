using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayData
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            double average = list.Average();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < average)
                {
                    list.RemoveAt(i);
                    i--;
                }
            }

            string command = Console.ReadLine();

            if (command == "Max")
            {
                Console.WriteLine(list.Max());
            }
            else if (command == "Min")
            {
                Console.WriteLine(list.Min());
            }
            else
            {
                Console.WriteLine(string.Join(" ", list.OrderBy(x => x)));
            }
        }
    }
}
