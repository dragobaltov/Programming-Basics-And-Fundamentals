using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] demons = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            SortedDictionary<string, int> nameAndHealth = new SortedDictionary<string, int>();
            SortedDictionary<string, double> nameAndDamage = new SortedDictionary<string, double>();
            string patternForANumber = @"([+-])?[0-9]+(\.[0-9]+)?";
            string patternForOperationSigns = @"[*\/]";

            for (int i = 0; i < demons.Length; i++)
            {
                string currentDemon = demons[i];
                int health = 0;
                double damage = 0;

                MatchCollection numbers = Regex.Matches(currentDemon, patternForANumber);
                MatchCollection operationSigns = Regex.Matches(currentDemon, patternForOperationSigns);

                foreach (Match num in numbers)
                {
                    double number = ParsingNumber(num.Value.ToString());
                    damage += number;
                }
                foreach (Match sign in operationSigns)
                {
                    if (sign.Value.ToString() == "*")
                    {
                        damage *= 2;
                    }
                    else
                    {
                        damage /= 2;
                    }
                }

                nameAndDamage.Add(currentDemon, damage);

                for (int j = 0; j < currentDemon.Length; j++)
                {
                    char symbol = currentDemon[j];

                    if (!Char.IsDigit(symbol) && symbol != '+' && symbol != '-' &&
                        symbol != '/' && symbol != '*' && symbol != '.')
                    {
                        health += symbol;
                    }
                }

                nameAndHealth.Add(currentDemon, health);
            }

            foreach (var pair in nameAndHealth)
            {
                Console.WriteLine($"{pair.Key} - {pair.Value} health, {nameAndDamage[pair.Key]:F2} damage");
            }
        }

        static double ParsingNumber(string textNumber)
        {
            string newTextNumber = "";

            //doesn't work in judge
            for (int i = 0; i < textNumber.Length; i++)
            {
                if (textNumber[i] == '.')
                {
                    newTextNumber += ',';
                }
                else
                {
                    newTextNumber += textNumber[i];
                }
            }

            double number = double.Parse(newTextNumber);

            return number;
        }
    }
}
