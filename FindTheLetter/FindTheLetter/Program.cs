using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] tokens = Console.ReadLine().Split(' ');
            char letter = char.Parse(tokens[0]);
            int occurrence = int.Parse(tokens[1]);
            int counter = 0;
            int index = -1;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == letter)
                {
                    counter++;
                    if (counter == occurrence)
                    {
                        index = i;
                    }
                }
            }

            if (index == -1)
            {
                Console.WriteLine("Find the letter yourself!");
            }
            else
            {
                Console.WriteLine(index);
            }
        }
    }
}
