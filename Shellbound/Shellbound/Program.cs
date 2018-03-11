using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shellbound
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            var shellData = new Dictionary<string, List<int>>();

            while (input[0] != "Aggregate")
            {
                string region = input[0];
                int size = int.Parse(input[1]);

                if (!shellData.ContainsKey(region))
                {
                    shellData.Add(region, new List<int>());
                }

                if (!shellData[region].Contains(size))
                {
                    shellData[region].Add(size);
                }

                input = Console.ReadLine().Split(' ');
            }

            foreach (var item in shellData)
            {
                Console.Write($"{item.Key} -> {string.Join(", ", item.Value)}");

                int sum = 0;

                foreach (int size in item.Value)
                {
                    sum += size;
                }

                int giantShellSize = sum - (sum / item.Value.Count);

                Console.WriteLine($" ({giantShellSize})");
            }
        }
    }
}
