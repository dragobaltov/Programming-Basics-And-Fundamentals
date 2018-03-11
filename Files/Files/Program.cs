using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<File> files = new List<File>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new char[] { '\\', ';' }, StringSplitOptions.RemoveEmptyEntries);
                string root = input[0];
                long size = long.Parse(input[input.Length - 1]);
                string name = input[input.Length - 2];
                bool contains = false;

                for (int j = 0; j < files.Count; j++)
                {
                    if (files[j].Root == root && files[j].Name == name)
                    {
                        files[j].Size = size;
                        contains = true;
                    }
                }

                if (!contains)
                {
                    File file = File.ReadFile(name, size, root);
                    files.Add(file);
                }
            }

            string[] input2 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string neededExtension = input2[0];
            string neededRoot = input2[2];

            List<File> neededFiles = new List<File>();

            for (int i = 0; i < files.Count; i++)
            {
                if (files[i].Root == neededRoot)
                {
                    string[] tokens = files[i].Name.Split('.');
                    string extension = tokens[tokens.Length - 1];

                    if (extension == neededExtension)
                        neededFiles.Add(files[i]);
                }
            }

            if (neededFiles.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                foreach (var item in neededFiles.OrderByDescending(f => f.Size).ThenBy(f => f.Name))
                {
                    Console.WriteLine($"{item.Name} - {item.Size} KB");
                }
            }
        }
    }

    class File
    {
        public string Name { get; set; }
        public string Root { get; set; }
        public long Size { get; set; }

        public static File ReadFile(string name, long size, string root)
        {
            return new File
            {
                Name = name,
                Size = size,
                Root = root
            };
        }
    }
}
