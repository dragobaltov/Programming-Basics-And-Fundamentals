using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousCache
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var data = new Dictionary<string, Dictionary<string, long>>();
            var cliches = new Dictionary<string, Dictionary<string, long>>(); ;

            while (input != "thetinggoesskrra")
            {
                string[] tokens = input.Split(new string[] { " -> ", " | " }, StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Length == 1)
                {
                    string dataSet = tokens[0];

                    if (!data.ContainsKey(dataSet))
                    {
                        data.Add(dataSet, new Dictionary<string, long>());

                        if (cliches.ContainsKey(dataSet))
                        {
                            foreach (var item in cliches[dataSet])
                            {
                                data[dataSet].Add(item.Key, item.Value);
                            }
                        }
                    }
                }
                else
                {
                    string dataKey = tokens[0];
                    long dataSize = long.Parse(tokens[1]);
                    string dataSet = tokens[2];

                    if (!data.ContainsKey(dataSet))
                    {
                        if (!cliches.ContainsKey(dataSet))
                        {
                            cliches.Add(dataSet, new Dictionary<string, long>());
                        }

                        cliches[dataSet].Add(dataKey, dataSize);
                    }
                    else
                    {
                        data[dataSet].Add(dataKey, dataSize);
                    }
                }

                input = Console.ReadLine();
            }

            if (data.Keys.Count > 0 && data.Values.Count > 0)
            {
                foreach (var item in data.OrderByDescending(d => d.Value.Values.Sum()).Take(1))
                {
                    Console.WriteLine($"Data Set: {item.Key}, Total Size: {item.Value.Values.Sum()}");

                    foreach (var dict in item.Value)
                    {
                        Console.WriteLine($"$.{dict.Key}");
                    }
                }
            }
        }
    }
}
