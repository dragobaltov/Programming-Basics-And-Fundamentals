using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladybugs2
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int[] ladyBugIndexes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] field = new int[length];
            field = field.Select(x => x = 0).ToArray();

            for (int i = 0; i < ladyBugIndexes.Length; i++)
            {
                int index = ladyBugIndexes[i];

                if (index >= 0 && index < length)
                    field[index] = 1;
            }

            string input = Console.ReadLine();

            while (!input.Equals("end"))
            {
                string[] tokens = input.Split(' ');
                int index = int.Parse(tokens[0]);
                string direction = tokens[1];
                int poitionsToMove = int.Parse(tokens[2]);

                if (index >= 0 && index < field.Length)
                {
                    if (field[index] == 1)
                    {
                        field[index] = 0;

                        if (direction == "right")
                        {
                            if (index + poitionsToMove >= 0 && index + poitionsToMove < field.Length)
                            {
                                int currentIndex = index + poitionsToMove;

                                while (field[currentIndex] == 1)
                                {
                                    if (currentIndex + poitionsToMove >= field.Length)
                                        break;
                                    else
                                        currentIndex += poitionsToMove;
                                }

                                field[currentIndex] = 1;
                            }
                        }
                        else
                        {
                            if (index - poitionsToMove >= 0 && index - poitionsToMove < field.Length)
                            {
                                int currentIndex = index - poitionsToMove;

                                while (field[currentIndex] == 1)
                                {
                                    if (currentIndex - poitionsToMove < 0)
                                        break;
                                    else
                                        currentIndex -= poitionsToMove;
                                }

                                field[currentIndex] = 1;
                            }
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}
