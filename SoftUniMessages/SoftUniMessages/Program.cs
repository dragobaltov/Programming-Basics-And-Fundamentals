using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SoftUniMessages
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int length = 0;
            string pattern = @"^(?<firstDigits>[0-9]+)(?<text>[A-Za-z]+)(?<secondDigits>[0-9]+)$";

            while (input != "Decrypt!")
            {
                length = int.Parse(Console.ReadLine());
                bool containsInappropriateSymbols = ContainsInvalidSymbolInTheBeginning(input);
                input = RemovingUnwantedSymbols(input);

                if (Regex.IsMatch(input, pattern) && containsInappropriateSymbols == false)
                {
                    Match match = Regex.Match(input, pattern);

                    if (match.Groups["text"].Value.Length == length)
                    {
                        string text = match.Groups["text"].Value;
                        string firstDigits = match.Groups["firstDigits"].Value;
                        string secondDigits = match.Groups["secondDigits"].Value;
                        string result = DecryptedMessage(text, firstDigits, secondDigits);

                        Console.WriteLine(text + " = " + result);
                    }
                }

                input = Console.ReadLine();
            }
        }

        static string DecryptedMessage(string text, string firstDigits, string secondDigits)
        {
            string result = "";

            for (int i = 0; i < firstDigits.Length; i++)
            {
                int index = int.Parse(firstDigits[i].ToString());

                if (index < text.Length)
                {
                    result += text[index];
                }
            }
            for (int i = 0; i < secondDigits.Length; i++)
            {
                int index = int.Parse(secondDigits[i].ToString());

                if (index < text.Length)
                {
                    result += text[index];
                }
            }

            return result;
        }

        static string RemovingUnwantedSymbols(string input)
        {
            string newInput = "";

            for (int i = 0; i < input.Length; i++)
            {
                if ((input[i] >= 'A' && input[i] <= 'Z')
                    || (input[i] >= 'a' && input[i] <= 'z')
                    || (input[i] >= '0' && input[i] <= '9'))
                {
                    newInput += input[i];
                }
            }

            return newInput;
        }

        static bool ContainsInvalidSymbolInTheBeginning(string input)
        {
            bool contains = false;
            int i = 0;

            while (!char.IsLetter(input[i]))
            {
                if (!char.IsDigit(input[i]))
                {
                    contains = true;
                }

                i++;
            }

            return contains;
        }
    }
}
