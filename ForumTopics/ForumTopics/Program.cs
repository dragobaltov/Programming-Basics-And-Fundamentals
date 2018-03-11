using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumTopics
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new string[] { " -> " },
                StringSplitOptions.RemoveEmptyEntries);
            var topicData = new Dictionary<string, List<string>>();

            while (input[0] != "filter")
            {
                string topic = input[0];
                string[] tags = input[1].Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

                if (!topicData.ContainsKey(topic))
                {
                    topicData.Add(topic, new List<string>());
                }

                for (int i = 0; i < tags.Length; i++)
                {
                    if (!topicData[topic].Contains(tags[i]))
                    {
                        topicData[topic].Add(tags[i]);
                    }
                }

                input = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
            }

            string[] wantedTags = Console.ReadLine().Split(new string[] { ", " },
                StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in topicData)
            {
                bool containsAll = true;

                for (int i = 0; i < wantedTags.Length; i++)
                {
                    if (!item.Value.Contains(wantedTags[i]))
                    {
                        containsAll = false;
                    }
                }

                if (containsAll)
                {
                    Console.Write($"{item.Key} |");
                    for (int i = 0; i < item.Value.Count; i++)
                    {
                        if (i != item.Value.Count - 1)
                        {
                            Console.Write($" #{item.Value[i]},");
                        }
                        else
                        {
                            Console.Write($" #{item.Value[i]}");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
