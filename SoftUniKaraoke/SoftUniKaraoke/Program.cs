using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniKaraoke
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] listedParticipants = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            string[] availableSongs = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            string input = Console.ReadLine();
            var awardsData = new Dictionary<string, List<string>>();

            while (input != "dawn")
            {
                string[] inputTokens = input.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                string name = inputTokens[0];
                string song = inputTokens[1];
                string award = inputTokens[2];

                if (listedParticipants.Contains(name) && availableSongs.Contains(song))
                {
                    if (!awardsData.ContainsKey(name))
                        awardsData.Add(name, new List<string>());
                    if (!awardsData[name].Contains(award))
                        awardsData[name].Add(award);
                }

                input = Console.ReadLine();
            }

            if (awardsData.Count == 0)
            {
                Console.WriteLine("No awards");
            }
            else
            {
                foreach (var item in awardsData.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{item.Key}: {item.Value.Count} awards");
                    foreach (var award in item.Value.OrderBy(x => x))
                    {
                        Console.WriteLine($"--{award}");
                    }
                }
            }
        }
    }
}
