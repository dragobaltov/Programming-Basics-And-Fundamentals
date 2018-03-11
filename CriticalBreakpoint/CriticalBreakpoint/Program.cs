using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalBreakpoint
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<long> ratios = new List<long>();
            List<long[]> lines = new List<long[]>();

            while (!input.Equals("Break it."))
            {
                long[] numbers = input.Split(' ').Select(long.Parse).ToArray();
                long ratio = Math.Abs((numbers[3] + numbers[2]) - (numbers[1] + numbers[0]));
                ratios.Add(ratio);
                lines.Add(numbers);

                input = Console.ReadLine();
            }

            bool containsBreakpoint = true;
            long maxRatio = ratios.Max();

            for (int i = 0; i < ratios.Count; i++)
            {
                if (ratios[i] != maxRatio && ratios[i] != 0)
                    containsBreakpoint = false;
            }

            if (containsBreakpoint)
            {
                double breakpoint = Math.Pow(maxRatio, ratios.Count) % ratios.Count;

                for (int i = 0; i < lines.Count; i++)
                {
                    Console.WriteLine($"Line: [{string.Join(", ", lines[i])}]");
                }
                Console.WriteLine($"Critical Breakpoint: {Math.Round(breakpoint)}");
            }
            else
            {
                Console.WriteLine($"Critical breakpoint does not exist.");
            }
        }
    }
}
