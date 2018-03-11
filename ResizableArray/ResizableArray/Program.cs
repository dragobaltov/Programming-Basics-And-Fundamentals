using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResizableArray
{
    class Program
    {
        static int currentIndex;
        static int[] initialArray;

        static void Main(string[] args)
        {
            initialArray = new int[4];
            string[] command = Console.ReadLine().Split(' ');
            currentIndex = 0;

            while (command[0] != "end")
            {
                if (command[0] == "push")
                {
                    initialArray[currentIndex] = Convert.ToInt32(command[1]);
                    currentIndex++;

                    if (currentIndex >= initialArray.Length)
                    {
                        NewArray();
                    }
                }
                else if (command[0] == "pop")
                {
                    initialArray[currentIndex] = 0;
                    currentIndex--;
                }
                else if (command[0] == "removeAt")
                {
                    ShiftElementsInArray(Convert.ToInt32(command[1]));
                    currentIndex--;
                }
                else if (command[0] == "clear" || command[0] == "erase")
                {
                    currentIndex = 0;
                }

                command = Console.ReadLine().Split(' ');
            }

            PrintResult();
        }

        static void ShiftElementsInArray(int index)
        {
            for (int i = index + 1; i < initialArray.Length; i++)
            {
                initialArray[i - 1] = initialArray[i];
            }
        }

        static void NewArray()
        {
            int[] newArray = new int[currentIndex * 2];
            for (int i = 0; i < currentIndex; i++)
            {
                newArray[i] = initialArray[i];
            }

            initialArray = newArray;
        }

        static void PrintResult()
        {
            for (int i = 0; i < currentIndex; i++)
            {
                Console.Write(initialArray[i] + " ");
            }
        }
    }
}
