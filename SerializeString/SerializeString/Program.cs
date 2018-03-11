using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var symbolsData = new Dictionary<char, List<int>>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!symbolsData.ContainsKey(input[i]))
                {
                    symbolsData.Add(input[i], new List<int>());
                }
                symbolsData[input[i]].Add(i);
            }

            foreach (var item in symbolsData)
            {
                Console.WriteLine($"{item.Key}:{string.Join("/", item.Value)}");
            }
        }
    }
}
