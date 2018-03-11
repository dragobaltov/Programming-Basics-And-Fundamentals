using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballStandings2
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            List<Team> teamsData = new List<Team>();
            string input = Console.ReadLine();

            while (input != "final")
            {
                string[] tokens = input.Split(' ');

                string firstTeamEncryptedName = tokens[0];
                string secondTeamEncryptedName = tokens[1];
                string firstTeamDecryptedName = DecryptingName(firstTeamEncryptedName, key);
                string secondTeamDecryptedName = DecryptingName(secondTeamEncryptedName, key);

                string[] goalsTokens = tokens[2].Split(':');
                long firtsTeamGoals = long.Parse(goalsTokens[0]);
                long secondTeamGoals = long.Parse(goalsTokens[1]);

                int firstTeamPoints = TeamPoints(firtsTeamGoals, secondTeamGoals);
                int secondTeamPoints = TeamPoints(secondTeamGoals, firtsTeamGoals);

                if (!teamsData.Select(t => t.Name).Contains(firstTeamDecryptedName))
                {
                    Team team = new Team(firstTeamDecryptedName, 0, 0);
                    teamsData.Add(team);
                }
                foreach (Team team in teamsData.Where(t => t.Name == firstTeamDecryptedName))
                {
                    team.Goals += firtsTeamGoals;
                    team.Points += firstTeamPoints;
                }

                if (!teamsData.Select(t => t.Name).Contains(secondTeamDecryptedName))
                {
                    Team team = new Team(secondTeamDecryptedName, 0, 0);
                    teamsData.Add(team);
                }
                foreach (Team team in teamsData.Where(t => t.Name == secondTeamDecryptedName))
                {
                    team.Goals += secondTeamGoals;
                    team.Points += secondTeamPoints;
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

        static string DecryptingName(string encryptedName, string key)
        {
            string decryptedName = "";
            int firstOccurenceOfKey = encryptedName.IndexOf(key) + key.Length;
            int secondOccurenceOfKey = encryptedName.LastIndexOf(key);

            for (int i = secondOccurenceOfKey - 1; i >= firstOccurenceOfKey; i--)
            {
                decryptedName += encryptedName[i];
            }

            decryptedName = decryptedName.ToUpper();

            return decryptedName;
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
