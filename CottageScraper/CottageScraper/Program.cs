using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CottageScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            var treeData = new Dictionary<string, List<int>>();

            while (input[0] != "chop")
            {
                string treeType = input[0];
                int height = int.Parse(input[1]);

                if (!treeData.ContainsKey(treeType))
                {
                    treeData.Add(treeType, new List<int>());
                }

                treeData[treeType].Add(height);

                input = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            }

            string neededTypeWood = Console.ReadLine();
            int minHeight = int.Parse(Console.ReadLine());
            int logCount = 0;
            double sumOfLogHeight = 0;

            foreach (var item in treeData)
            {
                string treeType = item.Key;
                List<int> wood = item.Value;
                foreach (int height in wood)
                {
                    logCount++;
                    sumOfLogHeight += height;
                }
            }

            double pricePerMeter = Math.Round((sumOfLogHeight * 1.0 / logCount), 2);
            var usedLogs = new Dictionary<string, List<int>>();
            var unusedLogs = new Dictionary<string, List<int>>();

            foreach (var item in treeData)
            {
                string currentTypeTree = item.Key;
                List<int> woods = item.Value;

                foreach (int height in woods)
                {
                    if (currentTypeTree == neededTypeWood && height >= minHeight)
                    {
                        if (!usedLogs.ContainsKey(currentTypeTree))
                        {
                            usedLogs.Add(currentTypeTree, new List<int>());
                        }

                        usedLogs[currentTypeTree].Add(height);
                    }
                    else
                    {
                        if (!unusedLogs.ContainsKey(currentTypeTree))
                        {
                            unusedLogs.Add(currentTypeTree, new List<int>());
                        }

                        unusedLogs[currentTypeTree].Add(height);
                    }
                }
            }

            double sumOfUsedLogsHeight = 0;
            double sumOfUnusedLogsHeight = 0;

            foreach (var item in usedLogs)
            {
                sumOfUsedLogsHeight += item.Value.Sum();
            }
            foreach (var item in unusedLogs)
            {
                sumOfUnusedLogsHeight += item.Value.Sum();
            }

            sumOfUsedLogsHeight *= pricePerMeter;
            sumOfUsedLogsHeight = Math.Round(sumOfUsedLogsHeight, 2);
            sumOfUnusedLogsHeight *= (pricePerMeter * 0.25);
            sumOfUnusedLogsHeight = Math.Round(sumOfUnusedLogsHeight, 2);
            double total = sumOfUsedLogsHeight + sumOfUnusedLogsHeight;

            Console.WriteLine($"Price per meter: ${pricePerMeter:F2}");
            Console.WriteLine($"Used logs price: ${sumOfUsedLogsHeight:F2}");
            Console.WriteLine($"Unused logs price: ${sumOfUnusedLogsHeight:F2}");
            Console.WriteLine($"CottageScraper subtotal: ${total:F2}");
        }
    }
}
