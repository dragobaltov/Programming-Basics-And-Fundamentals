using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCommander
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string commandData = Console.ReadLine();

            while (commandData != "end")
            {
                string[] tokens = commandData.Split(' ');
                string command = tokens[0];

                if (command == "Left")
                {
                    int count = int.Parse(tokens[1]);
                    text = Left(text, count);
                }
                else if (command == "Right")
                {
                    int count = int.Parse(tokens[1]);
                    text = Right(text, count);
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(tokens[1]);
                    string textToInsert = tokens[2];

                    text = Insert(text, index, textToInsert);
                }
                else if (command == "Delete")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);

                    text = Delete(text, startIndex, endIndex);
                }

                commandData = Console.ReadLine();
            }

            Console.WriteLine(text);
        }

        static string Left(string text, int count)
        {
            char[] array = new char[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                array[i] = text[i];
            }

            for (int i = 0; i < count; i++)
            {
                char firstElement = array[0];
                for (int j = 0; j < array.Length - 1; j++)
                {
                    array[j] = array[j + 1];
                }
                array[array.Length - 1] = firstElement;
            }

            return string.Join("", array);
        }

        static string Right(string text, int count)
        {
            char[] array = new char[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                array[i] = text[i];
            }

            for (int i = 0; i < count; i++)
            {
                char lastSymbol = array[0];
                char helpElement;
                for (int j = 1; j < array.Length; j++)
                {
                    helpElement = array[j];
                    array[j] = lastSymbol;
                    lastSymbol = helpElement;
                }
                array[0] = lastSymbol;
            }

            return string.Join("", array);
        }

        static string Insert(string text, int index, string textToInsert)
        {
            StringBuilder builder = new StringBuilder(text);
            builder.Insert(index, textToInsert);

            return builder.ToString();
        }

        static string Delete(string text, int startIndex, int endIndex)
        {
            string[] array = new string[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                array[i] = text[i].ToString();
            }

            for (int i = startIndex; i <= endIndex; i++)
            {
                array[i] = "";
            }

            return string.Join("", array);
        }
    }
}
