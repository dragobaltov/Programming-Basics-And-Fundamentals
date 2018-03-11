using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetArmada3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var legionsData = new Dictionary<string, Dictionary<string, long>>();
            var lastAvtivityAndLegion = new Dictionary<string, long>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(new string[] { " = ", " -> ", ":" }, StringSplitOptions.RemoveEmptyEntries);
                long lastActivity = long.Parse(tokens[0]);
                string legionName = tokens[1];
                string soldierType = tokens[2];
                long countSoldiers = long.Parse(tokens[3]);

                if (!legionsData.ContainsKey(legionName))
                {
                    legionsData.Add(legionName, new Dictionary<string, long>());
                    lastAvtivityAndLegion.Add(legionName, 0);
                }

                if (!legionsData[legionName].ContainsKey(soldierType))
                {
                    legionsData[legionName].Add(soldierType, 0);
                }

                legionsData[legionName][soldierType] += countSoldiers;

                if (lastAvtivityAndLegion[legionName] < lastActivity)
                    lastAvtivityAndLegion[legionName] = lastActivity;
            }

            string[] tokens2 = Console.ReadLine().Split('\\');

            if (tokens2.Length == 2)
            {
                int activity = int.Parse(tokens2[0]);
                string soldierType = tokens2[1];

                foreach (var legion in legionsData.Where(l => lastAvtivityAndLegion[l.Key] < activity && l.Value.ContainsKey(soldierType))
                    .OrderByDescending(l => l.Value[soldierType]))
                {
                    Console.WriteLine(legion.Key + " -> " + legion.Value[soldierType]);
                }
            }
            else
            {
                string soldierType = tokens2[0];

                foreach (var legion in legionsData.Where(l => l.Value.ContainsKey(soldierType))
                    .OrderByDescending(l => lastAvtivityAndLegion[l.Key]))
                {
                    Console.WriteLine(lastAvtivityAndLegion[legion.Key] + " : " + legion.Key);
                }
            }
        }
    }
}
