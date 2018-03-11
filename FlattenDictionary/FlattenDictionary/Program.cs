using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlattenDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            Dictionary<string, Dictionary<string, string>> regularDict =
                new Dictionary<string, Dictionary<string, string>>();
            Dictionary<string, List<string>> flattenDict =
                new Dictionary<string, List<string>>();

            while (input[0] != "end")
            {
                string key = input[0];
                string innerKey = input[1];

                if (key != "flatten")
                {
                    string innerValue = input[2];

                    if (!regularDict.ContainsKey(key))
                    {
                        regularDict.Add(key, new Dictionary<string, string>());
                    }

                    if (!regularDict[key].ContainsKey(innerKey))
                    {
                        regularDict[key].Add(innerKey, innerValue);
                    }
                    else
                    {
                      regularDict[key][innerKey] = innerValue;
                    }
                }
                else
                {
                    string keyForFlattenning = innerKey;

                    if (!flattenDict.ContainsKey(keyForFlattenning))
                    {
                        flattenDict.Add(keyForFlattenning, new List<string>());
                    }

                    foreach (var item in regularDict[keyForFlattenning])
                    {
                        string concatElement = item.Key + item.Value;

                        flattenDict[keyForFlattenning].Add(concatElement);
                    }

                    regularDict.Remove(keyForFlattenning);
                }

                input = Console.ReadLine().Split(' ');
            }

            foreach (var item in regularDict.OrderByDescending(x => x.Key.Length))
            {
                int counter = 1;
                Console.WriteLine(item.Key);
                foreach (var pair in item.Value.OrderBy(x => x.Key.Length))
                {
                    Console.WriteLine($"{counter}. {pair.Key} - {pair.Value}");
                    counter++;
                }
                if (flattenDict.ContainsKey(item.Key))
                {
                    foreach (string word in flattenDict[item.Key])
                    {
                        Console.WriteLine($"{counter}. {word}");
                        counter++;
                    }
                    flattenDict.Remove(item.Key);
                }
            }
            foreach (var item in flattenDict.OrderByDescending(x => x.Key.Length))
            {
                int counter = 1;
                Console.WriteLine(item.Key);
                foreach (string word in item.Value)
                {
                    Console.WriteLine($"{counter}. {word}");
                    counter++;
                }
            }
        }
    }
}
