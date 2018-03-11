using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Placeholders
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string text = tokens[0];
                string[] placeholders = tokens[1].Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i <= text.Length - 3; i++)
                {
                    string currentText = text.Substring(i, 3);

                    if (currentText[0] == '{' && currentText[2] == '}')
                    {
                        int index = Convert.ToInt16(currentText[1]) - 48;
                        if (index >= 0 && index < placeholders.Length)
                            text = text.Replace(currentText, placeholders[index]);
                    }
                }

                Console.WriteLine(text);

                input = Console.ReadLine();
            }

        }
    }
}
