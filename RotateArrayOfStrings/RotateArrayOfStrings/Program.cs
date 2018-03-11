using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] separatedElements = text.Split(' ');
            string[] newArray = new string[separatedElements.Length];

            NewArray(text, separatedElements, newArray);
            PrintingOnConsole(text, separatedElements, newArray);
        }

        static void NewArray(string text, string[] separatedElement, string[] newArray)
        {
            newArray[0] = separatedElement[separatedElement.Length - 1];
            for (int i = 1; i < separatedElement.Length; i++)
            {
                    newArray[i] = separatedElement[i - 1];
            }
        }

        static void PrintingOnConsole(string text, string[] separatedElement, string[] newArray)
        {
            Console.WriteLine(string.Join(" ", newArray));
        }
    }
}
