using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowsAndCols = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rows = rowsAndCols[0];
            int cols = rowsAndCols[1];
            long[,] matrix = new long[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                long[] currentRow = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = currentRow[j];
                }
            }

            int[] targetedCell = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int neededRow = targetedCell[0];
            int neededCol = targetedCell[1];
            long initialValueOfTargetedCell = matrix[neededRow, neededCol];
            long newValueOfTargetedCell = initialValueOfTargetedCell;
            var rowsAndColsOfNeghbouringCells = new List<Tuple<int, int>>();

            if (neededCol - 1 < 0)
            {
                if (neededRow - 1 < 0)
                {
                    rowsAndColsOfNeghbouringCells.Add(Tuple.Create(neededRow, neededCol + 1));
                    rowsAndColsOfNeghbouringCells.Add(Tuple.Create(neededRow + 1, neededCol));
                    rowsAndColsOfNeghbouringCells.Add(Tuple.Create(neededRow + 1, neededCol + 1));
                }
                else if (neededRow + 1 >= matrix.Length)
                {
                    rowsAndColsOfNeghbouringCells.Add(Tuple.Create(neededRow - 1, neededCol));
                    rowsAndColsOfNeghbouringCells.Add(Tuple.Create(neededRow, neededCol + 1));
                    rowsAndColsOfNeghbouringCells.Add(Tuple.Create(neededRow - 1, neededCol + 1));
                }
                else
                {
                    rowsAndColsOfNeghbouringCells.Add(Tuple.Create(neededRow - 1, neededCol));
                    rowsAndColsOfNeghbouringCells.Add(Tuple.Create(neededRow + 1, neededCol));
                    rowsAndColsOfNeghbouringCells.Add(Tuple.Create(neededRow - 1, neededCol + 1));
                    rowsAndColsOfNeghbouringCells.Add(Tuple.Create(neededRow, neededCol + 1));
                    rowsAndColsOfNeghbouringCells.Add(Tuple.Create(neededRow + 1, neededCol + 1));
                }
            }
            else if (neededCol + 1 >= cols)
            {
                if (neededRow - 1 < 0)
                {
                    rowsAndColsOfNeghbouringCells.Add(Tuple.Create(neededRow, neededCol - 1));
                    rowsAndColsOfNeghbouringCells.Add(Tuple.Create(neededRow + 1, neededCol));
                    rowsAndColsOfNeghbouringCells.Add(Tuple.Create(neededRow + 1, neededCol - 1));
                }
                else if (neededRow + 1 >= matrix.Length)
                {
                    rowsAndColsOfNeghbouringCells.Add(Tuple.Create(neededRow - 1, neededCol));
                    rowsAndColsOfNeghbouringCells.Add(Tuple.Create(neededRow, neededCol - 1));
                    rowsAndColsOfNeghbouringCells.Add(Tuple.Create(neededRow - 1, neededCol - 1));
                }
                else
                {
                    rowsAndColsOfNeghbouringCells.Add(Tuple.Create(neededRow - 1, neededCol));
                    rowsAndColsOfNeghbouringCells.Add(Tuple.Create(neededRow + 1, neededCol));
                    rowsAndColsOfNeghbouringCells.Add(Tuple.Create(neededRow - 1, neededCol - 1));
                    rowsAndColsOfNeghbouringCells.Add(Tuple.Create(neededRow, neededCol - 1));
                    rowsAndColsOfNeghbouringCells.Add(Tuple.Create(neededRow + 1, neededCol - 1));
                }
            }
            else
            {
                if (neededRow - 1 < 0)
                {
                    rowsAndColsOfNeghbouringCells.Add(Tuple.Create(neededRow, neededCol - 1));
                    rowsAndColsOfNeghbouringCells.Add(Tuple.Create(neededRow, neededCol + 1));
                    rowsAndColsOfNeghbouringCells.Add(Tuple.Create(neededRow + 1, neededCol - 1));
                    rowsAndColsOfNeghbouringCells.Add(Tuple.Create(neededRow + 1, neededCol));
                    rowsAndColsOfNeghbouringCells.Add(Tuple.Create(neededRow + 1, neededCol + 1));
                }
                else if (neededRow + 1 >= matrix.Length)
                {
                    rowsAndColsOfNeghbouringCells.Add(Tuple.Create(neededRow, neededCol - 1));
                    rowsAndColsOfNeghbouringCells.Add(Tuple.Create(neededRow, neededCol + 1));
                    rowsAndColsOfNeghbouringCells.Add(Tuple.Create(neededRow - 1, neededCol - 1));
                    rowsAndColsOfNeghbouringCells.Add(Tuple.Create(neededRow - 1, neededCol));
                    rowsAndColsOfNeghbouringCells.Add(Tuple.Create(neededRow - 1, neededCol + 1));
                }
                else
                {
                    rowsAndColsOfNeghbouringCells.Add(Tuple.Create(neededRow - 1, neededCol - 1));
                    rowsAndColsOfNeghbouringCells.Add(Tuple.Create(neededRow - 1, neededCol));
                    rowsAndColsOfNeghbouringCells.Add(Tuple.Create(neededRow - 1, neededCol + 1));
                    rowsAndColsOfNeghbouringCells.Add(Tuple.Create(neededRow, neededCol - 1));
                    rowsAndColsOfNeghbouringCells.Add(Tuple.Create(neededRow, neededCol + 1));
                    rowsAndColsOfNeghbouringCells.Add(Tuple.Create(neededRow + 1, neededCol - 1));
                    rowsAndColsOfNeghbouringCells.Add(Tuple.Create(neededRow + 1, neededCol));
                    rowsAndColsOfNeghbouringCells.Add(Tuple.Create(neededRow + 1, neededCol + 1));
                }
            }

            long sumOfNeghbouringCells = 0;

            foreach (var item in rowsAndColsOfNeghbouringCells)
            {
                int currentRow = item.Item1;
                int currentCol = item.Item2;

                sumOfNeghbouringCells += matrix[currentRow, currentCol];
                matrix[currentRow, currentCol] *= initialValueOfTargetedCell;
            }

            matrix[neededRow, neededCol] *= sumOfNeghbouringCells;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
