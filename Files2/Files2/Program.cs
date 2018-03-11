using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var filesData = new Dictionary<string, Dictionary<string, long>>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split('\\');
                string root = tokens[0];
                string[] nameAndSize = tokens[tokens.Length - 1].Split(';');
                string fileName = nameAndSize[0];
                long size = long.Parse(nameAndSize[1]);

                if (!filesData.ContainsKey(root))
                {
                    filesData.Add(root, new Dictionary<string, long>());
                }

                if (!filesData[root].ContainsKey(fileName))
                {
                    filesData[root].Add(fileName, size);
                }

                filesData[root][fileName] = size;
            }

            string[] tokens2 = Console.ReadLine().Split(' ');
            string neededExtension = tokens2[0];
            string neededRoot = tokens2[2];

            if (filesData.ContainsKey(neededRoot))
            {
                if (filesData[neededRoot].Where(f => f.Key.Contains("." + neededExtension)).ToList().Count == 0)
                {
                    Console.WriteLine("No");
                }
                else
                {
                    foreach (var file in filesData[neededRoot].Where(f => f.Key.Contains("." + neededExtension))
                        .OrderByDescending(f => f.Value).ThenBy(f => f.Key))
                    {
                        Console.WriteLine($"{file.Key} - {file.Value} KB");
                    }
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
