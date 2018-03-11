using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonEvolution
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var pokemonsData = new Dictionary<string, List<KeyValuePair<string, int>>>();

            while (input != "wubbalubbadubdub")
            {
                string[] inputTokens = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

                if (inputTokens.Length == 1)
                {
                    string name = inputTokens[0];

                    if (pokemonsData.ContainsKey(name))
                    {
                        Console.WriteLine($"# {name}");
                        foreach (var item in pokemonsData[name])
                        {
                            Console.WriteLine($"{item.Key} <-> {item.Value}");
                        }
                    }
                }
                else
                {
                    string name = inputTokens[0];
                    string evolutionType = inputTokens[1];
                    int index = int.Parse(inputTokens[2]);

                    if (!pokemonsData.ContainsKey(name))
                        pokemonsData.Add(name, new List<KeyValuePair<string, int>>());

                    pokemonsData[name].Add(new KeyValuePair<string, int>(evolutionType, index));
                }

                input = Console.ReadLine();
            }

            foreach (var item in pokemonsData)
            {
                Console.WriteLine($"# {item.Key}");
                foreach (var kvp in item.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"{kvp.Key} <-> {kvp.Value}");
                }
            }
        }
    }
}
