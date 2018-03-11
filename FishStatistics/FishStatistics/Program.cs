using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FishStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(?<tail>>*)<(?<body>\(+)(?<status>['\-x])>";
            int counter = 1;

            if (Regex.IsMatch(input, pattern))
            {
                MatchCollection matches = Regex.Matches(input, pattern);

                foreach (Match fish in matches)
                {
                    int tailLength = fish.Groups["tail"].Value.Length * 2;
                    int bodyLength = fish.Groups["body"].Value.Length * 2;
                    string status = fish.Groups["status"].Value;
                    Fish currentFish = new Fish(tailLength, bodyLength, status);

                    PrintingFish(currentFish, counter, fish);
                    counter++;
                }
            }
            else
            {
                Console.WriteLine("No fish found.");
            }
        }

        static void PrintingFish(Fish fish, int counter, Match match)
        {
            Console.WriteLine($"Fish {counter}: {match.Value}");
            Console.WriteLine($"   Tail type: {Fish.TailType(fish.TailLength)} ({fish.TailLength} cm)");
            Console.WriteLine($"   Body type: {Fish.BodyType(fish.BodyLength)} ({fish.BodyLength} cm)");
            Console.WriteLine($"   Status: {Fish.ReturnStatus(fish.Status)}");
        }
    }

    class Fish
    {
        public int TailLength { get; set; }
        public int BodyLength { get; set; }
        public string Status { get; set; }

        public static string TailType(int length)
        {
            if (length > 10)
            {
                return "Long";
            }
            else if (length > 2)
            {
                return "Medium";
            }
            else if(length == 2)
            {
                return "Short";
            }
            else
            {
                return "None";
            }
        }

        public static string BodyType(int length)
        {
            if (length > 20)
            {
                return "Long";
            }
            else if (length > 10)
            {
                return "Medium";
            }
            else
            {
                return "Short";
            }
        }

        public static string ReturnStatus(string symbol)
        {
            if (symbol == "'")
            {
                return "Awake";
            }
            else if(symbol == "-")
            {
                return "Asleep";
            }
            else
            {
                return "Dead";
            }
        }

        public Fish(int tail, int body, string status)
        {
            this.TailLength = tail;
            this.BodyLength = body;
            this.Status = status;
        }
    }
}
