using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deserialize_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var symbolsData = new Dictionary<char, List<int>>();
            int length = int.MinValue;

            while (input != "end")
            {
                string[] tokens = input.Split(new char[] { ':', '/' }, StringSplitOptions.RemoveEmptyEntries);
                char symbol = char.Parse(tokens[0]);

                if (!symbolsData.ContainsKey(symbol))
                    symbolsData.Add(symbol, new List<int>());

                for (int i = 1; i < tokens.Length; i++)
                {
                    int index = int.Parse(tokens[i]);
                    symbolsData[symbol].Add(index);

                    if (index > length)
                        length = index;
                }

                input = Console.ReadLine();
            }

            char[] result = new char[length + 1];

            foreach (var item in symbolsData)
            {
                char symbol = item.Key;

                foreach (var index in item.Value)
                {
                    result[index] = symbol;
                }
            }

            Console.WriteLine(string.Join("", result));
        }
    }
}
