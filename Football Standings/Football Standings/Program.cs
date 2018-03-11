using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Football_Standings
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            string encryptedString = Console.ReadLine();
            List<Team> teamsData = new List<Team>();

            while (!encryptedString.Equals("final"))
            {
                string[] tokens = encryptedString.Split(' ');
                string firstTeamEncryptedName = tokens[0];
                string secondTeamEncryptedName = tokens[1];
                int firstTeamGoals = int.Parse(tokens[2].Split(':')[0]);
                int secondTeamGoals = int.Parse(tokens[2].Split(':')[1]);

                string firstTeamDecryptedName = ReturnDecryptedName(firstTeamEncryptedName, key);
                string secondTeamDecryptedName = ReturnDecryptedName(secondTeamEncryptedName, key);

                int firstTeamPoints = 0;
                int secondTeamPoints = 0;

                if (firstTeamGoals > secondTeamGoals)
                {
                    firstTeamPoints += 3;
                }
                else if (firstTeamGoals < secondTeamGoals)
                {
                    secondTeamPoints += 3;
                }
                else
                {
                    firstTeamPoints += 1;
                    secondTeamPoints += 1;
                }
   
                if (!teamsData.Select(t => t.Name).Contains(firstTeamDecryptedName))
                {
                    Team team = new Team(firstTeamDecryptedName, firstTeamGoals, firstTeamPoints);
                    teamsData.Add(team);
                }
                else
                {
                    foreach (Team team in teamsData.Where(t => t.Name == firstTeamDecryptedName).ToList())
                    {
                        team.Goals += firstTeamGoals;
                        team.Points += firstTeamPoints;
                    }
                }

                if (!teamsData.Select(t => t.Name).Contains(secondTeamDecryptedName))
                {
                    Team team = new Team(secondTeamDecryptedName, secondTeamGoals, secondTeamPoints);
                    teamsData.Add(team);
                }
                else
                {
                    foreach (Team team in teamsData.Where(t => t.Name == secondTeamDecryptedName).ToList())
                    {
                        team.Goals += secondTeamGoals;
                        team.Points += secondTeamPoints;
                    }
                }

                encryptedString = Console.ReadLine();
            }

            int place = 1;

            Console.WriteLine("League standings:");

            foreach (Team team in teamsData.OrderByDescending(t => t.Points).ThenBy(t => t.Name))
            {
                Console.WriteLine($"{place}. {team.Name} {team.Points}");
                place++;
            }

            Console.WriteLine("Top 3 scored goals:");

            foreach (Team team in teamsData.OrderByDescending(t => t.Goals).ThenBy(t => t.Name).Take(3))
            {
                Console.WriteLine($"- {team.Name} -> {team.Goals}");
            }
        }

        class Team
        {
            public string Name { get; set; }
            public long Goals { get; set; }
            public long Points { get; set; }

            public Team(string name, long goals, long points)
            {
                this.Name = name;
                this.Goals = goals;
                this.Points = points;
            }
        }

        static string ReturnDecryptedName(string encrName, string key)
        {
            string decrName = "";

            int startIndex = encrName.IndexOf(key) + key.Length;
            int endIndex = encrName.LastIndexOf(key) - 1;

            for (int i = endIndex; i >= startIndex; i--)
            {
                decrName += encrName[i];
            }

            decrName = decrName.ToUpper().ToString();

            return decrName;
        }
    }
}
