using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var clothesData = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new string[] { " -> "},
                    StringSplitOptions.RemoveEmptyEntries);
                string colour = input[0];
                string clothes = input[1];
                string[] clothesArr = clothes.Split(',');


                if (!clothesData.ContainsKey(colour))
                {
                    clothesData.Add(colour, new Dictionary<string, int>());
                }

                for (int j = 0; j < clothesArr.Length; j++)
                {
                    string wear = clothesArr[j];

                    if (!clothesData[colour].ContainsKey(wear))
                    {
                        clothesData[colour].Add(wear, 0);
                    }

                    clothesData[colour][wear]++;
                }

            }

            string[] wantedWearData = Console.ReadLine().Split(' ');
            string wantedColour = wantedWearData[0];
            string wantedWear = wantedWearData[1];

            foreach (var item in clothesData)
            {
                string currentColour = item.Key;
                Dictionary<string, int> currentWearData = item.Value;

                Console.WriteLine($"{currentColour} clothes:");

                foreach (var data in currentWearData)
                {
                    string currentWear = data.Key;
                    int quantity = data.Value;

                    if (wantedColour == currentColour && wantedWear == currentWear)
                    {
                        Console.WriteLine($"* {currentWear} - {quantity} (found!)");
                    }
                    else 
                    {
                        Console.WriteLine($"* {currentWear} - {quantity}");
                    }
                }
            }
        }
    }
}
