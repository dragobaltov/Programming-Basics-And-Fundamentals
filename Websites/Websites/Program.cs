using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Websites
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Website> websites = new List<Website>();

            while (input != "end")
            {
                Website website = Website.ReadWebsite(input);
                websites.Add(website);

                input = Console.ReadLine();
            }

            foreach (var item in websites)
            {
                if (item.Queries.Length != 0)
                {
                    Console.Write($"https://www.{item.Host}.{item.Domain}/query?=");
                    for (int i = 0; i < item.Queries.Length; i++)
                    {
                        if (i != item.Queries.Length - 1)
                            Console.Write($"[{item.Queries[i]}]&");
                        else
                            Console.Write($"[{item.Queries[i]}]");
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine($"https://www.{item.Host}.{item.Domain}");
                }
            }
        }

        class Website
        {
            public string Host { get; set; }
            public string Domain { get; set; }
            public string[] Queries { get; set; }

            public static Website ReadWebsite(string input)
            {
                string[] tokens = input.Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Length == 3)
                {
                    string[] queries = tokens[2].Split(',');
                    return new Website
                    {
                        Host = tokens[0],
                        Domain = tokens[1],
                        Queries = queries
                    };
                }
                else
                {
                    return new Website
                    {
                        Host = tokens[0],
                        Domain = tokens[1],
                        Queries = new string[0]
                    };
                }
            }
        }
    }
}
