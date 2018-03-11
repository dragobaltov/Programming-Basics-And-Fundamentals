using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> bannedWords = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            string text = Console.ReadLine();

            for (int i = 0; i < bannedWords.Count; i++)
            {
                if (text.Contains(bannedWords[i]))
                {
                    text = text.Replace(bannedWords[i], new string('*', bannedWords[i].Length));
                }
            }

            Console.WriteLine(text);
        }
    }
}
