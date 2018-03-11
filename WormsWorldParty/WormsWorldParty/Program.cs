using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace WormsWorldParty
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var teamsData = new Dictionary<string, Dictionary<string, long>>();

            while (!input.Equals("quit"))
            {
                string[] tokens = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string wormName = tokens[0];
                string team = tokens[1];
                long score = long.Parse(tokens[2]);

                if (!teamsData.ContainsKey(team))
                {
                    teamsData.Add(team, new Dictionary<string, long>());
                }

                if (!TheWormIsContained(teamsData, wormName))
                {
                    teamsData[team].Add(wormName, score);
                }

                input = Console.ReadLine();
            }

            int count = 1;

            foreach (var team in teamsData.Where(x => x.Value.Count > 0)
                .OrderByDescending(x => x.Value.Values.Sum())
                .ThenByDescending(x => x.Value.Values.Average()))
            {
                Console.WriteLine($"{count}. Team: {team.Key} - {team.Value.Values.Sum()}");

                foreach (var worm in team.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"###{worm.Key} : {worm.Value}");
                }

                count++;
            }
        }

        static bool TheWormIsContained(Dictionary<string, Dictionary<string, long>> teamsData, string searchedName)
        {
            foreach (var team in teamsData)
            {
                foreach (var worm in team.Value)
                {
                    if (worm.Key == searchedName)
                        return true;
                }
            }

            return false;
        }
    }
}
