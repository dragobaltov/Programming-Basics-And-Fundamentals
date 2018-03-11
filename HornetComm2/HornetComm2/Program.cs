using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HornetComm2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex privateMessagePattern = new Regex(@"^([0-9]+) <-> ([A-Za-z0-9]+)$");
            Regex broadcastPattern = new Regex(@"^([^0-9]+) <-> ([A-Za-z0-9]+)$");
            List<KeyValuePair<string, string>> messages = new List<KeyValuePair<string, string>>();
            List<KeyValuePair<string, string>> broadcasts = new List<KeyValuePair<string, string>>();

            while (!input.Equals("Hornet is Green"))
            {
                if (privateMessagePattern.IsMatch(input))
                {
                    Match match = privateMessagePattern.Match(input);
                    string firstQuery = match.Groups[1].Value.ToString();
                    string secondQuery = match.Groups[2].Value.ToString();

                    firstQuery = string.Join("", firstQuery.ToCharArray().Reverse().ToArray());
                    messages.Add(new KeyValuePair<string, string>(firstQuery, secondQuery));
                }
                else if (broadcastPattern.IsMatch(input))
                {
                    Match match = broadcastPattern.Match(input);
                    string firstQuery = match.Groups[1].Value.ToString();
                    string secondQuery = match.Groups[2].Value.ToString();

                    secondQuery = NewQuery(secondQuery);
                    broadcasts.Add(new KeyValuePair<string, string>(secondQuery, firstQuery));
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Broadcasts:");
            if (broadcasts.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var item in broadcasts)
                {
                    Console.WriteLine(item.Key + " -> " + item.Value);
                }
            }

            Console.WriteLine("Messages:");
            if (messages.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var item in messages)
                {
                    Console.WriteLine(item.Key + " -> " + item.Value);
                }
            }
        }

        static string NewQuery(string query)
        {
            string newQuery = "";

            for (int i = 0; i < query.Length; i++)
            {
                if (Char.IsLower(query[i]))
                {
                    newQuery += Char.ToUpper(query[i]);
                }
                else if (Char.IsUpper(query[i]))
                {
                    newQuery += Char.ToLower(query[i]);
                }
                else
                {
                    newQuery += query[i];
                }
            }

            return newQuery;
        }
    }
}
