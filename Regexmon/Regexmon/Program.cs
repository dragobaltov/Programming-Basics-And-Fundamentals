using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regexmon
{
    class Program
    {
        static void Main(string[] args)
        {
            string bojomonPattern = @"[A-Za-z]+-[A-Za-z]+";
            string didimonPattern = @"[^A-Za-z-]+";

            string text = Console.ReadLine();

            while (true)
            {
                if (Regex.IsMatch(text, didimonPattern))
                {
                    Match didiMatch = Regex.Match(text, didimonPattern);
                    Console.WriteLine(didiMatch.Value.ToString());
                    text = text.Substring(didiMatch.Index + didiMatch.Length);
                }
                else
                {
                    return;
                }

                if (Regex.IsMatch(text, bojomonPattern))
                {
                    Match bojoMatch = Regex.Match(text, bojomonPattern);
                    Console.WriteLine(bojoMatch.Value.ToString());
                    text = text.Substring(bojoMatch.Index + bojoMatch.Length);
                }
                else
                {
                    return;
                }
            }
        }
    }
}
