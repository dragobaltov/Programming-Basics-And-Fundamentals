using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulator2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split(' ');
                string command = tokens[0];

                if (command == "exchange")
                {
                    int index = int.Parse(tokens[1]);

                    if (index < 0 || index >= array.Length)
                        Console.WriteLine("Invalid index");
                    else
                        array = Exchange(array, index);
                }
                else if (command == "max")
                {
                    string type = tokens[1];
                    int index = Max(array, type);

                    if (index == -1)
                        Console.WriteLine("No matches");
                    else
                        Console.WriteLine(index);
                }
                else if (command == "min")
                {
                    string type = tokens[1];
                    int index = Min(array, type);

                    if (index == -1)
                        Console.WriteLine("No matches");
                    else
                        Console.WriteLine(index);
                }
                else if (command == "first")
                {
                    int count = int.Parse(tokens[1]);
                    string type = tokens[2];

                    if (count > array.Length)
                        Console.WriteLine("Invalid count");
                    else
                        Console.WriteLine(First(array, type, count));
                }
                else if (command == "last")
                {
                    int count = int.Parse(tokens[1]);
                    string type = tokens[2];

                    if(count > array.Length)
                        Console.WriteLine("Invalid count");
                    else
                        Console.WriteLine(Last(array, type, count));
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("[" + string.Join(", ", array) + "]");
        }

        static int[] Exchange(int[] initialArray, int index)
        {
            int[] newArray = new int[initialArray.Length];
            int counter = 0;

            for (int i = index + 1; i < initialArray.Length; i++)
            {
                newArray[counter] = initialArray[i];
                counter++;
            }
            for (int i = 0; i <= index; i++)
            {
                newArray[counter] = initialArray[i];
                counter++;
            }

            return newArray;
        }

        static int Max(int[] array, string neededType)
        {
            int index = -1;
            int maxValue = int.MinValue;

            if (neededType == "even")
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0 && array[i] >= maxValue)
                    {
                        index = i;
                        maxValue = array[i];
                    }
                }
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 1 && array[i] >= maxValue)
                    {
                        index = i;
                        maxValue = array[i];
                    }
                }
            }

            return index;
        }

        static int Min(int[] array, string neededType)
        {
            int index = -1;
            int minValue = int.MaxValue;

            if (neededType == "even")
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0 && array[i] <= minValue)
                    {
                        index = i;
                        minValue = array[i];
                    }
                }
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 1 && array[i] <= minValue)
                    {
                        index = i;
                        minValue = array[i];
                    }
                }
            }

            return index;
        }

        static string First(int[] array, string neededType, int count)
        {
            string result = "";
            List<int> elements = new List<int>();

            if (neededType == "even")
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0 && count > 0)
                    {
                        elements.Add(array[i]);
                        count--;
                    }
                }
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 1 && count > 0)
                    {
                        elements.Add(array[i]);
                        count--;
                    }
                }
            }

            result = "[" + string.Join(", ", elements) + "]";

            return result;
        }

        static string Last(int[] array, string neededType, int count)
        {
            string result = "";
            List<int> elements = new List<int>();

            if (neededType == "even")
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0)
                    {
                        elements.Add(array[i]);
                    }
                }
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 1)
                    {
                        elements.Add(array[i]);
                    }
                }
            }

            result = "[" + string.Join(", ", elements.Skip(elements.Count - count)) + "]";

            return result;
        }
    }
}
