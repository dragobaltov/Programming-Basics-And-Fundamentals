using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQuistics
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var collectionsData = new Dictionary<string, List<string>>();

            while (input != "exit")
            {
                string[] inputTokens = input.Split(new char[] { '.', '(', ')'}, StringSplitOptions.RemoveEmptyEntries);
                string collection = inputTokens[0];
                int n;

                if (inputTokens.Length == 1)
                {
                    if(collectionsData.ContainsKey(collection))
                    {
                        foreach (var item in collectionsData[collection].OrderByDescending(x => x.Length).ThenByDescending(x => x.Distinct().Count()))
                        {
                            Console.WriteLine($"* {item}");
                        }
                    }
                    else if (int.TryParse(collection, out n))
                    {
                        foreach (var item in collectionsData.OrderByDescending(x => x.Value.Count).Take(1))
                        {
                            foreach (var meth in collectionsData[item.Key].OrderBy(x => x.Length).Take(n))
                            {
                                Console.WriteLine($"* {meth}");
                            }
                        }
                    }
                }
                else
                {
                    if (!collectionsData.ContainsKey(collection))
                        collectionsData.Add(collection, new List<string>());

                    for (int i = 1; i < inputTokens.Length; i++)
                    {
                        if (!collectionsData[collection].Contains(inputTokens[i]))
                            collectionsData[collection].Add(inputTokens[i]);
                    }
                }

                input = Console.ReadLine();
            }

            string[] input2 = Console.ReadLine().Split(' ');
            string method = input2[0];
            string selection = input2[1];

            if (selection == "all")
            {
                foreach (var item in collectionsData.OrderByDescending(x => x.Value.Count).ThenByDescending(x => x.Value.OrderBy(y => y.Length).First().Length))
                {
                    if (collectionsData[item.Key].Contains(method))
                    {
                        Console.WriteLine(item.Key);
                        foreach (var meth in item.Value.OrderByDescending(x => x.Length))
                        {
                            Console.WriteLine($"* {meth}");
                        }
                    }
                    
                }
            }
            else
            {
                foreach (var item in collectionsData.OrderByDescending(x => x.Value.Count).ThenByDescending(x => x.Value.OrderBy(y => y.Length).First().Length))
                {
                    if (collectionsData[item.Key].Contains(method))
                    {
                        Console.WriteLine(item.Key);
                    }
                }
            }
        }
    }
}
