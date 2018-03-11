using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HTMLContents
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var tagAndContent = new List<KeyValuePair<string, string>>();
            string title = "";
            List<string> finalContent = File.ReadAllLines(@"D:\New\HTMLBasicContent.txt").ToList();

            while (input != "exit")
            {
                string[] tokens = input.Split(' ');
                string tag = tokens[0];
                string content = tokens[1];

                if (tag == "title")
                {
                    title = content;
                }
                else
                {
                    tagAndContent.Add(new KeyValuePair<string, string> (tag, content));
                }

                input = Console.ReadLine();
            }

            string tab = new string(' ', 6);
            int startPoint = 5;

            if (title != "")
            {
                finalContent.Insert(3, tab + "<title>" + title + "</title>");
                startPoint++;
            }
            foreach (var item in tagAndContent)
            {
                finalContent.Insert(startPoint, $"{tab}<{item.Key}>{item.Value}</{item.Key}>");
                startPoint++;
            }

            File.WriteAllLines("index.html", finalContent);
        }
    }
}
