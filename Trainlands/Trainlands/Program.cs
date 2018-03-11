using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainlands
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var trainsData = new Dictionary<string, Dictionary<string, int>>();

            while (!input.Equals("It's Training Men!"))
            {
                string[] tokens;

                if (input.Contains(" -> ") && input.Contains(" : "))
                {
                    tokens = input.Split(new string[] { " -> ", " : " }, StringSplitOptions.RemoveEmptyEntries);
                    string trainName = tokens[0];
                    string wagonName = tokens[1];
                    int wagonPower = int.Parse(tokens[2]);

                    if (!trainsData.ContainsKey(trainName))
                    {
                        trainsData.Add(trainName, new Dictionary<string, int>());
                    }

                    trainsData[trainName].Add(wagonName, wagonPower);
                }
                else if (input.Contains(" -> "))
                {
                    tokens = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                    string firstTrainName = tokens[0];
                    string secondTrainName = tokens[1];

                    if (!trainsData.ContainsKey(firstTrainName))
                    {
                        trainsData.Add(firstTrainName, new Dictionary<string, int>());
                    }

                    foreach (var item in trainsData[secondTrainName])
                    {
                        trainsData[firstTrainName].Add(item.Key, item.Value);
                    }

                    trainsData.Remove(secondTrainName);
                }
                else if(input.Contains(" = "))
                {
                    tokens = input.Split(new string[] { " = " }, StringSplitOptions.RemoveEmptyEntries);
                    string firstTrainName = tokens[0];
                    string secondTrainName = tokens[1];

                    if (!trainsData.ContainsKey(firstTrainName))
                    {
                        trainsData.Add(firstTrainName, new Dictionary<string, int>());
                    }

                    trainsData[firstTrainName] = new Dictionary<string, int>();

                    foreach (var item in trainsData[secondTrainName])
                    {
                        trainsData[firstTrainName].Add(item.Key, item.Value);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var train in trainsData.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Value.Count))
            {
                Console.WriteLine($"Train: {train.Key}");

                foreach (var wagon in train.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"###{wagon.Key} - {wagon.Value}");
                }
            }
        }
    }
}
