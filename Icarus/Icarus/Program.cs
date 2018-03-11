using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icarus
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] planePositions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int currentPosition = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int icarusDamage = 1;

            while (command != "Supernova")
            {
                string[] commandTokens = command.Split(' ');
                string direction = commandTokens[0];
                int steps = int.Parse(commandTokens[1]);

                if (direction == "left")
                {
                    while (steps > 0)
                    {
                        if (currentPosition - 1 < 0)
                        {
                            currentPosition = planePositions.Length;
                            icarusDamage += 1;
                        }

                        currentPosition -= 1;
                        planePositions[currentPosition] -= icarusDamage;
                        steps -= 1;
                    }
                }
                else
                {
                    while (steps > 0)
                    {
                        if (currentPosition + 1 >= planePositions.Length)
                        {
                            currentPosition = -1;
                            icarusDamage += 1;
                        }

                        currentPosition += 1;
                        planePositions[currentPosition] -= icarusDamage;
                        steps -= 1;
                    }
                }

                command = Console.ReadLine();
            }

            foreach (var item in planePositions)
            {
                Console.Write(item + " ");
            }
        }
    }
}
