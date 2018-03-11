using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNegativeAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int count = 0;

            list.Reverse();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > 0)
                {
                    Console.Write(list[i] + " ");
                    count++;
                }
            }

            if (count == 0)
            {
                Console.WriteLine("empty");
            }
        }
    }
}
