using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camel_sBack
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int camelsBackSize = int.Parse(Console.ReadLine());
            int rounds = 0;
            int backIndex = numbers.Count - 1;

            if (numbers.Count == camelsBackSize)
            {
                Console.WriteLine($"already stable: {string.Join(" ", numbers)}");
            }
            else
            {
                while (numbers.Count != camelsBackSize)
                {
                    rounds++;
                    numbers.RemoveAt(0);
                    backIndex--;
                    numbers.RemoveAt(backIndex);
                    backIndex--;
                }

                Console.WriteLine($"{rounds} rounds");
                Console.WriteLine($"remaining: {string.Join(" ", numbers)}");
            }
            
        }
    }
}
