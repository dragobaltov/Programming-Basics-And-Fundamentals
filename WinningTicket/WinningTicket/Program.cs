using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinningTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tickets = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < tickets.Length; i++)
            {
                string ticket = tickets[i];

                if (tickets[i].Length == 20)
                {
                    string firstHalf = ticket.Substring(0, 10);
                    string secondHalf = ticket.Substring(10);
                    char firstHalfMostCommonSymbol = MostCommonSymbol(firstHalf);
                    char secondHalfMostCommonSymbol = MostCommonSymbol(secondHalf);

                    if (firstHalfMostCommonSymbol == secondHalfMostCommonSymbol)
                    {
                        if (firstHalfMostCommonSymbol == '-')
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - no match");
                        }
                        else
                        {
                            int countSymbol = CountSymbol(firstHalf, secondHalf, firstHalfMostCommonSymbol);

                            if (countSymbol == 10)
                            {
                                Console.WriteLine($"ticket \"{ticket}\" - {countSymbol}{firstHalfMostCommonSymbol} Jackpot!");
                            }
                            else
                            {
                                Console.WriteLine($"ticket \"{ticket}\" - {countSymbol}{firstHalfMostCommonSymbol}");
                            }
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

        static char MostCommonSymbol(string half)
        {
            int counterA = 0;
            int counterS = 0;
            int counterDS = 0;
            int counterChovka = 0;

            for (int i = 0; i < half.Length; i++)
            {
                if (half[i] == '@')
                {
                    counterA++;
                }
                else if (half[i] == '$')
                {
                    counterS++;
                }
                else if (half[i] == '#')
                {
                    counterDS++;
                }
                else if (half[i] == '^')
                {
                    counterChovka++;
                }
            }

            if (counterA >= 6)
            {
                return '@';
            }
            else if (counterS >= 6)
            {
                return '$';
            }
            else if (counterDS >= 6)
            {
                return '#';
            }
            else if (counterChovka >= 6)
            {
                return '^';
            }
            else
            {
                return '-';
            }
        }

        static int CountSymbol(string firstHalf, string secondHalf, char symbol)
        {
            int firstHalfCount = 0;

            for (int i = 0; i < firstHalf.Length; i++)
            {
                if (firstHalf[i] == symbol)
                {
                    firstHalfCount++;
                }
            }

            int secondHalfCount = 0;

            for (int i = 0; i < secondHalf.Length; i++)
            {
                if (secondHalf[i] == symbol)
                {
                    secondHalfCount++;
                }
            }

            int minCount = Math.Min(firstHalfCount, secondHalfCount);

            return minCount;
        }
    }
}
