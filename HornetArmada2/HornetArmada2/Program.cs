using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetArmada2
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            var nameAndLastActivity = new Dictionary<string, long>();
            var legionsData = new Dictionary<string, Dictionary<string, long>>();

            for (long i = 0; i < m; i++)
            {
                string[] tokens = Console.ReadLine().Split(new string[] { " = ", " -> ", ":" }, StringSplitOptions.RemoveEmptyEntries);
                long lastActivity = long.Parse(tokens[0]);
                string legionName = tokens[1];
                string soldierType = tokens[2];
                long soldiersCount = long.Parse(tokens[3]);

                if (!nameAndLastActivity.ContainsKey(legionName))
                {
                    nameAndLastActivity.Add(legionName, lastActivity);
                    legionsData.Add(legionName, new Dictionary<string, long>());
                }

                if (!legionsData[legionName].ContainsKey(soldierType))
                {
                    legionsData[legionName].Add(soldierType, 0);
                }

                legionsData[legionName][soldierType] += soldiersCount;

                if (nameAndLastActivity[legionName] < lastActivity)
                {
                    nameAndLastActivity[legionName] = lastActivity;
                }
            }

            string[] inputTokens = Console.ReadLine().Split('\\');

            if (inputTokens.Length == 2)
            {
                long maxActivityValue = long.Parse(inputTokens[0]);
                string neededTypeSoldier = inputTokens[1];

                foreach (var item in legionsData.Where(l => l.Value.ContainsKey(neededTypeSoldier))
                    .OrderByDescending(l => l.Value[neededTypeSoldier]))
                {
                    foreach (var pair in item.Value.Where(i => i.Key == neededTypeSoldier))
                    {
                        if (nameAndLastActivity[item.Key] < maxActivityValue)
                            Console.WriteLine(item.Key + " -> " + pair.Value);
                    }
                }
            }
            else
            {
                string neededTypeSoldier = inputTokens[0];

                foreach (var item in nameAndLastActivity.OrderByDescending(n => n.Value))
                {
                    if (legionsData[item.Key].ContainsKey(neededTypeSoldier))
                    {
                        Console.WriteLine(item.Value + " : " + item.Key);
                    }
                }
            }
        }
    }
}
