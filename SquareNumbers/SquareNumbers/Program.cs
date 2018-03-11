using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var squareNums = new List<int>();
            
            for (int i = 0; i < nums.Count; i++)
            {
                if (Math.Sqrt(nums[i]) == (int)Math.Sqrt(nums[i]))
                {
                    squareNums.Add(nums[i]);
                }
            }

            squareNums.Sort();
            squareNums.Reverse();

            Console.WriteLine(string.Join(" ", squareNums));
        }
    }
}
