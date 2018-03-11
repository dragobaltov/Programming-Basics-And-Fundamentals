﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ReplaceATag
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            while (input != "end")
            {
                string pattern = @"<a href=(.*)>(.*?)</a>";
                string replacement = @"[URL href=$1]$2[/URL]";
                string replacedString = Regex.Replace(input, pattern, replacement);
                
                Console.WriteLine(replacedString);

                input = Console.ReadLine();
            }
        }
    }
}
