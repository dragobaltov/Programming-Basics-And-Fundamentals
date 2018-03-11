using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupContinentsCountriesAndCities
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedDictionary<string, SortedDictionary<string, SortedSet<string>>> continentsData = 
                new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (!continentsData.ContainsKey(continent))
                {
                    continentsData.Add(continent, new SortedDictionary<string, SortedSet<string>>());
                }

                if (!continentsData[continent].ContainsKey(country))
                {
                    continentsData[continent].Add(country, new SortedSet<string>());
                }

                continentsData[continent][country].Add(city);
            }

            foreach (var item in continentsData)
            {
                string continent = item.Key;
                Console.WriteLine($"{continent}:");
                foreach (var cc in item.Value)
                {
                    Console.WriteLine($"  {cc.Key} -> {string.Join(", ", cc.Value)}");
                }
            }
        }
    }
}
