using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitiesByContinentAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var continetsData = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (!continetsData.ContainsKey(continent))
                {
                    continetsData.Add(continent, new Dictionary<string, List<string>>());
                }

                if (!continetsData[continent].ContainsKey(country))
                {
                    continetsData[continent].Add(country, new List<string>());
                }

                continetsData[continent][country].Add(city);
            }

            foreach (var item in continetsData)
            {
                string continent = item.Key;
                Console.WriteLine(continent + ":");

                foreach (var cc in item.Value)
                {
                    string country = cc.Key;
                    Console.Write($"  {country} -> ");
                    Console.WriteLine(string.Join(", ", cc.Value));
                }
            }
        }
    }
}
