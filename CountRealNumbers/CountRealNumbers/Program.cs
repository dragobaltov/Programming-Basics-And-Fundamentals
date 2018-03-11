using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            SortedDictionary<double, int> count = new SortedDictionary<double, int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (count.ContainsKey(array[i]))
                {
                    count[array[i]]++;
                }
                else
                {
                    count.Add(array[i], 1);
                }
            }

            foreach (var item in count)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
