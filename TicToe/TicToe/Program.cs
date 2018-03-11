using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicToe
{
    class Program
    {
        public static char[,] field = new char[3, 3];

        static void Main(string[] args)
        {
            //choose players' names
            Console.WriteLine("First player's name:");
            string firstPlayerName = Console.ReadLine();
            Console.WriteLine("Second player's name:");
            string secondPlayerName = Console.ReadLine();

            //choose figures
            Console.WriteLine($"{firstPlayerName}, please choose X or O for your figure:");
            char firstPlayerFigure = char.Parse(Console.ReadLine());
            char secondPlayerFigure;

            while (firstPlayerFigure != 'X' && firstPlayerFigure != 'O')
            {
                Console.WriteLine($"Invalid figure. {firstPlayerName}, please choose again:");
                firstPlayerFigure = char.Parse(Console.ReadLine());
            }

            if (firstPlayerFigure == 'X')
            {
                secondPlayerFigure = 'O';
            }
            else
            {
                secondPlayerFigure = 'X';
            }

            Console.WriteLine($"{firstPlayerName} is playing with \"{firstPlayerFigure}\"");
            Console.WriteLine($"{secondPlayerName} is playing with \"{secondPlayerFigure}\"");

            //initializing field
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    field[i, j] = '*';
                }
            }

            bool gameOver = false;
            Tuple<int, int> firstPlayerPosition;
            Tuple<int, int> secondPlayerPosition;

            PrintField();

            while (!gameOver)
            {
                if (!AllPositionsAreTaken())
                {
                    gameOver = true;
                }
                else
                {
                    firstPlayerPosition = ChoosePosition(firstPlayerName);
                    field[firstPlayerPosition.Item1, firstPlayerPosition.Item2] = firstPlayerFigure;

                    if (SomeoneHasWinned(firstPlayerFigure))
                    {
                        Console.WriteLine("{0} win.", firstPlayerName);
                        gameOver = true;
                    }
                    PrintField();
                }

                if (!gameOver)
                {
                    if (!AllPositionsAreTaken())
                    {
                        gameOver = true;
                    }
                    else
                    {
                        secondPlayerPosition = ChoosePosition(secondPlayerName);
                        field[secondPlayerPosition.Item1, secondPlayerPosition.Item2] = secondPlayerFigure;

                        if (SomeoneHasWinned(secondPlayerFigure))
                        {
                            Console.WriteLine("{0} win.", secondPlayerName);
                            gameOver = true;
                        }
                        PrintField();
                    }
                }
            }

            Console.WriteLine("Game Over!");
        }

        static bool SomeoneHasWinned(char figure)
        {
            //check rows
            if (field[0, 0] == figure && field[0, 1] == figure && field[0, 2] == figure)
            {
                return true;
            }
            else if (field[1, 0] == figure && field[1, 1] == figure && field[1, 2] == figure)
            {
                return true;
            }
            else if (field[2, 0] == figure && field[2, 1] == figure && field[2, 2] == figure)
            {
                return true;
            }
            //check columns
            else if (field[0, 0] == figure && field[1, 0] == figure && field[2, 0] == figure)
            {
                return true;
            }
            else if (field[0, 1] == figure && field[1, 1] == figure && field[2, 1] == figure)
            {
                return true;
            }
            else if (field[0, 2] == figure && field[1, 2] == figure && field[2, 2] == figure)
            {
                return true;
            }
            //check diagonals
            else if (field[0, 0] == figure && field[1, 1] == figure && field[2, 2] == figure)
            {
                return true;
            }
            else if (field[0, 2] == figure && field[1, 1] == figure && field[2, 0] == figure)
            {
                return true;
            }

            return false;
        }

        static Tuple<int, int> ChoosePosition(string name)
        {
            Console.WriteLine($"{name}, please choose row:");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine($"{name}, please choose column:");
            int col = int.Parse(Console.ReadLine());

            while (row < 0 || row > 2)
            {
                Console.WriteLine($"Invalid index! {name}, you should choose row again: ");
                row = int.Parse(Console.ReadLine());
            }
            while (col < 0 || col > 2)
            {
                Console.WriteLine($"Invalid index! {name}, you should choose column again: ");
                col = int.Parse(Console.ReadLine());
            }

            while (field[row, col] != '*')
            {
                Console.WriteLine("This position is already taken. Please, choose another one:");

                Console.WriteLine("${name}, you should choose row again:");
                row = int.Parse(Console.ReadLine());
                Console.WriteLine("${name}, you should choose column again:");
                col = int.Parse(Console.ReadLine());

                while (row < 0 || row > 2)
                {
                    Console.WriteLine($"Invalid index! {name}, you should choose row again: ");
                    row = int.Parse(Console.ReadLine());
                }
                while (col < 0 || col > 2)
                {
                    Console.WriteLine($"Invalid index! {name}, you should choose column again: ");
                    col = int.Parse(Console.ReadLine());
                }
            }

            return Tuple.Create(row, col);
        }

        static bool AllPositionsAreTaken()
        {
            bool conatinsStar = false;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (field[i, j] == '*')
                    {
                        conatinsStar = true;
                    }
                }
            }

            return conatinsStar;
        }

        static void PrintField()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(field[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
