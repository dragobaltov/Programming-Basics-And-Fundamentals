using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SpyGram
{
    class Program
    {
        static void Main(string[] args)
        {
            string privateKey = Console.ReadLine();
            string input = Console.ReadLine();
            Regex pattern = new Regex(@"^TO: (?<senderName>[A-Z]+); MESSAGE: .+;$");
            var messages = new List<Tuple<string, string>>();

            while (!input.Equals("END"))
            {
                if (pattern.IsMatch(input))
                {
                    Match match = pattern.Match(input);
                    string senderName = match.Groups["senderName"].ToString();
                    string encryptedMessage = EncryptedMessage(input, privateKey);

                    messages.Add(new Tuple<string, string>(senderName, encryptedMessage));
                }

                input = Console.ReadLine();
            }

            foreach (var item in messages.OrderBy(x => x.Item1))
            {
                Console.WriteLine(item.Item2);
            }
        }

        static string EncryptedMessage(string input, string privateKey)
        {
            string encryptedMessage = "";
            int index = 0;

            for (int i = 0; i < input.Length; i++)
            {
                int digit = int.Parse(privateKey[index].ToString());
                char currentNewSymbol = Convert.ToChar((int)input[i] + digit);
                encryptedMessage += currentNewSymbol;

                index++;
                if (index >= privateKey.Length)
                    index = 0;
            }

            return encryptedMessage;
        }
    }
}
