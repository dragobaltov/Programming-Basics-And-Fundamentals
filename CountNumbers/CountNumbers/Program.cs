using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            nums.Sort();

            for (int i = 0; i < nums.Count; i++)
            {
                Algorithm(i, nums);
            }
        }

        static void Algorithm(int i, List<int> nums)
        {
            int counter = 0;
            for (int j = 0; j < nums.Count; j++)
            {
                if (nums[i] == nums[j])
                {
                    counter++;
                }
            }
            if (i != nums.Count - 1)
            {
                if (nums[i] != nums[i + 1])
                    Console.WriteLine($"{nums[i]} -> {counter}");
            }
            else
            {
                Console.WriteLine($"{nums[i]} -> {counter}");
            }
        }
    }
}
