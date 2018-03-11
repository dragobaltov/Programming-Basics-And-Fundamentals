using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dict_Ref_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
            var keyValue = new Dictionary<string, List<int>>();

            while (input[0] != "end")
            {
                string key = input[0];
                string[] value = input[1].Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                int firstValue;

                if (!keyValue.ContainsKey(key))
                {
                    keyValue.Add(key, new List<int>());
                }

                if (int.TryParse(value[0], out firstValue))
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        keyValue[key].Add(int.Parse(value[i]));
                    }
                }
                else
                {
                    string otherKey = value[0];
                    if (keyValue.ContainsKey(otherKey))
                    {
                        if (!keyValue.ContainsKey(key))
                        {
                            keyValue.Add(key, new List<int>());
                        }

                        keyValue[key].AddRange(keyValue[otherKey]);
                    }
                }

                input = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var item in keyValue)
            {
                if (item.Value.Count != 0)
                {
                    Console.WriteLine($"{item.Key} === {string.Join(", ", item.Value)}");
                }
            }
        }
    }
}
