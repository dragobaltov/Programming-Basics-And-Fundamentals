using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace PhoenixGrid
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex pattern = new Regex(@"^([^\s_]{3}\.)*([^\s_]{3})*$");

            while (input != "ReadMe")
            {
                if (pattern.IsMatch(input) && MessageIsPalindrome(input))
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }

                input = Console.ReadLine();
            }
        }

        static bool MessageIsPalindrome(string input)
        {
            string reversedInput = "";

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversedInput += input[i];
            }

            return input == reversedInput;
        }
    }
}
