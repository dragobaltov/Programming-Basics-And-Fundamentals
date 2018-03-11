using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOperator
{
    class Program
    {
        public static int[][] table;

        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            table = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                int[] tokens = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                table[i] = new int[tokens.Length];

                for (int j = 0; j < table[i].Length; j++)
                {
                    table[i][j] = tokens[j];
                }
            }

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split(' ');
                string command = tokens[0];

                if (command == "remove")
                {
                    string typeNumbers = tokens[1];
                    string rowOrCol = tokens[2];
                    int n = int.Parse(tokens[3]);

                    Remove(typeNumbers, rowOrCol, n);
                }
                else if (command == "swap")
                {
                    int firstRow = int.Parse(tokens[1]);
                    int secondRow = int.Parse(tokens[2]);

                    Swap(firstRow, secondRow);
                }
                else
                {
                    int rowToInsert = int.Parse(tokens[1]);
                    int number = int.Parse(tokens[2]);

                    Insert(rowToInsert, number);
                }

                input = Console.ReadLine();
            }

            for (int i = 0; i < table.Length; i++)
            {
                Console.WriteLine(string.Join(" ", table[i]));
            }
        }

        static void Remove(string typeNumbers, string rowOrCol, int n)
        {
            if (rowOrCol == "row")
            {
                int row = n;

                table[row] = table[row].Where(num => !NumberRefersToTheType(num, typeNumbers)).ToArray();
            }
            else
            {
                int col = n;

                for (int row = 0; row < table.Length; row++)
                {
                    if (table[row].Length > col)
                    {
                        if (NumberRefersToTheType(table[row][col], typeNumbers))
                        {
                            table[row][col] = int.MinValue;
                            table[row] = table[row].Where(num => num != int.MinValue).ToArray();
                        }
                    }
                }
            }
        }

        static void Swap(int firstRow, int secondRow)
        {
            int[] copyOfFirstRow = table[firstRow];
            table[firstRow] = table[secondRow];
            table[secondRow] = copyOfFirstRow;
        }

        static void Insert(int row, int number)
        {
            int[] newRow = new int[table[row].Length + 1];
            newRow[0] = number;

            for (int i = 1; i < newRow.Length; i++)
            {
                newRow[i] = table[row][i - 1];
            }

            table[row] = newRow;
        }

        static bool NumberRefersToTheType(int number, string typeNumbers)
        {
            if (typeNumbers == "even")
            {
                return number % 2 == 0;
            }
            else if (typeNumbers == "odd")
            {
                return number % 2 == 1;
            }
            else if (typeNumbers == "positive")
            {
                return number >= 0;
            }
            else
            {
                return number < 0;
            }
        }
    }
}
