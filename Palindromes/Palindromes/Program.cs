using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine()
                .Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> palindromes = new List<string>();

            for (int i = 0; i < text.Count; i++)
            {
                string reversed = "";

                for (int j = text[i].Length - 1; j >= 0 ; j--)
                {
                    reversed += text[i][j];
                }

                if (text[i] == reversed)
                {
                    if (!palindromes.Contains(text[i]))
                    {
                        palindromes.Add(text[i]);
                    }
                }
            }

            Console.WriteLine(string.Join(", ", palindromes.OrderBy(p => p)));
        }
    }
}
