using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FootballStandings
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            string patternTeamName = @"(?<key>[^ ]+)(?<name>[A-Za-z]+)(\k<key>)";
            string patternResult = @"(?<goalsFirstTeam>[0-9]+):(?<goalsSecondTeam>[0-9]+)";
            List<Team> teamsData = new List<Team>();

            string input = Console.ReadLine();

            while (input != "final")
            {
                MatchCollection teamNames = Regex.Matches(input, patternTeamName);
                Match result = Regex.Match(input, patternResult);

                if (teamNames.Count == 2 && result.Success)
                {
                    bool legitNames = LegitTeamNames(teamNames, key);

                    if (legitNames)
                    {
                        string firstTeamName = ReversingName(teamNames[0].Groups["name"].Value.ToString());
                        string secondTeamName = ReversingName(teamNames[1].Groups["name"].Value.ToString());
                        long firstTeamGoals = long.Parse(result.Groups["goalsFirstTeam"].Value.ToString());
                        long secondTeamGoals = long.Parse(result.Groups["goalsSecondTeam"].Value.ToString());
                        int firstTeamPoints = TeamPoints(firstTeamGoals, secondTeamGoals);
                        int secondTeamPoints = TeamPoints(secondTeamGoals, firstTeamGoals);

                        if (!teamsData.Select(t => t.Name).Contains(firstTeamName))
                        {
                            Team team = new Team(firstTeamName, 0, 0);
                            teamsData.Add(team);
                        }
                        foreach (var team in teamsData.Where(t => t.Name == firstTeamName))
                        {
                            team.Goals += firstTeamGoals;
                            team.Points += firstTeamPoints;
                        }

                        if (!teamsData.Select(t => t.Name).Contains(secondTeamName))
                        {
                            Team team = new Team(secondTeamName, 0, 0);
                            teamsData.Add(team);
                        }
                        foreach (var team in teamsData.Where(t => t.Name == secondTeamName))
                        {
                            team.Goals += secondTeamGoals;
                            team.Points += secondTeamPoints;
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("League standings:");
            int count = 1;

            foreach (Team team in teamsData.OrderByDescending(t => t.Points).ThenBy(t => t.Name))
            {
                Console.WriteLine($"{count}. {team.Name} {team.Points}");
                count++;
            }

            Console.WriteLine("Top 3 scored goals:");

            foreach (Team team in teamsData.OrderByDescending(t => t.Goals).ThenBy(t => t.Name).Take(3))
            {
                Console.WriteLine($"- {team.Name} -> {team.Goals}");
            }
        }

        static bool LegitTeamNames(MatchCollection teamNames, string key)
        {
            bool isLegit = true;

            foreach (Match team in teamNames)
            {
                string currentKey = team.Groups["key"].Value;

                if (currentKey != key)
                {
                    isLegit = false;
                }
            }



            return isLegit;
        }

        static int TeamPoints(long firstTeamGoals, long secondTeamGoals)
        {
            if (firstTeamGoals > secondTeamGoals)
            {
                return 3;
            }
            else if (firstTeamGoals < secondTeamGoals)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        static string ReversingName(string reversedName)
        {
            string resultName = "";

            for (int i = reversedName.Length - 1; i >= 0; i--)
            {
                resultName += reversedName[i];
            }

            resultName = resultName.ToUpper().ToString();

            return resultName;
        }
    }

    class Team
    {
        public string Name { get; set; }
        public int Points { get; set; }
        public long Goals { get; set; }

        public Team(string name, int points, long goals)
        {
            this.Name = name;
            this.Points = points;
            this.Goals = goals;
        }
    }
}
