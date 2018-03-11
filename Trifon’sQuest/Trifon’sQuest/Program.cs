using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trifon_sQuest
{
    class Program
    {
        public static char[,] map;

        static void Main(string[] args)
        {
            long health = long.Parse(Console.ReadLine());
            int[] tokens = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = tokens[0];
            int cols = tokens[1];
            map = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string letters = Console.ReadLine();

                for (int j = 0; j < cols; j++)
                {
                    map[i, j] = letters[j];
                }
            }

            bool isAlive = true;
            int turns = 0;
            int currentRow = 0;
            int currentCol = 0;
            
            while (isAlive)
            {
                if (map[currentRow, currentCol] == 'F')
                {
                    health -= turns / 2;

                    if (health <= 0)
                    {
                        isAlive = false;
                    }
                }
                else if (map[currentRow, currentCol] == 'H')
                {
                    health += turns / 3;
                }
                else if (map[currentRow, currentCol] == 'T')
                {
                    turns += 2;
                }

                if (IsAtLastPosition(currentRow, currentCol, rows, cols))
                {
                    turns++;
                    break;
                }

                if (isAlive)
                {
                    if (currentCol % 2 == 0)
                    {
                        if (currentRow + 1 >= rows)
                        {
                            currentCol++;
                        }
                        else
                        {
                            currentRow++;
                        }
                    }
                    else
                    {
                        if (currentRow - 1 < 0)
                        {
                            currentCol++;
                        }
                        else
                        {
                            currentRow--;
                        }
                    }

                    turns++;
                }
            }

            if (isAlive)
            {
                Console.WriteLine("Quest completed!");
                Console.WriteLine("Health: {0}", health);
                Console.WriteLine("Turns: {0}", turns);
            }
            else
            {
                Console.WriteLine("Died at: [{0}, {1}]", currentRow, currentCol);
            }
        }

        static bool IsAtLastPosition(int currRow, int currCol, int rows, int cols)
        {
            if (cols % 2 == 0)
                return currRow == 0 && currCol == cols - 1;
            else
                return currRow == rows - 1 && currCol == cols - 1;
        }
    }
}
