using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Commits
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"https:\/\/github\.com\/(?<user>[\w\-]+)\/(?<repo>[A-Za-z\-_]+)\/commit\/(?<hash>[A-Fa-f0-9]{40}),(?<message>.+?),(?<additions>[0-9]+),(?<deletions>[0-9]+)";
            string input = Console.ReadLine();
            var usersData = new SortedDictionary<string, SortedDictionary<string, List<Commit>>>();

            while (input != "git push")
            {
                if (Regex.IsMatch(input, pattern))
                {
                    Match match = Regex.Match(input, pattern);
                    string user = match.Groups["user"].Value;
                    string repo = match.Groups["repo"].Value;
                    string hash = match.Groups["hash"].Value;
                    string message = match.Groups["message"].Value;
                    int additions = int.Parse(match.Groups["additions"].Value);
                    int deletions = int.Parse(match.Groups["deletions"].Value);

                    if (!usersData.Keys.Contains(user))
                    {
                        usersData.Add(user, new SortedDictionary<string, List<Commit>>());
                    }
                    if (!usersData[user].ContainsKey(repo))
                    {
                        usersData[user].Add(repo, new List<Commit>());
                    }

                    Commit commit = new Commit(hash, message, additions, deletions);

                    usersData[user][repo].Add(commit);

                }

                input = Console.ReadLine();
            }

            foreach (var user in usersData)
            {
                string userName = user.Key;
                var repos = user.Value;

                Console.WriteLine(userName + ":");

                foreach (var repoData in repos)
                {
                    string repoName = repoData.Key;
                    List<Commit> commits = repoData.Value;

                    Console.WriteLine("  " + repoName + ":");

                    foreach (var commit in commits)
                    {
                        Console.WriteLine(commit);
                    }

                    Console.WriteLine($"    Total: {commits.Select(c => c.Additions).Sum()} additions, {commits.Select(c => c.Deletions).Sum()} deletions");
                }
            }
        }
    }

    class Commit
    {
        public string Hash { get; set; }
        public string Message { get; set; }
        public int Additions { get; set; }
        public int Deletions { get; set; }

        public Commit(string hash, string message, int additions, int deletions)
        {
            this.Hash = hash;
            this.Message = message;
            this.Additions = additions;
            this.Deletions = deletions;
        }

        public override string ToString()
        {
            string result = string.Format("    commit {0}: {1} ({2} additions, {3} deletions)", 
                             this.Hash, this.Message, this.Additions, this.Deletions);

            return result;
        }
    }
}
