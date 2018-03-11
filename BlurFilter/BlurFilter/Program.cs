using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlurFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            int blurAmount = int.Parse(Console.ReadLine());
            int[] rowsAndCols = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rows = rowsAndCols[0];
            int cols = rowsAndCols[1];
            long[,] matrix = new long[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                long[] numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = numbers[j];
                }
            }

            int[] coordinatesOfBlur = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rowOfBlur = coordinatesOfBlur[0];
            int colOfBlur = coordinatesOfBlur[1];
            List<Tuple<int, int>> indexes = new List<Tuple<int, int>>();

            if (rowOfBlur == 0)
            {
                if (colOfBlur == 0)
                {
                    indexes.Add(new Tuple<int, int>(rowOfBlur, colOfBlur));

                    if (colOfBlur + 1 < cols)
                    {
                        indexes.Add(new Tuple<int, int>(rowOfBlur, colOfBlur + 1));
                    }
                    if (rowOfBlur + 1 < rows)
                    {
                        indexes.Add(new Tuple<int, int>(rowOfBlur + 1, colOfBlur));
                    }
                    if (colOfBlur + 1 < cols && rowOfBlur + 1 < rows)
                    {
                        indexes.Add(new Tuple<int, int>(rowOfBlur + 1, colOfBlur + 1));
                    }
                }
                else if (colOfBlur == cols - 1)
                {
                    indexes.Add(new Tuple<int, int>(rowOfBlur, colOfBlur));

                    if (colOfBlur - 1 > 0)
                    {
                        indexes.Add(new Tuple<int, int>(rowOfBlur, colOfBlur - 1));
                    }
                    if (rowOfBlur + 1 < rows)
                    {
                        indexes.Add(new Tuple<int, int>(rowOfBlur + 1, colOfBlur));
                    }
                    if (colOfBlur - 1 > 0 && rowOfBlur + 1 < rows)
                    {
                        indexes.Add(new Tuple<int, int>(rowOfBlur + 1, colOfBlur - 1));
                    }
                }
                else
                {
                    if (colOfBlur > 0 && colOfBlur < cols - 1)
                    {
                        indexes.Add(new Tuple<int, int>(rowOfBlur, colOfBlur));
                        indexes.Add(new Tuple<int, int>(rowOfBlur, colOfBlur - 1));
                        indexes.Add(new Tuple<int, int>(rowOfBlur, colOfBlur + 1));

                        if (rowOfBlur + 1 < rows)
                        {
                            indexes.Add(new Tuple<int, int>(rowOfBlur + 1, colOfBlur));
                            indexes.Add(new Tuple<int, int>(rowOfBlur + 1, colOfBlur - 1));
                            indexes.Add(new Tuple<int, int>(rowOfBlur + 1, colOfBlur + 1));
                        }
                    }
                }
            }
            else if (rowOfBlur == rows - 1)
            {
                if (colOfBlur == 0)
                {
                    indexes.Add(new Tuple<int, int>(rowOfBlur, colOfBlur));

                    if (rowOfBlur - 1 >= 0)
                    {
                        indexes.Add(new Tuple<int, int>(rowOfBlur - 1, colOfBlur));
                    }
                    if (colOfBlur + 1 < cols)
                    {
                        indexes.Add(new Tuple<int, int>(rowOfBlur, colOfBlur + 1));
                    }
                    if (rowOfBlur - 1 >= 0 && colOfBlur + 1 < cols)
                    {
                        indexes.Add(new Tuple<int, int>(rowOfBlur - 1, colOfBlur + 1));
                    }
                }
                else if (colOfBlur == cols - 1)
                {
                    indexes.Add(new Tuple<int, int>(rowOfBlur, colOfBlur));

                    if (rowOfBlur - 1 >= 0)
                    {
                        indexes.Add(new Tuple<int, int>(rowOfBlur - 1, colOfBlur));
                    }
                    if (colOfBlur - 1 >= 0)
                    {
                        indexes.Add(new Tuple<int, int>(rowOfBlur, colOfBlur - 1));
                    }
                    if (rowOfBlur - 1 >= 0 && colOfBlur - 1 >= 0)
                    {
                        indexes.Add(new Tuple<int, int>(rowOfBlur - 1, colOfBlur - 1));
                    }
                }
                else
                {
                    if (colOfBlur > 0 && colOfBlur < cols - 1)
                    {
                        indexes.Add(new Tuple<int, int>(rowOfBlur, colOfBlur));
                        indexes.Add(new Tuple<int, int>(rowOfBlur, colOfBlur - 1));
                        indexes.Add(new Tuple<int, int>(rowOfBlur, colOfBlur + 1));

                        if (rowOfBlur - 1 >= 0)
                        {
                            indexes.Add(new Tuple<int, int>(rowOfBlur - 1, colOfBlur));
                            indexes.Add(new Tuple<int, int>(rowOfBlur - 1, colOfBlur - 1));
                            indexes.Add(new Tuple<int, int>(rowOfBlur - 1, colOfBlur + 1));
                        }
                    }
                }
            }
            else
            {
                if (rowOfBlur > 0 && rowOfBlur < rows - 1)
                {
                    if (colOfBlur == 0)
                    {
                        indexes.Add(new Tuple<int, int>(rowOfBlur, colOfBlur));
                        indexes.Add(new Tuple<int, int>(rowOfBlur + 1, colOfBlur));
                        indexes.Add(new Tuple<int, int>(rowOfBlur - 1, colOfBlur));

                        if (colOfBlur + 1 < cols)
                        {
                            indexes.Add(new Tuple<int, int>(rowOfBlur, colOfBlur + 1));
                            indexes.Add(new Tuple<int, int>(rowOfBlur + 1, colOfBlur + 1));
                            indexes.Add(new Tuple<int, int>(rowOfBlur - 1, colOfBlur + 1));

                        }
                    }
                    else if (colOfBlur == cols - 1)
                    {
                        indexes.Add(new Tuple<int, int>(rowOfBlur, colOfBlur));
                        indexes.Add(new Tuple<int, int>(rowOfBlur + 1, colOfBlur));
                        indexes.Add(new Tuple<int, int>(rowOfBlur - 1, colOfBlur));

                        if (colOfBlur - 1 >= 0)
                        {
                            indexes.Add(new Tuple<int, int>(rowOfBlur, colOfBlur - 1));
                            indexes.Add(new Tuple<int, int>(rowOfBlur + 1, colOfBlur - 1));
                            indexes.Add(new Tuple<int, int>(rowOfBlur - 1, colOfBlur - 1));
                        }
                    }
                    else
                    {
                        if (colOfBlur > 0 && colOfBlur < cols - 1)
                        {
                            indexes.Add(new Tuple<int, int>(rowOfBlur, colOfBlur - 1));
                            indexes.Add(new Tuple<int, int>(rowOfBlur, colOfBlur));
                            indexes.Add(new Tuple<int, int>(rowOfBlur, colOfBlur + 1));
                            indexes.Add(new Tuple<int, int>(rowOfBlur - 1, colOfBlur - 1));
                            indexes.Add(new Tuple<int, int>(rowOfBlur - 1, colOfBlur));
                            indexes.Add(new Tuple<int, int>(rowOfBlur - 1, colOfBlur + 1));
                            indexes.Add(new Tuple<int, int>(rowOfBlur + 1, colOfBlur - 1));
                            indexes.Add(new Tuple<int, int>(rowOfBlur + 1, colOfBlur));
                            indexes.Add(new Tuple<int, int>(rowOfBlur + 1, colOfBlur + 1));
                        }
                    }
                }
            }

            foreach (var pair in indexes)
            {
                int row = pair.Item1;
                int col = pair.Item2;

                matrix[row, col] += blurAmount;
            }

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
