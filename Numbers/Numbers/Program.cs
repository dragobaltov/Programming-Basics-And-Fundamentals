using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse).ToList();
            double average = numbers.Average();

            numbers = numbers.Where(x => x > average).OrderByDescending(x => x).ToList();

            if (numbers.Count >= 5)
            {
                numbers = numbers.Take(5).ToList();
                Console.WriteLine(string.Join(" ", numbers));
            }
            else if(numbers.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
