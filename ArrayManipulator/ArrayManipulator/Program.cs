using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulator
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

                    if (count < 0 || count >= array.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        string result = First(array, count, type);
                        Console.WriteLine(result);
                    }
                }
                else if (command == "last")
                {
                    int count = int.Parse(tokens[1]);
                    string type = tokens[2];

                    if (count < 0 || count >= array.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        string result = Last(array, count, type);
                        Console.WriteLine(result);
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("[" + string.Join(", ", array) + "]");
        }

        static int[] Exchange(int[] initialArr, int index)
        {
            int[] newArr = new int[initialArr.Length];
            int counter = 0;

            for (int i = index + 1; i < initialArr.Length; i++)
            {
                newArr[counter] = initialArr[i];
                counter++;
            }
            for (int i = 0; i <= index; i++)
            {
                newArr[counter] = initialArr[i];
                counter++;
            }

            return newArr;
        }

        static int Max(int[] array, string wantedType)
        {
            if (wantedType == "even")
            {
                int index = -1;
                int maxElement = int.MinValue;

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0 && array[i] >= maxElement)
                    {
                        maxElement = array[i];
                        index = i;
                    }
                }

                return index;
            }
            else
            {
                int index = -1;
                int maxElement = int.MinValue;

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 1 && array[i] >= maxElement)
                    {
                        maxElement = array[i];
                        index = i;
                    }
                }

                return index;
            }
        }

        static int Min(int[] array, string wantedType)
        {
            if (wantedType == "even")
            {
                int index = -1;
                int minElement = int.MaxValue;

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0 && array[i] <= minElement)
                    {
                        minElement = array[i];
                        index = i;
                    }
                }

                return index;
            }
            else
            {
                int index = -1;
                int minElement = int.MaxValue;

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 1 && array[i] <= minElement)
                    {
                        minElement = array[i];
                        index = i;
                    }
                }

                return index;
            }
        }

        static string First(int[] initialArray, int count, string wantedType)
        {
            string result = "[";
            int length = count;

            if (wantedType == "even")
            {
                for (int i = 0; i < initialArray.Length; i++)
                {
                    if (initialArray[i] % 2 == 0 && count > 0)
                    {
                        if (count == length)
                            result += initialArray[i].ToString() + ", ";
                        else if (count == 1)
                            result += initialArray[i].ToString();
                        else
                            result += ", " + initialArray[i].ToString();

                        count--;
                    }
                }
            }
            else
            {
                for (int i = 0; i < initialArray.Length; i++)
                {
                    if (initialArray[i] % 2 == 1 && count > 0)
                    {
                        if (count == length)
                            result += initialArray[i].ToString() + ", ";
                        else if (count == 1)
                            result += initialArray[i].ToString();
                        else
                            result += ", " + initialArray[i].ToString();

                        count--;
                    }
                }
            }

            result += "]";

            return result;
        }

        static string Last(int[] initialArray, int count, string wantedType)
        {
            int length = count;
            string result = "[";

            if (wantedType == "even")
            {
                for (int i = initialArray.Length - 1; i >= 0; i--)
                {
                    if (initialArray[i] % 2 == 0 && count > 0)
                    {
                        if (count == length)
                            result += initialArray[i].ToString() + ", ";
                        else if (count == 1)
                            result += initialArray[i].ToString();
                        else
                            result += ", " + initialArray[i].ToString();

                        count--;
                    }
                }
            }
            else
            {
                for (int i = initialArray.Length - 1; i >= 0; i--)
                {
                    if (initialArray[i] % 2 == 1 && count > 0)
                    {
                        if (count == length)
                            result += initialArray[i].ToString() + ", ";
                        else if (count == 1)
                            result += initialArray[i].ToString();
                        else
                            result += ", " + initialArray[i].ToString();

                        count--;
                    }
                }
            }

            return result;
        }
    }
}
