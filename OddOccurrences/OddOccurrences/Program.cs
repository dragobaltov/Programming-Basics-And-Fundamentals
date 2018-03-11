using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ').Select(w => w.ToLower()).ToArray();
            Dictionary<string, int> occurences = new Dictionary<string, int>();
            Dictionary<string, int> oddOccurences = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                if (!occurences.ContainsKey(words[i]))
                {
                    occurences.Add(words[i], 0);
                }

                occurences[words[i]]++;
            }
            
            foreach (KeyValuePair<string, int> item in occurences)
            {
                if (item.Value % 2 == 1)
                {
                    oddOccurences.Add(item.Key, item.Value);
                }
            }
            Console.WriteLine(string.Join(", ", oddOccurences.Keys));
        }
    }
}
