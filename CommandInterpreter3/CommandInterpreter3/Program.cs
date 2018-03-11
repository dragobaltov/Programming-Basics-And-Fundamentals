using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandInterpreter3
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
                        if (startIndex + count >= 0 && startIndex + count <= elements.Count)
                        {
                            elements.Reverse(startIndex, count);
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
                        if (startIndex + count >= 0 && startIndex + count <= elements.Count)
                        {
                            elements.Sort(startIndex, count, StringComparer.InvariantCulture);
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

                    if (count >= 0)
                        RollLeft(count);
                    else
                        Console.WriteLine("Invalid input parameters.");
                }
                else
                {
                    int count = int.Parse(tokens[1]);

                    if (count >= 0)
                        RollRight(count);
                    else
                        Console.WriteLine("Invalid input parameters.");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("[" + string.Join(", ", elements) + "]");
        }

        static void RollLeft(int count)
        {
            for (int i = 0; i < count % elements.Count; i++)
            {
                string element = elements[0];
                elements.RemoveAt(0);
                elements.Add(element);
            }
        }

        static void RollRight(int count)
        {
            for (int i = 0; i < count % elements.Count; i++)
            {
                string element = elements[elements.Count - 1];
                elements.RemoveAt(elements.Count - 1);
                elements.Insert(0, element);
            }
        }
    }
}
