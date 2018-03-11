using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            Regex patternForNumbers = new Regex(@"[+-]?[0-9]+(\.[0-9]+)?");
            Regex patternForOperand = new Regex(@"[*\/]");
            List<Demon> demons = new List<Demon>();

            foreach (var name in tokens)
            {
                int health = GetHealth(name);
                double damage = 0;

                if (patternForNumbers.IsMatch(name))
                {
                    MatchCollection matches = patternForNumbers.Matches(name);
                    damage = GetDamage(matches);
                }
                damage = UpdateDamage(name, damage);

                demons.Add(new Demon(name, health, damage));
            }

            foreach (var item in demons.OrderBy(d => d.Name))
            {
                Console.WriteLine($"{item.Name} - {item.Health} health, {item.Damage:F2} damage");
            }
        }

        static double UpdateDamage(string name, double damage)
        {
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == '*')
                {
                    damage *= 2;
                }
                else if (name[i] == '/')
                {
                    damage /= 2;
                }
            }

            return damage;
        }

        static double GetDamage(MatchCollection matches)
        {
            double damage = 0;

            foreach (Match match in matches)
            {
                string value = match.Value.ToString();
                //value = value.Replace('.', ',');
                double number = double.Parse(value);
                damage += number;
            }

            return damage;
        }

        static int GetHealth(string name)
        {
            int health = 0;

            for (int i = 0; i < name.Length; i++)
            {
                if (!Char.IsDigit(name[i]))
                {
                    if (name[i] != '+' && name[i] != '-' && name[i] != '/' && name[i] != '*' && name[i] != '.')
                    {
                        health += name[i];
                    }
                }
            }

            return health;
        }
    }

    class Demon
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public double Damage { get; set; }

        public Demon(string name, int health, double damage)
        {
            this.Name = name;
            this.Health = health;
            this.Damage = damage;
        }
    }
}
