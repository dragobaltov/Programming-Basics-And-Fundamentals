using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlattenDictionary2
{
    class Program
    {
        static void Main(string[] args)
        {
            var regularData = new Dictionary<string, Dictionary<string, string>>();
            var flattenedData = new Dictionary<string, List<string>>();
            string[] input = Console.ReadLine().Split(' ');

            while (input[0] != "end")
            {
                if (input[0] == "flatten")
                {
                    string keyToBeFlattened = input[1];

                    if (!flattenedData.ContainsKey(keyToBeFlattened))
                    {
                        flattenedData.Add(keyToBeFlattened, new List<string>());
                    }

                    foreach (var pair in regularData[keyToBeFlattened])
                    {
                        string concatenatedElement = pair.Key + pair.Value;
                        flattenedData[keyToBeFlattened].Add(concatenatedElement);
                    }

                    regularData[keyToBeFlattened] = new Dictionary<string, string>();
                }
                else
                {
                    string key = input[0];
                    string innerKey = input[1];
                    string innerValue = input[2];

                    if (!regularData.ContainsKey(key))
                    {
                        regularData.Add(key, new Dictionary<string, string>());
                    }

                    regularData[key][innerKey] = innerValue;
                }

                input = Console.ReadLine().Split(' ');
            }

            foreach (var item in regularData.OrderByDescending(x => x.Key.Length))
            {
                int counter = 1;
                string key = item.Key;

                Console.WriteLine(key);
                foreach (var pair in regularData[key].OrderBy(x => x.Key.Length))
                {
                    Console.WriteLine($"{counter}. {pair.Key} - {pair.Value}");
                    counter++;
                }
                if (flattenedData.ContainsKey(key))
                {
                    foreach (var word in flattenedData[key])
                    {
                        Console.WriteLine($"{counter}. {word}");
                        counter++;
                    }
                    flattenedData[key] = new List<string>();
                }
            }

            foreach (var item in flattenedData)
            {
                if (!regularData.ContainsKey(item.Key))
                {
                    int counter = 1;
                    Console.WriteLine(item.Key);
                    foreach (var word in flattenedData[item.Key])
                    {
                        Console.WriteLine($"{counter}. {word}");
                        counter++;
                    }
                }
            }
        }
    }
}
