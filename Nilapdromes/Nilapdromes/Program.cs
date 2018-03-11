using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nilapdromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                string newNilapdrome = NewNilapdrome(input);

                if(newNilapdrome != "")
                {
                    Console.WriteLine(newNilapdrome);
                }

                input = Console.ReadLine();
            }
        }

        static string NewNilapdrome(string input)
        {
            int length = input.Length / 2;
            int index = 0;

            if (input.Length % 2 == 0)
                index = input.Length / 2;
            else
                index = input.Length / 2 + 1;

            string beginning = input.Substring(0, length);
            string end = input.Substring(index);

            while (beginning != end)
            {
                length--;
                if (length == 0)
                    break;
                index++;
                if (index == input.Length)
                    break;

                beginning = input.Substring(0, length);
                end = input.Substring(index);
            }

            string border = "";
            string core = "";

            if (beginning == end)
            {
                border = end;
                core = input.Substring(border.Length, input.Length - 2 * (border.Length));

                if (core == "")
                    return "";
                else
                    return (core + border + core);
            }
            else
            {
                return "";
            }
        }
    }
}
