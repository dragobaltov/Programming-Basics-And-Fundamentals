using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int players = int.Parse(Console.ReadLine());
            int maxScore = int.MinValue;
            string nameOfBestPlayer = "";

            for (int i = 0; i < players; i++)
            {
                string name = Console.ReadLine();
                int initialScore = int.Parse(Console.ReadLine());

                for (int j = 0; j < name.Length; j++)
                {
                    if (name[j] % 2 == 0)
                    {
                        initialScore += name[j];
                    }
                    else
                    {
                        initialScore -= name[j];
                    }
                }

                if (initialScore > maxScore)
                {
                    nameOfBestPlayer = name;
                    maxScore = initialScore;
                }
            }

            Console.WriteLine($"The winner is {nameOfBestPlayer} - {maxScore} points");
        }
    }
}
