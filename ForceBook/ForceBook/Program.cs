using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var sideData = new Dictionary<string, List<string>>();

            while (!input.Equals("Lumpawaroo"))
            {
                string[] tokens = input.Split(new string[] { " -> ", " | " }, StringSplitOptions.RemoveEmptyEntries);

                if (input.Contains(" | "))
                {
                    string side = tokens[0];
                    string user = tokens[1];

                    if (!TheUserIsContained(user, sideData))
                    {
                        if (!sideData.ContainsKey(side))
                        {
                            sideData.Add(side, new List<string>());
                        }

                        sideData[side].Add(user);
                    }
                }
                else if(input.Contains(" -> "))
                {
                    string side = tokens[1];
                    string user = tokens[0];

                    if (TheUserIsContained(user, sideData))
                    {
                        foreach (var currentSide in sideData.Where(s => s.Value.Contains(user)))
                        {
                            currentSide.Value.Remove(user);
                        }

                        if (!sideData.ContainsKey(side))
                        {
                            sideData.Add(side, new List<string>());
                        }

                        sideData[side].Add(user);
                    }
                    else
                    {
                        if (!sideData.ContainsKey(side))
                        {
                            sideData.Add(side, new List<string>());
                        }

                        sideData[side].Add(user);
                    }

                    Console.WriteLine($"{user} joins the {side} side!");
                }

                input = Console.ReadLine();
            }

            sideData = sideData.Where(s => s.Value.Count > 0).ToDictionary(k => k.Key, k => k.Value);

            foreach (var side in sideData.OrderByDescending(s => s.Value.Count).ThenBy(s => s.Key))
            {
                Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");

                foreach (var user in side.Value.OrderBy(u => u))
                {
                    Console.WriteLine("! " + user);
                }
            }
        }

        static bool TheUserIsContained(string user, Dictionary<string, List<string>> sideData)
        {
            foreach (var side in sideData)
            {
                foreach (var currentUser in side.Value)
                {
                    if (currentUser == user)
                        return true;
                }
            }

            return false;
        }
    }
}
