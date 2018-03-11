using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WinningTicket2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tickets = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Regex pattern = new Regex(@"@{6,}|\${6,}|\^{6,}|#{6,}");

            foreach (var ticket in tickets)
            {
                if (ticket.Length == 20)
                {
                    string firstHalf = ticket.Substring(0, 10);
                    string secondHalf = ticket.Substring(10);

                    if (pattern.IsMatch(firstHalf) && pattern.IsMatch(secondHalf))
                    {
                        Match firstMatch = pattern.Match(firstHalf);
                        Match secondMatch = pattern.Match(secondHalf);
                        int firstMatchLength = firstMatch.Value.ToString().Length;
                        int secondMatchLength = secondMatch.Value.ToString().Length;
                        int length = Math.Min(firstMatchLength, secondMatchLength);

                        if (length == 10)
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - 10{ticket[0]} Jackpot!");
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {length}{firstMatch.Value.ToString()[0]}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }
                }
                else
                {
                    Console.WriteLine("invalid ticket");
                }
            }
        }
    }
}
