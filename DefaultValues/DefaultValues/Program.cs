using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, string> kvp = new Dictionary<string, string>();

            while (input[0] != "end")
            {
                string key = input[0];
                string value = input[1];

                if (!kvp.ContainsKey(key))
                {
                    kvp.Add(key, value);
                }
                else
                {
                    kvp[key] = value;
                }

                input = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
            }

            string defaultValue = Console.ReadLine();
            Dictionary<string, string> notChanged = new Dictionary<string, string>();
            Dictionary<string, string> changed = new Dictionary<string, string>();

            foreach (var item in kvp)
            {
                if (kvp[item.Key] == "null")
                {
                    changed.Add(item.Key, defaultValue);
                }
                else
                {
                    notChanged.Add(item.Key, item.Value);
                }
            }

            notChanged = notChanged.OrderByDescending(x => x.Value.Length).ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in notChanged)
            {
                Console.WriteLine($"{item.Key} <-> {item.Value}");
            }
            foreach (var item in changed)
            {
                Console.WriteLine($"{item.Key} <-> {item.Value}");
            }
        }
    }
}
