using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousThreat
{
    class Program
    {
        public static List<string> elements;

        static void Main(string[] args)
        {
            elements = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            string input = Console.ReadLine();

            while (!input.Equals("3:1"))
            {
                string[] tokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];

                if (command == "merge")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);

                    Merge(startIndex, endIndex);
                }
                else if (command == "divide")
                {
                    int index = int.Parse(tokens[1]);
                    int partions = int.Parse(tokens[2]);

                    Divide(index, partions);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", elements));
        }

        static void Merge(int startIndex, int endIndex)
        {
            if (startIndex < 0)
            {
                startIndex = 0;
            }

            if (endIndex >= elements.Count)
            {
                endIndex = elements.Count - 1;
            }

            if (startIndex >= 0 && startIndex < elements.Count - 1
                && endIndex > 0 && endIndex < elements.Count)
            {
                string newElementAtStartIndex = "";

                for (int i = startIndex; i <= endIndex; i++)
                {
                    newElementAtStartIndex += elements[i];
                }

                elements[startIndex] = newElementAtStartIndex;

                for (int i = startIndex + 1; i <= endIndex; i++)
                {
                    elements.RemoveAt(i);
                    i--;
                    endIndex--;
                }
            }
        }

        static void Divide(int index, int partions)
        {
            if (partions <= elements[index].Length)
            {
                List<string> elementsToInsert = new List<string>();
                string elementToDivide = elements[index];

                if (elements[index].Length % partions == 0)
                {
                    int length = elements[index].Length / partions;

                    for (int i = 0; i < partions; i++)
                    {
                        string currentElementToAdd = "";

                        for (int j = 0; j < length; j++)
                        {
                            currentElementToAdd += elementToDivide[j];
                        }

                        elementsToInsert.Add(currentElementToAdd);
                        elementToDivide = elementToDivide.Remove(0, length);
                    }

                    elements.RemoveAt(index);

                    for (int i = elementsToInsert.Count - 1; i >= 0; i--)
                    {
                        elements.Insert(index, elementsToInsert[i]);
                    }
                }
                else
                {
                    int lengthFirstElements = elementToDivide.Length / partions;

                    for (int i = 0; i < partions - 1; i++)
                    {
                        string currentElementToAdd = "";

                        for (int j = 0; j < lengthFirstElements; j++)
                        {
                            currentElementToAdd += elementToDivide[j];
                        }

                        elementsToInsert.Add(currentElementToAdd);
                        elementToDivide = elementToDivide.Remove(0, lengthFirstElements);
                    }

                    elementsToInsert.Add(elementToDivide);

                    elements.RemoveAt(index);

                    for (int i = elementsToInsert.Count - 1; i >= 0; i--)
                    {
                        elements.Insert(index, elementsToInsert[i]);
                    }
                }
            }
        }
    }
}
