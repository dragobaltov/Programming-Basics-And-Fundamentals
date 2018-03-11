using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Regex pattern = new Regex(@"^[^@\-\!\:\>]*@([A-Za-z]+)[^@\-\!\:\>]*:([0-9]+)[^@\-\!\:\>]*!([A|D])![^@\-\!\:\>]*->([0-9]+)[^@\-\!\:\>]*$");
            List<string> atackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                int countNeededLetters = CountLetters(input);
                string encryptedMessage = UpdateInput(countNeededLetters, input);

                if (pattern.IsMatch(encryptedMessage))
                {
                    Match match = pattern.Match(encryptedMessage);
                    string name = match.Groups[1].Value.ToString();
                    //int population = int.Parse(match.Groups[2].Value.ToString());
                    string type = match.Groups[3].Value.ToString();

                    if (type == "A")
                    {
                        atackedPlanets.Add(name);
                    }
                    else
                    {
                        destroyedPlanets.Add(name);
                    }
                }
            }

            Console.WriteLine($"Attacked planets: {atackedPlanets.Count}");
            foreach (var planet in atackedPlanets.OrderBy(p => p))
            {
                Console.WriteLine("-> " + planet);
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            foreach (var planet in destroyedPlanets.OrderBy(p => p))
            {
                Console.WriteLine("-> " + planet);
            }
        }

        static string UpdateInput(int count, string input)
        {
            string updatedInput = "";

            for (int i = 0; i < input.Length; i++)
            {
                updatedInput += Convert.ToChar(input[i] - count);
            }

            return updatedInput;
        }

        static int CountLetters(string input)
        {
            int count = 0;
            input = input.ToLower().ToString();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 's' || input[i] == 't' ||
                    input[i] == 'a' || input[i] == 'r')
                {
                    count++;
                }
            }

            return count;
        }
    }
}
