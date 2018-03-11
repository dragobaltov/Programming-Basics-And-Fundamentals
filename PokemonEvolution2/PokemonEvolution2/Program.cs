using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonEvolution2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var pokemonsData = new Dictionary<string, List<KeyValuePair<string, int>>>();

            while (!input.Equals("wubbalubbadubdub"))
            {
                string[] tokens = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[0];

                if (tokens.Length == 1)
                {
                    if (pokemonsData.ContainsKey(name))
                    {
                        foreach (var pokemon in pokemonsData.Where(p => p.Key == name))
                        {
                            Console.WriteLine("# " + pokemon.Key);

                            foreach (var kvp in pokemon.Value)
                            {
                                Console.WriteLine(kvp.Key + " <-> " + kvp.Value);
                            }
                        }
                    }
                }
                else
                {
                    string evolutionType = tokens[1];
                    int evolutionIndex = int.Parse(tokens[2]);

                    if (!pokemonsData.ContainsKey(name))
                    {
                        pokemonsData.Add(name, new List<KeyValuePair<string, int>>());
                    }

                    pokemonsData[name].Add(new KeyValuePair<string, int>(evolutionType, evolutionIndex));
                }

                input = Console.ReadLine();
            }

            foreach (var pokemon in pokemonsData)
            {
                Console.WriteLine("# " + pokemon.Key);

                foreach (var kvp in pokemon.Value.OrderByDescending(p => p.Value))
                {
                    Console.WriteLine(kvp.Key + " <-> " + kvp.Value);
                }
            }
        }
    }
}
