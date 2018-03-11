using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] words = input.Split(new char[]
                {
                    '!', '?', '$', '$', '%', '&', '*', '(', ')',
                    '-', '=', '"', '/', '\\', ' ', ',', '.', '<', '>', '+', '^', ':', ';', '[', ']', '{', '}'
                }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < words.Length; i++)
                {
                    words[i] = ChangingWord(words[i]);
                }

                Console.WriteLine(string.Join(", ", words));

                input = Console.ReadLine();
            }
        }

        public static string ChangingWord(string word)
        {
            string newWord = "";

            for (int i = 0; i < word.Length; i++)
            {
                if (i == 0)
                {
                    newWord += char.ToUpper(word[i]);
                }
                else
                {
                    newWord += char.ToLower(word[i]);
                }
            }

            return newWord;
        }
    }
}
