using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CubicsMessages
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int requiredLength = 0;
            string pattern = @"(?<textBeforeMessage>.+?)(?<message>[A-Za-z]+)((?<textAfterMessage>.+))*";

            while (!input.Equals("Over!"))
            {
                requiredLength = int.Parse(Console.ReadLine());
                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    string message = match.Groups["message"].Value;

                    if (message.Length == requiredLength)
                    {
                        string textBeforeMessage = match.Groups["textBeforeMessage"].Value;
                        string textAfterMessage = match.Groups["textAfterMessage"].Value;

                        if (TextAfterMessageMatch(textAfterMessage) && TextBeforeMessageMatch(textBeforeMessage))
                        {
                            string decryptedMessage = GettingDecryptedMessage(message, textBeforeMessage, textAfterMessage);

                            Console.WriteLine($"{message} == {decryptedMessage}");
                        }
                    }
                }

                input = Console.ReadLine();
            }
        }

        static string GettingDecryptedMessage(string message, string numbersBeforeMessage, string textAfterMessage)
        {
            string decryptedMessage = "";

            for (int i = 0; i < numbersBeforeMessage.Length; i++)
            {
                int currentIndex = int.Parse(numbersBeforeMessage[i].ToString());

                if (currentIndex < 0 || currentIndex >= message.Length)
                {
                    decryptedMessage += " ";
                }
                else
                {
                    decryptedMessage += message[currentIndex];
                }
            }

            for (int i = 0; i < textAfterMessage.Length; i++)
            {
                string currentSymbol = textAfterMessage[i].ToString();
                int index = -1;

                if (int.TryParse(currentSymbol, out index))
                {
                    if (index < 0 || index >= message.Length)
                    {
                        decryptedMessage += " ";
                    }
                    else
                    {
                        decryptedMessage += message[index];
                    }
                }
            }

            return decryptedMessage;
        }

        static bool TextAfterMessageMatch(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsLetter(text[i]))
                {
                    return false;
                }
            }

            return true;
        }

        static bool TextBeforeMessageMatch(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (!char.IsDigit(text[i]))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
