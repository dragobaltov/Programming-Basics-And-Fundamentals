using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftuniCoffeeOrders2
{
    class Program
    {
        public static List<string> elements;

        static void Main(string[] args)
        {
            elements = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            string input = Console.ReadLine();

            while (!input.Equals("end"))
            {
                string[] tokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];

                if (command == "reverse")
                {
                    int startIndex = int.Parse(tokens[2]);
                    int count = int.Parse(tokens[4]);

                    if (startIndex >= 0 && startIndex < elements.Count)
                    {
                        if (count >= 0 && startIndex + count - 1 < elements.Count)
                        {
                            Reverse(startIndex, count);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                }
                else if (command == "sort")
                {
                    int startIndex = int.Parse(tokens[2]);
                    int count = int.Parse(tokens[4]);

                    if (startIndex >= 0 && startIndex < elements.Count)
                    {
                        if (count >= 0 && startIndex + count - 1 < elements.Count)
                        {
                            Sort(startIndex, count);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                }
                else if (command == "rollLeft")
                {
                    int count = int.Parse(tokens[1]);

                    if (count >= 0 )
                    {
                        RollLeft(count);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                }
                else
                {
                    int count = int.Parse(tokens[1]);

                    if (count >= 0)
                    {
                        RollRight(count);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("[" + string.Join(", ", elements) + "]");
        }

        static void Reverse(int startIndex, int count)
        {
            int endIndex = startIndex + count - 1;

            while (startIndex < endIndex)
            {
                string initialValue = elements[startIndex];
                elements[startIndex] = elements[endIndex];
                elements[endIndex] = initialValue;

                startIndex++;
                endIndex--;
            }
        }

        static void Sort(int startIndex, int count)
        {
            int endIndex = startIndex + count - 1;
            bool change = true;

            while (change)
            {
                change = false;

                for (int i = startIndex; i < endIndex; i++)
                {
                    if (elements[i].CompareTo(elements[i + 1]) > 0)
                    {
                        string initialValue = elements[i];
                        elements[i] = elements[i + 1];
                        elements[i + 1] = initialValue;
                        change = true;
                    }
                }
            }
        }

        static void RollLeft(int count)
        {
            for (int i = 0; i < count; i++)
            {
                string firstElement = elements[0];

                for (int j = 0; j < elements.Count - 1; j++)
                {
                    elements[j] = elements[j + 1];
                }

                elements[elements.Count - 1] = firstElement;
            }
        }
        
        static void RollRight(int count)
        {
            for (int i = 0; i < count; i++)
            {
                string lastElement = elements[0];
                string helpElement = "";

                for (int j = 1; j < elements.Count; j++)
                {
                    helpElement = elements[j];
                    elements[j] = lastElement;
                    lastElement = helpElement;
                }

                elements[0] = lastElement;
            }
        }
    }
}
