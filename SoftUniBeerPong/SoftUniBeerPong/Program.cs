using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniBeerPong
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { '|', ' ' });
            Dictionary<string, Dictionary<string, int>> teamsData = new Dictionary<string, Dictionary<string, int>>();

            while (input[0] != "stop")
            {
                string playerName = input[0];
                string team = input[1];
                int points = int.Parse(input[2]);

                if (!teamsData.ContainsKey(team))
                {
                    teamsData.Add(team, new Dictionary<string, int>());
                }

                if (teamsData[team].Keys.Count < 3)
                {
                    teamsData[team].Add(playerName, points);
                }

                input = Console.ReadLine().Split(new char[] { '|', ' ' });
            }

            int counter = 0;

            foreach (var item in teamsData.OrderByDescending(x => x.Value.Values.Sum()))
            {
                string team = item.Key;

                if (item.Value.Keys.Count == 3)
                {
                    counter++;
                    Console.WriteLine($"{counter}. {team}; Players:");
                    foreach (var pair in item.Value.OrderByDescending(x => x.Value))
                    {
                        Console.WriteLine($"###{pair.Key}: {pair.Value}");
                    }
                }
            }
        }
    }
}
