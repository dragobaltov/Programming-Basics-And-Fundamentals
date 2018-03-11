using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambadaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var selectorsData = new Dictionary<string, Dictionary<string, string>>();
            var resultDict = new Dictionary<string, Dictionary<string, string>>();

            while (input != "lambada")
            {
                if (input == "dance")
                {
                    foreach (var item in selectorsData)
                    {
                        foreach (var pair in item.Value)
                        {
                            resultDict[item.Key][pair.Key] = pair.Key + "." + resultDict[item.Key][pair.Key];
                        }
                    }
                }
                else
                {
                    string[] inputTokens = input.Split(new char[] { ' ', '=', '>', '.' }, StringSplitOptions.RemoveEmptyEntries);
                    string selector = inputTokens[0];
                    string selectorObject = inputTokens[1];
                    string property = inputTokens[2];

                    if (!selectorsData.ContainsKey(selector))
                        selectorsData.Add(selector, new Dictionary<string, string>());
                    if (!resultDict.ContainsKey(selector))
                        resultDict.Add(selector, new Dictionary<string, string>());

                    if (!selectorsData[selector].ContainsKey(selectorObject))
                    {
                        selectorsData[selector].Add(selectorObject, property);
                    }
                    else
                    {
                        selectorsData[selector][selectorObject] = property;
                    }
                    if (!resultDict[selector].ContainsKey(selectorObject))
                    {
                        resultDict[selector].Add(selectorObject, property);
                    }
                    else
                    {
                        resultDict[selector][selectorObject] = property;
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var item in resultDict)
            {
                Console.Write($"{item.Key} => ");
                foreach (var pair in item.Value)
                {
                    Console.Write($"{pair.Key}.{pair.Value}");
                }
                Console.WriteLine();
            }
        }
    }
}
