using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSA
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var spiesData = new Dictionary<string, Dictionary<string, int>>();

            while (!input.Equals("quit"))
            {
                string[] tokens = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string country = tokens[0];
                string spyName = tokens[1];
                int daysInService = int.Parse(tokens[2]);

                if (!spiesData.ContainsKey(country))
                {
                    spiesData.Add(country, new Dictionary<string, int>());
                }

                if (!spiesData[country].ContainsKey(spyName))
                {
                    spiesData[country].Add(spyName, 0);
                }

                spiesData[country][spyName] = daysInService;

                input = Console.ReadLine();
            }

            foreach (var country in spiesData.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine("Country: {0}", country.Key);

                foreach (var spy in country.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"**{spy.Key} : {spy.Value}");
                }
            }
        }
    }
}
