using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(':');
            var cityData = new Dictionary<string, Dictionary<string, int>>();

            while (input[0] != "ready")
            {
                string city = input[0];
                string[] vehicleData = input[1].Split(',');

                if (!cityData.ContainsKey(city))
                {
                    cityData.Add(city, new Dictionary<string, int>());
                }

                for (int i = 0; i < vehicleData.Length; i++)
                {
                    string[] array = vehicleData[i].Split('-');
                    string type = array[0];
                    int capacity = int.Parse(array[1]);

                    if (!cityData[city].ContainsKey(type))
                    {
                        cityData[city].Add(type, 0);
                    }

                    cityData[city][type] = capacity;
                }

                input = Console.ReadLine().Split(':');
            }

            string[] input1 = Console.ReadLine().Split(' ');

            while (input1[0] != "travel")
            {
                string city = input1[0];
                int neededCapacity = int.Parse(input1[1]);
                int currentCapacity = 0;

                foreach (var item in cityData[city])
                {
                    currentCapacity += item.Value;
                }

                if (currentCapacity >= neededCapacity)
                {
                    Console.WriteLine($"{city} -> all {neededCapacity} accommodated");
                }
                else
                {
                    Console.WriteLine($"{city} -> all except {neededCapacity - currentCapacity} accommodated");
                }

                input1 = Console.ReadLine().Split(' ');
            }
        }
    }
}
