using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniKaraoke2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> participants = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> songs = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            string input = Console.ReadLine();
            var winners = new Dictionary<string, List<string>>();

            while (!input.Equals("dawn"))
            {
                string[] tokens = input.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[0];
                string song = tokens[1];
                string award = tokens[2];

                if (participants.Contains(name) && songs.Contains(song))
                {
                    if (!winners.ContainsKey(name))
                    {
                        winners.Add(name, new List<string>());
                    }

                    winners[name].Add(award);
                }

                input = Console.ReadLine();
            }

            if (winners.Count > 0)
            {
                foreach (var participant in winners.OrderByDescending(p => p.Value.Distinct().Count()).ThenBy(p => p.Key))
                {
                    Console.WriteLine($"{participant.Key}: {participant.Value.Distinct().Count()} awards");

                    foreach (var award in participant.Value.Distinct().OrderBy(a => a))
                    {
                        Console.WriteLine($"--{award}");
                    }
                }
            }
            else
            {
                Console.WriteLine("No awards");
            }
        }
    }
}
