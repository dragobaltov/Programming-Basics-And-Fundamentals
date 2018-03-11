using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = File.ReadAllText("words.txt").Split(' ').Select(w => w.ToLower()).ToList();
            var occurances = new Dictionary<string, int>();

            for (int i = 0; i < words.Count; i++)
            {
                occurances.Add(words[i], 0);
            }

            List<string> inputWords = File.ReadAllText("input.txt").Split(new char[]
            {
                ',', ' ', '.', '-', ';', ':', '!', '?', '\"', 
            }, StringSplitOptions.RemoveEmptyEntries).Select(w => w.ToLower()).ToList();

            for (int i = 0; i < inputWords.Count; i++)
            {
                if (words.Contains(inputWords[i]))
                {
                    occurances[inputWords[i]]++;
                }
            }

            List<string> outputLines = new List<string>(); 

            foreach (var item in occurances.OrderByDescending(o => o.Value))
            {
                string text = $"{item.Key} - {item.Value}";
                outputLines.Add(text);
            }

            File.WriteAllLines("output.txt", outputLines);
        }
    }
}
