using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');
            Random rnd = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int index = rnd.Next(0, words.Length);
                string helpElement = words[i];
                words[i] = words[index];
                words[index] = helpElement;
            }

            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
        }
    }
}
