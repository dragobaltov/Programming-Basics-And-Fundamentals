using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulationAggregation
{
    class Program
    {
        static void Main(string[] args)
        {
            var countriesAndTowns = new Dictionary<string, int>();
            var townsAndPopulation = new Dictionary<string, long>();
            string input = Console.ReadLine();

            while (!input.Equals("stop"))
            {
                string[] tokens = input.Split('\\');
                string country = GetName(tokens[0]);
                string town = GetName(tokens[1]);
                long population = long.Parse(tokens[2]);

                if (Char.IsLower(country[0]))
                {
                    string copy = town;
                    town = country;
                    country = copy;
                }

                if (!countriesAndTowns.ContainsKey(country))
                {
                    countriesAndTowns.Add(country, 0);
                }

                countriesAndTowns[country]++;

                if (!townsAndPopulation.ContainsKey(town))
                {
                    townsAndPopulation.Add(town, 0);
                }

                townsAndPopulation[town] = population;

                input = Console.ReadLine();
            }

            foreach (var item in countriesAndTowns.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

            foreach (var item in townsAndPopulation.OrderByDescending(x => x.Value).Take(3))
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }

        static string GetName(string input)
        {
            string name = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsLetter(input[i]))
                {
                    name += input[i];
                }
            }

            return name;
        }
    }
}
