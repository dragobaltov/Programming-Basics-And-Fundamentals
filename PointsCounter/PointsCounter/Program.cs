using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointsCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var teamsData = new Dictionary<string, Dictionary<string, int>>();

            while (input != "Result")
            {
                string[] tokens = input.Split('|');

                for (int i = 0; i < tokens[0].Length; i++)
                {
                    if (tokens[0][i] == '@' || tokens[0][i] == '%' || tokens[0][i] == '$' || tokens[0][i] == '*')
                    {
                        tokens[0] = tokens[0].Remove(i, 1);
                        i--;
                    }
                }
                for (int i = 0; i < tokens[1].Length; i++)
                {
                    if (tokens[1][i] == '@' || tokens[1][i] == '%' || tokens[1][i] == '$' || tokens[1][i] == '*')
                    {
                        tokens[1] = tokens[1].Remove(i, 1);
                        i--;
                    }
                        
                }

                string name = "";
                string team = "";
                int points = int.Parse(tokens[2]);

                if (tokens[0] == tokens[0].ToUpper())
                {
                    team = tokens[0];
                    name = tokens[1];
                }
                else
                {
                    team = tokens[1];
                    name = tokens[0];
                }

                if (!teamsData.ContainsKey(team))
                    teamsData.Add(team, new Dictionary<string, int>());

                if (!teamsData[team].ContainsKey(name))
                    teamsData[team].Add(name, 0);

                teamsData[team][name] = points;
               
                input = Console.ReadLine();
            }

            foreach (var item in teamsData.OrderByDescending(t => t.Value.Values.Sum()))
            {
                string bestPlayer = "";
                int maxPoints = int.MinValue;

                Console.WriteLine($"{item.Key} => {item.Value.Values.Sum()}");

                foreach (var pair in item.Value)
                {
                    if (maxPoints < pair.Value)
                    {
                        bestPlayer = pair.Key;
                        maxPoints = pair.Value;
                    }
                }

                Console.WriteLine($"Most points scored by {bestPlayer}");
            }
        }
    }
}
