using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetArmada
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Legion> legions = new List<Legion>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] tokens = input.Split(new string[] { " = ", " -> ", ":" },
                    StringSplitOptions.RemoveEmptyEntries);

                int lastActivity = int.Parse(tokens[0]);
                string legionName = tokens[1];
                string soldierType = tokens[2];
                int soldiersCount = int.Parse(tokens[3]);

                if (legions.Select(l => l.LegionName).Contains(legionName))
                {
                    foreach (var item in legions.Where(l => l.LegionName == legionName))
                    {
                        if (item.LastActivity < lastActivity)
                        {
                            item.LastActivity = lastActivity;
                        }

                        if (!item.SoldiersTypeData.ContainsKey(soldierType))
                        {
                            item.SoldiersTypeData.Add(soldierType, 0);
                        }

                        item.SoldiersTypeData[soldierType] += soldiersCount;
                    }
                }
                else
                {
                    Legion legion = new Legion(legionName, lastActivity, soldierType, soldiersCount);
                    legions.Add(legion);
                }
            }

            string[] printTokens = Console.ReadLine().Split('\\');

            if (printTokens.Length == 2)
            {
                int maxActivity = int.Parse(printTokens[0]);
                string wantedSoldierType = printTokens[1];

                foreach (var item in legions.Where(l => l.SoldiersTypeData.ContainsKey(wantedSoldierType))
                    .OrderByDescending(l => l.SoldiersTypeData[wantedSoldierType]))
                {
                    if (item.LastActivity < maxActivity)
                    {
                        Console.WriteLine($"{item.LegionName} -> {item.SoldiersTypeData[wantedSoldierType]}");
                    }
                }
            }
            else
            {
                string wantedSoldierType = printTokens[0];

                foreach (var item in legions.Where(l => l.SoldiersTypeData.ContainsKey(wantedSoldierType))
                    .OrderByDescending(l => l.LastActivity))
                {
                    Console.WriteLine($"{item.LastActivity} : {item.LegionName}");
                }
            }
        }
    }

    class Legion
    {
        public string LegionName { get; set; }
        public int LastActivity { get; set; }
        public Dictionary<string, int> SoldiersTypeData { get; set; }

        public Legion(string name, int lastActivity, string soldierType, int soldiersCount)
        {
            this.LegionName = name;
            this.LastActivity = lastActivity;
            this.SoldiersTypeData = new Dictionary<string, int>();
            SoldiersTypeData.Add(soldierType, soldiersCount);
        }
    }
}
