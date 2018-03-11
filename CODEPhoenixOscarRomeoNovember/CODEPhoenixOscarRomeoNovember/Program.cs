using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODEPhoenixOscarRomeoNovember
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var creaturesData = new Dictionary<string, List<string>>();

            while (input != "Blaze it!")
            {
                string[] inputTokens = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string creature = inputTokens[0];
                string squadMate = inputTokens[1];

                if (creature != squadMate)
                {
                    if (!creaturesData.ContainsKey(creature))
                    {
                        creaturesData.Add(creature, new List<string>());
                    }
                    if (!creaturesData[creature].Contains(squadMate))
                    {
                        creaturesData[creature].Add(squadMate);
                    }
                }

                input = Console.ReadLine();
            }

            var countData = new Dictionary<string, int>();

            foreach (var item in creaturesData)
            {
                if (!countData.ContainsKey(item.Key))
                    countData.Add(item.Key, 0);

                foreach (var mate in item.Value)
                {
                    if (!(creaturesData.ContainsKey(mate) && creaturesData[mate].Contains(item.Key)))
                    {
                        countData[item.Key] += 1;
                    }
                }
            }

            foreach (var item in countData.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
        }
    }
}
