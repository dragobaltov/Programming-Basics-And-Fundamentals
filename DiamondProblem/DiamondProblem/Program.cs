using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool foundDiamond = false;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '<')
                {
                    string substring = input.Substring(i);
                    if (substring.Contains('>'))
                    {
                        int index = substring.IndexOf('>');
                        string content = substring.Substring(1, index - 1);
                        int carats = SumOfCarats(content);
                        if (carats != 0)
                        {
                            Console.WriteLine($"Found {carats} carat diamond");
                            foundDiamond = true;
                        }
                    }
                }
            }

            if (!foundDiamond)
            {
                Console.WriteLine("Better luck next time");
            }
        }

        static int SumOfCarats(string content)
        {
            int sum = 0;

            for (int i = 0; i < content.Length; i++)
            {
                int num;
                if (int.TryParse(content[i].ToString(), out num))
                {
                    sum += num;
                }
            }

            return sum;
        }
    }
}
