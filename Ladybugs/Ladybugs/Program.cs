using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int trackSize = int.Parse(Console.ReadLine());
            int[] track = new int[trackSize];
            List<int> indexesOfLadybugs = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string input = Console.ReadLine();

            for (int i = 0; i < trackSize; i++)
            {
                if (indexesOfLadybugs.Contains(i))
                {
                    track[i] = 1;
                }
                else
                {
                    track[i] = 0;
                }
            }

            while (input != "end")
            {
                string[] tokens = input.Split(' ');
                int ladybugIndex = int.Parse(tokens[0]);
                string direction = tokens[1];
                int flyLength = int.Parse(tokens[2]);

                if (ladybugIndex >= 0 && ladybugIndex < track.Length && track[ladybugIndex] == 1 && flyLength != 0)
                {
                    track[ladybugIndex] = 0;

                    if (direction == "right")
                    {
                        RightDirection(track, ladybugIndex, flyLength);
                    }
                    else if (direction == "left")
                    {
                        LeftDirection(track, ladybugIndex, flyLength);
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", track));
        }

        public static void RightDirection(int[] track, int ladybugIndex, int flyLength)
        {
            if ((ladybugIndex + flyLength) < track.Length && (ladybugIndex + flyLength) >= 0)
            {
                int index = ladybugIndex + flyLength;

                while (true)
                {
                    if (track[index] == 1)
                    {
                        index += flyLength;
                        if (index >= track.Length || index < 0)
                        {
                            break;
                        }
                    }
                    else
                    {
                        track[index] = 1;
                        break;
                    }
                }
            }
            else
            {
                track[ladybugIndex] = 0;
            }
        }

        public static void LeftDirection(int[] track, int ladybugIndex, int flyLength)
        {
            if ((ladybugIndex - flyLength) >= 0 && (ladybugIndex - flyLength) < track.Length)
            {
                int index = ladybugIndex - flyLength;

                while (true)
                {
                    if (track[index] == 1)
                    {
                        index -= flyLength;
                        if (index < 0 || index >= track.Length)
                        {
                            break;
                        }
                    }
                    else
                    {
                        track[index] = 1;
                    }
                }
            }
        }
    }
}

