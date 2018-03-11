using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camping
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            var campData = new Dictionary<string, Dictionary<string, int>>();

            while (input[0] != "end")
            {
                string name = input[0];
                string camperModel = input[1];
                int nights = int.Parse(input[2]);

                if (!campData.ContainsKey(name))
                {
                    campData.Add(name, new Dictionary<string, int>());
                }

                campData[name].Add(camperModel, nights);

                input = Console.ReadLine().Split(' ');
            }

            foreach (var item in campData.OrderByDescending(x => x.Value.Keys.Count).ThenBy(x => x.Key.Length))
            {
                string name = item.Key;
                Dictionary<string, int> campModelAndNights = item.Value;
                int campers = campModelAndNights.Keys.Count;
                int nights = 0;

                Console.WriteLine($"{name}: {campers}");
                foreach (var pair in campModelAndNights)
                {
                    Console.WriteLine($"***{pair.Key}");
                    nights += pair.Value;
                }
                Console.WriteLine($"Total stay: {nights} nights");
            }
        }
    }
}
