using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] innitialArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] secondRow = innitialArray.Skip(innitialArray.Length / 4)
                .Take(innitialArray.Length - 2 * (innitialArray.Length / 4)).ToArray();
            int[] firstPartOfFirstRow = innitialArray.Take(innitialArray.Length / 4).Reverse().ToArray();
            int[] secondPartOfFirstRow = innitialArray.Skip(3 * (innitialArray.Length / 4))
                .Take(innitialArray.Length / 4).Reverse().ToArray();
            int[] firstRow = firstPartOfFirstRow.Concat(secondPartOfFirstRow).ToArray();

            int[] result = new int[firstRow.Length];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = firstRow[i] + secondRow[i];
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
