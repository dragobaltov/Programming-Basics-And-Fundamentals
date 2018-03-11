using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitHole
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> obstacles = Console.ReadLine().Split(' ').ToList();
            int energy = int.Parse(Console.ReadLine());

            for (int i = 0; i < obstacles.Count; i++)
            {
                if (obstacles[i] == "RabbitHole")
                {
                    Console.WriteLine("You have 5 years to save Kennedy!");
                    break;
                }
                else
                {
                    string[] array = obstacles[i].Split('|');
                    string command = array[0];
                    int number = int.Parse(array[1]);
                    energy -= number;

                    if (command == "Left")
                    {
                        if (energy <= 0)
                        {
                            Console.WriteLine("You are tired. You can't continue the mission.");
                            break;
                        }

                        if (i - number < 0)
                        {
                            number = Math.Abs(number - i);

                            while ((obstacles.Count - 1) - number < 0)
                            {
                                number = Math.Abs(number - (obstacles.Count));
                            }

                            i = (number - 1);
                        }
                        else
                        {
                            i -= (number + 1);
                        }
                    }
                    else if (command == "Right")
                    {
                        if (energy <= 0)
                        {
                            Console.WriteLine("You are tired. You can't continue the mission.");
                            break;
                        }

                        if (i + number > obstacles.Count - 1)
                        {
                            number = Math.Abs(number - (obstacles.Count - i));

                            while (number > obstacles.Count - 1)
                            {
                                number = Math.Abs(number - (obstacles.Count - 1));
                            }

                            i = 0;
                            i += (number - 1);
                        }
                        else
                        {
                            i += (number - 1);
                        }
                    }
                    else if (command == "Bomb")
                    {
                        if (energy <= 0)
                        {
                            Console.WriteLine("You are dead due to bomb explosion!");
                            break;
                        }
                        obstacles.RemoveAt(i);
                        i--;
                    }
                }

                InsertingBomb(energy, obstacles);
            }
        }

        static void InsertingBomb(int energy, List<string> obstacles)
        {
            if (obstacles[obstacles.Count - 1] != "RabbitHole")
            {
                obstacles.RemoveAt(obstacles.Count - 1);
                obstacles.Insert(obstacles.Count, $"Bomb|{energy.ToString()}");
            }
            else
            {
                obstacles.Insert(obstacles.Count, $"Bomb|{energy.ToString()}");
            }
        }
    }
}
