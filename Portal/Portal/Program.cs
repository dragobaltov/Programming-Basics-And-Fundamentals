using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal
{
    class Program
    {
        public static char[][] matrix;
        public static int currentRow;
        public static int currentCol;

        static void Main(string[] args)
        {
            int sizeOfMatrix = int.Parse(Console.ReadLine());
            matrix = new char[sizeOfMatrix][];
            int startRow = -1;
            int startCol = -1;

            for (int i = 0; i < sizeOfMatrix; i++)
            {
                string currentLineItems = Console.ReadLine();
                matrix[i] = new char[currentLineItems.Length];

                for (int j = 0; j < currentLineItems.Length; j++)
                {
                    matrix[i][j] = currentLineItems[j];

                    if (currentLineItems[j] == 'S')
                    {
                        startRow = i;
                        startCol = j;
                    }
                }
            }

            string commands = Console.ReadLine();
            bool found = false;
            int countTurns = 0;
            currentRow = startRow;
            currentCol = startCol;

            for (int i = 0; i < commands.Length; i++)
            {
                char currentDirection = commands[i];

                if (currentDirection == 'R')
                {
                    MoveRight();
                }
                else if (currentDirection == 'L')
                {
                    MoveLeft();
                }
                else if (currentDirection == 'U')
                {
                    MoveUpper();
                }
                else if (currentDirection == 'D')
                {
                    MoveDown();
                }

                if (matrix[currentRow][currentCol] == 'E')
                {
                    found = true;
                    i = commands.Length - 1; 
                }

                countTurns++;
            }

            if (found)
            {
                Console.WriteLine($"Experiment successful. {countTurns} turns required.");
            }
            else
            {
                Console.WriteLine($"Robot stuck at {currentRow} {currentCol}. Experiment failed.");
            }
        }

        static void MoveRight()
        {
            if (currentCol + 1 >= matrix[currentRow].Length)
            {
                currentCol = 0;
            }
            else
            {
                currentCol++;
            }
        }

        static void MoveLeft()
        {
            if (currentCol - 1 < 0)
            {
                currentCol = matrix[currentRow].Length - 1;
            }
            else
            {
                currentCol--;
            }
        }

        static void MoveUpper()
        {
            if (currentRow - 1 < 0)
            {
                currentRow = matrix.Length - 1;

                while (currentCol >= matrix[currentRow].Length)
                {
                    currentRow--;
                }
            }
            else
            {
                currentRow--;

                while (currentCol >= matrix[currentRow].Length)
                {
                    if (currentRow - 1 < 0)
                    {
                        currentRow = matrix.Length - 1;
                    }
                    else
                    {
                        currentRow--;
                    }
                }
            }
        }

        static void MoveDown()
        {
            if (currentRow + 1 >= matrix.Length)
            {
                currentRow = 0;

                while (currentCol >= matrix[currentRow].Length)
                {
                    currentRow++;
                }
            }
            else
            {
                currentRow++;

                while (currentCol >= matrix[currentRow].Length)
                {
                    if (currentRow + 1 >= matrix.Length)
                    {
                        currentRow = 0;
                    }
                    else
                    {
                        currentRow++;
                    }
                }
            }
        }
    }
}
