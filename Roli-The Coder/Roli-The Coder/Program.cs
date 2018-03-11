using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roli_The_Coder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Event> events = new List<Event>();

            while (input != "Time for Code")
            {
                if (input.Contains('#'))
                {
                    string[] tokens = input.Split(new char[] { ' ', '#' }, StringSplitOptions.RemoveEmptyEntries);
                    string ID = tokens[0];
                    string name = tokens[1];
                    List<string> participants = new List<string>();

                    for (int i = 2; i < tokens.Length; i++)
                    {
                        if (!participants.Contains(tokens[i]))
                            participants.Add(tokens[i]);
                    }

                    Event newEvent = Event.ReadEvent(ID, name, participants);

                    if (events.Select(e => e.ID).Contains(newEvent.ID))
                    {
                        for (int i = 0; i < events.Count; i++)
                        {
                            if (events[i].ID == newEvent.ID && events[i].Name == newEvent.Name)
                            {
                                foreach (var item in newEvent.Participants)
                                {
                                    if (!events[i].Participants.Contains(item))
                                        events[i].Participants.Add(item);
                                }
                            }
                        }
                    }
                    else
                    {
                        events.Add(newEvent);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var item in events.OrderByDescending(e => e.Participants.Count).ThenBy(e => e.Name))
            {
                Console.WriteLine($"{item.Name} - {item.Participants.Count}");

                foreach (var participant in item.Participants.OrderBy(p => p))
                {
                    Console.WriteLine(participant);
                }
            }
        }
    }

    class Event
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public List<string> Participants { get; set; }

        public static Event ReadEvent(string ID, string name, List<string> participants)
        {
            return new Event
            {
                ID = ID,
                Name = name,
                Participants = participants
            };
        }
    }
}
