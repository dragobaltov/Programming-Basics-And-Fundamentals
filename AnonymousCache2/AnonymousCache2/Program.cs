using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousCache2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var data = new Dictionary<string, Dictionary<string, long>>();
            var cache = new Dictionary<string, Dictionary<string, long>>();

            while (!input.Equals("thetinggoesskrra"))
            {
                string[] tokens = input.Split(new string[] { " -> ", " | " }, StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Length == 1)
                {
                    string dataSet = tokens[0];

                    if (!data.ContainsKey(dataSet))
                    {
                        data.Add(dataSet, new Dictionary<string, long>());

                        if (cache.ContainsKey(dataSet))
                        {
                            foreach (var item in cache[dataSet])
                            {
                                data[dataSet].Add(item.Key, item.Value);
                            }
                        }
                    }
                }
                else
                {
                    string dataSet = tokens[2];
                    string dataKey = tokens[0];
                    long dataSize = long.Parse(tokens[1]);

                    if (data.ContainsKey(dataSet))
                    {
                        data[dataSet].Add(dataKey, dataSize);
                    }
                    else
                    {
                        if (!cache.ContainsKey(dataSet))
                        {
                            cache.Add(dataSet, new Dictionary<string, long>());
                        }

                        cache[dataSet].Add(dataKey, dataSize);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var item in data.OrderByDescending(d => d.Value.Values.Sum()).Take(1))
            {
                Console.WriteLine($"Data Set: {item.Key}, Total Size: {item.Value.Values.Sum()}");

                foreach (var pair in item.Value)
                {
                    Console.WriteLine($"$.{pair.Key}");
                }
            }
        }
    }
}
