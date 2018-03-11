using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GUnit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var classesData = new Dictionary<string, Dictionary<string, List<string>>>();
            Regex pattern = new Regex(@"^([A-Z][A-Za-z0-9]+ \| ){2}[A-Z][A-Za-z0-9]+$");

            while (!input.Equals("It's testing time!"))
            {
                if (pattern.IsMatch(input))
                {
                    string[] tokens = input.Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);
                    string className = tokens[0];
                    string methodName = tokens[1];
                    string unitTestName = tokens[2];

                    if (!classesData.ContainsKey(className))
                    {
                        classesData.Add(className, new Dictionary<string, List<string>>());
                    }

                    if (!classesData[className].ContainsKey(methodName))
                    {
                        classesData[className].Add(methodName, new List<string>());
                    }

                    if (!classesData[className][methodName].Contains(unitTestName))
                    {
                        classesData[className][methodName].Add(unitTestName);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var cls in classesData.OrderByDescending(c => CountUnitTests(c.Value))
                                           .ThenBy(c => c.Value.Count).ThenBy(c => c.Key))
            {
                Console.WriteLine(cls.Key + ":");

                foreach (var method in cls.Value.OrderByDescending(m => m.Value.Count).ThenBy(m => m.Key))
                {
                    Console.WriteLine("##" + method.Key);

                    foreach (var unitTest in method.Value.OrderBy(u => u.Length).ThenBy(u => u))
                    {
                        Console.WriteLine("####" + unitTest);
                    }
                }
            }
        }

        static int CountUnitTests(Dictionary<string, List<string>> methods)
        {
            int count = 0;

            foreach (var item in methods)
            {
                count += item.Value.Count;
            }

            return count;
        }
    }
}
