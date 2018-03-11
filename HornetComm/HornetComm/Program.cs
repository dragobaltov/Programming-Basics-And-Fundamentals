using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetComm
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var broadcasts = new List<KeyValuePair<string, string>>();
            var messages = new List<KeyValuePair<string, string>>();

            while (input != "Hornet is Green")
            {
                string[] inputTokens = input.Split(new string[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries);
                string firstQuery = inputTokens[0];
                string secondQuery = inputTokens[1];
                int num;
                bool inappropriateContain = false;

                for (int i = 0; i < secondQuery.Length; i++)
                {
                    int toInt = Convert.ToInt16(secondQuery[i]);
                    if (!((toInt >= 48 && toInt <= 57) ||
                        (toInt >= 65 && toInt <= 90) ||
                        (toInt >= 97 && toInt <= 122)))
                    {
                        inappropriateContain = true;
                        break;
                    }
                }

                if (inappropriateContain == false)
                {
                    if (int.TryParse(firstQuery, out num))
                    {
                        string newFirstQuery = "";
                        for (int i = firstQuery.Length - 1; i >= 0; i--)
                        {
                            newFirstQuery += firstQuery[i];
                        }
                        messages.Add(new KeyValuePair<string, string>(newFirstQuery, secondQuery));
                    }
                    else
                    {
                        bool containsDigit = false;

                        for (int i = 0; i < firstQuery.Length; i++)
                        {
                            int toInt = Convert.ToInt16(firstQuery[i]);
                            if (toInt >= 48 && toInt <= 57)
                            {
                                containsDigit = true;
                                break;
                            }
                        }

                        if (containsDigit == false)
                        {
                            string newSecondQuery = "";
                            for (int i = 0; i < secondQuery.Length; i++)
                            {
                                int n = Convert.ToInt16(secondQuery[i]);
                                if (n >= 65 && n <= 90)
                                {
                                    n += 32;
                                }
                                else if (n >= 97 && n <= 122)
                                {
                                    n -= 32;
                                }
                                newSecondQuery += Convert.ToChar(n);
                            }
                            broadcasts.Add(new KeyValuePair<string, string>(newSecondQuery, firstQuery));
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Broadcasts:");
            if (broadcasts.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var item in broadcasts)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value}");
                }
            }
            Console.WriteLine("Messages:");
            if (messages.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var item in messages)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value}");
                }
            }
        }
    }
}
