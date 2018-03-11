using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace WinningTicketsWithRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tickets = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            string pattern = @"(\${6,})|(\@{6,})|(\#{6,})|(\^{6,})";

            for (int i = 0; i < tickets.Length; i++)
            {
                string ticket = tickets[i];

                if (ticket.Length == 20)
                {
                    string firstHalf = ticket.Substring(0, 10);
                    string secondHalf = ticket.Substring(10);

                    Match firstHalfMatch = Regex.Match(firstHalf, pattern);
                    Match secondHalfMatch = Regex.Match(secondHalf, pattern);

                    if (firstHalfMatch.Success && secondHalfMatch.Success)
                    {
                        if (firstHalfMatch.Value.ToString()[0] == secondHalfMatch.Value.ToString()[0])
                        {
                            int countSymbol = Math.Min(firstHalfMatch.Value.Length, secondHalfMatch.Value.Length);

                            if (countSymbol == 10)
                            {
                                Console.WriteLine($"ticket \"{ticket}\" - {countSymbol}{firstHalfMatch.Value.ToString()[0]} Jackpot!");
                            }
                            else
                            {
                                Console.WriteLine($"ticket \"{ticket}\" - {countSymbol}{firstHalfMatch.Value.ToString()[0]}");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - no match");
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
