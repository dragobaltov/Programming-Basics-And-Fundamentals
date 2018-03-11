using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOperator2
{
    class Program
    {
        public static List<List<int>> table = new List<List<int>>();

        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            for (int i = 0; i < rows; i++)
            {
                List<int> elements = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                table.Add(elements);
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
                    int index = int.Parse(tokens[3]);

                    if (rowOrCol == "row")
                    {
                        if (index >= 0 && index < table.Count)
                        {
                            if (typeNumbers == "even")
                                table[index] = table[index].Where(x => x % 2 != 0).ToList();
                            else if (typeNumbers == "odd")
                                table[index] = table[index].Where(x => x % 2 == 0).ToList();
                            else if (typeNumbers == "positive")
                                table[index] = table[index].Where(x => x < 0).ToList();
                            else if(typeNumbers == "negative")
                                table[index] = table[index].Where(x => x >= 0).ToList();
                        }
                    }
                    else
                    {
                        for (int i = 0; i < table.Count; i++)
                        {
                            if (index >= 0 && index < table[i].Count)
                            {
                                if (typeNumbers == "even" && table[i][index] % 2 == 0)
                                {
                                    table[i].RemoveAt(index);
                                }
                                else if (typeNumbers == "odd" && table[i][index] % 2 != 0)
                                {
                                    table[i].RemoveAt(index);
                                }
                                else if (typeNumbers == "positive" && table[i][index] >= 0)
                                {
                                    table[i].RemoveAt(index);
                                }
                                else if (typeNumbers == "negative" && table[i][index] < 0)
                                {
                                    table[i].RemoveAt(index);
                                }
                            }
                        }
                    }
                }
                else if (command == "swap")
                {
                    int firstRow = int.Parse(tokens[1]);
                    int secondRow = int.Parse(tokens[2]);

                    if (firstRow >= 0 && secondRow >= 0 && firstRow < table.Count && secondRow < table.Count)
                    {
                        List<int> copyOfFirstRow = table[firstRow];
                        table[firstRow] = table[secondRow];
                        table[secondRow] = copyOfFirstRow;
                    }
                }
                else if(command == "insert")
                {
                    int row = int.Parse(tokens[1]);
                    int number = int.Parse(tokens[2]);

                    if (row >= 0 && row < table.Count)
                        table[row].Insert(0, number);
                }

                input = Console.ReadLine();
            }

            for (int i = 0; i < table.Count; i++)
            {
                Console.WriteLine(string.Join(" ", table[i]));
            }
        }
    }
}
