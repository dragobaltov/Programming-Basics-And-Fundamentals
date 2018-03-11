using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MirrorImage
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] elements = Console.ReadLine().Split(' ');
            string index = Console.ReadLine();

            while (true)
            {
                if (index == "Print")
                {
                    break;
                }
                else
                {
                    int i = int.Parse(index);

                    for (int frontIndex = 0; frontIndex <= i - 1; frontIndex++)
                    {
                        int backIndex = i - 1 - frontIndex;
                        if (frontIndex >= backIndex)
                        {
                            break;
                        }
                        else
                        {
                            string helpElement = elements[frontIndex];
                            elements[frontIndex] = elements[backIndex];
                            elements[backIndex] = helpElement;
                        }
                    }
                    for (int frontIndex = i + 1; frontIndex < elements.Length; frontIndex++)
                    {
                        int backIndex = elements.Length - (frontIndex - i);
                        if (frontIndex >= backIndex)
                        {
                            break;
                        }
                        else
                        {
                            string helpElement = elements[frontIndex];
                            elements[frontIndex] = elements[backIndex];
                            elements[backIndex] = helpElement;
                        }
                    }
                }

                index = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", elements));
        }
    }
}
