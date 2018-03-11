using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RoliTheCoder2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex pattern = new Regex(@"^[0-9]+( )+#(.+?)(( )+@.+?)*$");
            var idAndEvent = new Dictionary<int, string>();
            var eventAndParticipants = new Dictionary<string, List<string>>();

            while (!input.Equals("Time for Code"))
            {
                if (pattern.IsMatch(input))
                {
                    string[] tokens = input.Split(new char[] { '#', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    int id = int.Parse(tokens[0]);
                    string event1 = tokens[1];

                    if (idAndEvent.ContainsKey(id))
                    {
                        if (idAndEvent[id] == event1)
                        {
                            for (int i = 2; i < tokens.Length; i++)
                            {
                                if (!eventAndParticipants[event1].Contains(tokens[i]))
                                {
                                    eventAndParticipants[event1].Add(tokens[i]);
                                }
                            }
                        }
                    }
                    else
                    {
                        idAndEvent.Add(id, event1);
                        eventAndParticipants.Add(event1, new List<string>());

                        for (int i = 2; i < tokens.Length; i++)
                        {
                            if (!eventAndParticipants[event1].Contains(tokens[i]))
                                eventAndParticipants[event1].Add(tokens[i]);
                        }
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var event1 in eventAndParticipants.OrderByDescending(e => e.Value.Count).ThenBy(e => e.Key))
            {
                Console.WriteLine($"{event1.Key} - {event1.Value.Count}");

                foreach (var participant in event1.Value.OrderBy(p => p))
                {
                    Console.WriteLine($"{participant}");
                }
            }
        }
    }
}
